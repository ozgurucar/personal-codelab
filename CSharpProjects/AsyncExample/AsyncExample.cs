using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Diagnostics;

bool flag = WriteToFile("test.txt");

Console.WriteLine(flag);

Stopwatch sp = Stopwatch.StartNew();
var task1 = ReadFromFileAsync("test.txt");
sp.Stop();
Console.WriteLine(sp.Elapsed);
var task2 = ReadFromFileAsync("test2.txt");

string text1 = await task1;

string text2 = await task2;

//File.WriteAllText("test2.txt", text);

bool WriteToFile(string path) 

{	
	using (var sw = new StreamWriter(path)) {
		for(int i = 0; i < 1000000; i++) {
			sw.WriteLine("Hello" + (i * 57));
		}
	}
	return true;
}

async Task<string> ReadFromFileAsync(string path) {
	
	Stopwatch stopWatch = new Stopwatch();
	stopWatch.Start();
	Console.WriteLine("Read Operation Started");
	await Task.Delay(4000);
	StringBuilder sb = new StringBuilder();	
	using (var sr  = new StreamReader(path)) {
		
		string? line;		

		while((line = await sr.ReadLineAsync()) != null){
		sb.Append(line);
		}	
	}
	stopWatch.Stop();
	TimeSpan ts  = stopWatch.Elapsed;
	
	string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
	
	Console.WriteLine("Elapsed: " + elapsedTime);
	
	return sb.ToString();
}
