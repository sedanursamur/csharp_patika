using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_app
{
    public class BoardElement
    {
        public Card Card { get; set; }
        public StatusType Status { get; set; }


        public BoardElement(Card card, StatusType status)
        {
            this.Card = card;
            this.Status = status;
        }


        public BoardElement()
        {

        }
    }
}
