using Xunit;
using static CreateTree;
using static OrderInput;
using static CheckNumbers;

using System;
using System.Diagnostics;
using System.ComponentModel;


public class TreeParsingTest
{

    [Theory]
    [InlineData("15,22,10,4,12,35,24")]
    public void OrderInputFunctionTest(string inputString)
    {
        string[] expect = { "15", "10", "22", "4", "12", "24", "35" };
        Assert.Equal(expect, OrderInputFunction(inputString));
    }

    [Theory]
    [InlineData(new string[] { "15", "22", "10", "4", "12", "35", "24" }, 0)]
    public void CreateTreeFunctionTest(string[] arrayInput, int index)
    {
        string expect = "22";
        string expect2 = "12";
        string expect3 = "123"; // fails if change it to 12 
        Assert.Equal(expect, CreateTreeFunction(arrayInput, index).leftNode.name);
        Assert.Equal(expect2, CreateTreeFunction(arrayInput, index).leftNode.rightNode.name);
        Assert.NotEqual(expect3, CreateTreeFunction(arrayInput, index).leftNode.rightNode.name);
    }

    [Theory]
    [InlineData("15,22,10,4,12,35,24")]
    public void CheckNumbersFunctionTest(string numbersToCheck)
    {
        Boolean expect = false;
        Assert.Equal(expect, CheckNumbersFunction(numbersToCheck));
    }

}


