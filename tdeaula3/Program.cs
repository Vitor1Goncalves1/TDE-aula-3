Console.WriteLine("Informe o primeiro numero: ");

double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o segundo numero: ");

double num2 = Convert.ToDouble(Console.ReadLine());

double adicao = num1 + num2;
double subtracao = num1 - num2;
double multiplicacao = num1 * num2; 
double divisao = num1 / num2;

Console.WriteLine($"A adicao do {num1} + {num2} é = {adicao}");

Console.WriteLine("A subtração de {0} - {1} = {2}", num1, num2, subtracao);

Console.WriteLine($"A divisão de {num1} / {num2} é = {divisao}");

Console.WriteLine($"A multiplicação de "+ num1 + " * " + num2 + " = " + multiplicacao);
