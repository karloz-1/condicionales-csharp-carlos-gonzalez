// ### Problema 12. Aprobación de crédito
// Un banco estudia solicitudes de crédito. Primero verifica si el solicitante tiene empleo.
// Si no tiene, el crédito se rechaza. Si tiene empleo, revisa su ingreso mensual:
// si gana $2.500.000 o más se aprueba un crédito alto; si gana menos, se aprueba un crédito básico.

bool tieneEmpleo = true;
double ingresoMensual = 3000000;

if (!tieneEmpleo)
{
    Console.WriteLine("Crédito rechazado");
}
else
{
    if (ingresoMensual >= 2500000)
    {
        Console.WriteLine("Crédito alto aprobado");
    }
    else
    {
        Console.WriteLine("Crédito básico aprobado");
    }
}
