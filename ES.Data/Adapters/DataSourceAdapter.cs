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
        public abstract IEnumerable<StorageBox> GetStorageBoxes();
        public abstract StorageBox GetStorageBoxById(int id);
        public abstract void AddStorageBox(StorageBox box);

        // Editable layout
        public abstract IEnumerable<StorageLayout> GetStorageLayouts();
        public abstract StorageLayout GetStorageLayoutById(int id);
        public abstract void AddStorageLayout(StorageLayout layout);


        public abstract IEnumerable<DrawerArea> GetDrawerAreas();
        public abstract DrawerArea GetDrawerAreaById(int id);
        public abstract void AddDrawerArea(DrawerArea area);
    }
}
