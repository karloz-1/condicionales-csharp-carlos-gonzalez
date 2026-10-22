// ### Problema 28. Descuento por compra
// Un almacén aplica descuentos según el valor de la compra:
// - $500.000 o más: 15 %
// - $200.000 a menos de $500.000: 10 %
// - $100.000 a menos de $200.000: 5 %
// - Menos de $100.000: sin descuento
// Además, si el cliente está inscrito en el programa de cliente frecuente y la compra es de $100.000 o más, recibe un 5 % adicional.
// El programa muestra el valor de la compra, el porcentaje total de descuento y el total a pagar.

double compra = 250000;
bool esFrecuente = true;
double descuentoPorValor = 0;

if (compra >= 500000)
{
    descuentoPorValor = 0.15;
}
else if (compra >= 200000)
{
    descuentoPorValor = 0.10;
}
else if (compra >= 100000)
{
    descuentoPorValor = 0.05;
}

double descuentoAdicional = (esFrecuente && compra >= 100000) ? 0.05 : 0;
double porcentajeTotalDescuento = descuentoPorValor + descuentoAdicional;
double totalAPagar = compra * (1 - porcentajeTotalDescuento);

Console.WriteLine($"Compra: ${compra:N0} | Descuento: {porcentajeTotalDescuento * 100}% | Total: ${totalAPagar:N0}");
