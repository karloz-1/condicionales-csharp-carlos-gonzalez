// ### Problema 15. Índice de masa corporal
// Calcula el IMC con la fórmula peso / (estatura × estatura), peso en kg y estatura en metros,
// y clasifica el resultado. Se deben mostrar el valor del IMC con un decimal y la categoría:
// - Menos de 18,5: Bajo peso
// - De 18,5 a menos de 25: Peso normal
// - De 25 a menos de 30: Sobrepeso
// - 30 o más: Obesidad

double peso = 70;
double estatura = 1.75;
double imc = peso / (estatura * estatura);
string categoria;

if (imc < 18.5)
{
    categoria = "Bajo peso";
}
else if (imc < 25)
{
    categoria = "Peso normal";
}
else if (imc < 30)
{
    categoria = "Sobrepeso";
}
else
{
    categoria = "Obesidad";
}

Console.WriteLine($"IMC: {imc:F1} - {categoria}");
