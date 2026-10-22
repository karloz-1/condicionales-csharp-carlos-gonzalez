### Problema 1. Registro electoral

La Registraduría necesita un programa que reciba la edad de una persona e informe si puede votar (16 años o más en este ejercicio) o si todavía no puede hacerlo.

- Entrada: 17 → Salida: `Puede votar`
- Entrada: 15 → Salida: `Aún no puede votar`

### Problema 2. Tarifa de envío por peso

Una transportadora cobra según el peso del paquete en kilogramos y necesita guardar la tarifa en una variable para usarla después:

- Menos de 1 kg: $8.000
- De 1 kg a menos de 5 kg: $15.000
- De 5 kg a menos de 20 kg: $32.000
- 20 kg o más: $60.000
- Peso 0 o negativo: tarifa 0 y mensaje de peso inválido

Ejemplos: 0,5 → `$8.000` · 7 → `$32.000` · 25 → `$60.000` · -3 → `Peso inválido`

### Problema 3. Menú de cajero automático

El cajero muestra un menú: 1 = Consultar saldo, 2 = Retirar, 3 = Depositar, 4 = Salir. Según la opción digitada, el programa imprime la acción. Cualquier otro número muestra `Opción no válida`.

- Entrada: 2 → `Ha seleccionado: Retirar`
- Entrada: 9 → `Opción no válida`

### Problema 4. Alerta de batería

Una app de celular revisa el nivel de batería. Si está por debajo del 15 %, muestra `Batería baja: conecte el cargador`. En cualquier caso, al final siempre muestra `Nivel actual: X %`.

- Entrada: 10 → dos líneas: la alerta y `Nivel actual: 10 %`
- Entrada: 80 → una línea: `Nivel actual: 80 %`

### Problema 5. El mayor de dos números

Dados dos números enteros, guarda en una variable `mayor` el más grande de los dos usando una sola línea de asignación, y luego imprímelo.

- Entrada: 14 y 9 → `El mayor es 14`
- Entrada: -2 y 3 → `El mayor es 3`

### Problema 6. Piedra, papel o tijera

Dos jugadores eligen “piedra”, “papel” o “tijera”. El programa recibe ambas jugadas y determina el resultado: piedra vence a tijera, tijera vence a papel, papel vence a piedra; si son iguales es empate.

- (“piedra”, “tijera”) → `Gana el jugador 1`
- (“piedra”, “papel”) → `Gana el jugador 2`
- (“papel”, “papel”) → `Empate`

### Problema 7. Signo de un número

Lee un número entero e indica si es positivo, negativo o cero.

- 8 → `Positivo` · -5 → `Negativo` · 0 → `Cero`

### Problema 8. Vocal o consonante

Lee una letra minúscula e indica si es vocal (a, e, i, o, u) o consonante. Si el carácter no es una letra del alfabeto, debe mostrar `No es una letra`.

- ‘e’ → `Es vocal` · ‘m’ → `Es consonante` · ‘7’ → `No es una letra`

### Problema 9. Año bisiesto

Un año es bisiesto si es divisible entre 4 y no entre 100, o si es divisible entre 400. Determina si un año dado es bisiesto.

- 2024 → `Bisiesto` · 1900 → `No bisiesto` · 2000 → `Bisiesto`

### Problema 10. Analizador de datos recibidos

Un sistema recibe datos en una variable de tipo `object` que puede contener un texto, un entero, un decimal (`double`) o un valor booleano. El programa debe describir el dato:

- Texto → `Texto de N caracteres`
- Entero → `Entero: valor`
- Decimal → `Decimal: valor`
- Booleano → `Booleano: valor`
- Otro → `Tipo no reconocido`

Ejemplos: “SENA” → `Texto de 4 caracteres` · 42 → `Entero: 42` · true → `Booleano: True`

### Problema 11. Semáforo inteligente

Define un tipo con los estados posibles de un semáforo: Rojo, Amarillo y Verde. Según el estado actual, el programa imprime la instrucción para el conductor:

- Rojo → `Deténgase`
- Amarillo → `Precaución, prepárese para detenerse`
- Verde → `Avance`

### Problema 12. Aprobación de crédito

Un banco estudia solicitudes de crédito. Primero verifica si el solicitante tiene empleo. Si no tiene, el crédito se rechaza. Si tiene empleo, revisa su ingreso mensual: si gana $2.500.000 o más se aprueba un crédito alto; si gana menos, se aprueba un crédito básico.

