﻿<h1 align="center">La Solución</h1>

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/SRP/SpecializedTools.jpg" alt="OCP en C#">
</p>

>"Para cada tarea, su herramienta."\
> -Algún programador clean coder.

## Ejemplo de Implementación del Principio de Responsabilidad Única en C#:
Vamos a implementar el mismo ejemplo siguiendo el SRP (Principio de Responsabilidad Única). Por favor, echa un vistazo al siguiente diagrama.


<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/SRP/AplicacionPrincipio.jpg" alt="Principio de Responsabilidad Única en C#">
</p>

Como se puede ver en el diagrama anterior, ahora vamos a crear tres clases. En la clase "Invoice" (Factura), solo se implementarán las funcionalidades relacionadas con las facturas. La clase "Logger" se utilizará únicamente para el registro de actividades. Del mismo modo, la clase "Email" manejará las actividades de correo electrónico. Ahora cada clase tiene solo sus propias responsabilidades, lo que cumple con el Principio de Responsabilidad Única en C#. Si deseas modificar la funcionalidad de correo electrónico, solo necesitas cambiar la clase "Email", no las clases "Invoice" y "Logger". De manera similar, si deseas modificar las funcionalidades de "Invoice", solo necesitas cambiar la clase "Invoice", no las clases "Email" y "Logger". Ahora, procedamos y veamos cómo implementar esto utilizando C#.

### Logger.cs::
Agrega un archivo de clase con el nombre "Logger.cs" y luego copia y pega el siguiente código en él. Como se puede ver en la siguiente clase, definimos todas las actividades de registro, es decir, Info, Debug y Error. El punto que debes recordar es que la clase puede contener varios métodos siempre y cuando todos los métodos pertenezcan a la misma responsabilidad. Aquí, estamos creando una interfaz con el nombre "ILogger" con tres métodos abstractos (por defecto, los métodos de interfaz son abstractos). Luego, implementamos los métodos de la interfaz "ILogger" dentro de la clase "Logger". Los métodos "Info", "Debug" y "Error" realizarán diferentes actividades de registro, y por lo tanto, los colocamos todos dentro de la clase "Logger".

### MailSender.cs::
Ahora, necesitamos agregar otro archivo de clase con el nombre "MailSender.cs" y luego copiar y pegar el siguiente código en él. En la clase "MailSender" a continuación, definimos las actividades de envío de correos electrónicos. Aquí, puedes ver que hemos agregado las propiedades requeridas para enviar el correo electrónico junto con el método "SendEmail". Por simplicidad, no hemos proporcionado la lógica para enviar el correo electrónico, pero en tiempo real, deberás escribir la lógica dentro del método "SendEmail" para enviar un correo electrónico.
### Modificando la Clase Invoice:
Finalmente, modifica la clase "Invoice" como se muestra a continuación. En esta clase, solo definimos las actividades relacionadas con la factura. Como puedes ver, la clase "Invoice" delega la actividad de registro a la clase "Logger". De manera similar, también delega la actividad de envío de correos electrónicos a la clase "MailSender". Ahora, la clase "Invoice" se concentra solo en las actividades relacionadas con la factura.

Así es como debemos diseñar la aplicación siguiendo el Principio de Responsabilidad Única en C#. Ahora, cada clase tiene sus propias responsabilidades. Esto significa que cada módulo de software o clase debe tener solo una razón para cambiar.

### Ventajas del Principio de Responsabilidad Única:

- **Reducción de la complejidad del código de la aplicación:** El código se basa en su funcionalidad. Cada clase contiene la lógica para una sola funcionalidad, lo que reduce la complejidad del código de la aplicación.
- **Mayor legibilidad, extensibilidad y mantenibilidad:** Como cada clase o módulo tiene una sola funcionalidad, es fácil leer y mantener el código de la aplicación.
- **Mayor facilidad para realizar pruebas de las funciones:** Cuando cambia la funcionalidad, no es necesario probar todas las funcionalidades, ya que cada módulo tiene solo una funcionalidad.
- **Reducción del acoplamiento entre los componentes del software:** Se reduce la dependencia entre los componentes del software. El código de un método no depende de otros métodos, por lo que los cambios en un método no afectarán a otro.