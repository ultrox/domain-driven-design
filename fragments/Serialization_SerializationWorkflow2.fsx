type JsonString = string
type MyInputDto = ...

type DeserializeInputDto = JsonString -> MyInputDto
type InputDtoToDomain = MyInputDto -> MyInputType
