using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class BoardBuilder<T>
    {
        #region PublicMembers
        public Grid<T> Build(int height, int width)
        {
            return new Grid<T>(height, width);
        }
        #endregion
    }
}
