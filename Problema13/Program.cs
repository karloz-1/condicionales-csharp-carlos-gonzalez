// ### Problema 13. Códigos de país

// Un formulario web recibe un código de país de dos letras y debe guardar en una variable el nombre completo:

// - "CO" → Colombia · "MX" → México · "AR" → Argentina · "PE" → Perú · "CL" → Chile
// - Cualquier otro → `País no registrado`

System.Console.WriteLine("Ingrese el código de país (dos letras): ");
string codigo = Console.ReadLine().ToUpper();

string pais = codigo switch
{
    "CO" => "Colombia",
    "MX" => "México",
    "AR" => "Argentina",
    "PE" => "Perú",
    "CL" => "Chile",
    _ => "País no registrado"
};

System.Console.WriteLine(pais);
