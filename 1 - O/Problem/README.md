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

## Ejemplo sin usar el Principio de ABIERTO-CERRADO en C#:

Imagina que tienes una clase llamada "ReportingServices" que se encarga de generar informes en una aplicación. Actualmente, esta clase puede generar informes en diferentes formatos, como PDF, Excel. Sin embargo, debido a cambios en los requisitos del negocio, ahora también necesitas que esta clase sea capaz de generar informes en un nuevo formato llamado XML (Extensible Markup Language) o en JSON (JavaScript Object Notation). Si la clase "ReportingServices" no sigue el Principio de Abierto-Cerrado (OCP), tendrás que modificar directamente el código de la clase para agregar la nueva funcionalidad como se ve en la implementación de "ReportingServices2".

```csharp
public class ReportingServices2
{
    public void GenerateReport(List<Order> orders, ReportType type)
    {
        //Generic implementation to create a report.
        
        //Specific conversion depending on type
        if (type == ReportType.PDF)
        {
            CreatePDFReport(orders);
        }
        else if(type == ReportType.EXCEL)
        {
            CreateExcelReport(orders);
        }        
        else if(type == ReportType.JSON)
        {
            CreateJsonReport(orders);
        }
        else if(type == ReportType.XML)
        {
            CreateXMLReport(orders);
        }
    }

    private void CreateExcelReport(List<Order> orders)
    {
        //Code to create an Excel Report
    }

    private void CreatePDFReport(List<Order> orders)
    {
        //Code to create a PDF Report
    }
    
    private void CreateXMLReport(List<Order> orders)
    {
        //Code to create a XML Report
    }

    private void CreateJsonReport(List<Order> orders)
    {
        //Code to create a JSON Report
    }

}

public class Order
{
    //Generic implementation of Order Class.
}

public enum ReportType
{
    PDF,
    EXCEL,
    JSON,
    XML
}
```
El problema como vemos ahora en "ReportingServices2" está acoplada directamente a los diferentes tipos de informes (PDF, EXCEL, JSON, XML). Como resultado, cada vez que se agregue un nuevo tipo de informe o se desee modificar uno existente, es necesario modificar directamente el código de la clase ReportingServices. Si se desea agregar un nuevo tipo de informe en el futuro, será necesario modificar la clase ReportingServices, lo que va en contra del Principio de Abierto-Cerrado (OCP). Las múltiples verificaciones condicionales dentro del método **GenerateReport** hacen que la extensión del código sea complicada y propensa a errores.

## Conclusión:
Si se desea agregar un nuevo tipo de informe en el futuro, será necesario modificar la clase ReportingServices, lo que va en contra del Principio de Abierto-Cerrado (OCP). Las múltiples verificaciones condicionales dentro del método GenerateReport hacen que la extensión del código sea complicada y propensa a errores.




