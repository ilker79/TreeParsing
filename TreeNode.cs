public class TreeNode : INode
{
    public string name;
    public TreeNode leftNode { get; set; }
    public TreeNode rightNode { get; set; }

    public TreeNode(string node)

    {
        name = node;
    }
}