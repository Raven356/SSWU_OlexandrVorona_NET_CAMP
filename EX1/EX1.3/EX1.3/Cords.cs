using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1._3
{
    internal class Cords
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public override string? ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}\n";
        }
    }
}
