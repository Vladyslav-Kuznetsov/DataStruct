namespace DataStruct
{
    public class BinaryTree
    {
    }

    public class TreeNode
    {
        public object Data { get;set; }
        public TreeNode Left { get; private set; }
        public TreeNode Right { get; private set; }

        public TreeNode(object data)
        {
            Data = data;
        }
    }
}
