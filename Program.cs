using DotNetTestApp;
using System;

string[] A = new string[] { "unlock.microvirus.md ", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" };
string[] B = new string[] { "microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us" };

var s = Solution.solution(A, B);

Console.WriteLine(String.Join(" ", s));
