using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvasionEngine.Core.Util.DataStructures
{
    public class NodeTree<T>
    {
        public Node<T> Root { get; set; }
        public NodeTree()
        {
        }

        public int Count()
        {
            int count = 0;
            if(Root != null)
            {
                count = Root.CountChildren() + 1;
            }

            return count;
        }

        public NodeTreeEnumerator<T> GetEnumerator()
        {
            return new NodeTreeEnumerator<T>(this);
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; private set; }

        public Node(T value)
        {
            this.Value = value;
            Children = new List<Node<T>>();
        }

        public Node<T> AddChild(T value)
        {
            Node<T> child = new Node<T>(value);
            Children.Add(child);
            return Children[Children.Count - 1];
        }

        public bool RemoveChild(Predicate<Node<T>> match)
        {

            Node<T> node = this.Children.Find(match);
            if (node != null)
            {
                this.Children.Remove(node);
                return true;
            }
            return false;
        }

        public int CountChildren()
        {
            int count = this.Children.Count;
            foreach (Node<T> child in this.Children)
            {
                count += child.CountChildren();
            }
            return count;
        }

        public void Traverse(Action<Node<T>> func) 
        {
            foreach (Node<T> node in this.Children)
            {
                func(node);
            }
        }

        public Node<T> Find(Predicate<Node<T>> match)
        {
            Node<T> node = this.Children.Find(match);
            return node;
        }
    }

    public class NodeTreeEnumerator<T>
    {
        NodeTree<T> collection;
        Queue<Node<T>> queue;
        public NodeTreeEnumerator(NodeTree<T> coll)
        {
            collection = coll;
            queue = new Queue<Node<T>>();
            if (coll.Root != null)
            {
                queue.Enqueue(coll.Root);
            }
        }

        public bool MoveNext()
        {
            if (queue.Count > 0)
            {
                Node<T> next = queue.Peek();
                //add children to queue for breadth first
                foreach (Node<T> node in next.Children)
                {
                    queue.Enqueue(node);
                }

            }
            return queue.Count > 0;
        }

        public Node<T> Current
        {
            get
            {
                return queue.Dequeue();
            }
        }
    }
}
