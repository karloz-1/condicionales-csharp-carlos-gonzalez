// ### Problema 8. Vocal o consonante

// Lee una letra minúscula e indica si es vocal (a, e, i, o, u) o consonante. Si el carácter no es una letra
// del alfabeto, debe mostrar `No es una letra`.

// - ‘e’ → `Es vocal` · ‘m’ → `Es consonante` · ‘7’ → `No es una letra`

System.Console.WriteLine("Ingrese una letra minúscula: ");
char letra = char.Parse(Console.ReadLine());

string mensaje = letra switch
{
    'a' or 'e' or 'i' or 'o' or 'u' => "Es vocal",
    (>= 'a' and <= 'z') or 'ñ' => "Es consonante",
    _=> "No es letra."
};

System.Console.WriteLine(mensaje);