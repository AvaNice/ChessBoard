using System;
using System.Collections.Generic;
using System.Diagnostics;
using NLog;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class Program
    {
        #region PrivateMembers
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static CellVisualization<string> design = new CellVisualization<string>("*", " ");
        private static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                try
                {
                    int height = Convert.ToInt32(args[0]);
                    int width = Convert.ToInt32(args[1]);
                    ChessBoardDrawer<string>.DrawChessBoard(BuildChessBoadr(height, width), design);
                }
                catch
                {
                    logger.Error($"User try wrong args");
                }
            }

            logger.Info(new string('-', 50));

            UserMenu();
        }

        private static void UserMenu()
        {
            string userMode = Console.ReadLine().ToLower();
            switch (userMode)
            {
                case TextMessages.StartMode:
                    ChessBoardDrawer<string>.DrawChessBoard(BuildChessBoadr(), design);
                    break;

                case TextMessages.ExitMode:
                    logger.Info("Exit");
                    Process.GetCurrentProcess().Kill();
                    break;

                case TextMessages.SettingsMode:
                    design = GetUserDesign();
                    break;

                default:
                    Console.WriteLine(TextMessages.Help);
                    logger.Trace($"Default in UserMenu userMode input = ({userMode})");
                    break;
            }
            UserMenu();
        }

        private static ChessBoard<IDrawableCell> BuildChessBoadr()
        {
            int height;
            int width;

            height = GetUserParameter(TextMessages.Heigth);
            width = GetUserParameter(TextMessages.Width);

            logger.Trace($"Try to build ChessBoard Height = ({height}); Width = ({width})");

            var board = new ChessBoard<IDrawableCell>(height, width, new BlackCell(), new WhiteCell());

            logger.Trace("Builded");

            return board;
        }
        private static ChessBoard<IDrawableCell> BuildChessBoadr(int height, int width)
        {
            logger.Trace($"Try to build ChessBoard From Args Height = ({height}); Width = ({width})");

            var board = new ChessBoard<IDrawableCell>(height, width, new BlackCell(), new WhiteCell());

            logger.Trace("Builded");

            return board;
        }

        private static int GetUserParameter(string parameterName)
        {
            int parameterValue = 0;
            string input = string.Empty;

            Console.Write($"{parameterName} = ");
            input = Console.ReadLine();
            try
            {
                parameterValue = Convert.ToInt32(input);

                logger.Trace($"User enter {parameterName} = {parameterValue}");

                return parameterValue;
            }
            catch
            {
                Console.WriteLine(TextMessages.IncorrectInput);

                logger.Error($"Incorrect Input of {parameterName} - {input}");
            }
            return GetUserParameter(parameterName);
        }
        private static CellVisualization<string> GetUserDesign()
        {
            return new CellVisualization<string>(GetCellDesign(TextMessages.DesignWhite), GetCellDesign(TextMessages.DesignBlack));
        }
        private static string GetCellDesign(string parameterName)
        {
            string design = string.Empty;

            Console.Write($"{parameterName} : ");
            design = Console.ReadLine();

            logger.Trace($"User set new design for ({parameterName}) - {design}");
            return design;
        }
        #endregion
    }
}
