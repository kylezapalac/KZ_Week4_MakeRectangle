// Kyle Zapalac, 11-Feb-2022, GAME-1343 (SP 2022)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4_MakeRectangle_KZ
{
    class Program
    {
        // void type function to take 2 'in' parameters (min, max) and 2 'out' parameters (w, h)
        // set random values for w and h, within the max provided, and return width and height
        public static void MakeRectangle(int min, int max, out int w, out int h)
        {
            // create random object
            Random random = new Random();
            
            // use random object to generate random numbers within the min/max 
            w = random.Next(min, max);
            h = random.Next(min, max);
            
        }

        // use main function to choose min/max measurements for length & width (or get from user),
        // then send to MakeRectangle function which sends back a randomized length & width
        // then use those values to create an instance of Rectangle and print length, width, area, & perimeter
        static void Main(string[] args)
        {
            // declare variables
            int width = 0;
            int height = 0;
            int min = 0;
            int max = 0;
            
            // begin input
            Console.WriteLine("===========================================\n");

            // get min and max from user
            Console.Write("Choose a minimum: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Choose a maximum: ");
            max = int.Parse(Console.ReadLine());

            // use return by parameter to get randomized width and height
            MakeRectangle(min, max, out width, out height);

            // create Rectangle object  
            Rectangle R = new Rectangle(width, height);
  
            // end input/begin output
            Console.WriteLine("\n===========================================\n");

            Console.WriteLine("Length: " + R.getWidth());
            Console.WriteLine("Width: " + R.getHeight());
            Console.WriteLine("Area: " + R.getArea());
            Console.WriteLine("Perimeter: " + R.getPerimeter());

            // end output
            Console.WriteLine("\n===========================================\n");
        }
    }

    // include variables for width and weight with appropriate access and a constructor to fill them
    public class Rectangle
    {
        // declare properties
        public int width;
        public int height;
        public int area;
        public int perimeter;

        // default constructor
        public Rectangle()
        {
            width = 0;
            height = 0;
            area = 0;
            perimeter = 0;
        }

        // overloaded constructor
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
            area = Utility.Area(w, h);
            perimeter = Utility.Perimeter(w, h);
        }

        // access methods (getters and setters)
        public void setWidth(int w)
        {
            width = w;
        }

        public int getWidth()
        {
            return width;
        }

        public void setHeight(int h)
        {
            height = h;
        }

        public int getHeight()
        {
            return height;
        }

        public void setArea(int a)
        {
            area = a;
        }

        public int getArea()
        {
            return area;
        }
        
        public void setPerimeter(int p)
        {
            perimeter = p;
        }

        public int getPerimeter()
        {
            return perimeter;
        }
    }

    // utility class containing static functions to get rectangle's area and perimeter
    public static class Utility
    {
        // calculate and return area as an int
        public static int Area(int w, int h)
        {
            return w * h;
        }

        // calculate and return perimeter as an int
        public static int Perimeter(int w, int h)
        {
            return 2 * (w + h);
        }
    }
}
