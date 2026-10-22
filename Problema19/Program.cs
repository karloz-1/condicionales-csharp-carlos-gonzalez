// ### Problema 19. Radar de velocidad
// Un radar en una vía urbana con límite de 50 km/h clasifica la velocidad medida
// y guarda la sanción en una variable:
// - Menos de 0: `Lectura inválida`
// - De 0 a 50: `Sin infracción`
// - Más de 50 hasta 70: `Multa leve`
// - Más de 70 hasta 90: `Multa grave`
// - Más de 90: `Multa gravísima e inmovilización`

double velocidad = 68;
string sancion;

if (velocidad < 0)
{
    sancion = "Lectura inválida";
}
else if (velocidad <= 50)
{
    sancion = "Sin infracción";
}
else if (velocidad <= 70)
{
    sancion = "Multa leve";
}
else if (velocidad <= 90)
{
    sancion = "Multa grave";
}
else
{
    sancion = "Multa gravísima e inmovilización";
}

Console.WriteLine(sancion);
