﻿<h1 align="center">La Solución</h1>

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/OCP/no_change_but_children.jpg" alt="OCP en C#">
</p>

>"Delegar responsabilidades, de nuevo la especialización segregada."\
> -Algún programador clean coder.

## Ejemplo de Implementación del Principio de Abierto-Cerrado (OCP) en C#:
Para aplicar el Principio de Abierto-Cerrado (OCP) en el código proporcionado, necesitamos separar la generación de informes específicos por tipo en clases separadas y utilizar una interfaz común que permita extender el comportamiento sin modificar el código existente. A continuación, se muestra una implementación detallada que también se puede ver en los archivos .cs de la carpeta:.
### IReportGenerator.cs:
Vamos a crear una interfaz IReportGenerator que contenga un método GenerateReport:

   ```csharp
   public interface IReportGenerator
   {
    void CreateReport(List<Order> orders);
   }
   ```

La interfaz **IReportGenerator** actúa como una abstracción que define un contrato para generar informes. Al definir un método GenerateReport en esta interfaz, se establece una estructura común para todas las clases que implementan esta interfaz. Esta abstracción permite separar la responsabilidad de generar informes de la implementación específica para cada tipo de informe (PDF, Excel, JSON, XML, etc.). Al tener una interfaz común, podemos diseñar el código para depender de esta abstracción en lugar de depender de implementaciones concretas.

Mediante la interfaz **IReportGenerator**, permitimos que nuestro código sea abierto para extensión. Esto significa que podemos agregar nuevas clases que implementen **IReportGenerator** para admitir nuevos tipos de informes sin modificar el código existente. Por ejemplo, si en el futuro se desea agregar soporte para informes **CSV**, solo se necesita crear una nueva clase **ReportGeneratorCSV** que implemente la interfaz IReportGenerator. Esto mejora la flexibilidad del código, ya que podemos extender su funcionalidad de manera sencilla y sin riesgo de alterar su comportamiento actual.

Al depender de la interfaz **IReportGenerator** en lugar de implementaciones concretas, seguimos el **Principio de Inversión de Dependencias (DIP)**, otro de los principios SOLID. El DIP sugiere que los módulos de alto nivel no deben depender de módulos de bajo nivel, sino de abstracciones. En este caso, la clase **ReportingServices** de alto nivel depende de la abstracción **IReportGenerator**, mientras que las clases concretas de bajo nivel (**ReportGeneratorPDF**, **ReportGeneratorExcel**, etc.) implementan dicha abstracción. Esto reduce el acoplamiento entre las clases y facilita el cambio de implementaciones sin afectar al código de alto nivel.

### ReportGeneratorXXX.cs:
Crear clases separadas para cada tipo de informe que implementen la interfaz IReportGenerator:
 ```csharp
   public class ReportGeneratorPDF : IReportGenerator
{
    public void GenerateReport(List<Order> orders)
    {
        // Code to create a PDF Report
    }
}

public class ReportGeneratorExcel : IReportGenerator
{
    public void GenerateReport(List<Order> orders)
    {
        // Code to create an Excel Report
    }
}

public class ReportGeneratorJSON : IReportGenerator
{
    public void GenerateReport(List<Order> orders)
    {
        // Code to create a JSON Report
    }
}

public class ReportGeneratorXML : IReportGenerator
{
    public void GenerateReport(List<Order> orders)
    {
        // Code to create an XML Report
    }
}
   ```


El OCP establece que un componente de software debe estar abierto para la extensión pero cerrado para la modificación. Al crear clases separadas para cada tipo de informe que implementen la interfaz **IReportGenerator**, estamos siguiendo este principio. Podemos agregar nuevas implementaciones para nuevos tipos de informes sin modificar el código existente en la clase **ReportingService**. Esto nos permite extender la funcionalidad del sistema sin alterar su comportamiento actual, lo que hace que el código sea más flexible y menos propenso a errores.

Al crear clases separadas para cada tipo de informe, estamos aplicando el **Principio de Responsabilidad Única (SRP)**, otro de los principios SOLID. Cada clase se enfoca únicamente en la generación de un tipo específico de informe, lo que garantiza que cada clase tenga una única responsabilidad y sea cohesiva. Esta separación de responsabilidades facilita la comprensión y el mantenimiento del código, ya que cada clase tiene una función claramente definida.

