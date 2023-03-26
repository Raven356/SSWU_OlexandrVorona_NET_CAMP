using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1._2
{
    internal class Cord
    {
        public int XStart { get; set; }
        public int YStart { get; set; }
        public int XEnd { get; set; }
        public int YEnd { get; set; }
        public int LongestSize { get; set; }

        public override string? ToString()
        {
            return $"Start coords: X: {XStart}, Y: {YStart}, End coords: X: {XEnd}" +
                $", Y: {YEnd}, Size: {LongestSize}";
        }
    }
}
