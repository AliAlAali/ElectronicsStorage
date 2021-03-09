using ES.Data.Model;
using System;
using System.Collections.Generic;

namespace ES.Data.Adapters
{
    /*
     * Abstract class to allow multiple methods of obtaining data from various db types.
     */
    public abstract class DataSourceAdapter
    {
        // Drawers
        public abstract IEnumerable<Drawer> GetDrawers();
        public abstract Drawer GetDrawerById(int id);
        public abstract void AddDrawer(Drawer drawer);

        // Storage box
        public abstract IEnumerable<Drawer> GetStorageBoxes();
        public abstract StorageBox GetStorageBoxById(int id);
        public abstract void AddStorageBox(StorageBox box);

    }
}
