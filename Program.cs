// <copyright file="Program.cs" company="PlaceholderCompany">
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
    /// Starts the program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Program"/> class.
        /// </summary>
        public Program()
        {
        }

        private static void Main(string[] args)
        {
            ////initializing variables
            Node root = null;
            BSTNumberList tree = new BSTNumberList();
            int num = 0, max = 100, min = 0, minLevels = 0, levels = 0;
            string val;

            ////prompts user to enter numbers from [0, 100]
            Console.WriteLine("Enter a collection of number in the range of [0, 100], seperated by spaces.");
            val = Console.ReadLine();

            ////parsing the prompt values
            string[] numbers = val.Split();

            ////inserting values in to tree
            foreach (string number in numbers)
            {
               num = int.Parse(number);
               if (num < min || num > max)
                {
                    Console.WriteLine("{0} is not in the range of [0, 100]", num);
                }
                else
                {
                    root = tree.Insert(root, num);
                }
            }

            ////Display the bst in order
            Console.WriteLine("Tree contents: ");
            tree.DisplayInOrder(root);

            Console.WriteLine("Tree Statistics:");
            Console.WriteLine(" Number of nodes: {0}", tree.LeafCount(root));

            ////Displaying the levels of nodes in a tree
            minLevels = Convert.ToInt32(1 + Math.Floor(Math.Log(tree.LeafCount(root) + 1)));

            ////Math.pow only accepts doubles, had to convert to integers
            levels = Convert.ToInt32(Math.Pow(2.0, 1 + Math.Floor(Math.Log(tree.LeafCount(root)))));

            Console.WriteLine(" Number of levels: {0}", levels);
            Console.WriteLine(" Minimum levels that a tree of {0} nodes could have is {1}", tree.LeafCount(root), minLevels);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
