// ### Problema 13. Códigos de país
// Un formulario web recibe un código de país de dos letras y debe guardar en una variable el nombre completo:
// - “CO” → Colombia · “MX” → México · “AR” → Argentina · “PE” → Perú · “CL” → Chile
// - Cualquier otro → `País no registrado`

string codigo = "CO";
string pais;

switch (codigo)
{
    case "CO":
        pais = "Colombia";
        break;
    case "MX":
        pais = "México";
        break;
    case "AR":
        pais = "Argentina";
        break;
    case "PE":
        pais = "Perú";
        break;
    case "CL":
        pais = "Chile";
        break;
    default:
        pais = "País no registrado";
        break;
}
Console.WriteLine(pais);
