type DbError = ...
type DbResult<'a> = AsyncResult<'a,DbError>

type InsertData = Data -> DbResult<Unit>
type ReadData = Query -> DbResult<Data>
type UpdateData = Data -> DbResult<Unit>
type DeleteData = Key -> DbResult<Unit>
