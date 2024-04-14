type PersonDto = {
  PersonId : int
  ...
  }

let savePersonDtoToBlob personDto = 
  let blobId = sprintf "Person%i" personDto.PersonId 
  let blob = container.GetBlockBlobReference(blobId)
  let json = Json.serialize personDto 
  blob.UploadText(json)
