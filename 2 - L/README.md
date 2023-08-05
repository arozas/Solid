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
- [Cerrado para modificación](#cerrado-para-modificación)  
- [Abierto para extensión](#abierto-para-extensión)
- [Relación con otros principios SOLID](#relación-con-otros-principios-solid)
- [El principio OCP se puede entender y aplicar mediante los siguientes puntos](#el-principio-ocp-se-puede-entender-y-aplicar-mediante-los-siguientes-puntos)
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

### 1. Métodos y Propiedades de la Clase Base:
Cuando una clase A es una subclase de una clase B, la clase A debe proporcionar todos los métodos y propiedades que son definidos en la clase B. Esto significa que cualquier método o propiedad que se espera encontrar en la clase B también debe estar presente en la clase A. Esto asegura que los clientes que utilizan la clase base puedan seguir utilizando la clase derivada sin problemas.

Por ejemplo, si tenemos una clase base Shape que tiene un método calculateArea() y una clase derivada Circle que hereda de Shape, entonces Circle debe implementar el método calculateArea(). Si Circle no implementa este método, violaría el LSP, ya que no sería compatible con la interfaz esperada de Shape.

### 2. Contratos y Precondiciones:
Una clase base puede tener ciertas expectativas sobre los valores de entrada o el estado antes de que se invoque un método. Estas expectativas se conocen como precondiciones. Una clase derivada debe respetar estas precondiciones y cumplir con los contratos establecidos por la clase base.

Por ejemplo, si tenemos una clase base TemperatureConverter que tiene un método convertToCelsius() que espera recibir una temperatura en grados Fahrenheit, la clase derivada CelsiusConverter debe cumplir con esta expectativa y también aceptar temperaturas en grados Fahrenheit como entrada. Si CelsiusConverter no puede manejar estas entradas, no sería compatible con la interfaz de TemperatureConverter.

### 3. Respetar la Semántica de los Métodos:
Una clase derivada debe mantener la semántica y el propósito de los métodos definidos en la clase base. Esto significa que el comportamiento y los resultados de los métodos en la clase derivada deben ser consistentes con lo que se espera en la clase base.

Por ejemplo, si tenemos una clase base Animal con un método makeSound() que devuelve un sonido característico del animal, la clase derivada Cat que hereda de Animal debe devolver el sonido "Miau" en su implementación de makeSound(). Si la clase Cat devuelve un sonido diferente o no devuelve ningún sonido, no sería compatible con la interfaz de Animal.

### Resumen:
La compatibilidad de la interfaz es crucial para cumplir con el Principio de Sustitución de Liskov y garantizar que las clases derivadas sean realmente sustituibles por las clases base. Al respetar las expectativas y contratos establecidos por la clase base, se crea un diseño coherente y sólido que facilita el uso y mantenimiento del código en el futuro.

## Cerrado para modificación

Una vez que un componente de software ha sido desarrollado, probado y puesto en producción, su comportamiento y lógica interna no deben ser modificados directamente para incorporar nuevos requisitos o cambios en el sistema. Esta es otra parte esencial del OCP y se basa en la premisa de que cambiar el código existente puede introducir errores, afectar la estabilidad del sistema y crear efectos secundarios no deseados.

Para lograr el "cerrado para modificación" en OCP, es importante seguir ciertas prácticas y principios de diseño que eviten la necesidad de cambiar el código existente:

1. **Interfaces estables:** Las interfaces, que definen la forma en que se comunican diferentes componentes del sistema, deben ser diseñadas cuidadosamente y mantenerse estables. Esto significa que una vez que una interfaz ha sido establecida y utilizada por otras partes del sistema, no debe cambiar su firma o comportamiento. Si las interfaces cambian constantemente, las clases que las implementan se verán afectadas y requerirán modificaciones, lo que contradice el "cerrado para modificación".


2. **Encapsulación y ocultamiento de información:** Un principio importante en el desarrollo de software es la encapsulación, que implica ocultar los detalles internos de una clase y proporcionar una interfaz pública coherente y estable. Al mantener la información oculta y proporcionar métodos de acceso controlado, se evita la necesidad de cambiar el código existente que depende de esa clase interna.


3. **Uso de clases y módulos bien definidos:** Dividir el sistema en clases y módulos cohesivos y bien definidos facilita el "cerrado para modificación". Si una clase o módulo tiene una única responsabilidad y no tiene acoplamiento innecesario con otras partes del sistema, será menos probable que un cambio en una parte afecte a otras partes.


4. **Pruebas unitarias:** La implementación de pruebas unitarias sólidas permite detectar errores antes de que el código entre en producción. Al asegurarse de que el código existente funcione correctamente antes de introducir nuevos cambios, se reduce el riesgo de introducir errores mediante modificaciones directas.


5. **Versionado y control de código:** Utilizar sistemas de control de versiones, como Git, permite rastrear cambios y revertir modificaciones si es necesario. También se pueden usar etiquetas y ramas para gestionar diferentes versiones del software, lo que ayuda a mantener el "cerrado para modificación" en las versiones estables.

### Resumen:
El Principio de Abierto-Cerrado implica mantener la estabilidad del código existente y evitar cambios directos en su lógica y comportamiento. Al seguir prácticas de diseño sólidas, utilizar interfaces estables, encapsulación adecuada y pruebas unitarias, los desarrolladores pueden asegurarse de que el software se mantenga confiable y estable con el tiempo, lo que facilita la extensión sin comprometer la integridad del sistema.

## Abierto para extensión:

Un componente de software debe permitir la incorporación de nuevas funcionalidades o características sin requerir cambios en el código existente de dicho componente. La idea es que el software pueda evolucionar y adaptarse a nuevos requisitos o escenarios sin modificar su comportamiento previo, lo que facilita la extensión sin afectar la estabilidad y funcionalidad existentes.

Para lograr el "abierto para extensión" en OCP, es necesario seguir ciertas prácticas y principios de diseño que faciliten la incorporación de nuevas funcionalidades:

1. **Interfaces bien definidas**: Definir interfaces claras y estables es fundamental para permitir la extensión en OCP. Las interfaces actúan como contratos que especifican qué métodos deben implementar las clases que las implementan. Al programar en términos de interfaces, en lugar de implementaciones concretas, se pueden agregar nuevas implementaciones para extender el comportamiento del sistema sin afectar las partes existentes.

2. **Clases o módulos cohesivos**: Es importante diseñar clases o módulos que tengan una única responsabilidad y sean cohesivos. De esta manera, cuando se necesite agregar una nueva funcionalidad, se puede crear una nueva clase o módulo que cumpla con esa responsabilidad adicional, sin afectar las clases ya existentes.

3. **Herencia y polimorfismo**: El uso de herencia y polimorfismo es esencial para permitir la extensión en OCP. Al heredar de clases base o implementar interfaces comunes, es posible agregar nuevas clases que se ajusten a la estructura del sistema y puedan ser utilizadas en lugar de las clases base, aprovechando el polimorfismo para mantener la coherencia en el código existente.

4. **Patrones de diseño**: Algunos patrones de diseño, como el patrón Strategy o el patrón Decorator, son especialmente útiles para permitir la extensión en OCP. Por ejemplo, el patrón Strategy permite cambiar el comportamiento de un objeto en tiempo de ejecución al intercambiar la estrategia asociada.

5. **Inyección de dependencias**: La inyección de dependencias es otra técnica que facilita la extensión en OCP. Permite proporcionar dependencias externas a una clase en lugar de que la clase las cree internamente. De esta manera, se pueden reemplazar las dependencias con otras nuevas para extender el comportamiento sin modificar el código existente.

### Resumen:
En resumen, el "abierto para extensión" en el Principio de Abierto-Cerrado se refiere a la capacidad de agregar nuevas funcionalidades al software sin modificar el código existente. Al seguir prácticas de diseño sólidas, utilizar interfaces, clases o módulos cohesivos, herencia, polimorfismo, patrones de diseño y la inyección de dependencias, los desarrolladores pueden diseñar sistemas de software flexibles y extensibles que puedan adaptarse a los cambios futuros sin comprometer la estabilidad y funcionalidad existentes. Esto facilita la evolución y mantenimiento del software a lo largo del tiempo.

## Relación con otros principios SOLID

A continuación, se explora la relación del OCP con los otros principios SOLID:

- Principio de Responsabilidad Única (Single Responsibility Principle, SRP):
El SRP establece que una clase debe tener una única responsabilidad y motivo para cambiar. La relación con el OCP radica en que, al seguir el SRP, una clase tiene menos razones para cambiar, lo que facilita el "cerrado para modificación" del OCP. Cuando una clase tiene una única responsabilidad y cambia solo por motivos relacionados con esa responsabilidad, es menos probable que necesite modificaciones directas para incorporar nuevas funcionalidades.

- Principio de Sustitución de Liskov (Liskov Substitution Principle, LSP):
El LSP establece que los objetos de una clase derivada deben poder reemplazar a los objetos de la clase base sin afectar la correctitud del programa. La relación con el OCP es que, al seguir el LSP, se pueden agregar nuevas clases derivadas para extender el comportamiento del sistema, permitiendo la "extensión" sin afectar el código existente.

- Principio de Segregación de Interfaces (Interface Segregation Principle, ISP):
El ISP establece que una clase no debe depender de interfaces que no utiliza. La relación con el OCP es que, al adherirse al ISP, se evita la dependencia innecesaria y se facilita la "extensión" en OCP. Si una clase solo depende de las interfaces que necesita y no de otras interfaces irrelevantes, agregar nuevas implementaciones de interfaces para extender el comportamiento se vuelve más sencillo.

- Principio de Inversión de Dependencias (Dependency Inversion Principle, DIP):
El DIP establece que los módulos de alto nivel no deben depender de los módulos de bajo nivel, sino de abstracciones. La relación con el OCP es que el DIP facilita el "abierto para extensión" en OCP. Al depender de abstracciones en lugar de implementaciones concretas, es más fácil agregar nuevas implementaciones sin modificar el código de alto nivel.

## El principio OCP se puede entender y aplicar mediante los siguientes puntos

### Identificación de extensiones potenciales:
Para aplicar el OCP, es crucial identificar las áreas del código que pueden requerir extensiones en el futuro. Esto implica analizar los requisitos cambiantes o nuevas funcionalidades que podrían ser necesarias. Una vez que se han identificado estas extensiones potenciales, es posible diseñar el código de manera que permita agregar estas funcionalidades sin modificar el código existente.

### Utilización de interfaces y abstracciones:
Una de las principales técnicas para lograr el OCP es utilizar interfaces y abstracciones en lugar de depender de implementaciones concretas. Al programar en términos de interfaces, se puede agregar nueva funcionalidad creando nuevas clases que implementen esas interfaces sin afectar el código existente. Esto permite extender el comportamiento del sistema sin cambiar las clases ya establecidas.

### Empleo de patrones de diseño:
La aplicación de patrones de diseño también puede facilitar el cumplimiento del OCP. Por ejemplo, el patrón Strategy permite cambiar el comportamiento de un objeto en tiempo de ejecución mediante la sustitución de estrategias. De esta manera, se pueden agregar nuevas estrategias sin modificar el código existente, lo que favorece la extensibilidad.

### Separación de preocupaciones:
Otra técnica para adherirse al OCP es dividir las responsabilidades y funcionalidades en clases o módulos cohesivos y separados. Al mantener cada clase enfocada en una única responsabilidad, se puede extender el sistema agregando nuevas clases o módulos sin afectar los existentes. La separación de preocupaciones reduce la posibilidad de cambios no deseados y efectos secundarios.

### Utilización de herencia y polimorfismo:
El uso adecuado de la herencia y el polimorfismo también contribuye al cumplimiento del OCP. Al heredar de clases base o implementar interfaces comunes, se pueden agregar nuevas clases que se ajusten a la estructura del sistema existente. Esto permite extender el sistema sin modificar el código base y favorece la coherencia y flexibilidad del diseño.

### Cumplimiento del DIP:
El Principio de Inversión de Dependencias (DIP) está estrechamente relacionado con el OCP. Al depender de abstracciones y no de implementaciones concretas, se facilita la extensión y se evita la necesidad de modificar el código existente al agregar nuevas funcionalidades.

## Conclusión

El OCP es un principio importante de SOLID que establece que un componente de software debe estar abierto para la extensión pero cerrado para la modificación. Para aplicar el OCP de manera efectiva, se deben identificar las áreas que pueden requerir extensiones en el futuro, utilizar interfaces y abstracciones, emplear patrones de diseño adecuados y separar las preocupaciones en clases cohesivas.

Al seguir el OCP, se crea un diseño de software más flexible, mantenible y extensible, lo que permite adaptarse a cambios futuros sin afectar el funcionamiento previo. Al relacionarse con otros principios SOLID, el OCP se convierte en una parte esencial para lograr una arquitectura de software sólida y de alta calidad.
