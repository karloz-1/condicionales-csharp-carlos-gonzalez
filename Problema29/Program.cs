// ### Problema 29. Control de acceso a la sede
// El torniquete de la sede recibe dos datos: el rol de la persona (“admin”, “instructor”, “aprendiz”)
// y la hora de llegada (0 a 23). Las reglas son:
// - “admin” puede entrar a cualquier hora.
// - “instructor” puede entrar de 6 a 21 horas.
// - “aprendiz” puede entrar de 6 a 18 horas.
// - Cualquier otro caso: acceso denegado.

string rol = "aprendiz";
int hora = 19;
bool accesoPermitido = false;

switch (rol)
{
    case "admin":
        accesoPermitido = true;
        break;
    case "instructor":
        accesoPermitido = (hora >= 6 && hora <= 21);
        break;
    case "aprendiz":
        accesoPermitido = (hora >= 6 && hora <= 18);
        break;
}

if (accesoPermitido)
{
    Console.WriteLine("Acceso permitido");
}
else
{
    Console.WriteLine("Acceso denegado");
}
