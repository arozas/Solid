<h1 align="center">PRINCIPIOS S.O.L.I.D.</h1>

<p align="center">
  <img src="https://github.com/arozas/Solid/blob/main/img/SOLID%20TITILE.png" alt="SOLID img">
</p>

>"Los buenos sistemas de software comienzan con un código limpio. Por un lado, si los ladrillos no están bien hechos, la arquitectura del edificio no importa mucho. Por otro lado, puedes hacer un gran desorden con ladrillos bien hechos. Aquí es donde entran en juego los principios SOLID."\
> — Robert C. Martin

## Tabla de Contenidos
- [Resumen](#resumen)
- [Objetivo](#objetivo)
- [Criticas](#criticas)
- [Descripición de cada principio](#descripición-de-cada-principio)
- [Licencia](#licencia)
  
## Resumen
Los principios SOLID fueron concebidos por **Robert C. Martin**, conocido en la industria como uncle Bob (El tío Bob), en un ensayo del año 2000 titulado **"Principios de Diseño y Patrones de Diseño"**, aunque el acrónimo fue acuñado más tarde por **Michael Feathers**. En su ensayo, Martin destacó la importancia de la evolución y el cambio en el software exitoso. A medida que un sistema evoluciona, tiende a volverse más complejo. Sin embargo, Martin advirtió que sin buenos principios de diseño, el software puede volverse rígido, frágil, inmóvil y difícil de modificar. Los principios SOLID surgieron como una solución para abordar estos patrones de diseño problemáticos.

Los principios SOLID son un conjunto de cinco pautas de diseño de software que fueron introducidas por el ingeniero de software Robert C. Martin. Estos principios se centran en la escritura de código limpio, mantenible y extensible, y son ampliamente considerados como fundamentales para la ingeniería de software orientada a objetos. Cada principio aborda una faceta específica del diseño de software y, en conjunto, buscan mejorar la calidad y la flexibilidad de los sistemas de software.

## Objetivo
La idea principal de este repositorio es explicar de manera técnica y detallada los principios SOLID. Sin embargo, para no limitarnos únicamente al marco teórico, también planteamos problemas de diseño que estos principios abarcan e implementamos las soluciones propuestas por ellos.

Tanto los problemas como las soluciones están desarrollados en **C#** para facilitar la visualización y comprensión de lo que se está planteando. Cada principio cuenta con una carpeta en este repositorio con un archivo readme que explica el marco teórico en detalle. Además, hay dos carpetas adicionales para cada principio, una con un problema y otra con la solución correspondiente, ambas con sus respectivos readme que detallan las ventajas de aplicar dicho principio y las desventajas de no hacerlo.

Considero que aprender los fundamentos de los principios **SOLID** es esencial para el desarrollo de nuestra carrera como programadores. Aunque se les llama principios y son definidos por **Robert C. Martin** como proposiciones o verdades fundamentales que rigen el diseño de software, creo que en una profesión tan dinámica como la programación, donde los avances son constantes, es prudente considerarlos como prácticas comunes con un amplio consenso en el sector. Nuestro trabajo como programadores y desarrolladores también implica una investigación constante que nos permita encontrar nuevas soluciones. **Robert C. Martin** no declaró el fin de la historia con estos principios, sino que nos proporcionó una herramienta adicional para resolver de manera eficiente los problemas comunes en nuestras tareas cotidianas en el mundo del desarrollo.

## Criticas
A pesar de que los principios SOLID han sido ampliamente aceptados y utilizados como guías para el diseño de software, también han sido objeto de algunas críticas y debates en la comunidad técnica y profesional. Algunas de las críticas más comunes incluyen:

**Sobrediseño (Over-engineering):** Aplicar los principios SOLID de manera excesiva puede llevar a una mayor complejidad y costos innecesarios, especialmente en proyectos pequeños o de corta duración.

**Rigidez (Rigidity):** Interpretaciones estrictas del principio "cerrado para modificación" (Open/Closed Principle) pueden resultar en estructuras complejas que dificultan la incorporación de cambios reales.

**Dificultad para aprender:** Para los desarrolladores menos experimentados, aplicar los principios SOLID puede ser un desafío y aumentar la curva de aprendizaje, llevando a diseños innecesariamente complejos o malinterpretaciones de los principios.

**Tendencia a la jerarquía:** El Principio de Sustitución de Liskov (Liskov Substitution Principle) puede dar lugar a jerarquías de clases innecesariamente complejas, creando una estructura de herencia difícil de mantener.

**Interfaz segregada excesivamente:** Aplicar el Principio de Segregación de Interfaces (Interface Segregation Principle) de manera extrema puede resultar en muchas interfaces pequeñas y específicas, lo que aumenta la complejidad y dificulta la gestión.

Es importante recordar que los principios SOLID son directrices y no reglas rígidas. Cada proyecto y equipo de desarrollo es diferente, y la aplicación de estos principios debe ser equilibrada según las necesidades y el contexto específico. Algunas críticas pueden surgir de una mala interpretación o aplicación excesiva de los principios, por lo que es esencial considerar el contexto y el juicio profesional al aplicarlos.

## Descripición de cada principio.

### [Principio de Responsabilidad Única (Single Responsibility Principle - SRP)](https://github.com/arozas/Solid/tree/main/0%20-%20S)

Cada clase o módulo debe tener una única responsabilidad. Esto implica que una clase debe tener una razón para cambiar y solo una, lo que mejora la cohesión y facilita la comprensión y el mantenimiento del código.

-[El problema que ataca](https://github.com/arozas/Solid/tree/main/0%20-%20S/Problem)

-[La solución que propone](https://github.com/arozas/Solid/tree/main/0%20-%20S/Solution)

### [Principio de Abierto/Cerrado (Open/Closed Principle - OCP)](https://github.com/arozas/Solid/tree/main/1%20-%20O)
Las entidades del software (clases, módulos, funciones) deben estar abiertas para su extensión pero cerradas para su modificación. En otras palabras, se deben poder agregar nuevas funcionalidades sin modificar el código existente.

-[El problema que ataca](https://github.com/arozas/Solid/tree/main/1%20-%20O/Problem)

-[La solución que propone](https://github.com/arozas/Solid/tree/main/1%20-%20O/Solution)

### [Principio de Sustitución de Liskov (Liskov Substitution Principle - LSP)](https://github.com/arozas/Solid/tree/main/2%20-%20L)
Las clases derivadas deben poder sustituir a sus clases base sin afectar la funcionalidad esperada del programa. Esto asegura la consistencia y coherencia en el comportamiento de las clases.

-[El problema que ataca](#)

-[La solución que propone](#)

### Principio de Segregación de Interfaces (Interface Segregation Principle - ISP):
Un cliente no debe verse obligado a depender de interfaces que no utiliza. En lugar de tener interfaces monolíticas, es mejor tener interfaces más pequeñas y específicas para cada cliente.

-[El problema que ataca](#)

-[La solución que propone](#)

### Principio de Inversión de Dependencia (Dependency Inversion Principle - DIP):
Los módulos de alto nivel no deben depender de módulos de bajo nivel. Ambos deben depender de abstracciones. Además, las abstracciones no deben depender de los detalles, sino que los detalles deben depender de las abstracciones.

-[El problema que ataca](#)

-[La solución que propone](#)

## Licencia
Este proyecto está bajo la licencia [MIT](LICENSE).
