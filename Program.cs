using DotNetTestApp;
using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;


//example:
string[] A = new string[] { "unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" };
string[] B = new string[] { "microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us" };

//var solution = Solution.solution(A, B);

//Console.WriteLine(String.Join(" ", solution));

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
var A2 = Generator.GenereateA(A, B, 100000);
stopwatch.Stop();

var solution = Solution.solution(A2, B);
Console.WriteLine(String.Join(" ", solution));

Console.WriteLine(stopwatch.ElapsedMilliseconds);
