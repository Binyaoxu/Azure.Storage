using System.Threading.Tasks;
using Azure.Storage.Interfaces;
using Microsoft.WindowsAzure.Storage.Blob;
using Xunit;

namespace Azure.Storage.Tests
{
    public class BlobDataManagerTests
    {
        private const string ContainerName = "test-container";
        //private const string ConnectionString = "UseDevelopmentStorage=true";
        private const string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=daaacn2col0metricacc;AccountKey=AYu1zfTXzPrA1ipItSFCv2xYoDa2QHkoEyz2qJHmLrnB7lZH7PqHrFRE4ZTGFW1EgX23aEloT74tNeINGewckQ==";

        private IBlobDataManager blobDataManager;

        [Fact]
        public async Task UploadLocalFileShouldSucceed()
        {
            blobDataManager = new BlobDataManager();
            var options = new BlobOptions
            {
                BlobName = "SampleData.txt",
                BlobType = BlobType.BlockBlob,
                ConnectionString = ConnectionString,
                ContainerName = ContainerName,
                OverwriteDestination = true,
                Public = true
            };

            await blobDataManager.UploadFileToBlobAsync("SampleData.txt", options);

            Assert.True(blobDataManager.ProgressRecorder.LatestNumberOfFilesFailed == 0);
            Assert.True(blobDataManager.ProgressRecorder.LatestNumberOfFilesTransferred == 1);
        }
    }
}
