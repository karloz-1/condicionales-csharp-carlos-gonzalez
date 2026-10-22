// ### Problema 7. Signo de un número

// Lee un número entero e indica si es positivo, negativo o cero.

// - 8 → `Positivo` · -5 → `Negativo` · 0 → `Cero`

System.Console.WriteLine("Ingresa un número entero: ");
int numero = int.Parse(Console.ReadLine());

if (numero >= 1)
{
    System.Console.WriteLine("Positivo");
}
else if (numero <= -1)
{
    System.Console.WriteLine("Negativo");
}
else
{
    System.Console.WriteLine("Cero");
}