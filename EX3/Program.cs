
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;

namespace cercle
{
    public class Point
{
    private int X;
    private int Y;
    private int originalX;
    private int originalY;
    public void Reset()
    {
        X = originalX;
        Y = originalY;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
        originalX = X;
        originalY = Y;
    }
    public void MoveX(int cord)
    {
        X = X + cord;
    }
    public void MoveY(int cord)
    {
        Y = Y + cord;
    }
    public string GetLocation()
    {
        return string.Format("location de cette point est {0},{1}", X, Y);
    }
}

    

}
internal class Program
{
    static void Main(string[] args)
    {

    }
}
