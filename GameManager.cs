using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson01
{
    internal class GameManager
    {
        private Settlement settlement;
        private int gameTime;
        public GameManager(Settlement settlement, int gameTime)
        {
            this.settlement = settlement;
            this.gameTime = gameTime;
        }
        public int GameTime
        {
            get { return gameTime; }
        }
           
        public int SimulateProduction()
        {
            int Sum = 0;
            Sum = settlement.GetTotalProduction();
            Sum *= gameTime;
            return Sum;
        }
    }
}
