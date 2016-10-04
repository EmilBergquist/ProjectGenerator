using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektGenerator_Test1
{
    class DataToInsert
    {

        private int row;
        public int Row
        {
            get
            {
                return row;
            }

            set
            {
                if (value > 0)
                {
                    row = value;
                }
            }
        }

        private int column;
        public int Column
        {
            get
            {
                return column;
            }

            set
            {
                if (value > 0)
                {
                    column = value;
                }
            }
        }

        public string Text { get; set; }
    }
}
