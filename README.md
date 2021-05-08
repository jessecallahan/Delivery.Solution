# Jesse's Delivery Service
https://github.com/jessecallahan/Delivery.Solution

Created 04.23.21</br>
By _**Jesse Callahan**_</br>
Contact: _**Jessetylercallahan@gmail.com**_</br>

## Description
This delivery service, is a C# application that replicates a delivery tracking service for a bakery. It uses two classes, Vendor and Order. "Vendor" is for the business' we are setting up delivery for and "order" are the items that are ordered. 

## Setup/Installation Requirements

1. Clone this [repository](https://github.com/jessecallahan/Bakery.Solution)
2. Navigate to the Bakery folder
3. Run 'dotnet restore && dotnet run' to run the application
4. Navigate to the Bakery.Tests folder
5. Run ''dotnet restore && dotnet test' to run the MSTest Enviorment
6. Enjoy!

## Specs

_**Bread Object**_

|  Amount/User Input|  Type | Output  | Test Function |
|---|---|---|---|
| 1  |  "Vendor" | Instance of Vendor is Vendor type | BreadConstructor_CreatesInstanceOfBread_Bread() |
| 0  |  "Vendor" | Vendor can be added to | ReturnBreadTotalCost_ReturnsBreadTotalCostTest1_Int()| 
| 1  |  "Vendor"  | Vendor can be deleted | GetAmount_ReturnsBreadAmount_Int() |



_**Pastry Object**_

|  Amount/User Input|  Type | Output  | Test Function |
|---|---|---|---|
| 1  |  "order" | Instance of order is order type | PastriesConstructor_CreatesInstanceOfPastry_Pastries() | 
| 1  |  "order"  | Order inputs working | GetAmount_ReturnsPastryAmount_Int() |
| 0  |  "order" | Order can be added to vendor | ReturnPastryTotalCost_ReturnsPastryTotalCostTest1_Int()|


## Technologies Used
* C#
* MSTest
* .NET
* MVC


