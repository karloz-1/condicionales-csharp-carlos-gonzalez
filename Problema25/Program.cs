// ### Problema 25. Calidad del aire
// Una estación de monitoreo recibe el índice de calidad del aire (ICA, entero)
// y debe asignar la categoría:
// - 0 a 50: Buena
// - 51 a 100: Moderada
// - 101 a 150: Dañina para grupos sensibles
// - 151 a 200: Dañina
// - Más de 200: Muy dañina
// - Negativo: Valor inválido

int ica = 120;
string categoria;

if (ica < 0)
{
    categoria = "Valor inválido";
}
else if (ica <= 50)
{
    categoria = "Buena";
}
else if (ica <= 100)
{
    categoria = "Moderada";
}
else if (ica <= 150)
{
    categoria = "Dañina para grupos sensibles";
}
else if (ica <= 200)
{
    categoria = "Dañina";
}
else
{
    categoria = "Muy dañina";
}

Console.WriteLine(categoria);
