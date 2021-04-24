# Jesse's Pierre's Bakery
https://github.com/jessecallahan/Bakery.Solution

Created 04.23.21</br>
By _**Jesse Callahan**_</br>
Contact: _**Jessetylercallahan@gmail.com**_</br>

## Description
Pierre's Bakery is a C# application that uses two classes, Bread and Pastry. Based on the user's input and the built-in "deals", these classes sum the cost of buying goods at the bakery.

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
| 1  |  "bread" | Instance of Bread is Bread type | BreadConstructor_CreatesInstanceOfBread_Bread() | 
| 1  |  "bread"  | Amount is being recognized | GetAmount_ReturnsBreadAmount_Int() |
| 0  |  "bread" | $0 |ReturnBreadTotalCost_ReturnsBreadTotalCostTest1_Int()|
| 1  |  "bread" | $5  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest2_Int() |
| 2  |  "bread" | $10  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest3_Int() |
| 3  |  "bread" | $10  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest4_Int() |
| 4  |  "bread" | $15  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest5_Int() |
| 1  |  "bread" | "1 Loaf of Bread" | ReturnAmountofBread_ReturnsBreadDetailsTest1_String() |
| 2  |  "bread" | "3 Loaves of Bread" Note: Remember you cannot order 2 loaves, you always get that third one for free| ReturnAmountofBread_ReturnsBreadDetailsTest2_String() |


_**Pastry Object**_

|  Amount/User Input|  Type | Output  | Test Function |
|---|---|---|---|
| 1  |  "pastry" | Instance of Pastry is Partry type | PastriesConstructor_CreatesInstanceOfPastry_Pastries() | 
| 1  |  "pastry"  | Amount is being recognized | GetAmount_ReturnsPastryAmount_Int() |
| 0  |  "pastry" | $0 | ReturnPastryTotalCost_ReturnsPastryTotalCostTest1_Int()|
| 1  |  "pastry" | $2  | ReturnPastryTotalCost_ReturnsPastryTotalCostTest2_Int() |
| 2  |  "pastry" | $4  | ReturnPastryTotalCost_ReturnsPastryTotalCostTest3_Int() |
| 3  |  "pastry" | $5  | ReturnPastryTotalCost_ReturnsPastryTotalCostTest4_Int() |
| 100  |  "pastry" | $167  | ReturnPastryTotalCost_ReturnsPastryTotalCostTest5_Int() |
| 1  |  "pastry" | "1 Pastry" | ReturnAmountofPastry_ReturnsPastryDetailsTest1_String() |
| 100  |  "pastry" | "100 Pastries"  | ReturnAmountofPastry_ReturnsPastryDetailsTest2_String() |

## Technologies Used
* C#
* MSTest
* .NET
* MVC


