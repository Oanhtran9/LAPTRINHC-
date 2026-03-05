using System.Drawing;
using System.Security.Cryptography;
namespace BaiTap
{
    enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }
        public Point(int x, int y, PointColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, PointColor.LightBlue);
            Console.WriteLine($"Point({p1.X}, {p1.Y}) - color: {p1.Color}");
            Point p2 = new Point(3, 4, PointColor.BloodRed);
            Console.WriteLine($"Point({p2.X},{p2.Y}) - color: {p2.Color}");
            Point p3 = new Point(5, 6, PointColor.Gold);
            Console.WriteLine($"Point({p3.X},{p3.Y}) - color: {p3.Color}");
        }
    }
}
