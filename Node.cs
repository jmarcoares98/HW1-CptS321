// <copyright file="Node.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BSTNumberList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Node class for the BST.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// a private variable to add to the node of the BST.
        /// </summary>
        /// <param name="Num">The first name to join.</param>
        /// <param name="LeftNode">This goes to the left of the node.</param>
        /// <param name="RightNode">Goes to the right of the node.</param>
        /// <returns>The joined names.</returns>
        private int num;
#pragma warning disable SA1202 // Elements should be ordered by access
#pragma warning disable SA1401 // Fields should be private
#pragma warning disable SA1600 // Elements should be documented
        public Node LeftNode;
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1401 // Fields should be private
#pragma warning restore SA1202 // Elements should be ordered by access
#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable SA1401 // Fields should be private
        public Node RightNode;
#pragma warning restore SA1401 // Fields should be private
#pragma warning restore SA1600 // Elements should be documented

        /// <summary>
        /// Gets or sets joins a first name and a last name together into a single string.
        /// </summary>
        /// <param name="num">The first name to join.</param>
        /// <param name="num">The last name to join.</param>
        /// <returns>The joined names.</returns>
        public int Num { get => this.num; set => this.num = value; }

#pragma warning disable SA1614 // Element parameter documentation should have text

#pragma warning disable SA1201 // Elements should appear in the correct order
                              /// <summary>
                              /// Initializes a new instance of the <see cref="Node"/> class.
                              /// </summary>
                              /// <param name="data"></param>
        public Node(int data)
#pragma warning restore SA1201 // Elements should appear in the correct order
#pragma warning restore SA1614 // Element parameter documentation should have text
        {
            int num = data;
            this.LeftNode = null;
            this.RightNode = null;
        }
    }
}
