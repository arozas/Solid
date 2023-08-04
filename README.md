<h1 align="center">PRINCIPIOS S.O.L.I.D.</h1>

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/SOLID%20TITILE.png" alt="SOLID img">
</p>

>"Los buenos sistemas de software comienzan con un código limpio. Por un lado, si los ladrillos no están bien hechos, la arquitectura del edificio no importa mucho. Por otro lado, puedes hacer un gran desorden con ladrillos bien hechos. Aquí es donde entran en juego los principios SOLID."\
> — Robert C. Martin

## Tabla de Contenidos
- [Resumen](#resumen)
- [Principio de Responsabilidad Única (Single Responsibility Principle - SRP)](#)
- [Principio de Abierto/Cerrado (Open/Closed Principle - OCP)](#)
- [Principio de Sustitución de Liskov (Liskov Substitution Principle - LSP)](#)
- [Principio de Segregación de Interfaces (Interface Segregation Principle - ISP)](#)
- [Principio de Inversión de Dependencia (Dependency Inversion Principle - DIP)](#)
- [Licencia](#licencia)
  
## Resumen
Los principios SOLID fueron concebidos por **Robert C. Martin**, conocido en la industria como uncle Bob (El tío Bob), en un ensayo del año 2000 titulado **"Principios de Diseño y Patrones de Diseño"**, aunque el acrónimo fue acuñado más tarde por **Michael Feathers**. En su ensayo, Martin destacó la importancia de la evolución y el cambio en el software exitoso. A medida que un sistema evoluciona, tiende a volverse más complejo. Sin embargo, Martin advirtió que sin buenos principios de diseño, el software puede volverse rígido, frágil, inmóvil y difícil de modificar. Los principios SOLID surgieron como una solución para abordar estos patrones de diseño problemáticos.

Los principios SOLID son un conjunto de cinco pautas de diseño de software que fueron introducidas por el ingeniero de software Robert C. Martin. Estos principios se centran en la escritura de código limpio, mantenible y extensible, y son ampliamente considerados como fundamentales para la ingeniería de software orientada a objetos. Cada principio aborda una faceta específica del diseño de software y, en conjunto, buscan mejorar la calidad y la flexibilidad de los sistemas de software.

Estos principios son:

Principio de Responsabilidad Única (Single Responsibility Principle - SRP):
Cada clase o módulo debe tener una única responsabilidad. Esto implica que una clase debe tener una razón para cambiar y solo una, lo que mejora la cohesión y facilita la comprensión y el mantenimiento del código.

Principio de Abierto/Cerrado (Open/Closed Principle - OCP):
Las entidades del software (clases, módulos, funciones) deben estar abiertas para su extensión pero cerradas para su modificación. En otras palabras, se deben poder agregar nuevas funcionalidades sin modificar el código existente.

Principio de Sustitución de Liskov (Liskov Substitution Principle - LSP):
Las clases derivadas deben poder sustituir a sus clases base sin afectar la funcionalidad esperada del programa. Esto asegura la consistencia y coherencia en el comportamiento de las clases.

Principio de Segregación de Interfaces (Interface Segregation Principle - ISP):
Un cliente no debe verse obligado a depender de interfaces que no utiliza. En lugar de tener interfaces monolíticas, es mejor tener interfaces más pequeñas y específicas para cada cliente.

Principio de Inversión de Dependencia (Dependency Inversion Principle - DIP):
Los módulos de alto nivel no deben depender de módulos de bajo nivel. Ambos deben depender de abstracciones. Además, las abstracciones no deben depender de los detalles, sino que los detalles deben depender de las abstracciones.

## Licencia
Este proyecto está bajo la licencia [MIT](LICENSE).
