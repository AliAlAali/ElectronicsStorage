using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Data.Model
{
    [Serializable]
    public class StorageBox
    {
        public int Id { get; set; } = 0;

        public IEnumerable<Drawer> Drawers {get; set;}
    }
}
