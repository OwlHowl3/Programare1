using System;
using System.Collections;
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form4 : Form
    {
        // 1. Algoritm de cautare index pentru valoare in vector

        // 2. Algoritm de cautare pentru toti
        //    indecsii la care apare valoarea in vector

        // 3. Algoritm de cautare in multimi ordonate (iterativ)

        // 4. Algoritm de cautare in multimi ordinate (divide-et-impera)

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // 1. Start--------------------------------------------------------------
            int[] haystack = new int[] { 42, 8, 4, 16, 23, 15, 16 };
            int needle = 16;

            int index = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Element not found.");
            } else
            {
                Console.WriteLine("Element found at index " + index);
            }
            // 1. End --------------------------------------------------------------

            // 2. Start --------------------------------------------------------------
            ArrayList indexes = new ArrayList(); // [3, 6]
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle)
                {
                    indexes.Add(i);
                }
            }

            var sb = new StringBuilder(); // ""

            for (int i = 0; i < indexes.Count; i++)
            {
                sb.Append(indexes[i]); //   "3,6"
                if (i != indexes.Count - 1)
                {
                    sb.Append(",");
                }
            }

            string indexesString = sb.ToString();

            if (indexes.Count == 0)
            {
                Console.WriteLine("Element not found.");
            } else
            {
                Console.WriteLine("Element found at indexes " + indexesString);
            }
            // 2. End --------------------------------------------------------------
            
            // 3. Start --------------------------------------------------------------
            int[] vector = { 5, 8, 15, 16, 23, 42 };
            int value = 13;

            int foundIndex = -1;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == value)
                {
                    foundIndex = i;
                    break;
                }
                if (vector[i] > value)
                {
                    break;
                }
            }
            if (foundIndex == -1)
            {
                Console.WriteLine("Element not found");
            } else
            {
                Console.WriteLine($"Element found at index:{foundIndex}");
            }
            // 3. End --------------------------------------------------------------

            // 4. Start --------------------------------------------------------------
            int[] vector2 = { 4, 8, 15, 16, 23, 42, 51, 61, 88 };
            int value2 = 61;
            int leftIndex = 0;
            int rightIndex = vector2.Length - 1; 
            int foundIndex2 = -1;
            while (leftIndex <= rightIndex)
            {
                int mid = leftIndex + (rightIndex - leftIndex) / 2;
                // int middle = (dreapta + stanga) /2;
                if (vector2[mid] == value2)
                {
                    foundIndex2 = mid;
                    break;
                }
                if (value2 > vector2[mid])
                {
                    leftIndex = mid + 1;
                }
                else
                {
                    rightIndex = mid - 1;
                }
            }

            if (foundIndex2 == -1)
            {
                Console.WriteLine("Element not found");
            } else
            {
                Console.WriteLine("Element found at index " + foundIndex2);
            }
            // 4. End --------------------------------------------------------------
        }
    }
}
