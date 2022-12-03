using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
   public  class Point
    {
        private int abscisse;
        private int ordonnée;

        public Point (int x , int y)
        {
            abscisse = x;
            ordonnée = y;
        }
        //accesseurs 
        public int absciss
        {
            set { abscisse = value; }
            get { return abscisse; }
        }
        public int ordonn
        {
            set { ordonnée = value; }
            get { return ordonnée; }
        }
        
        public void translit(int dx ,int dy)
        {
            abscisse += dx;
            ordonnée += dy;

        }
        public double distanceorg()
        {
            return Math.Sqrt(abscisse * abscisse + ordonnée * ordonnée);
        }
        public double disTtanceautrepoint(Point B)
        {
            return Math.Sqrt((abscisse - B.abscisse) * (abscisse - B.abscisse) + (ordonnée - B.ordonnée) * (ordonnée - B.ordonnée));

        }


    }
}
