<h1 align="center">El Problema</h1>

<p align="center">
  <img src="url_de_la_imagen" alt="Violación del Principio de Responsabilidad Única en C#">
</p>

## Sobre el problema:

El SRP es uno de los principios SOLID y establece que una clase debe tener una única responsabilidad, es decir, una razón para cambiar. Esto implica que cada clase debe enfocarse en realizar una sola tarea o funcionalidad, lo que conduce a un código más cohesivo, fácil de mantener, extensible y menos propenso a errores.

Para aplicar el SRP de manera efectiva, es importante identificar claramente las responsabilidades de una clase y asegurarse de que estén relacionadas y pertenezcan a un mismo contexto coherente. La separación de intereses y la modularidad son aspectos clave para mantener el principio SRP en el diseño del software.

El SRP también se relaciona con otros principios SOLID, como el Principio de Abierto/Cerrado (OCP) y el Principio de Sustitución de Liskov (LSP), ya que una clase con una única responsabilidad es más fácil de extender y permite que las clases derivadas sean intercambiables con las clases base.

## Ejemplos para entender el Principio de Responsabilidad Única usando C#:

Supongamos que necesitamos diseñar una clase llamada "Invoice" (Factura). Como sabemos, la clase "Invoice" se utiliza básicamente para calcular varios importes basados en sus datos. La clase "Invoice" no sabe cómo recuperar los datos, ni cómo formatear los datos para mostrarlos, imprimirlos, registrarlos, enviar un correo electrónico, etc.

Si escribimos la lógica de la base de datos, la lógica de negocio y también la lógica de visualización en una sola clase, entonces nuestra clase realizará múltiples responsabilidades. Entonces se vuelve muy difícil cambiar una responsabilidad sin romper las otras responsabilidades. Así que, al mezclar múltiples responsabilidades en una sola clase, obtenemos la siguiente desventaja:
- Difícil de entender
- Difícil de probar
- Posibilidad de duplicar la lógica de otras partes de la aplicación

## Ejemplo sin usar el Principio de Responsabilidad Única en C#:

Vamos a crear una clase "Invoice" con cuatro funcionalidades, es decir, Agregar y Eliminar Facturas, Registro de Errores y Envío de Correos Electrónicos. Al poner todas estas cuatro funcionalidades en una sola clase o módulo, estamos violando el Principio de Responsabilidad Única en C#. Esto se debe a que el envío de correos electrónicos y el registro de errores no son parte del módulo de facturación.

Con este diseño, si queremos modificar la funcionalidad de registro o si queremos modificar la funcionalidad de envío de correos electrónicos, entonces necesitamos modificar la clase "Invoice". Esto viola el Principio de Responsabilidad Única, ya que estamos cambiando la clase "Invoice" para otra funcionalidad. Si realizamos los cambios, entonces necesitamos probar la funcionalidad de registro y de correo electrónico junto con la funcionalidad de facturación. Ahora discutiremos cómo implementar las funcionalidades anteriores de tal manera que se siga el Principio de Responsabilidad Única utilizando el lenguaje C#.

---
*Nota: Reemplaza "url_de_la_imagen" con la URL de la imagen que desees mostrar en el README.*
