# Desarrollo de App 

## 2DO EXAMEN PARCIAL 

### Diseñe y desarrolle en XamarinForm una App que realice las  operaciones básicas de Banca electrónica de acuerdo con los  siguientes requerimientos. 

1. Aplique el patrón MVVM para el diseño e implementación de  la App. 

2. Se tiene un único usuario con los siguientes datos: Nombre,  Apellido paterno, apellido materno, teléfono. 

3. El usuario puede tener uno o mas de una cuenta de debito  en el banco de la(s) cual(es) se desea conocer: nombre (ahorro, gasto diario, etc), número de cuenta (número único -validación-), saldo (al momento del registro debe ser mayor a 0). 

4. La app debe permitir el registro de cuenta nueva. El número  de cuenta debe ser único, el saldo debe ser mayor a 0 al  momento del registro. 

5. De cada cuenta se pueden realizar transacciones (deposito,  retiros), de cada transacción se desea conocer: el monto,  fecha, hora. 

6. Cuando se realiza una transacción de tipo ***deposito*** el saldo  de la cuenta aumenta en el importe del depósito. 

7. Cuando se realiza una transacción de tipo ***retiro*** el saldo de  la cuenta disminuye en el importe del retiro. 

8. No se pueden realizar ***retiros*** mayores al saldo de la cuenta. 9. En todos los casos los importes son enteros positivos. 10. La app debe mostrar un listado de todas las cuentas, permitir seleccionar una cuenta y mostrar saldo y todas las  transacciones. Al seleccionar una cuenta y mostrar sus transacciones debe permitir realizar una transacción nueva  (depósito, retiro). 

11. De cada cuenta debe mostrar: Número, saldo. 12. De cada transacción debe mostrar: tipo de transacción  (abono, deposito), importe. 

13. La app debe permitir registrar y modificar los datos del  usuario. 

14. La app debe permitir registrar transacciones. 15. La app debe permitir eliminar cuentas únicamente si el  saldo es 0. 

16. Diseñe a su gusto la interfaz de usuario aplicando  colores y estilos. 

**REQUISITO:** El nombre del proyecto, cada página, clase o  elemento del proyecto que debe tener al final del nombre los  últimos 4 dígitos de tú número de control. 

Ejemplo: 

- Tu número de control 2015***2468*** 

- Nombre del proyecto: Tarjetas***2468*** 

- Pagina(s) 

- inicio: Inicio***2468*** 

- Registro usuario: RegistroUsuario***2468*** 

- Transacciones: Transaccion***2468*** 

- Modelo: usuario***2468*** 

- ViewModel: RegistroUsuarioViewModel***2468*** 

- Etc. … 

__TEMA A INVESTIGAR: Generación de números aleatorios.__

### Lista de cotejo para calificar: 

1. Diseño de interfaz de usuario con estilos y colores 2. Implementación patrón MVVM 

2. Nomenclatura solicitada para los elementos utilizados (requisito indispensable). 

3. Registro y modificación de datos del usuario, campos  obligatorios: Nombre 

4. Cuenta.

   a. Registro de cuenta.

   b. Validación de número único de cuenta. 

   c. Saldo mayor a 0. 

   d. Eliminar únicamente si el saldo es mayor a 0. 

   e. Mostrar las cuentas del usuario 

   f. Seleccionar cuenta

5. Transacciones 

   a. Registro de depósitos: Entero positivo, actualización  de saldo de cuenta. 

   b. Registro de retiros: Entero positivo, no mayor al saldo  de la cuenta, actualización de saldo de la cuenta. 

   c. Al desplegar las transacciones indicar si es deposito o  retiro. 

   d. Mostrar las transacciones de cada cuenta
