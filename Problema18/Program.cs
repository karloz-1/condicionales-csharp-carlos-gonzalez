// ### Problema 18. Montaña rusa
// Para subir a la montaña rusa, una persona debe medir al menos 1,40 m y además tener 12 años o más,
// a menos que vaya acompañada por un adulto, en cuyo caso basta con la estatura.
// Determina si puede subir.

double estatura = 1.50;
int edad = 13;
bool conAcompanante = false;

if (estatura >= 1.40 && (edad >= 12 || conAcompanante))
{
    Console.WriteLine("Puede subir");
}
else
{
    Console.WriteLine("No puede subir");
}
