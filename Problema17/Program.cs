// ### Problema 17. Control de un reproductor
// Un reproductor de música recibe comandos de texto: “play”, “pause”, “stop”, “next”.
// Cada comando imprime un mensaje distinto (`Reproduciendo...`, `En pausa`, `Detenido`, `Siguiente canción`).
// Un comando desconocido imprime `Comando no reconocido`.

string comando = "play";

switch (comando)
{
    case "play":
        Console.WriteLine("Reproduciendo...");
        break;
    case "pause":
        Console.WriteLine("En pausa");
        break;
    case "stop":
        Console.WriteLine("Detenido");
        break;
    case "next":
        Console.WriteLine("Siguiente canción");
        break;
    default:
        Console.WriteLine("Comando no reconocido");
        break;
}
