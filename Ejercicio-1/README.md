# Ejercicio 1:

##  Datos de los integrantes

* Nombre: Byron Adner Jorge Herrera.
* Numero: 10#.
.

##  Descripción de la tarea o proyecto

Este trabajo permite calcular el total de una factura a partir del subtotal de una compra y si el cliente es frecuente,
recibe un descuento. Despues, se calcula el ITBIS (impuesto) y al final se muestra el total que debe pagar.


##  Entrada

El ejercicio solicita tres datos al usuario:

* Nombre del cliente.
* Subtotal de la compra.
* Si es un cliente frecuente (true o false).

##  Proceso

1. Se reciben los datos introducidos por el usuario.
2. Se llama a la función `CalcularTotal()`, que recibe el subtotal y comprueba si el cliente es frecuente.
3. Si es frecuente, se aplica un descuento del 10% al subtotal.
4. Se calcula el ITBIS del 18% sobre el subtotal después del descuento.
5. Se suman el subtotal y el ITBIS para obtener el total.
6. Se llama al procedimiento `MostrarFactura()`, que presenta el nombre del cliente y el total a pagar.

##  Salida

El ejercicio muestra:

* Nombre del cliente.
* Total a pagar después de aplicar el descuento correspondiente y el ITBIS.

##  Tecnologías utilizadas

* Lenguaje de programación: C#.
* Entorno de desarrollo: Visual Studio.
* Plataforma: .NET.

##  Capturas de pantalla

### Escenario 1: Cliente frecuente

<img width="227" height="85" alt="Captura de pantalla prueba 1 (true)" src="https://github.com/user-attachments/assets/34a7c726-3807-435d-8cb7-2afa7e6114d8" />


### Escenario 2: Cliente no frecuente

<img width="232" height="87" alt="Captura de pantalla prueba 2(falsa)" src="https://github.com/user-attachments/assets/5a4ae120-8080-473a-b5c9-10bd72c69085" />


