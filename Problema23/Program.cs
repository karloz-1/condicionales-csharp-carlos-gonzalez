// ### Problema 23. Inicio de sesión
// Un sistema valida el acceso en dos pasos. Primero verifica que el usuario exista
// (el único usuario registrado es “aprendiz”). Si no existe, muestra `Usuario no encontrado`.
// Si existe, verifica la contraseña (“Sena2026”): si es correcta muestra `Bienvenido`;
// si no, muestra `Contraseña incorrecta`. Cada error debe tener su propio mensaje.

string usuarioIngresado = "aprendiz";
string contrasenaIngresada = "Sena2026";

if (usuarioIngresado != "aprendiz")
{
    Console.WriteLine("Usuario no encontrado");
}
else if (contrasenaIngresada != "Sena2026")
{
    Console.WriteLine("Contraseña incorrecta");
}
else
{
    Console.WriteLine("Bienvenido");
}
