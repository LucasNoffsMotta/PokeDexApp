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
        public Image image;
        public string[] baseStats;
        public int HPEV, ATKEV, SPATKEV, DEFEV, SPDEFEV, SPDEV, HPIV, ATKIV, SPATKIV, DEFIV, SPDEFIV, SPDIV;
        public int[] moveSet;
            
        public Pokemon(string name, int id, string typeOne, string typeTwo, Image image=null, string[] baseStats=null)
        {
            this.name = name;
            this.id = id;
            this.typeOne = typeOne;
            this.typeTwo = typeTwo;
            this.image = image;
            this.baseStats = baseStats;
            this.moveSet = MovesDataBase.GetMoves(this.name);

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

        public void SaveEvAndIv(int hpev, int atkev, int spatkev, int defev, int spdefev, 
            int spdev, int hpiv, int atkiv, int spatkiv, int defiv, int spdefiv, int spdiv)
        {
            HPEV = hpev;
            ATKEV = atkev;
            SPATKEV = spatkev;
            DEFEV = defev;
            SPDEFEV = spdefev;
            SPDEV = spdev;
            HPIV = hpiv;
            ATKIV = atkiv;
            SPATKIV = spatkiv;
            DEFIV = defiv;
            SPDEFIV = spdefiv;
            SPDIV = spdiv;       
        }
    }
}
