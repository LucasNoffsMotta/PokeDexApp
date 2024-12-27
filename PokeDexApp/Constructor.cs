using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
