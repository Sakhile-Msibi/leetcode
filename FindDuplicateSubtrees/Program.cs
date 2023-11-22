namespace FindDuplicateSubtrees
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            int counter = 0;

            while (root.right != null || root.left != null)
            {
                counter++;
            }

            if (counter == 0 || counter == 1)
            {
                return new List<TreeNode>();
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}