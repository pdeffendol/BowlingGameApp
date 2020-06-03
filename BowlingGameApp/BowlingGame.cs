using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingGameApp
{
    public class BowlingGame
    {
        private int _currentFrame = 1;
        private List<int> _rolls = new List<int>();

        public void Roll(int pins)
        {
            _rolls.Add(pins);
        }

        public int Score()
        {
            var score = 0;

            for (var currentRoll = 0; currentRoll < 20; currentRoll++)
            {
                score += _rolls[currentRoll];
                if (IsSpare(currentRoll))
                {
                    score += _rolls[currentRoll + 1];
                }
            }

            return score;
        }

        private bool IsSpare(currentRoll)
        {

        }
    }

    public class Frame
    {

    }

}
