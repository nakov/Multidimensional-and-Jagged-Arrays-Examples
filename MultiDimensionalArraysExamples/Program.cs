// Read a jagged array
int rowsCount = int.Parse(Console.ReadLine());
int[][] jagged = new int[rowsCount][];
for (int row = 0; row < rowsCount; row++)
    jagged[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


Console.WriteLine();
Console.WriteLine("The array is:");
for (int row = 0; row < jagged.Length; row++)
    Console.WriteLine(String.Join(", ", jagged[row]));
