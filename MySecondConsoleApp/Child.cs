using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondConsoleApp
{
    class Child
    {
        public string Name { get; set; }
        public bool Sick { get; set; }

        public string ForgeASickNote()
        {
            if (Sick)
            {
                return $"Please exuse {Name} from class today because they are very sick.";
            }
            else
            {
                return $"{Name} you still have to go to school, quit faking. Love Mom.";
            }
            
        }
    }
}
