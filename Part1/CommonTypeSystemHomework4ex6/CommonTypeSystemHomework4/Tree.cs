using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystemHomework4
{
    public class Tree
    {
        public Node Insert(Node root,int v)
        {
            if (root == null)
            {
                root = new Node();
                root.Value = v;
            }
            else if (v < root.Value)
            {
                root.Left = Insert(root.Left, v);
            }
            else
            {
                root.Right = Insert(root.Right, v);
            }

            return root;
        }

        public void Traverse(Node root)
        {
            if (root == null)
                return;
            Traverse(root.Left);
            Console.WriteLine(root.Value);
            Traverse(root.Right);
            Console.WriteLine(root.Value);
        }
    }
}
