public class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void PrintDeatails()
    {
        console.Writeline("Printing details of shape..");
    }

}


public class Square :Shape
{
    public double side{ get; set;}
    public override double GetArea() => Side * Side;
    public override double GetPerimeter() => 4 * Side;
}
public class Rectangle :Shape
{
    public double Length{ get; set;}
    public double Breadth{ get; set;}
    public override double GetArea() => Length * Breadth;
    public override double GetPerimeter() => 2 * (Length + Breadth);
}
public class Circle :Shape
{
    public double Radius{ get; set;}
    public override double GetArea() => 3.14  * Radius * Radius;
    public override double GetPerimeter() => 2 * 3.14 * Radius;

}
//single inheritance
//multilevel inheritance
//multiple inheritance

class A
{

}
class B:A
{

}
class C:B
{

}
class D:A
{

}
interface IA
{

}
interface IX
