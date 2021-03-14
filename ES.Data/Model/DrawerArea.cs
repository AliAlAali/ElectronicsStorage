using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Data.Model
{
    public class DrawerArea
    {
        public Position Position { get; set; }
        public int RowSpan { get; set; }
        public int ColSpan { get; set; }

        public DrawerArea()
        {
            Position = new Position() { 
                X = 0,
                Y = 0 
            };

            RowSpan = 1;
            ColSpan = 1;
        }
    }
}
