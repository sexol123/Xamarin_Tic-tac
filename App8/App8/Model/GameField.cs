using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8.Model
{
   public class GameField
    {
        private List<Cell> GameList { get; set; }
        private short sumstep { get; set; }

        public GameField()
        {
            GameList = new List<Cell>();
            sumstep = 0;
        }

        public GameField(short size = 9)
        {
            GameList = new List<Cell>(9);
            sumstep = 0;
            for (int i = 0; i < size; i++)
            {
                GameList.Add(new Cell(Cell.State.Empty,"-"));
            }
        }
       
    }
}
