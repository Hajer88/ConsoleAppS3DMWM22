// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Test t = new Test();
t.x = 10;
t.y = 20;
t.FaireAddition();
Point p = new Point();
p.a = 12;
p.b= 13;

Point p2 = new Point(12,15);
//Init syntax
Point p3 = new Point
{
    a = 12,
    b = 13,
};
Point p4 = new Point(10,20,PointColor.Gold);





public struct Test
{
    public int x;
    public int y;
    //public int z { get; set; }
    private int z;
    public int Z { get { return z; }
        set { z = value; } }
    

    public void FaireAddition()
    {
        Console.WriteLine(x + y);
    }
}

//Exercice Point
public enum PointColor
{
    Red,
    Green,
    Gold,
};
public class Point
{
    public int a;
    public int b;
    public PointColor color;
    //Default constructor
    public Point()
    {

    }
    //Full Argument Constructor
    public Point(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public Point(int a, int b, PointColor color)
    {
        this.a = a;
        this.b = b;
        this.color = color;
    }
}
