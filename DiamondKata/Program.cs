using DiamondKata;

Console.Write("Input target letter: ");
var input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Error: empty input.");
    return;
}

if (input.Length > 1)
{
    Console.WriteLine("Error: input too long.");
    return;
}

var output = Diamond.Generate(input[0]);
Console.WriteLine(output);