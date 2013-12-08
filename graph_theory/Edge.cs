using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_theory
{
    /// <summary>
    /// An Edge which is part of a graph.
    /// </summary>
    public class Edge
    {
        private Node _one;
        private Node _two;

        public Edge(Node one, Node two)
        {
            _one = one;
            _two = two;
        }

        /// <summary>
        /// Returns the Node at the opposite end of this edge.
        /// </summary>
        /// <param name="start">On end of this Edge.</param>
        /// <returns>The opposite end.</returns>
        public Node Next(Node start)
        {
            if (start == _one)
            {
                return _two;
            }
            else if (start == _two)
            {
                return _one;
            }
            else
            {
                throw new ArgumentException("Start node is not positioned at this edge.");
            }
        }
    }
}
