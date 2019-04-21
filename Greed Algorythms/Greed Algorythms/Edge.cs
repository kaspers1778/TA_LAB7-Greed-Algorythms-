using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed_Algorythms
{
    class Edge
    {
        public double start { get; set; }
        public double end { get; set; }
        public int startComp { get; set; }
        public int endComp { get; set; }

        public Edge(double start, double end, int startComp, int endComp)
        {
            this.start = start;
            this.end = end;
            this.startComp = startComp;
            this.endComp = endComp;
        }
        public double getWeight(double percent)
        {
            return Convert.ToDouble((start + end) - ((start + end) * (percent / 100)));
        }
    }
}
