using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Data.Model
{
    public class StorageLayout
    {
        public List<DrawerArea> Drawers { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }

        public StorageLayout(int r, int c)
        {
            Drawers = new List<DrawerArea>();
            Columns = c;
            Rows = r;
        }

        public List<DrawerArea> GetRow(int r)
        {
            if(r * Columns + Columns <= Drawers.Count)
            {
                return Drawers.GetRange(r * Columns, Columns);
            }
            else if(r * Columns < Drawers.Count)
            {
                return Drawers.GetRange(r * Columns, Drawers.Count - r * Columns);
            }

            return null;
        }


    }
}
