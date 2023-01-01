using static OrderInput;
using static PostOrderFunction;
using static CreateTree;
using static WriteToFile;
using static CheckNumbers;

class Program

{
    static void Main(string[] args)
    {
        string argPassedFromCommandLine = args[0];
        CheckNumbersFunction(argPassedFromCommandLine);
        string[] inputArray = OrderInputFunction(argPassedFromCommandLine);
        TreeNode tree = CreateTreeFunction(inputArray, 0);
        TraversalFunction(tree);
        WriteTreeToFile(tree);
    }
}

