// ### Problema 14. Estado del aprendiz
// Dada la nota final de un aprendiz (0 a 5), guarda en una variable de texto `Aprobado`
// si la nota es 3,0 o más, o `Reprobado` en caso contrario, con una sola línea de asignación.
// Luego imprime `Nota: X - Estado`.

double nota = 3.5;
string estado = (nota >= 3.0) ? "Aprobado" : "Reprobado";

Console.WriteLine($"Nota: {nota} - {estado}");
