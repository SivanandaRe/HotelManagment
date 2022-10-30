For N-Layeried architecture 
https://www.c-sharpcorner.com/interview-question/what-is-difference-between-ntier-vs-nlayer-architecture
https://www.youtube.com/watch?v=Hqj8Xxebf9Y




Requirements for this Project



Siva Bussiness analyst 

Aravind customer

 
 Customer Aravind
 
 Table: Customer 
 CustomerId
 CustomerName
 CustomerAadhar
 customerAddressId
 customerHotelAddressId
 Isactive
 
 
Table: Address
 AddressId
 country
 state
 district
 city
 place
 address 
 Phonenumber
 email
 addressTypeId
 isactive
 
 Table AddressType
 AddressTypeId
 AdrressTypeName
 Isactive


 Hotel Room address 
 
 Table Inventry
 InventryId
 InventryName
 InventryProductId
 InventryQty
 InventryUnits  (kg, piece,bottle,liters)
 InventoryCustomerId
 isactive
 
Table Products
 ProductId
 ProductCode
 ProductName
 productCustomerId
 isactive
  
 Inventry 
 

 Table: employee
 EmployeeId
 EmployeeName
 
 EmployeeAadharId
 EmployeeSalary
 EmpoyeeJoiningDate
 EmployeeGenderId
 EmployeeAddressId
 EmployeeCustomerId
 EmployeeRoleId
 
 
 Isactive
 
 Table: Gender
 GenderId
 GenderName
 Isactive
  
 
 Table: Roles
 RoleId
 Rolecode
 RoleName
 Isactive
 
 Roles 
 Admin 
 casheier
 cooking 
 serving 
 cleaning
 
 Table :MenuItems
 MenuItemId
 MenuItemCode
 MenuItemName
 MenuItemCustomerId
 MenuItemExtraInfo
 MenuItemPrice
 Isactive
 
 Table: Orders
 OrderId
 OrderedPerson
 OrderedPersonMobileNumber
 OrderMenuItemId
 OrderMeniItemQty
 Isactive
 OrderCreatedDate
 OrderedforDate
 OrderModifiedDate
 
 Table: OrderDelivery
 OrderDeliveryId
 OrderdeliveryDate
 OrderDeliveryOrderId
 Isactive
 
 Table: Invoice
 InvoiceId
 InvoiceDate
 InvoiceDeliveryId
 InvoiceAmount
 isactive
 
 Table: Collection
 CollectionId
 CollectionDate
 CollectionAmount
 CollectionPendingAmount
 CollectionInvoiceId
 CollectionMode
 isactive
 
 
 
 
 
 
 
 
 
 
 
  




 
 
 
 
 Aravind Hotel Management
 
 Admin
 User
 
 Customer
 
 orders 
 deliveries
 invoice 
 collection
 debit 
 credit
 
 
 Sql
 C#
 Frontend 
 
 Mvc
 basics
 data passing ways from controller action to view 
 basic crud operation 
 Clientsidevalidation server side validation
 Frontend 
 
 
 