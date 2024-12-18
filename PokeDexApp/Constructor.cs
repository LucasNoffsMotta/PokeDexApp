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

        public static ListNode ConstructLinkedList(ListNode node, string [] data)
        {
            string poke_name = data[0];
            int poke_id = int.Parse(data[1]);
            string poke_type_one = data[2];
            string poke_type_two = data[3];
            Image img = Image.FromFile($"C:\\Users\\lnoff\\source\\repos\\PokeDexApp\\PokeDexApp\\Images\\{poke_id}.png");
            node.pokemon = new Pokemon(poke_name, poke_id, poke_type_one, poke_type_two, img);
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
            return emptyData;
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;

            while(curr != null)
            {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            return prev;
        }
    }
}
