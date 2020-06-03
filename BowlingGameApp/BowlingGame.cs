﻿using System;
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
            var rollIndex = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (IsSpare(frame))
                {
                    score += 10 + _rolls[rollIndex + 2];
                    rollIndex += 2;
                }
                else
                {
                    score += _rolls[rollIndex] + _rolls[rollIndex + 1];
                    rollIndex += 2;
                }
            }

            return score;
        }

        private bool IsSpare(int firstRollOfFrameIndex)
        {
            return _rolls[firstRollOfFrameIndex] 
                + _rolls[firstRollOfFrameIndex + 1] == 10;
        }
    }
}
