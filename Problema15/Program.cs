// ### Problema 15. Índice de masa corporal

// Calcula el IMC con la fórmula peso / (estatura × estatura), peso en kg y estatura en metros,
// y clasifica el resultado. Se deben mostrar el valor del IMC con un decimal y la categoría:

// - Menos de 18,5: Bajo peso
// - De 18,5 a menos de 25: Peso normal
// - De 25 a menos de 30: Sobrepeso
// - 30 o más: Obesidad

// Example: peso 70, estatura 1,75 → `IMC: 22,9 - Peso normal`

System.Console.WriteLine("Ingrese el peso en kg: ");
double peso = double.Parse(Console.ReadLine());

System.Console.WriteLine("Ingrese la estatura en metros: ");
double estatura = double.Parse(Console.ReadLine());

double imc = peso / (estatura * estatura);

string categoria = imc switch
{
    < 18.5 => "Bajo peso",
    < 25 => "Peso normal",
    < 30 => "Sobrepeso",
    _ => "Obesidad"
};

System.Console.WriteLine($"IMC: {imc:F1} - {categoria}");
