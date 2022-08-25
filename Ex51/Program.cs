Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
    // j, m , k 
    for (int j = 0; j < matrix.GetLength(1); j++) // cтолбцы
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t"); // "\t"
    }
    Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
           if(i == j) sum += matrix[i, j];
        
    }
} 

Console.WriteLine(sum);

