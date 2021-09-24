using System;
namespace LeetCode
{
    public class BTS
    {
        public NodeT root;
        public BTS()
        {
            root = null;
        }

        public void insert(int data)
        {
            NodeT newNode = new NodeT();
            newNode.data = data;
            if(root == null)
                root = newNode;
            else 
            {
                NodeT current = root;
                NodeT parent;
                
                while (true) 
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else 
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }

                }
            }
        }

        public void inOrder(NodeT theRoot)
        {
            if (theRoot != null)
            {
                inOrder(theRoot.left);
                theRoot.displayNode();
                inOrder(theRoot.right);
            }
        }

        public void preOrder(NodeT theRoot)
        {
            if (theRoot != null)
            {
                theRoot.displayNode();
                inOrder(theRoot.left);
                inOrder(theRoot.right);
            }
        }
    }
    
    public class NodeT
    {
        public int data;
        public NodeT left;
        public NodeT right;

        public void displayNode()
        {
            Console.WriteLine(data);
        }
    }
}