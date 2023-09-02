// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


Console.WriteLine("Start main");
var stopWatch = new Stopwatch();

var names = new List<string>() { "Ali", "Reza", "Mohammad" };

stopWatch.Start();

foreach (var name in names)
{
	await myClass.Method1(name);
	await myClass.Method2(name);
	await myClass.Method3(name);
}

stopWatch.Stop();

Console.WriteLine(stopWatch.Elapsed.Seconds);

stopWatch.Restart();
var validations = names.Select(name => Do(name));
await Task.WhenAll(validations);
Console.WriteLine(stopWatch.Elapsed.Seconds);

async static Task Do(string name)
{
	await myClass.Method1(name);
	await myClass.Method2(name);
	await myClass.Method3(name);
}

class myClass
{
	public async static Task Method1(string name)
	{
		await Task.Delay(1000);
		Console.WriteLine("Method1 " + name);
	}
	public async static Task Method2(string name)
	{
		await Task.Delay(1000);
		Console.WriteLine("Method2 " + name);
	}
	public async static Task Method3(string name)
	{
		await Task.Delay(1000);
		Console.WriteLine("Method3 " + name);
	}
}

// MyClass.Opreation();
//Console.WriteLine("End Main");

//public class MyClass
//{
//	public static void Opreation()
//	{
//		Console.WriteLine("start Operation");
//		//await Task.WhenAll(Delay());
//		Delay();
//		Console.WriteLine("End Operation");
//	}

//	public async static Task Delay()
//	{
//		Console.WriteLine("Start Delay");
//		await Task.Delay(10000);
//		Console.WriteLine("End Delay");

//	}
//}