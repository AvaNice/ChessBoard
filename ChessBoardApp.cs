using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class ChessBoardApp
    {
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private ChessBoard _board;
        private Validator _inputValidator = new Validator();
        private ChessBoardDrawer<string> _boardDrawer = new ChessBoardDrawer<string>();
        private CellVisualization<string> _design = new CellVisualization<string>("*", " ");

        public void Start()
        {
            UserMenu();
        }

        public void Start(string[] args)
        {
            try
            {
                int height = Convert.ToInt32(args[0]);
                int width = Convert.ToInt32(args[1]);

                _board = BuildChessBoadr(height, width);

                _boardDrawer.DrawChessBoard(_board, _design);
            }

            catch
            {
                Program.Logger.Error($"User input wrong args");
            }

            UserMenu();
        }
        public void UserMenu()
        {
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case TextMessages.START_MODE:

                    BuildChessBoadr();
                    _boardDrawer.DrawChessBoard(_board, _design);
                    
                    break;

                case TextMessages.EXIT_MODE:

                    Program.Logger.Info("Exit");
                    Process.GetCurrentProcess().Kill();

                    break;

                case TextMessages.SETTINGS_MODE:

                    _design = _inputValidator.GetUserDesign();

                    break;

                default:

                    Console.WriteLine(TextMessages.HELP);
                    Program.Logger.Trace($"Default in UserMenu userMode input = ({userInput})");

                    break;
            }

            UserMenu();
        }

        private ChessBoard BuildChessBoadr()
        {
            int height;
            int width;

            height = _inputValidator.GetUserNumeric(TextMessages.HEIGHT);
            width = _inputValidator.GetUserNumeric(TextMessages.WIDTH);

            return BuildChessBoadr(height, width);
        }

        private ChessBoard BuildChessBoadr(int height, int width)
        {
            Program.Logger.Trace($"Try to build ChessBoard From Args Height = ({height}); Width = ({width})");

            _board = new ChessBoard(height, width);

            _board.FillStaggered(new BlackCell(), new WhiteCell());

            Program.Logger.Trace("Builded");

            return _board;
        }
    }
}
