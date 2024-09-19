using Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameOverDisplay
    {
        //mängija andmete kogumine
        private Players _players;

        public GameOverDisplay(Players players)
        {
            _players = players;
        }
        //mängu lõpu teate ja mängijate nimekirja kuvamine
        public void ShowGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("G A M E    O V E R", xOffset + 1, yOffset++);
            yOffset++;

            Console.ForegroundColor = ConsoleColor.White;
            WriteText("mängijate arv:", xOffset, yOffset++);

            List<string> playersWithScores = _players.GetPlayers();
            foreach (string player in playersWithScores)
            {
                WriteText(player, xOffset, yOffset++);
            }

        }
        //kontrollib teksti kuvamist ekraanil antud positsioonil
        private void WriteText(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}