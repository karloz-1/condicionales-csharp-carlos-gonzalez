// ### Problema 3. Menú de cajero automático

// El cajero muestra un menú: 1 = Consultar saldo, 2 = Retirar, 3 = Depositar, 4 = Salir.
// Según la opción digitada, el programa imprime la acción. Cualquier otro número muestra `Opción no válida`.

// - Entrada: 2 → `Ha seleccionado: Retirar`
// - Entrada: 9 → `Opción no válida`

System.Console.WriteLine(@"
----- Menú Cajero -----
1 = Consultar saldo
2 = Retirar
3 = Depositar
4 = Salir
-----------------------
");
System.Console.WriteLine("Ingrese el numero de la opción: ");
int opcion = int.Parse(Console.ReadLine());
string defaultText = "Ha seleccionado:";
switch (opcion)
{
    case 1:
        System.Console.WriteLine($"{defaultText} Consultar saldo");
        break;
    case 2:
        System.Console.WriteLine($"{defaultText} Retirar");
        break;
    case 3:
        System.Console.WriteLine($"{defaultText} Depositar");
        break;
    case 4:
        System.Console.WriteLine($"{defaultText} Salir");
        break;
    default:
        System.Console.WriteLine("Opción no valida");
        break;
}