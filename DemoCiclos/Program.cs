Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Yellow;  
Console.Clear();    
Console.WriteLine("Numbers");
int i  = 0;
Console.Write("n? ");
int n = (int)Convert.ToInt32(Console.ReadLine());
long sum = 0;
while (i < n)
{
    i++;
    sum += i;
    Console.Write($"{i}\t");
}
Console.WriteLine($"\nThe sum is....: {sum:N0}");
double average = (double)sum / (double)n;
Console.WriteLine($"The average is: {average:N2}");
