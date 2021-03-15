using ES.Data.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ES.Data.Adapters
{
    [Serializable]
    public class FileSystemDataAdapter : DataSourceAdapter
    {
        private const string FILE_PATH = "./FILE_DATA_ADAPTER";

        private List<Drawer> Drawers = new List<Drawer>();
        private List<DrawerArea> DrawerAreas = new List<DrawerArea>();
        private List<StorageBox> StorageBoxes = new List<StorageBox>();
        private List<StorageLayout> StorageLayouts = new List<StorageLayout>();

        public FileSystemDataAdapter()
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            try
            {
                // read local data file
                if (File.Exists(FILE_PATH))
                {
                    var content = File.ReadAllText(FILE_PATH);
                    var data = JsonConvert.DeserializeObject<FileSystemDataAdapter>(content);

                    this.Drawers = data.Drawers;
                    this.DrawerAreas = data.DrawerAreas;
                    this.StorageBoxes = data.StorageBoxes;
                    this.StorageLayouts = data.StorageLayouts;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void SaveChanges()
        {
            // saves list into a file
            try
            {
                var content = JsonConvert.SerializeObject(this);
                File.WriteAllText(FILE_PATH, content);
            }
            catch(Exception e)
            {
                throw e;// for debuggin purposes.
            }
           
        }

        public override void AddDrawer(Drawer drawer)
        {
            if (drawer.Id != 0 && GetDrawerById(drawer.Id) == null)
            {
                Drawers.Add(drawer);
            }
        }

        public override void AddDrawerArea(DrawerArea area)
        {
            if (area.Id != 0 && GetDrawerAreaById(area.Id) == null)
            {
                DrawerAreas.Add(area);
            }
        }

        public override void AddStorageBox(StorageBox box)
        {
            if (box.Id != 0 && GetStorageBoxById(box.Id) == null)
            {
                StorageBoxes.Add(box);
            }
        }

        public override void AddStorageLayout(StorageLayout layout)
        {
            if (layout.Id != 0 && GetStorageLayoutById(layout.Id) == null)
            {
                StorageLayouts.Add(layout);
            }
        }

        public override DrawerArea GetDrawerAreaById(int id)
        {
            var area = DrawerAreas.Find(d => d.Id == id);
            if (area.Id == 0)
            {
                return null;
            }

            return area;
        }

        public override IEnumerable<DrawerArea> GetDrawerAreas()
        {
            return DrawerAreas;
        }

        public override Drawer GetDrawerById(int id)
        {
            var drawer = Drawers.Find(d => d.Id == id);
            if (drawer.Id == 0)
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
            var box = StorageBoxes.Find(d => d.Id == id);
            if (box.Id == 0)
            {
                return null;
            }

            return box;
        }

        public override IEnumerable<StorageBox> GetStorageBoxes()
        {
            return StorageBoxes;
        }

        public override StorageLayout GetStorageLayoutById(int id)
        {
            var layout = StorageLayouts.Find(d => d.Id == id);
            if (layout.Id == 0)
            {
                return null;
            }

            return layout;
        }

        public override IEnumerable<StorageLayout> GetStorageLayouts()
        {
            return StorageLayouts;
        }
    }
}
