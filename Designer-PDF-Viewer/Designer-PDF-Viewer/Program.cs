using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_PDF_Viewer
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> charHeightList = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            //var word = "abc";

            List<int> charHeightList = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            var word = "zaba";


            var maxHeight = 0;
            foreach(char c in word)
            {
                int currentIndex = c - 97;//97 is ascii 'a'
                int heightValue = charHeightList[currentIndex];
                if(heightValue > maxHeight)
                {
                    maxHeight = heightValue;
                }
            }
            var maxArea = word.Length * maxHeight;
            Console.WriteLine("Max Area: " + maxArea);
            Console.ReadKey();
        }
    }
}
