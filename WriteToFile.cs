
public class WriteToFile
{
    public static void WriteTreeToFile(TreeNode node)
    {
        string path = Directory.GetCurrentDirectory();
        string target = @$"{path}\TreeParsingFile.txt";

        if (node != null)
        {
            File.AppendAllText(target, node.name + ",");
            WriteTreeToFile(node.leftNode);
            WriteTreeToFile(node.rightNode);
        }
    }

}