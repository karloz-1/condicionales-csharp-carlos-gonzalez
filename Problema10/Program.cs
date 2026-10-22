// ### Problema 10. Analizador de datos recibidos

// Un sistema recibe datos en una variable de tipo `object` que puede contener un texto, un entero, un decimal (`double`) o un valor booleano.
// El programa debe describir el dato:

// - Texto → `Texto de N caracteres`
// - Entero → `Entero: valor`
// - Decimal → `Decimal: valor`
// - Booleano → `Booleano: valor`
// - Otro → `Tipo no reconocido`

// Ejemplos: "SENA" → `Texto de 4 caracteres` · 42 → `Entero: 42` · true → `Booleano: True`

System.Console.WriteLine("Ingrese el dato a analizar: ");
object dato = Console.ReadLine();

// Usamos patrones is con if-else para determinar el tipo
if (dato is string texto)
{
    System.Console.WriteLine($"Texto de {texto.Length} caracteres");
}
else if (dato is int entero)
{
    System.Console.WriteLine($"Entero: {entero}");
}
else if (dato is double valorDecimal)
{
    System.Console.WriteLine($"Decimal: {valorDecimal}");
}
else if (dato is bool booleano)
{
    System.Console.WriteLine($"Booleano: {booleano}");
}
else
{
    System.Console.WriteLine("Tipo no reconocido");
}
