using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;


namespace Snake
{
    public class Players
    {
        private readonly string _filePath;

        public Players(string filePath)
        {
            _filePath = filePath;
        }

        //lisab uue mängija nime faili.
        public void AddPlayer(string playerName, int score)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_filePath, true))
                {
                    sw.WriteLine($"{playerName}: {score}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("viga");
            }
        }

        // loeb nimed ja kannab need loetellu
        public List<string> GetPlayers()
        {
            List<string> players = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        players.Add(line);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("viga");
            }
            return players;
        }
    }
}

