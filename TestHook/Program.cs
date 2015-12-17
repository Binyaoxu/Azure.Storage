using Azure.Storage.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHook
{
    class Program
    {
        static void Main(string[] args)
        {
            BlobDataManagerTests blobTests = new BlobDataManagerTests();
            blobTests.UploadLocalFileShouldSucceed().Wait();
            //BlobStorageAsyncTests blobStorage = new BlobStorageAsyncTests();
            //blobStorage.CreateBlobFromSreamAsyncSucceeds().Wait();
        }
    }
}
