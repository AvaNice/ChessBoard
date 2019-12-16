namespace Chessboard
{
    public interface IUserInterface
    {
        void GetUserDesign();

        RunMode GetUserMode();

        int GetUserSide(string parameterName);

        bool NeedRestart();

        void DrawBoard(IBoard board);
    }
}