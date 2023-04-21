

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВведите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) {
    Console.WriteLine($"max = {a}");

}
else { 
     Console.WriteLine($"max = {b}");
}