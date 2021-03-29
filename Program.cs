using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Atom_Practice
{
    class Program
    {
        private static string[] fields;
        static void Main(string[] args)
        {
            storeInArrayFromFile("something.txt");
            createFileFromArray("somethingNew.txt", fields);

            //createFile("Thomas","Eames","one.txt");
            //readFile("one.txt");
            Console.ReadKey();
        }

        private static void createFile(string firstName, string lastName, string fileName)
        {
            TextWriter w = new StreamWriter(fileName);
            w.Write(String.Join(" ", firstName, lastName, DateTime.Now,"\n"));
            w.WriteLine("-------------------------------------------------\n");
            for(int i=1; i<10; i++)
            {
                w.WriteLine($"{i} X 12 = {i * 12}");
            }
            w.WriteLine("");
            w.WriteLine("Thanks for using my program");
            w.Close();
            
        }

        private static void storeInArrayFromFile(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                fields = line.Split(';');
            }
        }
        private static void createFileFromArray(string filepath, string[] myArray)
        {
            File.WriteAllLines(filepath, myArray);
        }

        private static void readFile(string fileName)
        {
            TextReader r = new StreamReader(fileName);
            string line = r.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = r.ReadLine();
            }
            r.Close();
        }
    }
}
