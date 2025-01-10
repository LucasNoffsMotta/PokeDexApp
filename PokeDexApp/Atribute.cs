using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp
{
    //Classe utilizada para calcular os atributos na calculadora de stats
    public class Atribute
    {
        //Declara todas as variaveis necessarias
        public string name;
        public int baseStat;
        public int ev;
        public int iv;
        public string statLabel;
        public int[] evTotalDecrease;
        public int evStatAdd;
        public int ivStatAdd;
        public double natureBonus;
        public int evIncreaseRate;
        public int ivIncreaseRate;
        public int maxEv;
        public int maxIv;
        public int level;

        public Atribute(int baseStat, string name)
        {
            //Inicializa as variaveis 
            this.name = name;
            this.baseStat = baseStat;
            this.level = 50;
            this.ev = 0;
            this.iv = 0;
            this.evTotalDecrease = new int[] { 0, 0 };
            this.natureBonus = 0;
            this.evStatAdd = 0;
            this.ivStatAdd = 0;
            this.evIncreaseRate = 4;
            this.ivIncreaseRate = 1;
            this.maxEv = 255;
            this.maxIv = 31;
        }

        public int ValidateLevelEntry(TextBox textChanged)
        {
            try
            {
                level = int.Parse(textChanged.Text);
            }

            catch 
            {
                level = 1;
            }

            if (level < 0 || level > 100)
            {
                MessageBox.Show("Digite um numero de 1 a 100");
                level = 1;
            }

            return level;
        }

        //Metodo que valida o EV digitado na caixa de texto, retorna 0 caso seja invalido
        public int ValidateEVEntry(TextBox textChanged, int totalEvs)
        {

            if (totalEvs == 0)
            {
                MessageBox.Show("Max EV reached.");
                ev = 0;
            }

            else
            {
                try
                {
                    ev = int.Parse(textChanged.Text);
                }

                catch
                {
                    ev = 0;
                }

                if (ev > maxEv)
                {
                    MessageBox.Show("Max EV per atribute: 255");
                    ev = 0;
                }

                else if (ev < 0)
                {
                    MessageBox.Show("Type a number greater than 0");
                    ev = 0;
                }

                else
                {
                    if (totalEvs - ev > 0)
                    {
                        return ev;
                    }
                }
            }
           
            return ev;
        }

        public int ValidateIVEntry(TextBox textChanged)
        {
            try
            {
                iv = int.Parse(textChanged.Text);
            }

            catch
            {
                iv = 0;
            }

            if (iv > maxIv)
            {
                MessageBox.Show("Max IV per atribute: 31");
                iv = 0;
            }

            else if (iv < 0)
            {
                MessageBox.Show("Type a number greater than 0");
                iv = 0;
            }

            return iv;
        }

        //Metodo utilizado para mapear os valores digitados e manter controle do total de EVs disponiveis
        //Este metodo e utilizado com a variavel totalEvs que fica fora desta classe
        //Cada vez que o numero de EV e alterado, subtrai do totalEV o novo valor digitado (indice 0 na array)
        //e soma-se o valor antigo (indice 1 na array)


        public void InputQueue(int newValue, string type = "")
        {
            if (type == "ev")
            {
                evTotalDecrease[1] = evTotalDecrease[0];
                evTotalDecrease[0] = newValue;
            }

            else
            {
                evTotalDecrease[3] = evTotalDecrease[2];
                evTotalDecrease[2] = newValue;
            }
        }


        //Metodo utilizado para calcular quanto o EV ira adicionar no stat
        public void ChangeEV()
        {
            evStatAdd = (int)ev / evIncreaseRate;
        }


        //Metodo utilizado para calcular o bonus da Nature
        public void ChangeNature(string status)
        {
            if (status == "positive")
            {
                natureBonus = 1.1;
            }

            else if (status == "negative")
            {
                natureBonus = 0.9;
            }

            else
            {
                natureBonus = 1;
            }
        }


        public void ChangeIV()
        {
            ivStatAdd = (int)iv / ivIncreaseRate;
        }


        //Metodo final utilizado para calcular o total do stat com base em todos os fatores
        public string CalculateStat()
        {

            if (name.Contains("hp"))
            {
                int finalStat = (int)((((2 * baseStat + iv + evStatAdd) * level) / 100) + level + 10);
                statLabel = finalStat.ToString();
                return statLabel;

            }

            else
            {
                int finalStat = (int)(((((2* baseStat + iv + evStatAdd) * level) / 100) + 5) * natureBonus);
                statLabel = finalStat.ToString();
            }
            return statLabel;


            //int finalStat = baseStat + natureBonus + ivStatAdd + evStatAdd;
            //statLabel = finalStat.ToString();
            //return statLabel;

        }
    }
}
