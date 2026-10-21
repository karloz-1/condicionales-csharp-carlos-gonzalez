// La Registraduría necesita un programa que reciba la edad de una persona e informe si puede votar
// (16 años o más en este ejercicio) o si todavía no puede hacerlo.

// - Entrada: 17 → Salida: `Puede votar`
// - Entrada: 15 → Salida: `Aún no puede votar`

System.Console.WriteLine("Ingrese la edad la persona: ");
int edadUsuario = int.Parse(Console.ReadLine());

if (edadUsuario < 16)
{
    System.Console.WriteLine("Aún no puede votar");
}
else
{
    System.Console.WriteLine("Puede votar");
}