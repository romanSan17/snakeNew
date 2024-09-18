using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    internal class Players
    {
        string playerName = "";
        try
            {
                StreamWriter sw = new StreamWriter(@"..\..\..\text.txt", true);
                Console.WriteLine("Sisesta oma nimi: ");
                playerName = Console.ReadLine();
                sw.WriteLine(playerName);
                sw.Close();
            }

            catch (Exception)
            {
                Console.WriteLine("Fail ei lieutd");
            }
            try
            {
                StreamReader sr = new StreamReader(@"..\..\..\text.txt");
                string lines = sr.ReadToEnd();
                Console.WriteLine(lines);
                sr.Close();

                List<string> result = new List<string>();
            foreach (string rida in File.ReadAllLines(@"..\..\..\text.txt"))
    {
        result.Add(rida);
    }
            foreach (var rida in result)
    {
        Console.WriteLine(rida);
    }
}
            catch (Exception e)
{
    Console.WriteLine(e);
}
Console.ReadLine();
    }
}
