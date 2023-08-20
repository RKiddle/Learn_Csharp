using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AzureBlobAccessExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = "YourConnectionString"; // Replace with your storage account connection string
            string containerName = "your-container-name";
            string blobName = "your-blob-name";
            string downloadFilePath = "path-to-download-file"; // e.g., "C:\\downloaded.blob"

            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient = containerClient.GetBlobClient(blobName);

            if (await blobClient.ExistsAsync())
            {
                BlobDownloadInfo blobDownloadInfo = await blobClient.DownloadAsync();

                using (FileStream fs = File.OpenWrite(downloadFilePath))
                {
                    await blobDownloadInfo.Content.CopyToAsync(fs);
                    fs.Close();
                }

                Console.WriteLine($"Blob downloaded to {downloadFilePath}");
            }
            else
            {
                Console.WriteLine($"Blob '{blobName}' does not exist.");
            }
        }
    }
}
