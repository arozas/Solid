<h1 align="center">El Problema</h1>

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/OCP/OCP.jpg" alt="Violación del Principio de ABIERTO-CERRADO en C#">
</p>

> "Sin OCP, el software se convierte en un castillo de naipes, donde cada cambio puede derrumbarlo todo."\
> -Algún programador clean coder.

## Sobre el problema que trata este principio:

El problema de no aplicar el Principio de Abierto-Cerrado (OCP) en la programación orientada a objetos (POO) radica en la falta de extensibilidad y la dificultad para adaptar el código a cambios futuros. Cuando una clase no sigue el OCP, es decir, no está abierta para la extensión y cerrada para la modificación, suele ser difícil agregar nuevas funcionalidades o adaptar el comportamiento existente sin modificar directamente el código fuente de la clase.

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

Imagina que tienes una clase llamada "ReportingServices" que se encarga de generar informes en una aplicación. Actualmente, esta clase puede generar informes en diferentes formatos, como PDF, Excel. Sin embargo, debido a cambios en los requisitos del negocio, ahora también necesitas que esta clase sea capaz de generar informes en un nuevo formato llamado XML (Extensible Markup Language) o en JSON (JavaScript Object Notation). Si la clase "ReportingServices" no sigue el Principio de Abierto-Cerrado (OCP), tendrás que modificar directamente el código de la clase para agregar la nueva funcionalidad como se ve en la implementación de "ReportingServices2".

## Conclusión:

Con este diseño, si queremos modificar la funcionalidad de registro o si queremos modificar la funcionalidad de envío de
correos electrónicos, entonces necesitamos modificar la clase "Invoice". Esto viola el Principio de Responsabilidad
Única, ya que estamos cambiando la clase "Invoice" para otra funcionalidad. Si realizamos los cambios, entonces
necesitamos probar la funcionalidad de registro y de correo electrónico junto con la funcionalidad de facturación. Y si
generamos otra clase, como puede ser "Receipt"(Recibo), esta tendrá que tener sus propias implementaciones de registro
de errores como de envío de correo electrónico, repitiendo mucho código por cada clase que generemos que diseñamos para
tener esas funcionalidades.




