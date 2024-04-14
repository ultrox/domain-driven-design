type InsertData = DbConnection -> Data -> Unit
type ReadData = DbConnection -> Query -> Data
type UpdateData = DbConnection -> Data -> Unit
type DeleteData = DbConnection -> Key -> Unit
