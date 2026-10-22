// ### Problema 20. Días de cada mes
// Dado el número de un mes (1 a 12) de un año no bisiesto, imprime cuántos días tiene.
// Varios meses comparten la misma cantidad de días.
// Un número fuera de rango imprime `Mes inválido`.

int mes = 4;

switch (mes)
{
    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
        Console.WriteLine("31 días");
        break;
    case 4: case 6: case 9: case 11:
        Console.WriteLine("30 días");
        break;
    case 2:
        Console.WriteLine("28 días");
        break;
    default:
        Console.WriteLine("Mes inválido");
        break;
}
