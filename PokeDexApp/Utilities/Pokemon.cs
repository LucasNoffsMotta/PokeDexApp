using PokeDexApp.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp.Utilities
{
    public class Pokemon
    {
        public string name;
        public int id, idUserTable;
        public string typeOne;
        public string typeTwo;
        public string nature;
        public int idMoveOne, idMoveTwo, idMoveThree, idMoveFour;
        public int level;
        public Image image;
        public string[] baseStats;
        public int HPEV, ATKEV, SPATKEV, DEFEV, SPDEFEV, SPDEV, HPIV, ATKIV, SPATKIV, DEFIV, SPDEFIV, SPDIV;
        public int[] moveSet;
        public string? nickName;

        public Pokemon(string name, int id, string typeOne, string typeTwo, Image image = null, string[] baseStats = null, int natureValue = 19, int level = 1)
        {
            this.name = name;
            this.id = id;
            this.typeOne = typeOne;
            this.typeTwo = typeTwo;
            this.image = image;
            this.baseStats = baseStats;
            nature = Constructor.EnumerateNatureToString(natureValue);
            this.level = level;


            //Just for testing:
            if (this.id <= 3)
            {
                moveSet = MovesDataBase.GetMoves(this.name);
            }

            //Maintenance (still without moves on DB) - Set all to tackle
            moveSet = new int[4] { 1,1,1,1};


            idMoveOne = moveSet[0];
            idMoveTwo = moveSet[1];
            idMoveThree = moveSet[2];
            idMoveFour = moveSet[3];
            HPEV = 0;
            ATKEV = 0;
            SPATKEV = 0;
            DEFEV = 0;
            SPDEFEV = 0;
            SPDEV = 0;

            HPIV = 0;
            ATKIV = 0;
            SPATKIV = 0;
            DEFIV = 0;
            SPDEFIV = 0;
            SPDIV = 0;
        }
    }
}
