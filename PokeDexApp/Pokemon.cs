using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp
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
            
        public Pokemon(string name, int id, string typeOne, string typeTwo, Image image=null, string[] baseStats=null, int natureValue=19, int level = 1)
        {
            this.name = name;
            this.id = id;
            this.typeOne = typeOne;
            this.typeTwo = typeTwo;
            this.image = image;
            this.baseStats = baseStats;
            this.nature = Constructor.EnumerateNatureToString(natureValue);
            this.level = level;


            //Just for testing:
            if (this.id <= 3)
            {
                this.moveSet = MovesDataBase.GetMoves(this.name);
            }

            this.idMoveOne = -1;
            this.idMoveTwo = -1;
            this.idMoveThree = -1;
            this.idMoveFour = -1;
            this.HPEV = 0;
            this.ATKEV = 0;
            this.SPATKEV = 0;
            this.DEFEV = 0;
            this.SPDEFEV = 0;
            this.SPDEV = 0;
            
            this.HPIV = 0;
            this.ATKIV = 0;
            this.SPATKIV = 0;
            this.DEFIV = 0;
            this.SPDEFIV = 0;
            this.SPDIV = 0;
        }
    }
}
