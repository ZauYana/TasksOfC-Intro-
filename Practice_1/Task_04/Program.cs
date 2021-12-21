//4. Найти максимальное из трех чисел

int number1 = 3;
int number2 = 4;
int number3 = 7;

int max = number1;

if (number2>max) max = number2;
if (number3>max) max = number3;

Console.WriteLine(max);