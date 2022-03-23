using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    public class Score
    {
        public int score = 0;
        public int speed = 2;

        public Score()
        {

        }
        public Score(int score_, int speed_)
        {
            this.score = score_;
            this.speed = speed_;
        }
        public void WriteScore()
        {
            Console.SetCursorPosition(80, 1);
            //score++;
            Console.WriteLine($"Sinu punktid: {score}");
        }
        public void ScoreUp()
        {
            score++;
        }
        public int Speed()
        {
            speed++;
            return speed;
        }
    }
}
