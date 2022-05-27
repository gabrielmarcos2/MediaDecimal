Console.Clear();

Console.Write($"Quantos numeros: ");
int quantosNumeros = Convert.ToInt32(Console.ReadLine()!);
int contador = 1;
while (contador <= quantosNumeros)
{
    Console.WriteLine($"Número #{contador,3:n0}");
    contador++;
}


