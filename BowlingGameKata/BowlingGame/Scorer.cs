using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    class Scorer
    {
        private int[] _Throws  = new int[21];
        private int _CurrentThrow;
        private int _CurrentBall;

        public void AddThrow(int pins)
        {
            _Throws[_CurrentThrow++] = pins;
        }

        public int GetScoreForFrame(int frameNumber)
        {
            var score = 0;
            _CurrentBall = 0;

            for (int currentFrame = 0; currentFrame < frameNumber; currentFrame++)
            {
                if (Strike()  )
                {
                    score += 10 + NextTwoBallsforStrikeScore();
                    _CurrentBall = _CurrentBall + 1;
                }
                else if (Spare() )
                {
                    score += 10 + NextBallforSpareScore();
                    _CurrentBall = _CurrentBall + 2;
                }
                else
                {
                    score += TwoBallsInFrame();
                    _CurrentBall = _CurrentBall + 2;
                }
            }

            return score;
        }

        private bool Spare()
        {
            return _Throws[_CurrentBall] + _Throws[_CurrentBall + 1] == 10;
        }

        private bool Strike()
        {
            return _Throws[_CurrentBall] == 10;
        }

        private int NextTwoBallsforStrikeScore()
        {
            return _Throws[_CurrentBall + 1] + _Throws[_CurrentBall + 2];
        }

        private int NextBallforSpareScore()
        {
            return _Throws[_CurrentBall + 2];
        }

        private int TwoBallsInFrame()
        {
            return _Throws[_CurrentBall] + _Throws[_CurrentBall + 1];
        }

    }
}
