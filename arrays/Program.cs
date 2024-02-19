/*string[] days = { "Monday", "Tuesday", "Wednesday" };
Console.WriteLine("enter day:");
int day = int.Parse(Console.ReadLine());
if (day >= 1 && day <= 3)
{
    Console.WriteLine(days[day - 1]);
}
else Console.WriteLine("invalid");

var n = int.Parse(Console.ReadLine());
var arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
for (int j = arr.Length - 1; j >= 0; j--)
{
    Console.Write(arr[j] + " ");
}

double[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToArray();
int[] rounded = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    rounded[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
    Console.WriteLine($"{Convert.ToDecimal(numbers[i])} to {Convert.ToDecimal(rounded[i])}");
}

int n = int.Parse(Console.ReadLine());
int sum = 0;
var arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
    sum = sum + arr[i];
}
Console.WriteLine($"\n{sum}");

int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstElement = arr[0];
    for (int j = 0; j < arr.Length - 1; j++)
    {
        arr[j] = arr[j + 1];
    }
    arr[arr.Length - 1] = firstElement;
}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}*/

