// ### Problema 5. El mayor de dos números

// Dados dos números enteros, guarda en una variable `mayor` el más grande de los dos usando una sola
// línea de asignación, y luego imprímelo.

// - Entrada: 14 y 9 → `El mayor es 14`
// - Entrada: -2 y 3 → `El mayor es 3`

System.Console.WriteLine("Ingresa el primer número entero: ");
int num1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Ingresa el segundo número entero: ");
int num2 = int.Parse(Console.ReadLine());

int mayor;
if (num1 > num2)
{
    mayor = num1;
} 
else
{
    mayor = num2;
}

System.Console.WriteLine($"Entrada: {num1} y {num2} → El mayor es {mayor}");