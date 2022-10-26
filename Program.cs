string[] input = new string[10];
for (int i = 0; i < 10; i++)
{
    input[i] = Console.ReadLine();
}

System.Console.Write("[");
for (int i = 0; i < input.Length; i++)
{
    if(input[i].Length < 4) 
        Console.Write($"{input[i]} ");
}
System.Console.Write("]");