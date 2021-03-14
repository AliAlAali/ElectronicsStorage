using ES.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Data.Adapters
{
    public class FileSystemDataAdapter : DataSourceAdapter
    {
        public override void AddDrawer(Drawer drawer)
        {
            throw new NotImplementedException();
        }

        public override void AddDrawerArea(DrawerArea area)
        {
            throw new NotImplementedException();
        }

        public override void AddStorageBox(StorageBox box)
        {
            throw new NotImplementedException();
        }

        public override void AddStorageLayout(StorageLayout layout)
        {
            throw new NotImplementedException();
        }

        public override DrawerArea GetDrawerAreaById(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<DrawerArea> GetDrawerAreas()
        {
            throw new NotImplementedException();
        }

        public override Drawer GetDrawerById(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Drawer> GetDrawers()
        {
            throw new NotImplementedException();
        }

        public override StorageBox GetStorageBoxById(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Drawer> GetStorageBoxes()
        {
            throw new NotImplementedException();
        }

        public override StorageLayout GetStorageLayoutById(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<StorageLayout> GetStorageLayouts()
        {
            throw new NotImplementedException();
        }
    }
}
