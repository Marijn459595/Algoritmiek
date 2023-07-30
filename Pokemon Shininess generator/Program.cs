using Pokemon_Shininess_generator;

Random rng = new Random();

int trainerID = rng.Next(0, 65536);
int secretID = rng.Next(0, 65536);

string bits = "";

while (bits.Length < 32)
{
    bits += rng.Next(0, 2).ToString();
}

uint pokemonID = Converter.ConvertToDecimal(bits);

Console.WriteLine(Converter.ConvertTID(trainerID));
Console.WriteLine(Converter.ConvertTID(secretID));
Console.WriteLine(Converter.ConvertPID(pokemonID)[0]);
Console.WriteLine(Converter.ConvertPID(pokemonID)[1]);

Console.WriteLine();

int shinyValue = FindShinyValue.Find(trainerID, secretID, pokemonID);

Console.WriteLine($"shinyValue = {shinyValue}");

Console.WriteLine();

if (shinyValue < 8)
{
    Console.WriteLine("This Pokémon would be shiny in every game that has shinies");
}
else if (shinyValue < 16)
{
    Console.WriteLine("This Pokémon would be shiny in every game since generation 6");
}

Console.ReadLine();