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
            var a = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 1, 1, 5, 5, 1, 5, 2, 5, 5, 5, 5, 5, 5 };
            Console.WriteLine(designerPdfViewer(a, "torn"));

            var b = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            Console.WriteLine(designerPdfViewer(a, "abc"));

            var c = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            Console.WriteLine(designerPdfViewer(b, "zaba"));

            Console.ReadKey();
        }

        public static int designerPdfViewer(List<int> h, string word)
        {
            int tallest = 0;
            int lowerCaseAIndex = 97;
            foreach (var letter in word)
            {
                var currentHeight = h[letter - lowerCaseAIndex];
                tallest = tallest < currentHeight ? currentHeight : tallest;
            }
            return tallest * word.Length;
        }
    }
}