- Sin empleo → `Crédito rechazado`
- Con empleo, ingreso $3.000.000 → `Crédito alto aprobado`
- Con empleo, ingreso $1.800.000 → `Crédito básico aprobado`

### Problema 13. Códigos de país

Un formulario web recibe un código de país de dos letras y debe guardar en una variable el nombre completo:

- “CO” → Colombia · “MX” → México · “AR” → Argentina · “PE” → Perú · “CL” → Chile
- Cualquier otro → `País no registrado`

### Problema 14. Estado del aprendiz

Dada la nota final de un aprendiz (0 a 5), guarda en una variable de texto `Aprobado` si la nota es 3,0 o más, o `Reprobado` en caso contrario, con una sola línea de asignación. Luego imprime `Nota: X - Estado`.

- 3,5 → `Nota: 3,5 - Aprobado`
- 2,9 → `Nota: 2,9 - Reprobado`

### Problema 15. Índice de masa corporal

Calcula el IMC con la fórmula peso / (estatura × estatura), peso en kg y estatura en metros, y clasifica el resultado. Se deben mostrar el valor del IMC con un decimal y la categoría:

- Menos de 18,5: Bajo peso
- De 18,5 a menos de 25: Peso normal
- De 25 a menos de 30: Sobrepeso
- 30 o más: Obesidad

Ejemplo: peso 70, estatura 1,75 → `IMC: 22,9 - Peso normal`

### Problema 16. Ubicación de un dron

El centro de control recibe la posición de un dron como un par de coordenadas con nombre (X, Y). Debe informar en qué cuadrante del plano cartesiano se encuentra, si está en el origen o si está sobre uno de los ejes.

- (3, 4) → `Primer cuadrante`
- (-2, -7) → `Tercer cuadrante`
- (0, 0) → `Origen`
- (0, 5) → `Sobre un eje`

### Problema 17. Control de un reproductor

Un reproductor de música recibe comandos de texto: “play”, “pause”, “stop”, “next”. Cada comando imprime un mensaje distinto (`Reproduciendo...`, `En pausa`, `Detenido`, `Siguiente canción`). Un comando desconocido imprime `Comando no reconocido`.

### Problema 18. Montaña rusa

Para subir a la montaña rusa, una persona debe medir al menos 1,40 m y además tener 12 años o más, a menos que vaya acompañada por un adulto, en cuyo caso basta con la estatura. Determina si puede subir.

- Estatura 1,50, edad 13, sin acompañante → `Puede subir`
- Estatura 1,45, edad 10, con acompañante → `Puede subir`
- Estatura 1,45, edad 10, sin acompañante → `No puede subir`
- Estatura 1,30, edad 15, con acompañante → `No puede subir`

### Problema 19. Radar de velocidad

Un radar en una vía urbana con límite de 50 km/h clasifica la velocidad medida y guarda la sanción en una variable:

- Menos de 0: `Lectura inválida`
- De 0 a 50: `Sin infracción`
- Más de 50 hasta 70: `Multa leve`
- Más de 70 hasta 90: `Multa grave`
- Más de 90: `Multa gravísima e inmovilización`

Ejemplos: 45 → `Sin infracción` · 68 → `Multa leve` · 95 → `Multa gravísima e inmovilización`

### Problema 20. Días de cada mes

Dado el número de un mes (1 a 12) de un año no bisiesto, imprime cuántos días tiene. Varios meses comparten la misma cantidad de días. Un número fuera de rango imprime `Mes inválido`.

- 4 → `30 días` · 2 → `28 días` · 12 → `31 días` · 13 → `Mes inválido`

### Problema 21. Carrito de compras

La tienda virtual muestra cuántos artículos hay en el carrito. La palabra debe ir en singular si hay exactamente uno y en plural en cualquier otro caso. Construye el mensaje con una sola línea de asignación.

- 1 → `Tienes 1 artículo en el carrito`
- 3 → `Tienes 3 artículos en el carrito`
- 0 → `Tienes 0 artículos en el carrito`

### Problema 22. Calculadora básica

Recibe dos números enteros y un operador (`+`, `-`, `*`, `/`) y guarda el resultado de la operación en una variable. Si se intenta dividir entre cero, el programa debe lanzar una excepción con el mensaje `No se puede dividir entre cero`. Si el operador no es válido, debe lanzar una excepción con el mensaje `Operador no soportado`.

- 12, 4, ‘*’ → `12 * 4 = 48`
- 10, 0, ‘/’ → excepción `No se puede dividir entre cero`
- 5, 2, ‘%’ → excepción `Operador no soportado`

