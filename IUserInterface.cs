namespace Chessboard
{
    public interface IUserInterface
    {
        void GetUserDesign();

        RunMode GetUserMode();

        int GetUserSide(string parameterName);

        bool IsOneMore();

        void DrawBoard(IBoard board);
    }
}