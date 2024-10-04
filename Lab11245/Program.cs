try
{
    Console.Write("Введите целое число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    bool conditionA = (N % 4 == 0) || (N % 7 == 0);
    bool conditionB = (N % 5 == 0) && (N % 10 != 0);

    Console.WriteLine($"Условие (а): {conditionA}");
    Console.WriteLine($"Условие (б): {conditionB}");
}
catch
{
    Console.WriteLine("Введите корректные данные");
}