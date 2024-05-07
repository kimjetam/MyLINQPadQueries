<Query Kind="Statements" />

var point = new Point(1, 2);

var p2 = point;
p2.X = 10;

point.Print();
p2.Print();

struct Point {
	public int X {get;set;}
	public int Y {get;set;}
	
	public Point(int x, int y) {
		X = x;
		Y = y;
	}
	
	public void Print() {
		Console.WriteLine($"{X},{Y}");
	}
}
