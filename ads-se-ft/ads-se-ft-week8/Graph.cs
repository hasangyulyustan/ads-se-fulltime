using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_PartTime_3
{
    public class Graph
    {
        internal const int MaxNode = 1024;
        private int[][] childNodes;

        public Graph(int[][] childNodes)
        {
            this.childNodes = childNodes;
        }

        public void TraverseBFS(int node)
        {
            bool[] visited = new bool[MaxNode];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            visited[node] = true;
            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                Console.Write("{0} ", currentNode);
                foreach (int childNode in childNodes[currentNode])
                {
                    if (!visited[childNode])
                    {
                        queue.Enqueue(childNode);
                        visited[childNode] = true;
                    }
                }
            }
        }

        public void TraverseDFS(int node)
        {
            bool[] visited = new bool[MaxNode];
            Stack<int> stack = new Stack<int>();
            stack.Push(node);
            visited[node] = true;
            while (stack.Count > 0)
            {
                int currentNode = stack.Pop();
                Console.Write("{0} ", currentNode);
                foreach (int childNode in childNodes[currentNode])
                {
                    if (!visited[childNode])
                    {
                        stack.Push(childNode);
                        visited[childNode] = true;
                    }
                }
            }
        }

        public void TraverseDFSRecursive(int node, bool[] visited)
        {
            if (!visited[node])
            {
                visited[node] = true;
                Console.Write("{0} ", node);
                foreach (int childNode in childNodes[node])
                {
                    TraverseDFSRecursive(childNode, visited);
                }
            }
        }
    }
}
