// ### Problema 22. Calculadora básica
// Recibe dos números enteros y un operador (`+`, `-`, `*`, `/`) y guarda el resultado
// de la operación en una variable. Si se intenta dividir entre cero, el programa debe lanzar
// una excepción con el mensaje `No se puede dividir entre cero`.
// Si el operador no es válido, debe lanzar una excepción con el mensaje `Operador no soportado`.

int num1 = 12;
int num2 = 4;
char operador = '*';
double resultado = 0;

switch (operador)
{
    case '+':
        resultado = num1 + num2;
        break;
    case '-':
        resultado = num1 - num2;
        break;
    case '*':
        resultado = num1 * num2;
        break;
    case '/':
        if (num2 == 0)
        {
            throw new Exception("No se puede dividir entre cero");
        }
        resultado = (double)num1 / num2;
        break;
    default:
        throw new Exception("Operador no soportado");
}

Console.WriteLine($"{num1} {operador} {num2} = {resultado}");
