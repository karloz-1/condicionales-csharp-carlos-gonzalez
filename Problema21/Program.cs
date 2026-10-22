// ### Problema 21. Carrito de compras
// La tienda virtual muestra cuántos artículos hay en el carrito.
// La palabra debe ir en singular si hay exactamente uno y en plural en cualquier otro caso.
// Construye el mensaje con una sola línea de asignación.

int cantidad = 3;
string mensaje = $"Tienes {cantidad} {(cantidad == 1 ? "artículo" : "artículos")} en el carrito";

Console.WriteLine(mensaje);
