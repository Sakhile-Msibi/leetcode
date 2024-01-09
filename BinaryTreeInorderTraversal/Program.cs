namespace BinaryTreeInorderTraversal
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

    internal class Program
    {
        IList<int> list = new List<int>();

        static void Main(string[] args)
        {
            Program program = new Program();

            TreeNode root = new TreeNode(1);
            root.left = null;
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            //TreeNode root = new TreeNode(6);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(4);
            //root.left.right.left = new TreeNode(3);
            //root.left.right.right = new TreeNode(5);
            //root.right = new TreeNode(7);
            //root.right.right = new TreeNode(9);
            //root.right.left = new TreeNode(8);

            //program.DisplayTree(root);

            program.DisplayList(program.InorderTraversal(root));
            Console.ReadKey();
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            //if (list.Count == 0 && root.left == null && root.right == null)
            //{
            //    list.Add(root.val);
            //}

            if (root.left != null)
            {
                InorderTraversal(root.left);
            }

            if (root.right != null)
            {
                InorderTraversal(root.right);
            }

            if (root.left == null)
            {
                list.Add(root.val);

                return list;
            }

            if (root.right == null)
            {
                list.Add(root.val);
            }

            return list;
        }

        void DisplayList(IList<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}