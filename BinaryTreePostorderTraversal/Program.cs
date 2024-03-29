﻿namespace BinaryTreePostorderTraversal
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

            //TreeNode root = new TreeNode(1);
            //root.left = null;
            //root.right = new TreeNode(2);
            //root.right.left = new TreeNode(3);

            TreeNode root = new TreeNode();
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(4);
            //root.left.right.left = new TreeNode(3);
            //root.left.right.right = new TreeNode(5);
            //root.right = new TreeNode(7);
            //root.right.right = new TreeNode(9);
            //root.right.left = new TreeNode(8);

            program.DisplayList(program.PostorderTraversal(root));

            Console.ReadKey();
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            if (root.left is not null && root.right is not null)
            {
                PostorderTraversal(root.left);
                PostorderTraversal(root.right);

                list.Add(root.val);
            }
            else if (root.left is not null && root.right is null)
            {
                PostorderTraversal(root.left);

                if (root.right is not null)
                {
                    PostorderTraversal(root.right);
                }

                list.Add(root.val);
            }
            else if (root.left is null && root.right is not null)
            {
                PostorderTraversal(root.right);
                list.Add(root.val);
            }
            else if (root.left is null && root.right is null)
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