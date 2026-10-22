// ### Problema 26. Peaje
// Un peaje identifica el vehículo con una letra y asigna la tarifa a cobrar:
// - ‘M’ moto: $0 (exenta)
// - ‘A’ automóvil: $12.000
// - ‘B’ bus: $25.000
// - ‘C’ camión: $38.000
// - Otra letra: se lanza una excepción con el mensaje `Categoría desconocida`
// Imprime `Categoría X - Tarifa: $Y`.

char categoria = 'A';
int tarifa = 0;

switch (categoria)
{
    case 'M':
        tarifa = 0;
        break;
    case 'A':
        tarifa = 12000;
        break;
    case 'B':
        tarifa = 25000;
        break;
    case 'C':
        tarifa = 38000;
        break;
    default:
        throw new Exception("Categoría desconocida");
}

Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifa:N0}");
