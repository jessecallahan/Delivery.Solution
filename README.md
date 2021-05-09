# Jesse's Delivery Service
https://github.com/jessecallahan/Delivery.Solution

Created 04.23.21</br>
By _**Jesse Callahan**_</br>
Contact: _**Jessetylercallahan@gmail.com**_</br>

## Description
This delivery service, is a C# application that replicates a delivery tracking service for a bakery. It uses two classes, Vendor and Order. "Vendor" is for the business' we are setting up delivery for and "order" are the items that are ordered. 

## Setup/Installation Requirements

1. Clone this [repository](https://github.com/jessecallahan/Bakery.Solution)
2. Navigate to the Delivery folder
3. Run 'dotnet restore && dotnet run' to run the application
4. Navigate to the Delivery.Tests folder
5. Run ''dotnet restore && dotnet test' to run the MSTest Enviorment
6. Enjoy!

## Specs

_**Vendor Object**_

|  Type | Output  | Test Function |
|---|---|---|
|  "Vendor" | Instance of Vendor is Vendor type | VendorConstructor_CreatesInstanceOVendor() |
 |  "Vendor" | Returns vendor list | GetAll_ReturnsAllVendorObjects_VendorList()| 
|  "Vendor"  | Returns specified vendor object | Find_ReturnsCorrectVendor_Vendor() |
 |  "Vendor"  | Adds an order object to vendor object | AddOrder_AssociatesOrderWithVendor_OrderList() |



_**Order Object**_

|  Type | Description  | Test Function |
|---|---|---|
|  "order" | Instance of order is order type | OrderConstructor_CreatesInstanceOfOrder_Order() | 
|  "order"  | Returns Order list | GetAll_ReturnsAllOrderObjects_OrderList() |
|  "order" | Order can be added to vendor | Find_ReturnsCorrectOrder_Order()|


## Technologies Used
* C#
* MSTest
* .NET
* MVC


