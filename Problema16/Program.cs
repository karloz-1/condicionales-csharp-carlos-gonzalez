// ### Problema 16. Ubicación de un dron
// El centro de control recibe la posición de un dron como un par de coordenadas con nombre (X, Y).
// Debe informar en qué cuadrante del plano cartesiano se encuentra, si está en el origen
// o si está sobre uno de los ejes.

int x = 3;
int y = 4;

if (x == 0 && y == 0)
{
    Console.WriteLine("Origen");
}
else if (x == 0 || y == 0)
{
    Console.WriteLine("Sobre un eje");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Primer cuadrante");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Segundo cuadrante");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Tercer cuadrante");
}
else
{
    Console.WriteLine("Cuarto cuadrante");
}
