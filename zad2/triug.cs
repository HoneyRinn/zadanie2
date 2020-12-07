using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Triug
{
    class zad2
    {
        private bool triangle;
        private double square;
        private double perimeter;

        public static List<string> equalTrgs = new List<string>();
        public static List<string> esoscleTrgs = new List<string>();
        public static List<string> rectangleTrgs = new List<string>();
        public static List<string> randomTrgs = new List<string>();
        public static List<string> notTrgs = new List<string>();

        public zad2(int l1, int l2, int l3)
        {
            double perimeter_ = l1 + l2 + l3;
            double halfOfP = perimeter / 2;
            double square_ = Math.Sqrt(halfOfP * (halfOfP - l1) * (halfOfP - l2) * (halfOfP - l3));

            if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))
            {
                triangle = true;
                square = square_;
                perimeter = perimeter_;

                if (l1 == l2 && l1 == l3) 
                {
                    equalTrgs.Add($"Треугольник a = {l1} b = {l2} c = {l3}");
                }
                else if ((l1 == l2 && l1 != l3) || (l2 == l3 && l2 != l1) || (l3 == l1 && l3 != l2)) 
                {
                    esoscleTrgs.Add($"Треугольник a = {l1} b = {l2} c = {l3}");
                }
                else if ((l1 * l1 + l2 * l2 == l3 * l3) || (l1 * l1 + l3 * l3 == l2 * l2) || (l3 * l3 + l2 * l2 == l1 * l1)) 
                {
                    rectangleTrgs.Add($"Треугольник a = {l1} b = {l2} c = {l3}");
                }
                else  
                {
                    randomTrgs.Add($"Треугольник a = {l1} b = {l2} c = {l3}");
                }

            }
            else
            {        
                notTrgs.Add($"Треугольник a = {l1} b = {l2} c = {l3}");
                triangle = false;
            }
        }
    }
}
