type SaveCustomer = WriteModel.Customer -> DbResult<Unit>
type LoadCustomer = CustomerId -> DbResult<ReadModel.Customer>   
