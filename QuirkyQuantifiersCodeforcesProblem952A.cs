#Solution to problem https://codeforces.com/problemset/problem/952/A
using System;
	
public class Program
{
	public static void Main()
	{
		var num = int.Parse(Console.ReadLine());
		if(num%2 == 0){
			Console.WriteLine(0);
		}else{
			Console.WriteLine(1);
		}
	}
}
