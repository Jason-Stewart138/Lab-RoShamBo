using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_RoShamBo
{
    public abstract class Player
    {
        public string? Name { get; set; }
        public string? RoshamboValue { get; set; }

        public abstract string GenerateRoshambo();
    
    
    
    }
}
