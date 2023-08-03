<h1 align="center">El Problema</h1>

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/OCP/OCP.jpg" alt="Violación del Principio de ABIERTO-CERRADO en C#">
</p>

> ""En la programación orientada a objetos, las clases son como herriamientas especializadas, ¡mejor enfocados en una tarea a la vez que ser navajas suizas complejas!."\
> -Algún programador clean coder.

## Sobre el problema que trata este principio:

El problema de no aplicar el Principio de Abierto-Cerrado (OCP) en la programación orientada a objetos (POO) radica en la falta de extensibilidad y la dificultad para adaptar el código a cambios futuros. Cuando una clase no sigue el OCP, es decir, no está abierta para la extensión y cerrada para la modificación, suele ser difícil agregar nuevas funcionalidades o adaptar el comportamiento existente sin modificar directamente el código fuente de la clase.

Imagina que tienes una clase llamada "ReportingServices2" que se encarga de generar informes en una aplicación. Actualmente, esta clase puede generar informes en diferentes formatos, como PDF, Excel, JSON y XML. Sin embargo, debido a cambios en los requisitos del negocio, ahora también necesitas que esta clase sea capaz de generar informes en un nuevo formato llamado CSV (Comma Separated Values). Si la clase "ReportingServices2" no sigue el Principio de Abierto-Cerrado (OCP), tendrás que modificar directamente el código de la clase para agregar la nueva funcionalidad.

El problema con esto es que puede llevar a una serie de desventajas:

1. Riesgo de errores: Al modificar directamente el código existente, existe un alto riesgo de introducir errores o efectos secundarios no deseados. El código ya probado y funcionando correctamente podría alterarse, lo que afectaría la estabilidad del sistema.

2. Dificultad de mantenimiento: Cuando el código está entrelazado y no sigue el OCP, se vuelve complicado comprender el impacto de los cambios y mantener la coherencia del sistema. Esto puede dificultar el trabajo del equipo de desarrollo y llevar a errores difíciles de detectar.

3. Acoplamiento excesivo: Si las clases no están diseñadas para seguir el OCP, es probable que estén altamente acopladas con otras clases y componentes del sistema. Esto aumenta la dependencia y hace que los cambios sean más complicados y riesgosos, ya que podrían afectar a múltiples partes del sistema.

4. Dificultad para adaptarse a cambios futuros: En un entorno empresarial en constante cambio, la capacidad de adaptarse rápidamente a nuevos requisitos es crucial. Si el código no sigue el OCP, será más difícil agregar nuevas funcionalidades y podría llevar a una resistencia al cambio en el equipo de desarrollo.

Para abordar estos problemas, es necesario aplicar el OCP en el diseño de software. Al seguir este principio, se deben crear interfaces estables que permitan la extensión y definir clases que implementen esas interfaces sin necesidad de modificar el código existente. Al agregar nuevas funcionalidades, se pueden crear nuevas clases que cumplan con las mismas interfaces, lo que permite que el código existente funcione sin cambios.

## Ejemplo sin usar el Principio de Responsabilidad Única en C#:

Veamos la diagramación de la clase "Invoice" sin el uso del Principio de Responsabilidad Única en C#. Ahora podemos
intentar al ver el diagrama entender lo expuesto anteriormente y en en esta misma carpeta se encuentra la implementación
de este diagrama.

Por favor, echa un vistazo al siguiente diagrama que queremos implementar en nuestro ejemplo:

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/SRP/InvoiceClass.jpg" alt="Violación del Principio de Responsabilidad Única en C#">
</p>

Como se puede ver en la imagen anterior, la clase "Invoice" posee cuatro funcionalidades que no guardan relación entre
si, es decir, los métodos Agregar Facturas, Eliminar Facturas, y Envío de Correos Electrónicos, todos con sus respectivo
Registro de Errores. Al poner todas estas cuatro funcionalidades en una sola clase o módulo, estamos violando el
Principio de Responsabilidad Única en C#. Esto se debe a que el envío de correos electrónicos y el registro de errores
no son parte del módulo de facturación.

## Conclusión:

Con este diseño, si queremos modificar la funcionalidad de registro o si queremos modificar la funcionalidad de envío de
correos electrónicos, entonces necesitamos modificar la clase "Invoice". Esto viola el Principio de Responsabilidad
Única, ya que estamos cambiando la clase "Invoice" para otra funcionalidad. Si realizamos los cambios, entonces
necesitamos probar la funcionalidad de registro y de correo electrónico junto con la funcionalidad de facturación. Y si
generamos otra clase, como puede ser "Receipt"(Recibo), esta tendrá que tener sus propias implementaciones de registro
de errores como de envío de correo electrónico, repitiendo mucho código por cada clase que generemos que diseñamos para
tener esas funcionalidades.




