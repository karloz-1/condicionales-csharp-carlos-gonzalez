// ### Problema 30. Boletín de calificaciones (integrador)
// Un instructor registra tres notas de un aprendiz (0 a 100). El programa debe:
// 1. Calcular el promedio.
// 2. Convertir el promedio a letra: 90 o más → A, 80 a 89 → B, 70 a 79 → C, 60 a 69 → D, menos de 60 → F.
// 3. Según la letra, imprimir un mensaje de retroalimentación: A → `Desempeño excelente`;
//    B o C → `Buen desempeño, sigue así`; D → `Aprobado, refuerza los temas`; F → `Debe presentar plan de mejoramiento`.
// 4. Indicar `Aprobado` o `Reprobado` (aprueba con 60 o más).
// 5. Si el promedio es exactamente 100, mostrar adicionalmente `¡Mención de honor!`.

double nota1 = 85, nota2 = 78, nota3 = 92;
double promedio = (nota1 + nota2 + nota3) / 3;
char letra;
string retroalimentacion;

if (promedio >= 90) { letra = 'A'; retroalimentacion = "Desempeño excelente"; }
else if (promedio >= 80) { letra = 'B'; retroalimentacion = "Buen desempeño, sigue así"; }
else if (promedio >= 70) { letra = 'C'; retroalimentacion = "Buen desempeño, sigue así"; }
else if (promedio >= 60) { letra = 'D'; retroalimentacion = "Aprobado, refuerza los temas"; }
else { letra = 'F'; retroalimentacion = "Debe presentar plan de mejoramiento"; }

string estado = (promedio >= 60) ? "Aprobado" : "Reprobado";

Console.Write($"Promedio: {promedio:F1} | Letra: {letra} | {retroalimentacion} | {estado}");
if (promedio == 100) Console.Write(" | ¡Mención de honor!");
Console.WriteLine();