La creación de clases separadas para cada tipo de informe mejora la modularidad y la reutilización del código. Cada clase se puede desarrollar, mantener y probar de forma independiente. Si se requiere modificar la lógica de generación de un tipo de informe específico, podemos hacerlo en la clase correspondiente sin afectar el comportamiento de otros informes. Además, si en el futuro se desea agregar un nuevo tipo de informe, simplemente creamos una nueva clase que implemente IReportGenerator, lo que facilita la extensión del sistema.

Al tener clases separadas para cada tipo de informe, podemos implementar la lógica de generación específica para cada informe de una manera más clara y organizada. Por ejemplo, si la generación de informes **PDF** requiere un enfoque diferente de la generación de informes **Excel**, tener clases separadas nos permite manejar esas diferencias de manera más estructurada y evitar mezclar lógicas que no son relevantes.

### ReportingService.cs::
El OCP establece que un componente de software debe estar abierto para la extensión pero cerrado para la modificación. Al depender de la interfaz **IReportGenerator** en lugar de realizar verificaciones condicionales para cada tipo de informe, la clase **ReportingService** se vuelve más abierta para la extensión. Siempre que tengamos una nueva clase que implemente **IReportGenerator** para un nuevo tipo de informe, podemos utilizarla directamente en la clase **ReportingServices** sin necesidad de cambiar el código existente. Esto facilita la adición de nuevos tipos de informes y evita la necesidad de modificar la clase principal, lo que mejora la flexibilidad del código.

 ```csharp
public class ReportingService
{
    private readonly IReportGenerator _reportGenerator;

    public ReportingService(IReportGenerator reportGenerator)
    {
        _reportGenerator = reportGenerator;
    }

    public void GenerateReport(List<Order> orders)
    {
        _reportGenerator.CreateReport(orders);
    }
}
 ```

Al eliminar las verificaciones condicionales para cada tipo de informe, la lógica dentro del método **GenerateReport** de la clase **ReportingServices** se vuelve más simple y legible. Las múltiples verificaciones condicionales pueden ser propensas a errores y dificultar la comprensión del código. Al depender de la interfaz **IReportGenerator**, la clase **ReportingServices** se desacopla de las implementaciones concretas de los informes y se centra en su funcionalidad principal de generar informes, lo que mejora la cohesión y la claridad del código.

Al depender de la interfaz **IReportGenerator**, la clase **ReportingServices** se vuelve más modular y reutilizable. Podemos tener diferentes implementaciones de generación de informes que se adapten a diferentes requisitos y contextos sin afectar el funcionamiento de la clase principal. Cada implementación concreta de **IReportGenerator** puede ser reutilizada en otras partes del sistema donde se necesite generar informes del mismo tipo. Esto mejora la mantenibilidad y promueve una estructura de código más organizada y escalable.

La modificación de la clase **ReportingServices** para depender de la interfaz **IReportGenerator** nos permite enfocarnos en la generación de informes como una responsabilidad única y claramente definida. Las verificaciones condicionales para cada tipo de informe pueden desviar el enfoque del propósito principal de la clase y hacerla menos mantenible. Al depender de la interfaz, separamos la generación de informes de los detalles de implementación, lo que mejora la cohesión y la legibilidad del código.

## Conclusión:
Con esta solución, hemos aplicado el **OCP** al código. Ahora, si se desea agregar un nuevo tipo de informe, simplemente se crea una nueva clase que implemente la interfaz **IReportGenerator**, sin necesidad de modificar el código existente en la clase **ReportingServices**.

Por ejemplo, si queremos agregar soporte para un nuevo tipo de informe llamado **CSV**, solo necesitamos crear una nueva clase **ReportGeneratorCSV** que implemente **IReportGenerator** y proporcione la lógica para generar el informe CSV.

De esta manera, el código se mantiene abierto para extensión, ya que se pueden agregar nuevas clases para diferentes tipos de informes sin modificar el código existente. Al mismo tiempo, se mantiene cerrado para modificación, ya que no hay necesidad de modificar la clase ReportingServices2 cada vez que se agrega un nuevo tipo de informe, lo que mejora la flexibilidad, mantenibilidad y reutilización del código.
