// Gedrag van "Value Type" variabele

using TypesInCS;

int a = 15;
int b = a;
a = 30;

Console.WriteLine("a = " + a + "    b = " + b);

// Gedrag van "Reference Type" variabele

TestClass tcA = new TestClass(15, "Eerste Object");
TestClass tcB = new TestClass(45, "Derde Object");
tcB = tcA;
tcA.Id = 30;
tcA.Name = "Tweede Object";

Console.WriteLine("tcA= " + tcA + "    tcB= " + tcB);
// Zowel tcA als tcB zijn gewijzigd.
