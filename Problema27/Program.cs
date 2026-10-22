// ### Problema 27. Taquilla de cine
// El precio de la boleta depende de dos datos a la vez: el día (texto: “lunes” … “domingo”)
// y si la persona es estudiante (sí/no).
// - Los martes la boleta cuesta $7.000 para todos.
// - De lunes a viernes (excepto martes), un estudiante paga $9.000 y un no estudiante $12.000.
// - Sábado y domingo cuesta $15.000 para todos.

string dia = "jueves";
bool esEstudiante = true;
int precio = 0;

if (dia == "martes")
{
    precio = 7000;
}
else if (dia == "sábado" || dia == "domingo")
{
    precio = 15000;
}
else if (dia == "lunes" || dia == "miércoles" || dia == "jueves" || dia == "viernes")
{
    precio = esEstudiante ? 9000 : 12000;
}

Console.WriteLine($"$ {precio:N0}");
