using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordCodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    {
                        string wordLongest = "a";
                        int wordLongestLength = 0;
                        string[] words = line.Split(' ');

                        for (int i = 0; i < words.Length; i++)
                        {
                            int wordLength = words[i].Length;  // Finds length of word
                            if (wordLength > wordLongestLength)
                            {
                                wordLongestLength = wordLength;
                                wordLongest = words[i];
                            }
                        }
                        System.Console.WriteLine(wordLongest);
                    }
                }
           
        }
    }
}
