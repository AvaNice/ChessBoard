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
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            Logger.Info(new string('-', 50));

            ChessBoardApp chessBoardApp = new ChessBoardApp();

            if (args.Length > 1)
            {
                chessBoardApp.Start(args);
            }

            chessBoardApp.Start();
        }
    }
}
