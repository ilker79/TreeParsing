# TreeParsing
This console application processes a coma seperated string values and parses them
in to a binary tree and then writes the values of the tree in traversal order.

To be able to use this console application you need to install .NET 7 and follow the steps below.

- clone the application
- run the donet build command to build the application
- under project folder go to directory \bin\Debug\net7.0
- and run the executalbe file "TreeParsing" with argument which is comma seperated values

Example:
C:\Users\...\bin\Debug\net7.0>TreeParsing "15,10,22,4,12,18,24"

Output on console should be 4,12,10,18,24,22,15

The application will also create a file called "TreeParsingFile.txt" 
with the values of the tree created.


