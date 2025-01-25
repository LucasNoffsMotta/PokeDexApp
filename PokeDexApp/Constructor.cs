using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp
{
    public static class Constructor
    {
        public static DBConnect conn = new DBConnect();

        public static ListNode ConstructLinkedList(ListNode node, string[] data)
        {
            string poke_name = data[0];
            int poke_id = int.Parse(data[1]);
            string poke_type_one = data[2];
            string poke_type_two = data[3];
            Image img;
            string[] baseStats = new string[6];
            int count = 0;

            for (int i = 4; i < data.Length; i++)
            {
                baseStats[count] = data[i];
                count++;
            }

            try
            {
                img = Image.FromFile($"C:\\Users\\lnoff\\source\\repos\\PokeDexApp\\PokeDexApp\\Images\\{poke_id}.png");
            }

            catch
            {
                img = null;
            }

            node.pokemon = new Pokemon(poke_name, poke_id, poke_type_one, poke_type_two, img, baseStats);
            return node;
        }


        public static String[] ConstructDexData(string[] emptyData, DataRow row)
        {
            DataTable type_one = new DataTable();
            string query_one, query_two, nameTypeOne;
            string nameTypeTwo = "";

            query_one = $"SELECT name_type FROM Types WHERE id_type = {row["id_type_one"]};";
            type_one = conn.SQLCommand(query_one);
            nameTypeOne = type_one.Rows[0]["name_type"].ToString();

            if (row["id_type_two"].ToString() != "")
            {
                DataTable type_two = new DataTable();
                query_two = $"SELECT name_type FROM Types WHERE id_type = {row["id_type_two"]};";
                type_two = conn.SQLCommand(query_two);
                nameTypeTwo = type_two.Rows[0]["name_type"].ToString();
            }

            emptyData[0] = row["Name"].ToString();
            emptyData[1] = row["id_poke"].ToString();
            emptyData[2] = nameTypeOne;
            emptyData[3] = nameTypeTwo;
            emptyData[4] = row["HP"].ToString();
            emptyData[5] = row["ATK"].ToString();
            emptyData[6] = row["SPATK"].ToString();
            emptyData[7] = row["DEF"].ToString();
            emptyData[8] = row["SPDEF"].ToString();
            emptyData[9] = row["SPD"].ToString();
            return emptyData;
        }

        public static int GetTotalBaseStats(string[] values)
        {
            int total = 0;

            foreach (string item in values)
            {
                total += int.Parse(item);
            }
            return total;
        }

        public static int[] ParseArray(string[] numbersArray)
        {
            int[] numbers = new int[numbersArray.Length];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbers[i] = int.Parse(numbersArray[i]);
            }

            return numbers;
        }


        public static string EnumerateTypes(int idType)
        {
            string nameType;

            switch (idType)
            {
                case 1:
                    nameType = "Normal";
                    break;
                case 2:
                    nameType = "Fire";
                    break;
                case 3:
                    nameType = "Water";
                    break;
                case 4:
                    nameType = "Electric";
                    break;
                case 5:
                    nameType = "Grass";
                    break;
                case 6:
                    nameType = "Ice";
                    break;
                case 7:
                    nameType = "Fighting";
                    break;
                case 8:
                    nameType = "Poison";
                    break;
                case 9:
                    nameType = "Ground";
                    break;
                case 10:
                    nameType = "Flying";
                    break;
                case 11:
                    nameType = "Psychic";
                    break;
                case 12:
                    nameType = "Bug";
                    break;
                case 13:
                    nameType = "Rock";
                    break;
                case 14:
                    nameType = "Ghost";
                    break;
                case 15:
                    nameType = "Dragon";
                    break;
                case 16:
                    nameType = "Dark";
                    break;
                case 17:
                    nameType = "Steel";
                    break;
                case 18:
                    nameType = "Fairy";
                    break;

                default:
                    nameType = "";
                    break;
            }

            return nameType;
        }
        

        public static int EnumerateStatsInt(string stat)
        {
            int statNumber;
            switch(stat)
            {
                case "HP":
                    statNumber = 1; 
                    break;

                case "Attack":
                    statNumber = 2;
                    break;

                case "Defense":
                    statNumber = 3;
                    break;

                case "Special Attack":
                    statNumber = 4;
                    break;

                case "Special Defense":
                    statNumber = 5;
                    break;

                case "Speed":
                    statNumber = 6;
                    break;

                default:
                    statNumber = 0;
                    break;
            }
            return statNumber;
        }


        public static Dictionary<string, string> EnumerateNature(string nature, Dictionary<string, string> natures)
        {

            switch (nature)
            {
                case "Adamant":
                    natures["atk"] = "positive";
                    natures["spatk"] = "negative";
                    break;

                case "Bold":
                    natures["def"] = "positive";
                    natures["atk"] = "negative";
                    break;

                case "Brave":
                    natures["atk"] = "positive";
                    natures["spd"] = "negative";
                    break;

                case "Calm":
                    natures["spdef"] = "positive";
                    natures["atk"] = "negative";
                    break;

                case "Careful":
                    natures["spdef"] = "positive";
                    natures["spatk"] = "negative";
                    break;

                case "Gentle":
                    natures["spdef"] = "positive";
                    natures["def"] = "negative";
                    break;


                case "Hasty":
                    natures["spd"] = "positive";
                    natures["def"] = "negative";
                    break;

                case "Impish":
                    natures["def"] = "positive";
                    natures["spatk"] = "negative";
                    break;

                case "Jolly":
                    natures["spd"] = "positive";
                    natures["spatk"] = "negative";
                    break;

                case "Lax":
                    natures["def"] = "positive";
                    natures["spddef"] = "negative";
                    break;

                case "Lonely":
                    natures["atk"] = "positive";
                    natures["def"] = "negative";
                    break;

                case "Mild":
                    natures["spatk"] = "positive";
                    natures["def"] = "negative";
                    break;

                case "Modest":
                    natures["spatk"] = "positive";
                    natures["atk"] = "negative";
                    break;

                case "Naive":
                    natures["spd"] = "positive";
                    natures["spddef"] = "negative";
                    break;

                case "Naughty":
                    natures["atk"] = "positive";
                    natures["spdef"] = "negative";
                    break;

                case "Quiet":
                    natures["spatk"] = "positive";
                    natures["spd"] = "negative";
                    break;


                case "Rash":
                    natures["spatk"] = "positive";
                    natures["spdef"] = "negative";
                    break;

                case "Relaxed":
                    natures["def"] = "positive";
                    natures["spd"] = "negative";
                    break;

                case "Sassy":
                    natures["spdef"] = "positive";
                    natures["spd"] = "negative";
                    break;


                case "Timid":
                    natures["spd"] = "positive";
                    natures["atk"] = "negative";
                    break;

                default:
                    natures["hp"] = "";
                    natures["atk"] = "";
                    natures["spatk"] = "";
                    natures["def"] = "";
                    natures["spdef"] = "";
                    natures["spd"] = "";
                    break;
            }
            return natures;
        }

        public static int EnumerateType(string type)
        {
            int typeNumber;
            switch (type)
            {
                case "Normal":
                    typeNumber = 1;
                    break;
                case "Fire":
                    typeNumber = 2;
                    break;
                case "Water":
                    typeNumber = 3;
                    break;
                case "Eletric":
                    typeNumber = 4;
                    break;
                case "Grass":
                    typeNumber = 5;
                    break;
                case "Ice":
                    typeNumber = 6;
                    break;
                case "Fighting":
                    typeNumber = 7;
                    break;
                case "Poison":
                    typeNumber = 8;
                    break;
                case "Ground":
                    typeNumber = 9;
                    break;
                case "Flying":
                    typeNumber = 10;
                    break;
                case "Psychic":
                    typeNumber = 11;
                    break;
                case "Bug":
                    typeNumber = 12;
                    break;
                case "Rock":
                    typeNumber = 13;
                    break;
                case "Ghost":
                    typeNumber = 14;
                    break;
                case "Dragon":
                    typeNumber = 15;
                    break;
                case "Dark":
                    typeNumber = 16;
                    break;
                case "Steel":
                    typeNumber = 17;
                    break;
                case "Fairy":
                    typeNumber = 18;
                    break;
                default:
                    typeNumber = 1;
                    break;
            }
            return typeNumber;
        }


        public static string EnumerateNatureToString(int natureValue)
        {
            string nature;

            switch(natureValue)
            {
                case 1:
                    nature = "Hardy";
                    break;
                case 2:
                    nature = "Lonely";
                    break;

                case 3:
                    nature = "Brave";
                    break;
                case 4:
                    nature = "Adamant";
                    break;

                case 5:
                    nature = "Naughty";
                    break;

                case 6:
                    nature = "Bold";
                    break;

                case 7:
                    nature = "Docile";
                    break;

                case 8:
                    nature = "Relaxed";
                    break;

                case 9:
                    nature = "Impish";
                    break;

                case 10:
                    nature = "Lax";
                    break;

                case 11:
                    nature = "Timid";
                    break;

                case 12:
                    nature = "Hasty";
                    break;
                
                case 13:
                    nature = "Serious";
                    break;

                case 14:
                    nature = "Jolly";
                    break;

                case 15:
                    nature = "Naive";
                    break;
                case 16:
                    nature = "Modest";
                    break;

                case 17:
                    nature = "Mild";
                    break;

                case 18:
                    nature = "Quiet";
                    break;

                case 19:
                    nature = "Bashful";
                    break;

                case 20:
                    nature = "Rash";
                    break;

                case 21:
                    nature = "Calm";
                    break;

                case 22:
                    nature = "Gentle";
                    break;

                case 23:
                    nature = "Sassy";
                    break;

                case 24:
                    nature = "Careful";
                    break;

                case 25:
                    nature = "Quirky";
                    break;

                default:
                    nature = "Bashful";
                    break;
            }

            return nature;
        }


        public static int EnumerateNatureToInt(string nature)
        {
            int natureValue;

            switch (nature)
            {
                case "Hardy":
                    natureValue = 1;
                    break;
                case "Lonely":
                    natureValue = 2;
                    break;
                case "Brave":
                    natureValue = 3;
                    break;
                case "Adamant":
                    natureValue = 4;
                    break;
                case "Naughty":
                    natureValue = 5;
                    break;
                case "Bold":
                    natureValue = 6;
                    break;
                case "Docile":
                    natureValue = 7;
                    break;
                case "Relaxed":
                    natureValue = 8;
                    break;
                case "Impish":
                    natureValue = 9;
                    break;
                case "Lax":
                    natureValue = 10;
                    break;
                case "Timid":
                    natureValue = 11;
                    break;
                case "Hasty":
                    natureValue = 12;
                    break;
                case "Serious":
                    natureValue = 13;
                    break;
                case "Jolly":
                    natureValue = 14;
                    break;
                case "Naive":
                    natureValue = 15;
                    break;
                case "Modest":
                    natureValue = 16;
                    break;
                case "Mild":
                    natureValue = 17;
                    break;
                case "Quiet":
                    natureValue = 18;
                    break;
                case "Bashful":
                    natureValue = 19;
                    break;
                case "Rash":
                    natureValue = 20;
                    break;
                case "Calm":
                    natureValue = 21;
                    break;
                case "Gentle":
                    natureValue = 22;
                    break;
                case "Sassy":
                    natureValue = 23;
                    break;
                case "Careful":
                    natureValue = 24;
                    break;
                case "Quirky":
                    natureValue = 25;
                    break;
                default:
                    natureValue = 19; // Default to "Bashful"
                    break;
            }

            return natureValue;
        }


        public static ListNode BinarySearch(ListNode[] nodesArray, int target)
        {
            int firstIndex = 0;
            int lastIndex = nodesArray.Length - 1;
            int middleIndex = (int)lastIndex / 2;

            while (firstIndex < lastIndex && nodesArray[middleIndex].pokemon.id != target)
            {
                if (nodesArray[middleIndex].pokemon.id < target)
                {
                    firstIndex = middleIndex + 1;
                }

                else if (nodesArray[firstIndex].pokemon.id == target)
                {
                    return nodesArray[firstIndex];
                }

                else
                {
                    lastIndex = middleIndex - 1;
                }
                middleIndex = (int) (firstIndex + lastIndex) / 2;
            }

            return nodesArray[middleIndex];
        }


        public static ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;

            while (curr != null)
            {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            return prev;
        }

        public static ListNode SearchOnLinkedList(string target, ListNode dexStart)
        {
            ListNode searchNodeOne = dexStart;
            ListNode searchNodeTwo = dexStart;
            string search = target;

            if (search != dexStart.pokemon.name)
            {
                while (searchNodeOne.pokemon != null || searchNodeTwo.pokemon != null)
                {
                    if (searchNodeOne.pokemon.name == search)
                    {
                        dexStart = searchNodeOne;
                        break;
                    }

                    if (searchNodeTwo.pokemon.name == search)
                    {
                        dexStart = searchNodeTwo;
                        break;
                    }

                    if (searchNodeOne.next.pokemon != null)
                    {
                        searchNodeOne = searchNodeOne.next;
                    }

                    if (searchNodeTwo.prev.pokemon != null)
                    {
                        searchNodeTwo = searchNodeTwo.prev;
                    }
                }
                return dexStart;
            }
            return dexStart;
        }
    }
}
