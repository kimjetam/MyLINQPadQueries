<Query Kind="Program" />

void Main()
{
	string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

	// Determine whether any string in the array is longer than "banana".
	string longestName =
	    fruits.Aggregate("banana",
	                    (longest, next) =>
	                        longest + next ,
	    // Return the final result as an upper case string.
	                    fruit => fruit.ToUpper());
	longestName.Dump();
	
	Enumerable.Range(1,10).Aggregate((a,b) => a + b).Dump();
	Func<StringBuilder, string, StringBuilder> sbFn = (sb, opt) => sb.AppendLine($"item: {opt}");
	
	var sb = new StringBuilder("empty");
	fruits.Aggregate(sb, sbFn).ToString().Dump();
	
	fruits.Tee(Console.WriteLine);
	fruits.Tee(x => Enumerable.ToArray(x)).Tee(x => x[0]="javor").Dump();
	
	string s = null;
	bool.TryParse(s, out var res);
	Console.WriteLine(res);
}

public static class Extensionss {
	public static T Tee<T> (this T @this, Action<T> act){
		act(@this);
		return @this;
	}
}

// You can define other methods, fields, classes and namespaces here