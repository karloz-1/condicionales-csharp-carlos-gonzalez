// ### Problema 24. ¿Día hábil?
// Dado el número de un día de la semana (1 = lunes … 7 = domingo), guarda en una variable
// si es `Día hábil` (lunes a viernes) o `Fin de semana` (sábado y domingo).
// Cualquier otro número es `Día inválido`.

int dia = 3;
string resultado;

switch (dia)
{
    case 1: case 2: case 3: case 4: case 5:
        resultado = "Día hábil";
        break;
    case 6: case 7:
        resultado = "Fin de semana";
        break;
    default:
        resultado = "Día inválido";
        break;
}

Console.WriteLine(resultado);
