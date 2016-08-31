using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            List<char> chList = new List<char>();
            chList.Add('*');
            chList.Add('#');
            chList.Add('@');
            chList.Add('%');


            Point p1 = new Point(1, 3, chList[0]);
            Point p2 = new Point(4, 6, chList[1]);
            Point p3 = new Point(8, 10, chList[2]);
            Point p4 = new Point(7, 6, chList[3]);
           

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point i in pList)
            {
                i.Draw();
            }

            Console.ReadLine(); 
        }
    }
}
