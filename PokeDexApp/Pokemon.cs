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
        public int id;
        public string typeOne;
        public string typeTwo;
        public Image image;
        public string[] baseStats;
            
        public Pokemon(string name, int id, string typeOne, string typeTwo, Image image=null, string[] baseStats=null)
        {
            this.name = name;
            this.id = id;
            this.typeOne = typeOne;
            this.typeTwo = typeTwo;
            this.image = image;
            this.baseStats = baseStats;
        }
    }
}
