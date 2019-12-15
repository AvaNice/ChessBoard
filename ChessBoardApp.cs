﻿using NLog;
using System;
using System.Diagnostics;

namespace Chessboard
{
    public class ChessBoardApp
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private ChessBoard _board;
        private UserInterface _userInterface = new UserInterface();
        private ChessBoardDrawer<string> _boardDrawer = new ChessBoardDrawer<string>();
        private CellVisualization<string> _design = new CellVisualization<string>("*", " ");

        public void Start()
        {
            Console.WriteLine(TextMessages.HELP);

            StartUserMenu();
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
                _logger.Error($"User input wrong args");
            }

            StartUserMenu();
        }
        public void StartUserMenu()
        {
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case TextMessages.START_MODE:
                    BuildChessBoadr();
                    _boardDrawer.DrawChessBoard(_board, _design);
                    break;

                case TextMessages.EXIT_MODE:
                    _logger.Info("Exit");
                    Process.GetCurrentProcess().Kill();
                    break;

                case TextMessages.SETTINGS_MODE:
                    _design = _userInterface.GetUserDesign();
                    break;

                default:
                    Console.WriteLine(TextMessages.HELP);
                    _logger.Trace($"Default in UserMenu userMode input = ({userInput})");
                    break;
            }

            if (_userInterface.IsOneMore())
            {
                StartUserMenu();
            }
        }

        private ChessBoard BuildChessBoadr()
        {
            int height;
            int width;

            height = _userInterface.GetUserSide(TextMessages.HEIGHT);
            width = _userInterface.GetUserSide(TextMessages.WIDTH);

            return BuildChessBoadr(height, width);
        }

        private ChessBoard BuildChessBoadr(int height, int width)
        {
            _logger.Trace($"Try to build ChessBoard From Args Height = ({height}); Width = ({width})");

            _board = new ChessBoard(height, width);

            _board.FillStaggered(new BlackCell(), new WhiteCell());

            _logger.Trace("Builded");

            return _board;
        }
    }
}
