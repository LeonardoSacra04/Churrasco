double adultoSim;
double adultoNao;
double adultoTotal;
double crianca;
double carne;
double acompanhamentos;
double cerveja;
double refri;
double agua;

Console.Clear();

Console.WriteLine("Quantidade de adultos que bebem álcool: ");
adultoSim = Convert.ToDouble(Console.ReadLine()!);
Console.Clear();

Console.WriteLine("Quantidade de adultos que não bebem álcool: ");
adultoNao = Convert.ToDouble(Console.ReadLine()!);
Console.Clear();

Console.WriteLine("Quantidade de crianças: ");
crianca = Convert.ToDouble(Console.ReadLine()!);
Console.Clear();

adultoTotal = adultoNao + adultoSim;

carne = (adultoTotal * 400 + crianca * 200) / 1000;
acompanhamentos = (adultoTotal * 200 + crianca * 200) / 1000;
cerveja = adultoSim * 2;
refri = (adultoNao * 500 + crianca * 500) / 1000;
agua = (adultoTotal * 400 + crianca * 400) / 1000;

Console.WriteLine("               --- Churrasco ---               ");
Console.WriteLine("");
Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultoSim}");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adultoNao}");
Console.WriteLine($"Crianças........................................: {crianca}");
Console.WriteLine("");
Console.WriteLine($"Carne.............: {carne} kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos} kg");
Console.WriteLine($"Cerveja...........: {cerveja} l");
Console.WriteLine($"Refrigerante......: {refri} l");
Console.WriteLine($"Água..............: {agua} l");