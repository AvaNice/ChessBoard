namespace Chessboard
{
    public interface IUserInterface
    {
        void GetUserDesign();

        bool NeedStart();

        int GetUserSide(string parameterName);

        bool NeedRestart();

        void DrawBoard(IBoard board);
    }
}