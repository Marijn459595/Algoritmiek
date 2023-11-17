float total = (2 * 3);
total = MathF.Floor(total / 5);
//total /= 5;
total += 2;
total *= 40;

Console.WriteLine("Attack drops: ");
float stat = Console.Read() - 48;

stat += 2;
//stat = MathF.Floor(2 / stat);
stat = 2 / stat;
//stat = MathF.Floor(7 * stat);
stat *= 7;
//stat = MathF.Floor(stat / 9);
stat = stat / 9;


total = MathF.Floor(total * stat);
total = MathF.Floor(total / 50);
total += 2;

Console.WriteLine();
Console.WriteLine(MathF.Floor(total * 0.85f));
Console.WriteLine(MathF.Floor(total * 0.86f));
Console.WriteLine(MathF.Floor(total * 0.87f));
Console.WriteLine(MathF.Floor(total * 0.88f));
Console.WriteLine(MathF.Floor(total * 0.89f));
Console.WriteLine(MathF.Floor(total * 0.90f));
Console.WriteLine(MathF.Floor(total * 0.91f));
Console.WriteLine(MathF.Floor(total * 0.92f));
Console.WriteLine(MathF.Floor(total * 0.93f));
Console.WriteLine(MathF.Floor(total * 0.94f));
Console.WriteLine(MathF.Floor(total * 0.95f));
Console.WriteLine(MathF.Floor(total * 0.96f));
Console.WriteLine(MathF.Floor(total * 0.97f));
Console.WriteLine(MathF.Floor(total * 0.98f));
Console.WriteLine(MathF.Floor(total * 0.99f));
Console.WriteLine(MathF.Floor(total * 1f));