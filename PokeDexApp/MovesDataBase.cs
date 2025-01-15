using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp
{
    public static class MovesDataBase
    {
        public static Dictionary<string, int[]> movesBypoke = new Dictionary<string, int[]>();

        public static void FillDict()
        {
            movesBypoke["Bulbasaur"] = new int[] { 33, 45, 22, 74, 73, 75, 77, 79, 402, 36, 230, 235, 388, 438, 76 };
            movesBypoke["Ivysaur"] = new int[] { 33, 45, 73, 22, 77, 79, 36, 75, 230, 74, 38, 76, 188, 89, 216, 218, 237, 241, 263, 156, 213, 496, 412, 14, 523, 249, 148, 130, 133, 174, 275, 267, 80, 204, 345, 320, 580, 402, 388, 235, 438, 806 };
            movesBypoke["Venusaur"] = new int[] { 33, 45, 73, 22, 77, 79, 36, 75, 230, 74, 38, 76, 188, 89, 216, 218, 237, 241, 263, 156, 213, 496, 412, 14, 523, 249, 148, 130, 133, 174, 275, 267, 80, 204, 345, 320, 580, 402, 388, 235, 438, 806 };
        }

        public static int[] GetMoves(string name)
        {
            return movesBypoke[name];
        }
    }
}
