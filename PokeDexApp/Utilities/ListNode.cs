using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp.Utilities
{
    public class ListNode
    {
        public Pokemon pokemon;
        public ListNode next;
        public ListNode prev;

        public ListNode(Pokemon pokemon = null, ListNode next = null, ListNode prev = null)
        {
            this.pokemon = pokemon;
            this.next = next;
            this.prev = prev;
        }
    }
}
