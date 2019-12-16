using NLog;

namespace Chessboard
{
    public class Program
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            _logger.Info(new string('-', 50));

            var boardDrawer = new BoardDrawer<string>();
            var userInterface = new UserInterface(boardDrawer);
            var chessBoardApp = new ChessBoardApp(userInterface);

            if (args.Length > 1)
            {
                _logger.Info("Start with args");

                chessBoardApp.Start(args);
            }

            _logger.Info("Start without args");

            chessBoardApp.Start();
        }
    }
}
