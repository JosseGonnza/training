Ejercicio 9: Verificar si un Año es Bisiesto
Descripción: Escribe una función que verifique si un año dado es bisiesto. Un año es bisiesto si es divisible por 4, pero no por 100, a menos que también sea divisible por 400.

Ejemplo:

- Entrada: 2000
- Salida esperada: true
- Entrada: 1900
- Salida esperada: false

Pruebas sugeridas en TDD:

- Dado un año divisible por 400, debe devolver true.
- Dado un año divisible por 100 pero no por 400, debe devolver false.
- Dado un año divisible por 4 pero no por 100, debe devolver true.
- Dado un año no divisible por 4, debe devolver false.