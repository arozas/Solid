<h1 align="center">Liskov Substitution Principle (LSP)</h1>

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/LSP/LSP%20-%20TITLE.png" alt="LSP Image">
</p>

>"La LSP (Principio de Sustitución de Liskov) deja claro que en el DOD (Diseño Orientado a Objetos) la relación ISA(relación de herencia) se refiere al comportamiento. No al comportamiento intrínseco privado, sino al comportamiento público extrínseco; comportamiento en el que los clientes dependen."\
> — Robert C. Martin

## Resumen

De los cinco principios SOLID, el Principio de Sustitución de Liskov es quizás uno de los más desafiantes de comprender. En términos generales, este principio simplemente establece que cada clase derivada debe ser sustituible por su clase padre. Lleva el nombre de Barbara Liskov, quien introdujo este concepto de subtipado de comportamiento en 1987. Liskov misma lo explicó de la siguiente manera:

>"Lo que se busca aquí es algo similar a la siguiente propiedad de sustitución: si para cada objeto O1 de tipo S hay un objeto O2 de tipo T tal que, para todos los programas P definidos en términos de T, el comportamiento de P no cambia cuando se sustituye O1 por O2, entonces S es un subtipo de T."\
> — Barbara Liskov

Aunque este principio puede ser complicado de asimilar, en muchos sentidos, es simplemente una extensión del principio abierto-cerrado, ya que garantiza que las clases derivadas amplíen la clase base sin cambiar su comportamiento.

Aplicar este principio ayuda a evitar consecuencias inesperadas de los cambios y evita la necesidad de modificar una clase cerrada para realizar cambios. Conduce a extensiones fáciles del software y, aunque pueda ralentizar el proceso de desarrollo, seguir este principio durante el desarrollo puede prevenir muchos problemas durante las actualizaciones y extensiones.

