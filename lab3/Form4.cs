using System;
using System.Collections;
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
            ArrayList indexes = new ArrayList();
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle)
                {
                    indexes.Add(i);
                }
            }

            var sb = new StringBuilder();

            for (int i = 0; i < indexes.Count; i++)
            {
                sb.Append(indexes[i]);
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
            int[] haystack2 = { 4, 8, 15, 16, 23, 42 };
            int needle2 = 13;

            int index2 = -1;
            for (int i = 0; i < haystack2.Length; i++)
            {
                if (haystack2[i] == needle2)
                {
                    index2 = i;
                    break;
                }
                if (haystack2[i] > needle2)
                {
                    break;
                }
            }

            if (index2 == -1)
            {
                Console.WriteLine("Element not found");
            } else
            {
                Console.WriteLine("Element found at index: " + index2);
            }
            // 3. End --------------------------------------------------------------

            // 4. Start --------------------------------------------------------------
            int[] vector4 = { 4, 8, 15, 16, 23, 42, 51, 61, 88 };
            int valoareCautata4 = 61;

            int stanga = 0;
            int dreapta = vector4.Length - 1;
           
            int index4 = -1;

            while (stanga < dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;
                //			int middle = (dreapta + stanga) /2;

                if (vector4[mijloc] == valoareCautata4)
                {
                    index4 = mijloc;
                    break;
                }

                if (valoareCautata4 > vector4[mijloc])
                {
                    stanga = mijloc + 1;
                }
                else
                {
                    dreapta = mijloc - 1;
                }
            }

            if (index4 == -1)
            {
                Console.WriteLine("Element not found");
            } else
            {
                Console.WriteLine("Element found at index " + index4);
            }
            // 4. End --------------------------------------------------------------
        }
    }
}
