
public class CreateTree
{

    public static TreeNode CreateTreeFunction(string[] input, int index)
    {

        TreeNode node = null;

        if (index < input.Length)
        {
            node = new TreeNode(input[index]);
            int childIndex = index * 2;
            node.leftNode = CreateTreeFunction(input, childIndex + 1);
            node.rightNode = CreateTreeFunction(input, childIndex + 2);
        }

        return node;
    }

}