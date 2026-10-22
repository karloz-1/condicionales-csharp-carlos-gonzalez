// ### Problema 11. Semáforo inteligente

// Define un tipo con los estados posibles de un semáforo: Rojo, Amarillo y Verde.
// Según el estado actual, el programa imprime la instrucción para el conductor:

// - Rojo → `Deténgase`
// - Amarillo → `Precaución, prepárese para detenerse`
// - Verde → `Avance`

System.Console.WriteLine("Ingrese el estado del semáforo (Rojo, Amarillo, Verde): ");
string estado = Console.ReadLine().ToLower();

string mensaje = estado switch
{
    "rojo" => "Deténgase",
    "amarillo" => "Precaución, prepárese para detenerse",
    "verde" => "Avance",
    _ => "Estado no reconocido"
};

System.Console.WriteLine(mensaje);
