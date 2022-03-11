using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingSimulatorProblem
{
    public class Gambler
    {
        public void Play()
        {
            const int STAKE_OF_EVERYDAY = 100;
            const int BET_FOR_EVERY_GAME = 1;
            const int LOSE = 0;
            const int WIN = 1;
            int leftAmount = 100;
            Random random = new Random();
            int option = random.Next(0, 2);
            switch (option)
            {
                case LOSE:
                    leftAmount = leftAmount - BET_FOR_EVERY_GAME;
                    break;
                case WIN:
                    leftAmount = leftAmount + BET_FOR_EVERY_GAME;
                    break;
            }
            Console.WriteLine("LeftAmount is " + leftAmount);
        }
    }
}
