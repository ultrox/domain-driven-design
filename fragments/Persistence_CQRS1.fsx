type SaveCustomer = Customer -> DbResult<Unit>
type LoadCustomer = CustomerId -> DbResult<Customer>   
