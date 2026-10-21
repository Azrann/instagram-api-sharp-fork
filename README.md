# instagram-api-sharp-fork

Copia histórica de la biblioteca InstagramApiSharp.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2020.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2020-05-21**, [`InstagramApiSharp/PhantomJs/Program.cs`](InstagramApiSharp/PhantomJs/Program.cs); fecha de modificación conservada.
- Primer registro del repositorio Git original que contiene este código: **2018-05-15**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [PuppeteerSharp.Contrib.Extensions 2.0.0](https://www.nuget.org/packages/PuppeteerSharp.Contrib.Extensions/2.0.0), publicada el **2020-05-08** (versión declarada), en [`InstagramApiSharp/PhantomJs/PhantomJs.csproj`](InstagramApiSharp/PhantomJs/PhantomJs.csproj).
- Referencia adicional: destino `netcoreapp3.1` en [`InstagramApiSharp/PhantomJs/PhantomJs.csproj`](InstagramApiSharp/PhantomJs/PhantomJs.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

## Por qué merece la pena mirarlo

La división en procesadores por cuentas, medios, mensajes e historias permite recorrer un cliente de API amplio sin empezar por todas sus operaciones. Los ejemplos de desafíos y segundo factor muestran la complejidad del ciclo de autenticación.

Puntos de entrada al código:

- [`src/InstagramApiSharp/API/Processors`](InstagramApiSharp/src/InstagramApiSharp/API/Processors/)
- [`src/InstagramApiSharp/API/Builder/InstaApiBuilder.cs`](InstagramApiSharp/src/InstagramApiSharp/API/Builder/InstaApiBuilder.cs)
- [`samples/TwoFactorSample/Program.cs`](InstagramApiSharp/samples/TwoFactorSample/Program.cs)

<!-- END project-context -->

## Contenido

| Directorio | Función |
| --- | --- |
| [`InstagramApiSharp/`](InstagramApiSharp/) | Copia de la biblioteca InstagramApiSharp, una implementación C# de operaciones de Instagram, con procesadores de cuentas, medios, comentarios, mensajes, historias y ejemplos de autenticación. |

Derivación importada de ramtinak/InstagramApiSharp. Se conservan las licencias existentes. El historial local anterior no se publica.

## Requisitos y preparación

.NET, NuGet y proyectos de ejemplo.

Esta es una copia histórica. Consultar los archivos de proyecto y los README de cada componente para sus versiones y dependencias. Restaurar NuGet/npm desde la carpeta correspondiente; las bibliotecas internas pueden necesitar reconstrucción. Preparar las bases de datos y los servicios externos con cuentas propias.

Soluciones conservadas:

- `InstagramApiSharp/InstagramApiSharp.sln`

## Configuración y seguridad

Los secretos originales se han eliminado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Buscar este marcador antes de ejecutar y aportar los valores mediante configuración local o variables de entorno. Las sesiones, claves privadas, certificados de firma, bases de datos, registros, perfiles de despliegue y paquetes binarios no se publican. El `.gitignore` protege estos archivos locales.

Se publica un historial nuevo: los commits antiguos permanecen únicamente en la copia local original. Los valores de ejemplo no permiten conectarse a los servicios originales.

## Estado de validación

Se realizó una revisión estática y un escaneo de secretos antes de publicar. No se ejecutaron aplicaciones, operaciones de trading, despliegues ni pruebas que contacten servicios externos. No se garantiza la compilación con herramientas actuales. Algunos proyectos necesitan dependencias históricas y activos que no están incluidos.

## Licencias y procedencia

Se conservan las licencias y atribuciones de terceros presentes en el código. No se añade una licencia global a los componentes que no la tenían. Esta importación conserva fuentes locales y no afirma ser una versión actual del proyecto original.

Proyecto de procedencia: [código original](https://github.com/ramtinak/InstagramApiSharp). Esta es una importación independiente de la copia local, con historial nuevo.
