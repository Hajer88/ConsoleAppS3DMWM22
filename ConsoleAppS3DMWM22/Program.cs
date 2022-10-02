// See https://aka.ms/new-console-template for more information


using ConsoleAppS3DMWM22;

Console.WriteLine("Hello, World!");
// exercice 4 atelier 2 Compte en banque
CompteBanque compte = new CompteBanque();
CompteBanque compte1 = new CompteBanque();
compte.deposerArgent(100);
compte.retirerArgent(50);
var a = new CompteBanque();
Console.WriteLine(compte.LireSolde());



//exercice 8 atelier 2
ListProduits listp = new ListProduits
{
    produits = new List<Produit>{

        new Produit{ Id=1, Name="aa", Price=10},
        new Produit{ Id=2, Name="bb", Price=10}, }

};


decimal total = listp.TotalPrix();
Console.WriteLine(total);
Console.ReadKey();
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
object o;
// anonymous types
var person = new { Name = "aa", Age = 22 };

//Test ? nullable type
DateTime? date = DateTime.Now;




//Test struct
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