## Tabla de Contenidos
- [La necesidad del LSP](#la-necesidad-del-lsp)
- [La compatibilidad de la interfaz](#la-compatibilidad-de-la-interfaz)
- [Comportamiento consistente](#comportamiento-consistente)  
- [No reducir la funcionalidad](#no-reducir-la-funcionalidad)
- [Postcondiciones más débiles o precondiciones más fuertes](#postcondiciones-más-débiles-o-precondiciones-más-fuertes)
- [Relación con otros principios SOLID](#relación-con-otros-principios-solid)
- [El principio LSP se puede entender y aplicar mediante los siguientes puntos](#el-principio-lsp-se-puede-entender-y-aplicar-mediante-los-siguientes-puntos)
- [Conclusión](#conclusión)

## La necesidad del LSP.

La necesidad del Principio de Sustitución de Liskov (LSP) surge debido a los desafíos inherentes que enfrentamos al diseñar jerarquías de clases en programación orientada a objetos. El LSP nos proporciona una serie de beneficios y garantías que son fundamentales para desarrollar software robusto y mantenible. A continuación, se detallan algunas de las razones que respaldan la necesidad del LSP:

1. **Consistencia en la jerarquía de clases:**
El LSP garantiza que las subclases sean coherentes y consistentes con la clase base. Si todas las subclases siguen el mismo contrato definido por la clase base, el comportamiento esperado es más predecible y fácil de mantener. Sin esta consistencia, sería complicado trabajar con diferentes clases en una jerarquía y podría llevar a resultados inesperados o errores difíciles de depurar.

2. **Polimorfismo y abstracción:**
El polimorfismo es una característica esencial de la programación orientada a objetos que nos permite tratar objetos de diferentes clases de manera uniforme, siempre y cuando cumplan con un contrato común (interfaz). El LSP es crucial para asegurar que el polimorfismo funcione correctamente, ya que garantiza que las subclases puedan ser usadas en lugar de la clase base sin comprometer la funcionalidad y sin afectar el comportamiento del código que depende de la clase base.

3. **Reutilización de código:**
Un objetivo importante del diseño orientado a objetos es la reutilización de código. Cuando las subclases cumplen con el LSP, pueden aprovechar el código de la clase base para realizar tareas comunes, lo que conduce a un código más limpio y eficiente. Si las subclases no siguen el LSP, es más difícil reutilizar el código y puede requerir una duplicación innecesaria, lo que a su vez aumenta la complejidad y el mantenimiento del código.

4. **Seguridad en la evolución del software:**
El software es una entidad en constante evolución, y las clases pueden ser extendidas o modificadas para satisfacer nuevos requisitos. Cuando se sigue el LSP, se puede estar seguro de que cualquier cambio en una subclase no afectará el funcionamiento de otras partes del programa que dependen de la clase base. Esto mejora la seguridad en la evolución del software y facilita la introducción de mejoras sin introducir errores inesperados.

5. **Facilita el trabajo en equipo:**
En proyectos de desarrollo de software, varios desarrolladores pueden trabajar simultáneamente en diferentes partes del código. Si todos siguen el LSP, pueden colaborar con mayor facilidad, ya que cada subclase se comporta de manera predecible y se puede confiar en que seguirán el contrato establecido por la clase base. Esto reduce los conflictos y las posibilidades de que se introduzcan errores en el código debido a inconsistencias.

6. **Pruebas unitarias más robustas:**
El LSP facilita la creación de pruebas unitarias más efectivas y robustas. Cuando las subclases siguen el contrato de la clase base, las pruebas diseñadas para la clase base pueden aplicarse automáticamente a todas las subclases. Esto ahorra tiempo en la creación de pruebas redundantes y garantiza que se cubra adecuadamente el comportamiento esperado en todos los casos.

### Resumen:
El Principio de Sustitución de Liskov es esencial para garantizar un diseño de software coherente, seguro y mantenible. Cumplir con el LSP proporciona beneficios como el polimorfismo efectivo, la reutilización de código, la consistencia en la jerarquía de clases y la facilidad de evolución del software. Es una herramienta poderosa para los diseñadores y desarrolladores de software que buscan construir sistemas sólidos y fiables.

## La compatibilidad de la interfaz

La compatibilidad de la interfaz es una parte fundamental del Principio de Sustitución de Liskov (LSP) y se refiere a la necesidad de que una clase derivada proporcione una interfaz que sea compatible con la clase base. Esto implica que la clase derivada debe implementar todos los métodos y propiedades definidos en la clase base y respetar sus contratos y precondiciones. Exploremos esto en detalle:

**1. Métodos y Propiedades de la Clase Base:**
Cuando una clase A es una subclase de una clase B, la clase A debe proporcionar todos los métodos y propiedades que son definidos en la clase B. Esto significa que cualquier método o propiedad que se espera encontrar en la clase B también debe estar presente en la clase A. Esto asegura que los clientes que utilizan la clase base puedan seguir utilizando la clase derivada sin problemas.

Por ejemplo, si tenemos una clase base Shape que tiene un método `calculateArea()` y una clase derivada `Circle` que hereda de `Shape`, entonces `Circle` debe implementar el método `calculateArea()`. Si `Circle` no implementa este método, violaría el LSP, ya que no sería compatible con la interfaz esperada de Shape.

**2. Contratos y Precondiciones:**
Una clase base puede tener ciertas expectativas sobre los valores de entrada o el estado antes de que se invoque un método. Estas expectativas se conocen como precondiciones. Una clase derivada debe respetar estas precondiciones y cumplir con los contratos establecidos por la clase base.

Por ejemplo, si tenemos una clase base `TemperatureConverter` que tiene un método `convertToCelsius()` que espera recibir una temperatura en grados Fahrenheit, la clase derivada `CelsiusConverter` debe cumplir con esta expectativa y también aceptar temperaturas en grados Fahrenheit como entrada. Si `CelsiusConverter` no puede manejar estas entradas, no sería compatible con la interfaz de `TemperatureConverter`.

**3. Respetar la Semántica de los Métodos:**
Una clase derivada debe mantener la semántica y el propósito de los métodos definidos en la clase base. Esto significa que el comportamiento y los resultados de los métodos en la clase derivada deben ser consistentes con lo que se espera en la clase base.

Por ejemplo, si tenemos una clase base `Animal` con un método `makeSound()` que devuelve un sonido característico del animal, la clase derivada `Cat` que hereda de `Animal` debe devolver el sonido "Miau" en su implementación de `makeSound()`. Si la clase `Cat` devuelve un sonido diferente o no devuelve ningún sonido, no sería compatible con la interfaz de `Animal`.

### Resumen:
La compatibilidad de la interfaz es crucial para cumplir con el Principio de Sustitución de Liskov y garantizar que las clases derivadas sean realmente sustituibles por las clases base. Al respetar las expectativas y contratos establecidos por la clase base, se crea un diseño coherente y sólido que facilita el uso y mantenimiento del código en el futuro.

## Comportamiento consistente
Otro aspecto importante del Principio de Sustitución de Liskov (LSP) es que el comportamiento debe ser consistente. Implica que los métodos en una clase derivada deben mantener el mismo comportamiento esperado que los definidos en la clase base. Veamos una expansión técnica y detallada de este concepto:

**1. Preservación de Invariantes:**
Una clase base puede tener invariantes, que son condiciones que deben ser siempre verdaderas antes y después de que un método sea invocado. Cuando una clase derivada hereda de la clase base, debe asegurarse de que estos invariantes sigan siendo válidos para mantener la consistencia del comportamiento.

Por ejemplo, si tenemos una clase base `BankAccount` con un atributo `balance` y un método `withdraw()` que no permite que el balance sea negativo, una clase derivada `SavingsAccount` no debe violar esta restricción. Si `SavingsAccount` permite un balance negativo después de invocar `withdraw()`, el comportamiento no sería consistente con la clase base.

**2. Cumplimiento de Contratos:**
Una clase base puede definir contratos que establecen ciertas condiciones para la correcta ejecución de sus métodos. Estos contratos incluyen precondiciones, que son condiciones que deben cumplirse antes de invocar un método, y postcondiciones, que son condiciones que deben cumplirse después de que un método se haya ejecutado.

La clase derivada debe mantener el cumplimiento de estos contratos y garantizar que las precondiciones y postcondiciones definidas por la clase base sigan siendo válidas en la clase derivada.

**3. Evitar Efectos Secundarios Inesperados:**
El comportamiento de los métodos en la clase derivada no debe introducir efectos secundarios inesperados que no estén presentes en la clase base. Un efecto secundario es cualquier cambio en el estado del sistema que no esté directamente relacionado con la funcionalidad del método.

Por ejemplo, si una clase base `FileWriter` tiene un método `writeToFile()` que solo escribe en un archivo, una clase derivada `EncryptedFileWriter` que hereda de `FileWriter` no debe, además de escribir en el archivo, cambiar el formato del archivo o eliminar otros archivos del sistema. Estos efectos secundarios adicionales introducirían comportamiento inconsistente con la clase base.

**4. No Limitar el Comportamiento Esperado:**
La clase derivada no debe limitar ni restringir el comportamiento que se espera de la clase base. Esto significa que el comportamiento de la clase base debe ser una "versión extendida" del comportamiento de la clase derivada, en lugar de una versión reducida.

Por ejemplo, si tenemos una clase base `Vehicle` con un método `startEngine()`, una clase derivada `Car` no debe eliminar la funcionalidad de `startEngine()` y hacer que no haga nada. En cambio, `Car` puede extender el método para agregar comportamiento específico relacionado con los motores de los automóviles.

### Resumen:
El Principio de Sustitución de Liskov asegura que las clases derivadas se comporten de manera coherente con las clases base. Cumplir con este principio garantiza una relación de herencia sólida y evita resultados inesperados o indeseables cuando se sustituye una clase base con una clase derivada. Al mantener la consistencia del comportamiento, se fomenta la confianza en la reutilización de código y se construye un diseño de software más confiable y mantenible.

## No reducir la funcionalidad
Otra faceta esencial del Principio de Sustitución de Liskov (LSP) es no reducir la funcionalidad. Esta regla dicta que una clase derivada no debe eliminar ni restringir la funcionalidad proporcionada por la clase base. La idea detrás de este principio es que una clase derivada debe ser una extensión de la clase base, proporcionando funcionalidad adicional sin perder la funcionalidad existente. Ahora, profundicemos en los aspectos técnicos y detallados de este concepto:

**1. Cumplimiento de Contratos:**
La funcionalidad proporcionada por la clase base a menudo se define mediante contratos, que especifican las precondiciones y postcondiciones que los métodos deben cumplir. La clase derivada debe respetar estos contratos y no eliminar ninguna de las precondiciones o restricciones impuestas por la clase base.

Por ejemplo, si tenemos una clase base `Animal` con un método `eat()` que asegura que el animal debe recibir una comida como parámetro, una clase derivada `Dog` no debe eliminar esta restricción y permitir que el método `eat()` se llame sin ningún parámetro. Esto restringiría la funcionalidad esperada de `eat()` y violaría el LSP.

**2. Extensión de Funcionalidad:**
La clase derivada puede extender la funcionalidad de la clase base agregando nuevos métodos o comportamientos, siempre y cuando mantenga todas las características de la clase base intactas. La adición de nuevos métodos debe ser compatible y coherente con el propósito general de la clase base.

Por ejemplo, si tenemos una clase base `Shape` con un método `calculateArea()` y una clase derivada `Rectangle` que hereda de `Shape`, `Rectangle` puede agregar un método adicional como `calculatePerimeter()` para calcular el perímetro. Esto no reduce la funcionalidad de `Shape`, sino que la amplía para adaptarse a las necesidades específicas de `Rectangle`.

**3. No Eliminar Métodos o Propiedades Importantes:**
La clase derivada no debe eliminar métodos o propiedades importantes que son esenciales para la funcionalidad y el comportamiento general de la clase base. Si la clase derivada elimina métodos o propiedades, los clientes que esperan utilizar esos métodos o propiedades en la clase base se verán afectados negativamente.

Por ejemplo, si tenemos una clase base `Vehicle` con un método `startEngine()`, una clase derivada `Bicycle` no debe eliminar este método solo porque las bicicletas no tienen motores. En su lugar, `Bicycle` puede implementar `startEngine()` de manera que indique que no se puede arrancar el motor, pero se puede activar otra característica relevante.

**4. Cumplimiento de Contratos de Interfaz:**
En lenguajes de programación que admiten interfaces o clases abstractas, la clase derivada debe cumplir con el contrato de la interfaz definido por la clase base. Esto incluye la implementación de todos los métodos declarados en la interfaz con el comportamiento apropiado.

### Resumen:
En resumen, "no reducir la funcionalidad" en el contexto del LSP enfatiza la importancia de mantener la integridad de la funcionalidad proporcionada por la clase base al diseñar clases derivadas. Al seguir este principio, garantizamos que las clases derivadas sean capaces de reemplazar las clases base de manera transparente, sin sacrificar características cruciales y sin afectar la interoperabilidad y la coherencia del código. El cumplimiento de este principio conduce a un diseño de software más sólido y confiable.

## Postcondiciones más débiles o precondiciones más fuertes
Este principio permite que una clase derivada relaje las restricciones de las postcondiciones o aumente las restricciones de las precondiciones en comparación con la clase base. A continuación, exploraremos en detalle este concepto técnico:

**1. Postcondiciones más débiles:**
Las postcondiciones se refieren a las condiciones que deben cumplirse después de la ejecución de un método. Una clase derivada puede establecer postcondiciones más débiles, lo que significa que el resultado o el estado después de invocar un método puede ser menos restrictivo que en la clase base.

Por ejemplo, si tenemos una clase base `Calculator` con un método `divide()` que tiene una postcondición que el resultado no debe ser igual a cero, una clase derivada `AdvancedCalculator` podría relajar esta postcondición permitiendo que el resultado sea cero en algunos casos especiales, como la división entre cero por cero.

**2. Precondiciones más fuertes:**
Las precondiciones son condiciones que deben cumplirse antes de invocar un método. Una clase derivada puede establecer precondiciones más fuertes, lo que significa que requiere condiciones más estrictas antes de permitir que un método sea invocado.

Por ejemplo, si tenemos una clase base `TemperatureConverter` con un método `convertToCelsius()` que acepta cualquier valor numérico como entrada, una clase derivada `StrictTemperatureConverter` podría establecer precondiciones más fuertes, como aceptar solo valores positivos, para evitar problemas con valores no válidos.

**3. Mantener Compatibilidad con la Interfaz:**
Es esencial que las postcondiciones más débiles o las precondiciones más fuertes de la clase derivada sigan siendo compatibles con las expectativas de la clase base y respeten el contrato establecido por la clase base. Si los clientes de la clase base asumen ciertas condiciones antes o después de llamar a un método, la clase derivada debe mantener estas expectativas.

**4. Cautela con Precondiciones más Fuertes:**
Si una clase derivada establece precondiciones más fuertes, debe asegurarse de que los clientes cumplan con estas condiciones antes de invocar los métodos. Esto podría requerir una validación adicional de los datos de entrada por parte de los clientes para cumplir con las nuevas restricciones impuestas por la clase derivada.

### Resumen:
Permitir postcondiciones más débiles o precondiciones más fuertes en la clase derivada ofrece cierta flexibilidad y adaptabilidad en el diseño de la jerarquía de clases. Sin embargo, es importante ejercer precaución al relajar o fortalecer las condiciones para asegurarse de que no se produzcan violaciones en el comportamiento esperado y que los clientes puedan interactuar correctamente con la clase derivada. El objetivo es permitir una mayor especialización en las clases derivadas sin comprometer la coherencia y la compatibilidad con la clase base.

## Relación con otros principios SOLID
A continuación, exploraremos la relación del LSP con los otros principios SOLID:

**1. Principio de Responsabilidad Única (SRP):**
El SRP establece que una clase debe tener una sola razón para cambiar, es decir, debe tener una sola responsabilidad en el sistema. El LSP complementa el SRP al garantizar que las clases derivadas, al reemplazar a las clases base, mantengan la responsabilidad y el comportamiento esperados de la clase base. Si una clase derivada viola el LSP y cambia el comportamiento fundamental de la clase base, es probable que también esté violando el SRP.

**2. Principio de Abierto/Cerrado (OCP):**
El OCP propone que las entidades de software (clases, módulos, etc.) deben estar abiertas para la extensión pero cerradas para la modificación. El LSP facilita la extensibilidad de las clases al permitir que las clases derivadas añadan nueva funcionalidad sin modificar el comportamiento de la clase base. Si se sigue el LSP, las clases derivadas pueden ser introducidas en el sistema sin romper el código existente que depende de las clases base.

**3. Principio de Inversión de Dependencias (DIP):**
El DIP establece que las clases de alto nivel no deben depender de clases de bajo nivel directamente, sino que deben depender de abstracciones. El LSP juega un papel clave en el DIP, ya que asegura que las clases derivadas sean reemplazables por sus clases base mediante el uso de polimorfismo y abstracciones. De esta manera, el DIP se beneficia del LSP al permitir la sustitución de implementaciones concretas por interfaces o clases base, lo que fomenta la flexibilidad y la reutilización del código.

**5. Principio de Segregación de Interfaces (ISP):**
El ISP propone que una clase no debe verse obligada a depender de interfaces que no utiliza. El LSP es relevante en el ISP al garantizar que las clases derivadas no hereden métodos o funcionalidades innecesarias de la clase base. Al mantener la compatibilidad de la interfaz, el LSP contribuye a la segregación de interfaces y evita la imposición de métodos no utilizados a las clases derivadas.

## El principio LSP se puede entender y aplicar mediante los siguientes puntos

Exactamente, el Principio de Sustitución de Liskov (LSP) se puede entender y aplicar mediante los siguientes puntos clave:

**1. Relación ISA (Herencia):**
El LSP se aplica en el contexto de la herencia entre clases. Si una clase A es una subclase de una clase B, entonces debe cumplir con el principio de sustitución, lo que significa que los objetos de la clase B deben poder ser reemplazados por objetos de la clase A sin afectar la funcionalidad y comportamiento esperados del programa.

**2. Compatibilidad de la Interfaz:**
La clase derivada (clase A) debe proporcionar una interfaz que sea compatible con la clase base (clase B). Esto implica que la clase A debe implementar todos los métodos y propiedades definidos en la clase B, respetando sus contratos y precondiciones. De esta manera, los clientes que dependen de la clase B pueden utilizar la clase A sin problemas.

**3. Coherencia de Comportamiento:**
El comportamiento de los métodos en la clase derivada debe ser coherente con el comportamiento esperado definido en la clase base. Esto implica que los resultados de los métodos deben seguir siendo consistentes y acordes con las expectativas de la clase base. El comportamiento no debe sorprender ni introducir efectos secundarios inesperados.

**4. No Reducir la Funcionalidad:**
La clase derivada no debe eliminar ni restringir la funcionalidad proporcionada por la clase base. Debe ser una extensión de la clase base, agregando funcionalidad adicional sin perder las características esenciales de la clase base. Si una clase derivada elimina métodos o propiedades importantes, los clientes que esperan utilizarlos en la clase base se verán afectados negativamente.

**5. Postcondiciones más Débiles o Precondiciones más Fuertes:**
La clase derivada puede establecer postcondiciones más débiles o precondiciones más fuertes que la clase base. Las postcondiciones más débiles permiten resultados menos restrictivos después de invocar un método, mientras que las precondiciones más fuertes requieren condiciones más estrictas antes de invocar un método. Sin embargo, estas nuevas condiciones deben mantener la coherencia con el comportamiento esperado y las expectativas de la clase base.

Aplicar estos puntos clave en el diseño y la implementación de clases y jerarquías de herencia permite que el código sea más flexible, reutilizable y mantenible. El cumplimiento del LSP garantiza que las clases derivadas sean sustituibles de manera transparente por las clases base, facilitando la evolución y extensión del software sin romper la funcionalidad existente.

## Conclusión
Cumplir con el Principio de Sustitución de Liskov garantiza que el sistema sea más flexible y extensible. Si se sigue este principio, se puede confiar en que las clases derivadas pueden ser usadas de manera intercambiable con las clases base, lo que facilita el mantenimiento y la evolución del software sin afectar su funcionalidad. Además, la aplicación del LSP promueve un mejor diseño de la jerarquía de clases y ayuda a evitar problemas comunes como el acoplamiento excesivo y la duplicación de código.