### Problema 23. Inicio de sesión

Un sistema valida el acceso en dos pasos. Primero verifica que el usuario exista (el único usuario registrado es “aprendiz”). Si no existe, muestra `Usuario no encontrado`. Si existe, verifica la contraseña (“Sena2026”): si es correcta muestra `Bienvenido`; si no, muestra `Contraseña incorrecta`. Cada error debe tener su propio mensaje.

### Problema 24. ¿Día hábil?

Dado el número de un día de la semana (1 = lunes … 7 = domingo), guarda en una variable si es `Día hábil` (lunes a viernes) o `Fin de semana` (sábado y domingo). Cualquier otro número es `Día inválido`.

- 3 → `Día hábil` · 7 → `Fin de semana` · 0 → `Día inválido`

### Problema 25. Calidad del aire

Una estación de monitoreo recibe el índice de calidad del aire (ICA, entero) y debe asignar la categoría:

- 0 a 50: Buena
- 51 a 100: Moderada
- 101 a 150: Dañina para grupos sensibles
- 151 a 200: Dañina
- Más de 200: Muy dañina
- Negativo: Valor inválido

Ejemplos: 35 → `Buena` · 120 → `Dañina para grupos sensibles` · 260 → `Muy dañina`

### Problema 26. Peaje

Un peaje identifica el vehículo con una letra y asigna la tarifa a cobrar:

- ‘M’ moto: $0 (exenta)
- ‘A’ automóvil: $12.000
- ‘B’ bus: $25.000
- ‘C’ camión: $38.000
- Otra letra: se lanza una excepción con el mensaje `Categoría desconocida`

Imprime `Categoría X - Tarifa: $Y`.

### Problema 27. Taquilla de cine

El precio de la boleta depende de dos datos a la vez: el día (texto: “lunes” … “domingo”) y si la persona es estudiante (sí/no).

- Los martes la boleta cuesta $7.000 para todos.
- De lunes a viernes (excepto martes), un estudiante paga $9.000 y un no estudiante $12.000.
- Sábado y domingo cuesta $15.000 para todos.

Ejemplos: (“martes”, no) → `$7.000` · (“jueves”, sí) → `$9.000` · (“jueves”, no) → `$12.000` · (“sábado”, sí) → `$15.000`

### Problema 28. Descuento por compra

Un almacén aplica descuentos según el valor de la compra:

- $500.000 o más: 15 %
- $200.000 a menos de $500.000: 10 %
- $100.000 a menos de $200.000: 5 %
- Menos de $100.000: sin descuento

Además, si el cliente está inscrito en el programa de cliente frecuente y la compra es de $100.000 o más, recibe un 5 % adicional. El programa muestra el valor de la compra, el porcentaje total de descuento y el total a pagar.

- $250.000, frecuente → descuento 15 %, total $212.500
- $250.000, no frecuente → descuento 10 %, total $225.000
- $80.000, frecuente → descuento 0 %, total $80.000

### Problema 29. Control de acceso a la sede

El torniquete de la sede recibe dos datos: el rol de la persona (“admin”, “instructor”, “aprendiz”) y la hora de llegada (0 a 23). Las reglas son:

- “admin” puede entrar a cualquier hora.
- “instructor” puede entrar de 6 a 21 horas.
- “aprendiz” puede entrar de 6 a 18 horas.
- Cualquier otro caso: acceso denegado.

Ejemplos: (“admin”, 2) → `Acceso permitido` · (“aprendiz”, 19) → `Acceso denegado` · (“instructor”, 20) → `Acceso permitido`

### Problema 30. Boletín de calificaciones (integrador)

Un instructor registra tres notas de un aprendiz (0 a 100). El programa debe:

1. Calcular el promedio.
2. Convertir el promedio a letra: 90 o más → A, 80 a 89 → B, 70 a 79 → C, 60 a 69 → D, menos de 60 → F.
3. Según la letra, imprimir un mensaje de retroalimentación: A → `Desempeño excelente`; B o C → `Buen desempeño, sigue así`; D → `Aprobado, refuerza los temas`; F → `Debe presentar plan de mejoramiento`.
4. Indicar `Aprobado` o `Reprobado` (aprueba con 60 o más).
5. Si el promedio es exactamente 100, mostrar adicionalmente `¡Mención de honor!`.

Ejemplo: notas 85, 78, 92 → `Promedio: 85,0 | Letra: B | Buen desempeño, sigue así | Aprobado`