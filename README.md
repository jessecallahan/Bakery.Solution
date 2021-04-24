# Jesse's Pierre's Bakery
https://github.com/jessecallahan/Bakery.Solution

Created 04.23.21</br>
By _**Jesse Callahan**_</br>
Contact: _**Jessetylercallahan@gmail.com**_</br>

## Description
Pierre's Bakery is a C# application that uses two classes, Bread and Pastries. Based on the user's input and the built-in "deals", these classes sum the cost of buying goods at the bakery.

## Setup/Installation Requirements

1. Clone this [repository](https://github.com/jessecallahan/Bakery.Solution)
2. Navigate to the Bakery folder
3. Run 'dotnet restore && dotnet run' to run the application
4. Navigate to the Bakery.Tests folder
5. Run ''dotnet restore && dotnet test' to run the MSTest Enviorment
6. Enjoy!

## Specs

|  Amount/User Input|  Type | Output  | Test Function |
|---|---|---|---|
| 1  |  "bread" | Instance of Bread is Bread type | BreadConstructor_CreatesInstanceOfBread_Bread() | 
| 1  |  "bread"  | Amount is being recognized | GetAmount_ReturnsBreadAmount_Int() |
| 0  |  "bread" | $0 | "1 Pastry"|ReturnBreadTotalCost_ReturnsBreadTotalCostTest1_Int()|
| 1  |  "bread" | $5  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest2_Int() |
| 2  |  "bread" | $10  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest3_Int() |
| 3  |  "bread" | $10  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest4_Int() |
| 4  |  "bread" | $15  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest5_Int() |
| 1  |  "bread" | "1 Loaf of Bread" | ReturnAmountofBread_ReturnsBreadDetailsTest1_String() |
| 2  |  "bread" | "3 Loaves of Bread" Note: Remember you cannot order 2 loaves, you always get that third one for free  | 

|  Amount/User Input|  Type | Output  | Test Function |
|---|---|---|---|
| 1  |  "bread" | Instance of Bread is Bread type | BreadConstructor_CreatesInstanceOfBread_Bread() | 
| 1  |  "bread"  | Amount is being recognized | GetAmount_ReturnsBreadAmount_Int() |
| 0  |  "bread" | $0 | "1 Pastry"|ReturnBreadTotalCost_ReturnsBreadTotalCostTest1_Int()|
| 1  |  "bread" | $5  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest2_Int() |
| 2  |  "bread" | $10  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest3_Int() |
| 3  |  "bread" | $10  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest4_Int() |
| 4  |  "bread" | $15  | ReturnBreadTotalCost_ReturnsBreadTotalCostTest5_Int() |
| 1  |  "bread" | "1 Loaf of Bread" | ReturnAmountofBread_ReturnsBreadDetailsTest1_String() |
| 2  |  "bread" | "3 Loaves of Bread" Note: Remember you cannot order 2 loaves, you always get that third one for free  | 

## Technologies Used
* C#
* MSTest
* .NET
* MVC


