using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertLine
    {
        List<Point> pList;

        public VertLine(int y1, int y2, int x, char sim)
        {
            pList = new List<Point>();
            for (int y = y1; y <= y2; y++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
