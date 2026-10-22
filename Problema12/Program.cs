// ### Problema 12. Aprobación de crédito

// Un banco estudia solicitudes de crédito. Primero verifica si el solicitante tiene empleo.
// Si no tiene, el crédito se rechaza. Si tiene empleo, revisa su ingreso mensual:
// si gana $2.500.000 o más se aprueba un crédito alto;
// si gana menos, se aprueba un crédito básico.

// - Sin empleo → `Crédito rechazado`
// - Con empleo, ingreso $3.000.000 → `Crédito alto aprobado`
// - Con empleo, ingreso $1.800.000 → `Crédito básico aprobado`

System.Console.WriteLine("¿El solicitante tiene empleo? (s/n): ");
char tieneEmpleo = char.Parse(Console.ReadLine());

string resultado;

if (tieneEmpleo == 'n' || tieneEmpleo == 'N')
{
    resultado = "Crédito rechazado";
}
else
{
    System.Console.WriteLine("Ingrese el ingreso mensual: ");
    double ingreso = double.Parse(Console.ReadLine());

    if (ingreso >= 2500000)
    {
        resultado = "Crédito alto aprobado";
    }
    else
    {
        resultado = "Crédito básico aprobado";
    }
}

System.Console.WriteLine(resultado);
