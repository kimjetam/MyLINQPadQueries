<Query Kind="Program">
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>

public static class C {
	public static string Gimme(this string @this, Func<bool> pred, string val) => pred() ? @this + val : @this;
	public static string Gimme2(this string @this, bool cond, string val) => cond ? @this + val : @this;
}
class Program
{
	public delegate string StringDel(string s);
    public static string ReverseString(string s)
    {
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
    
    public static string ReverseStringDirect(string s)
    {
        char[] array = new char[s.Length];
        int forward = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            array[forward++] = s[i];
        }
        return new string(array);
    }
	
	public static void Test(StringDel sd){
		int sum = 0;
        const int _max = 10000000;
		
		var s1 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            sum += sd("programmingisfun").Length;
        }
        s1.Stop();
		Console.WriteLine();
		Console.WriteLine($"Test1: {sd.Method.Name} lasted {s1.Elapsed.TotalMilliseconds} ms");
	}
	
	public static void Test2(Func<string, string> del){
		int sum = 0;
        const int _max = 10000000;
		
		var s1 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            sum += del("programmingisfun").Length;
        }
        s1.Stop();
		Console.WriteLine();
		Console.WriteLine($"Test2: {del.Method.Name} lasted {s1.Elapsed.TotalMilliseconds} ms");
	}

    
    static void Main()
    {
        
        Test(ReverseString);
        Test(ReverseStringDirect);
		Test2(ReverseString);
        Test2(ReverseStringDirect);
		var s = "vreck".Gimme(() => true, "ovka").Dump();
		var s2 = "vreck".Gimme2(true, "ovka").Dump();
    }
}