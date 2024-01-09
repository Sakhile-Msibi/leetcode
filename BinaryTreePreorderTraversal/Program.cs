namespace BinaryTreePreorderTraversal
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

        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            
            if (list.Count == 0)
            {
                list.Add(root.val);
            }

            if (root.left != null)
            {
                list.Add(root.left.val);
                PreorderTraversal(root.left);
            }

            if (root.right != null)
            {
                list.Add(root.right.val);
                PreorderTraversal(root.right);
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

        void DisplayTree(TreeNode root)
        {

            Console.WriteLine(root);

            while (root.left != null)
            {
                Console.WriteLine(root.left.val + " ");
                DisplayTree(root.left);
            }

            while (root.right != null)
            {
                Console.WriteLine(root.right.val + " ");
                DisplayTree(root.right);
            }
        }

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

            program.DisplayList(program.PreorderTraversal(root));

            //Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}