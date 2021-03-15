using ES.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Data.Adapters
{
    public class FixedDataAdapter : DataSourceAdapter
    {
        private List<Drawer> Drawers = new List<Drawer>();
        private List<StorageBox> StorageBoxes = new List<StorageBox>();
        public StorageLayout Layout = new StorageLayout(10, 6);

        public FixedDataAdapter()
        {
            InitializeDrawers();
            InitializeStorageBoxes();
        }

        private void InitializeDrawers()
        {
            for(int r = 0; r < 10; r++)
            {
                for(int c = 0; c < 6; c++)
                {
                    var area = new DrawerArea();
                    area.Position.X = c;
                    area.Position.Y = r;
                    
                    if(r == 2 && c == 0)
                    {
                        area.ColSpan = 2;
                        area.RowSpan = 2;
                    }

                    Drawers.Add(new Drawer()
                    {
                        Id = r + c + 1,
                        Place = area
                    });

                    Layout.Drawers.Add(area);
                }
            }

        }
        private void InitializeStorageBoxes()
        {

        }

        public override void AddDrawer(Drawer drawer)
        {
            // check if drawers exists in the first place
            if(GetDrawerById(drawer.Id) == null)
            {
                Drawers.Add(drawer);
            }
        }

        public override void AddStorageBox(StorageBox box)
        {
            throw new NotImplementedException();
        }

        public override Drawer GetDrawerById(int id)
        {
            var drawer = Drawers.Find(d => d.Id == id);
            if(drawer.Id == 0)
            {
                return null;
            }

            return drawer;
        }

        public override IEnumerable<Drawer> GetDrawers()
        {
            return Drawers;
        }

        public override StorageBox GetStorageBoxById(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<StorageBox> GetStorageBoxes()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<StorageLayout> GetStorageLayouts()
        {
            throw new NotImplementedException();
        }

        public override StorageLayout GetStorageLayoutById(int id)
        {
            throw new NotImplementedException();
        }

        public override void AddStorageLayout(StorageLayout layout)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<DrawerArea> GetDrawerAreas()
        {
            throw new NotImplementedException();
        }

        public override DrawerArea GetDrawerAreaById(int id)
        {
            throw new NotImplementedException();
        }

        public override void AddDrawerArea(DrawerArea area)
        {
            throw new NotImplementedException();
        }
    }
}
