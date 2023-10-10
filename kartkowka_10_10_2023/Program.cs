Console.WriteLine("Grupa 2");
Console.Write("\n");
// ♥ ☺
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("\x2665 " + "\x263a");

// byte (1 bajt): 0 - 255
// sbyte (1 bajt): -128 - 127

// short (2 bajty): -32 768 - 32 767
// ushort (2 bajty): 0 - 65 536

// int (4 bajty = 32 bity): -2 147 483 648 - 2 147 483 647
// uint (4 bajty): 0 - 4 294 967 296

// long (8 bajtow): -9 223 372 036 854 755 808 - 9 223 372 036 854 755 807 sufix L
// ulong (8 bajtow): 0 - 18 446 744 073 709 511 615 sufix UL

Console.WriteLine("Pole kwadratu = a\x00b2");
Console.Write("Podaj długość boku kwadratu: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Pole kwadratu o boku {a}cm: " + Math.Pow(a, 2) + "cm\x00b2");