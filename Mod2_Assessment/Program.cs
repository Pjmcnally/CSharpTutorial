using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Self Assessment Lab
            // For this assignment, you will create the pattern of a chess board that is 8 x 8.Use X and O to represent the squares.
            // Create the appropriate nested looping structure to output the characters in an 8 x 8 grid on the screen using Console.Write() or Console.WriteLine() as appropriate.
            // Include a decision structure to ensure that alternate rows start with opposite characters as a real chess board alternates the colors among rows.
            // This is what your output should look like.  (NOTE: Depending on how this renders in your browser, you may see additional blank lines between the XOXO output.It is not required in your output, just ensure each line is under the previous one.)

            // XOXOXOXO
            // OXOXOXOX
            // XOXOXOXO
            // OXOXOXOX
            // XOXOXOXO
            // OXOXOXOX
            // XOXOXOXO
            // OXOXOXOX

            // Grading Criteria:
            // Used a nested loop
            // Used a decision structure to flip row output
            // Output is correct per above image
            
            int size = 8;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
