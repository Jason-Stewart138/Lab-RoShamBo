using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_RoShamBo
{
    public class RandomPlayer : Player
    {
        public override string GenerateRoshambo()
        {
            Random random = new Random();
            int result = random.Next(1, 4);

            Roshambo randomPlayerThrow = (Roshambo)result;

            return randomPlayerThrow.ToString();
        }
    }
}
