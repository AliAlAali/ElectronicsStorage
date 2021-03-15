using System;
using Xunit;

using ES.Data.Model;
using ES.Data.Adapters;

namespace ES.Data.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestSaveChanges()
        {
            var adapter = new FileSystemDataAdapter();
            var storageBox = new StorageBox() { Id=1};
            adapter.AddStorageBox(storageBox);
            adapter.SaveChanges();

            var sAdapter = new FileSystemDataAdapter();
            Assert.Equal(1, sAdapter.GetStorageBoxById(1).Id);
        }


    }
}
