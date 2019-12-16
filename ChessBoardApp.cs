using NLog;
using System;

namespace Chessboard
{
    public class ChessBoardApp
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private readonly IUserInterface _userInterface;

        private IChessBoard _board;

        public ChessBoardApp(IUserInterface userInterface)//, BoardDrawer<string>)
        {
            _userInterface = userInterface;
        }

        public void Start()
        {
            do
            {
                Console.WriteLine(TextMessages.HELP);

                StartMode();
            }
            while (_userInterface.NeedRestart());
        }

        public void Start(string[] args)
        {
            try
            {
                int height = Convert.ToInt32(args[0]);
                int width = Convert.ToInt32(args[1]);

                _board = BuildChessBoadr(height, width);

                _userInterface.DrawBoard(_board);
            }
            catch
            {
                _logger.Error($"User input wrong args");
            }

            StartMode();
        }

        public void StartMode()
        {
            if(_userInterface.NeedStart())
            {
                BuildChessBoadr();
                _userInterface.DrawBoard(_board);
            }
        }

        private IChessBoard BuildChessBoadr()
        {
            int height;
            int width;

            height = _userInterface.GetUserSide(TextMessages.HEIGHT);
            width = _userInterface.GetUserSide(TextMessages.WIDTH);

            return BuildChessBoadr(height, width);
        }

        private IChessBoard BuildChessBoadr(int height, int width)
        {
            _logger.Info($"Try to build ChessBoard From Args Height = ({height}); Width = ({width})");

            _board = new ChessBoard(height, width);

            _board.FillStaggered(new BlackCell(), new WhiteCell());

            _logger.Info("Builded");

            return _board;
        }
    }
}
