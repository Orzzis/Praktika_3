Console.WriteLine("Введите количество целых положительных числе:");
int count = int.Parse(Console.ReadLine());
int i = 1;
int sum = 0;
while(count >= i)
{
    sum += i;
    i++;
}
Console.WriteLine($"Сумма первых {count} целых положительных чисел равна {sum}");