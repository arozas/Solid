<h1 align="center">El Problema</h1>

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/SRP/SwissArmyKnife.gif" alt="Violación del Principio de Responsabilidad Única en C#">
</p>

>""En la programación orientada a objetos, las clases son como herriamientas especializadas, ¡mejor enfocados en una tarea a la vez que ser navajas suizas complejas!."\
> -Algún programador clean coder.

## Sobre el problema que trata este principio:
El problema de las "navajas suizas" en la POO radica en violar el Principio de Responsabilidad Única (SRP). Cuando una clase asume múltiples responsabilidades y realiza diversas tareas, se convierte en una "navaja suiza". Esto conduce a un código poco mantenible, difícil de entender y propenso a errores.

Vamos a entender el Principio de Responsabilidad Única en C# con un ejemplo practico. Supongamos que necesitamos diseñar una clase llamada "Invoice" (Factura). Como sabemos, la clase "Invoice" se utiliza básicamente para calcular distintos importes basados en sus datos. La clase "Invoice" no deberia saber cómo obtener los datos, ni cómo formatear los datos para mostrarlos, imprimirlos, registrarlos, enviar un correo electrónico, etc.

Si implementamos la lógica de la base de datos, la lógica de negocio y también la lógica de visualización en una sola clase, entonces nuestra clase tendrá múltiples responsabilidades. Esto genera que se vuelva muy difícil cambiar una responsabilidad sin romper las otras responsabilidades. Así que, al mezclar múltiples responsabilidades en una sola clase, obtenemos la siguiente desventaja:

- Difícil de entender
- Difícil de probar
- Posibilidad de duplicar la lógica de otras partes de la aplicación

## Ejemplo sin usar el Principio de Responsabilidad Única en C#:
Veamos la diagramación de la clase "Invoice" sin el uso del Principio de Responsabilidad Única en C#. Ahora podemos intentar al ver el diagrama entender lo expuesto anteriormente y en en esta misma carpeta se encuentra la implementación de este diagrama.

Por favor, echa un vistazo al siguiente diagrama que queremos implementar en nuestro ejemplo:

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/SRP/InvoiceClass.jpg" alt="Violación del Principio de Responsabilidad Única en C#">
</p>

Como se puede ver en la imagen anterior, la clase "Invoice" posee cuatro funcionalidades que no guardan relación entre si, es decir,  los métodos Agregar Facturas, Eliminar Facturas, y Envío de Correos Electrónicos, todos con sus respectivo Registro de Errores. Al poner todas estas cuatro funcionalidades en una sola clase o módulo, estamos violando el Principio de Responsabilidad Única en C#. Esto se debe a que el envío de correos electrónicos y el registro de errores no son parte del módulo de facturación.

## Conclusión:
Con este diseño, si queremos modificar la funcionalidad de registro o si queremos modificar la funcionalidad de envío de correos electrónicos, entonces necesitamos modificar la clase "Invoice". Esto viola el Principio de Responsabilidad Única, ya que estamos cambiando la clase "Invoice" para otra funcionalidad. Si realizamos los cambios, entonces necesitamos probar la funcionalidad de registro y de correo electrónico junto con la funcionalidad de facturación. Y si generamos otra clase, como puede ser "Receipt"(Recibo), esta tendrá que tener sus propias implementaciones de registro de errores como de envío de correo electrónico, repitiendo mucho código por cada clase que generemos que diseñamos para tener esas funcionalidades.




