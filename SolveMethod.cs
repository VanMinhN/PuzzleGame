using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SolveMethod
    {

        /**
		Method can check any NxN puzzle in order to determine is it solvable
		The mothod will check if the parity is odd and the grid-width is even.
		If those two things above true, then the puzzle is solvable.
		**/
        protected internal static bool isSolvable(List<int> puzzle)
        {
            int parity = 0;
            int gridWidth = (int)Math.Sqrt(puzzle.Count);
            int row = 0; // the current row we are on
            int blankRow = 0; // the row with the blank tile

            for (int i = 0; i < puzzle.Count; i++)
            {
                if (i % gridWidth == 0)
                { // advance to next row
                    row++;
                }
                if (puzzle[i] == 0)
                { // the blank tile
                    blankRow = row; // save the row on which encountered
                    continue;
                }
                for (int j = i + 1; j < puzzle.Count; j++)
                {
                    if (puzzle[i] > puzzle[j] && puzzle[j] != 0)
                    {
                        parity++;
                    }
                }
            }

            if (gridWidth % 2 == 0)
            { // even grid
                if (blankRow % 2 == 0)
                { // blank on odd row; counting from bottom
                    return parity % 2 == 0;
                }
                else
                { // blank on even row; counting from bottom
                    return parity % 2 != 0;
                }
            }
            else
            { // odd grid
                return parity % 2 == 0;
            }
        }
    }
}
