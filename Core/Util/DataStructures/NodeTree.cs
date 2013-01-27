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
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; private set; }

        public Node(T value)
        {
            this.Value = value;
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
}
