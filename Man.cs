using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Man
    {
        public List<string> hangman = new()
        {
            "|",
            "|",
            "O",
            "|",
            "-",
            "-",
            "-",
            "-",
            "-",
            "|",
            "/",
            "|",
        };

        public void showMan(int errors)
        {
            var currentMan = new List<string>(new string[12]);

            for (int i = 0; i < errors && i < currentMan.Count; i++) currentMan[i] = hangman[i];

            Console.WriteLine($@"
    {currentMan[0]}
    {currentMan[1]}
    {currentMan[2]}
    {currentMan[3]}
  {currentMan[4]}{currentMan[5]}{currentMan[6]}{currentMan[7]}{currentMan[8]}
    {currentMan[9]}
   {currentMan[10]}{currentMan[11]}


    ");
        }
    }
}
