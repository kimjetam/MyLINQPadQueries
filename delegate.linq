<Query Kind="Program" />

public delegate void MyDelegate(string msg); //declaring a delegate
public delegate string StringDel(string s1, string s2);

public static string Concat (string s1, string s2) => s1+s2;

public static string ConcatReversed(string s1, string s2){
	var s = Concat(s1,s2);
	char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
}

public static int AddDecimals(int a, int b) => a + b;

public static void ExecuteDel(StringDel del){del("janko", "antalko").Dump();}

class Program
{
    static void Main(string[] args)
    {
        MyDelegate del = ClassA.MethodA;
        del("Hello World");

        del = ClassB.MethodB;
        del("Hello World");

        del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del("Hello World");
		
		StringDel ss = Concat;
		ss("ahoj","kikus").Dump();
		
		ExecuteDel(Concat);
		ExecuteDel(ConcatReversed);

		
		Func<string, string> myFunc = (s) => $"The {s} is outputed from this function";
		myFunc("pohar").Dump();
    }
}

class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}

class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}