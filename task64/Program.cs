// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1.

int N = InputNumbers("Введите N: ");
int count = 2;
PrintNumbers(N, count);
Console.Write(1);

void PrintNumbers(int N, int count)
{
	if(count > N) return;
	PrintNumbers(N, count + 1);
	Console.Write(count +", ");
}

int InputNumbers(string input)
{
	Console.Write(input);
	int output = Convert.ToInt32(Console.ReadLine());
	return output;
}