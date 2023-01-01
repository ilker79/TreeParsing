public class PostOrderFunction
{

    public static void TraversalFunction(TreeNode tree)
    {
        TreeNode current = tree;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (current != null || stack.Count != 0)
        {
            if (current != null)
            {
                stack.Push(current);
                current = current.leftNode;
            }
            else
            {
                TreeNode temp = stack.Peek().rightNode;
                if (temp == null)
                {
                    temp = stack.Pop();
                    Console.Write(temp.name + ",");
                    while (stack.Count != 0 && temp == stack.Peek().rightNode)
                    {
                        temp = stack.Pop();
                        Console.Write(temp.name + (stack.Count() == 0 && current == null ? "" : ","));
                    }
                }
                else
                {
                    current = temp;
                }
            }
        }
    }
}