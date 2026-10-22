// ### Problema 11. Semáforo inteligente
// Define un tipo con los estados posibles de un semáforo: Rojo, Amarillo y Verde.
// Según el estado actual, el programa imprime la instrucción para el conductor:
// - Rojo → `Deténgase`
// - Amarillo → `Precaución, prepárese para detenerse`
// - Verde → `Avance`

string estado = "Rojo";

switch (estado)
{
    case "Rojo":
        Console.WriteLine("Deténgase");
        break;
    case "Amarillo":
        Console.WriteLine("Precaución, prepárese para detenerse");
        break;
    case "Verde":
        Console.WriteLine("Avance");
        break;
    default:
        Console.WriteLine("Estado no reconocido");
        break;
}
