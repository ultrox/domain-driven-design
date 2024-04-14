open Microsoft.WindowsAzure
open Microsoft.WindowsAzure.Storage
open Microsoft.WindowsAzure.Storage.Blob

let connString = "... Azure connection string ..."
let storageAccount = CloudStorageAccount.Parse(connString)
let blobClient = storageAccount.CreateCloudBlobClient()

let container = blobClient.GetContainerReference("Person");
container.CreateIfNotExists()
