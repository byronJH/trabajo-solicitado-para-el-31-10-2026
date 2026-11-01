# Ejercicio 2:


##  Datos de los integrantes

* Nombre: Byron Abner Jorge Herrera
* Numero 10#


## Descripción de la tarea o proyecto

Este programa permite generar un nombre de usuario a partir del nombre y apellido de una persona y
verificar si la contraseña introducida cumple con las condiciones establecidas, que son: tener al menos 8 caracteres y no contener el nombre de usuario.

##  Entrada

El programa solicita tres datos al usuario:

* Nombre de la persona.
* Apellido de la persona.
* Contraseña que desea utilizar.

##  Proceso

1. Se reciben los datos introducidos por el usuario.
2. Se llama a la función `GenerarUsuario()`, que toma la primera letra del nombre y la une con el apellido, convirtiendo ambos a minúsculas.
3. Se llama a la función `ClaveValida()`, que comprueba si la contraseña tiene al menos 8 caracteres y no contiene el nombre de usuario.
4. Se obtiene un resultado verdadero o falso según las condiciones de validación.
5. Se llama al procedimiento `MostrarCuenta()`, que presenta el nombre de usuario y el resultado de la validación.

##  Salida

El ejercicio muestra:

* Nombre de usuario generado automáticamente.
* Mensaje indicando si la contraseña es válida o no.

## Tecnologías utilizadas

* Lenguaje de programación: C#.
* Entorno de desarrollo: Visual Studio.
* Plataforma: .NET.

##  Capturas de pantalla

### Escenario 1: Contraseña válida

<img width="320" height="77" alt="Captura de pantalla prueba de validacion (aceptada)" src="https://github.com/user-attachments/assets/dd2cdc01-efca-48ca-a07a-187236018e8d" />


### Escenario 2: Contraseña no válida por la poca cantidad de caracteres

<img width="220" height="88" alt="Captura de pantalla prueba de validacion (Negada1)" src="https://github.com/user-attachments/assets/118e8ef7-e763-4ca1-b6b8-978103977911" />

### Escenario 3: Contraseña no válida por usar el mismo nombre de usuario

<img width="322" height="86" alt="Captura de pantalla prueba de validacion(Negada 2)" src="https://github.com/user-attachments/assets/a88316a1-95e7-4801-9843-3c8d0203cdaa" />



