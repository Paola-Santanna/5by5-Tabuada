//2.Faça um programa que leia um número inteiro positivo e imprima a sua tabuada;

int num_usuario, num, contador = 0, multiplicador_2 = 0;

Console.WriteLine("Digite um número: ");
num_usuario = int.Parse(Console.ReadLine());

num = num_usuario;

if (num_usuario < 0)
{
    Console.WriteLine("\nSomente é válido número inteiro postivo");
}
else
{
    while (contador <= 10)
    {
        int resultado = num * multiplicador_2;
        Console.WriteLine($"{num} * {multiplicador_2} = {resultado}");
        contador++;
        multiplicador_2++;
    }
}
Console.ReadKey();