# RentaCar Express - Práctica de Programación Básica

## 1. Nombre y matrícula
Vladimir Corrielan — Matrícula: 2025-2527

## 2. Descripción del programa
Programa de escritorio hecho en C# Windows Forms para registrar alquileres de vehículos en RentaCar Express y calcular el monto total a pagar[cite: 10, 11]. Todo funciona dentro del formulario `frmAlquiler`, donde se escriben los datos del cliente y de cada vehículo, se van sumando los alquileres en una lista con columnas alineadas y al final se calculan descuentos, cargos, ITBIS y total[cite: 10, 11].

## 3. Datos de entrada
- **Cliente (`txtCliente`)**: Nombre de quien solicita el alquiler[cite: 10, 11].
- **Cliente corporativo (`chkCorporativo`)**: Marca si aplica descuento corporativo[cite: 10, 11].
- **Fecha de salida (`dtpSalida`)**: Fecha de salida del alquiler (inicia en la fecha actual)[cite: 10, 11].
- **Vehículo (`txtVehiculo`)**: Nombre del vehículo digitado a mano[cite: 11].
- **Tarifa (`txtTarifa`)**: Tarifa base diaria en RD$ digitada a mano[cite: 11].
- **Días (`nudDias`)**: Cantidad de días del alquiler, de `1` a `30`[cite: 11].
- **Seguro (`rbtBasico`, `rbtCompleto`)**: Seguro básico por defecto o completo que suma RD$300 por día[cite: 10, 11].
- **GPS (`chkGps`)**: Suma RD$100 por día si está marcado[cite: 10, 11].
- **Entrega (`rbtSucursal`, `rbtDomicilio`)**: En sucursal por defecto o a domicilio que suma RD$500 una sola vez por alquiler[cite: 10, 11].

## 4. Proceso
1. **Al iniciar (`Load`)**: Deja los campos y totales en su estado inicial, pone los encabezados de columna (`Días`, `Vehículo`, `Tarifa`, `Total`) en `lblEncabezado` y deja el subtotal en cero[cite: 11].
2. **Al agregar vehículo (`btnAgregar`)**: Toma la tarifa base, suma RD$300 si tiene seguro completo y RD$100 si lleva GPS, multiplica por los días para sacar el total de esa línea, muestra la fila en `lstAlquileres` con columnas alineadas (`PadRight` / `PadLeft` con anchos `6`, `24`, `10` y `12`) y el detalle entre paréntesis, acumula el subtotal y limpia los controles del vehículo[cite: 10, 11].
3. **Al calcular (`btnCalcular`)**: Si no hay vehículos en la lista, avisa y no hace el cálculo[cite: 11]. Si hay vehículos, calcula el 15 % de descuento sobre el subtotal si es corporativo, suma RD$500 si es a domicilio, saca la base imponible (`subtotal - descuento + domicilio`), calcula el 18 % de ITBIS y muestra el total a pagar[cite: 10, 11].
4. **Al limpiar (`btnLimpiar`)**: Reinicia todo, deja el subtotal en cero y manda el foco a `txtCliente`[cite: 11].
5. **Al salir (`btnSalir`)**: Pide confirmación con un `MessageBox` (`Sí`/`No`) antes de cerrar la ventana.

## 5. Salida
- Encabezado en `lblEncabezado` y detalle en `lstAlquileres` usando fuente `Consolas` con las columnas `Días`, `Vehículo`, `Tarifa` y `Total`[cite: 10, 11].
- Totales en `lblSubtotal`, `lblDescuento`, `lblDomicilio`, `lblItbis` y `lblTotal` en formato `RD$ 0.00`[cite: 10, 11].

## 6. Capturas de pantalla
![Foto 1](Capturas/Foto%201.jpg)
![Foto 2](Capturas/Foto%202.jpg)
![Foto 3](Capturas/Foto%203.jpg)
![Foto 4](Capturas/Foto%204.jpg)
