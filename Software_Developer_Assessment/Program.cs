
/* class Animals
{
    public virtual string speak(int x)
    {
        return "Silence";
    }

}
class Cat : Animals
{
    public override string speak(int x) 
    {
        return "meow";
    }
}
class Dog : Animals
{
    public override string speak(int x)
    {
        return "woof";
    }

    public string speak (short x)
    {
        return "bow-wow";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animals d = new Dog();
        Console.WriteLine(d.speak(0));

        Dog dog = new Dog();
        Console.WriteLine(dog.speak((short)0));
    }
}*/

class A
{
    public int a { get; set; }
    public int b { get; set; }
}
class B
{
    public readonly A a = new A();
    public B()
    {
        a.a = 10;
        a.b = 20;
    }
       
}
class Program
{
    public static void Main(string[] args)
    {
        B b=new B();
        Console.WriteLine($"{b.a.a}, {b.a.b}");
    }
}
