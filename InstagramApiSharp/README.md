# InstagramApiSharp

Copia de la biblioteca InstagramApiSharp, una implementación C# de operaciones de Instagram, con procesadores de cuentas, medios, comentarios, mensajes, historias y ejemplos de autenticación.

Documentación basada en los archivos locales revisados el 21 de octubre de 2026.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2020.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2020-05-21**, [`InstagramApiSharp/PhantomJs/Program.cs`](PhantomJs/Program.cs); fecha de modificación conservada.
- Primer registro del repositorio Git original que contiene este código: **2018-05-15**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [PuppeteerSharp.Contrib.Extensions 2.0.0](https://www.nuget.org/packages/PuppeteerSharp.Contrib.Extensions/2.0.0), publicada el **2020-05-08** (versión declarada), en [`InstagramApiSharp/PhantomJs/PhantomJs.csproj`](PhantomJs/PhantomJs.csproj).
- Referencia adicional: destino `netcoreapp3.1` en [`InstagramApiSharp/PhantomJs/PhantomJs.csproj`](PhantomJs/PhantomJs.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

## Por qué merece la pena mirarlo

La división en procesadores por cuentas, medios, mensajes e historias permite recorrer un cliente de API amplio sin empezar por todas sus operaciones. Los ejemplos de desafíos y segundo factor muestran la complejidad del ciclo de autenticación.

Puntos de entrada al código:

- [`src/InstagramApiSharp/API/Processors`](src/InstagramApiSharp/API/Processors/)
- [`src/InstagramApiSharp/API/Builder/InstaApiBuilder.cs`](src/InstagramApiSharp/API/Builder/InstaApiBuilder.cs)
- [`samples/TwoFactorSample/Program.cs`](samples/TwoFactorSample/Program.cs)

<!-- END project-context -->

## Estructura y responsabilidades

| Ruta | Responsabilidad |
| --- | --- |
| `src/InstagramApiSharp/API/` | InstaApi, constructor y procesadores por función. |
| `src/InstagramApiSharp/Classes/, src/InstagramApiSharp/Helpers/` | Modelos, estado de sesión, dispositivos y utilidades. |
| `samples/` | Ejemplos de consola, Windows Forms, UWP, VB, desafío, varias cuentas, Facebook y segundo factor. |
| `PhantomJs/` | Experimentos de automatización de navegador con Puppeteer/Selenium. |
| `InstagramApiSharp.sln, LICENSE` | Solución y licencia existentes. |

## Tecnologías y requisitos

Visual Studio/MSBuild y los SDK indicados por cada proyecto. La biblioteca declara distintos destinos .NET Standard/.NET Framework/UWP y condiciones de compilación; los ejemplos Windows y el experimento .NET Core 3.1 requieren herramientas distintas.

Destinos leídos de los proyectos: `netcoreapp3.1`, `netstandard2.0;net452;uap10.0;netstandard1.3`, `netstandard2.0;netstandard1.3`, `v4.5.2`, `v5.0`.

## Preparación y arranque

Abrir InstagramApiSharp.sln y elegir primero la biblioteca o el ejemplo que se quiere preparar. Revisar las condiciones del csproj antes de restaurar todos los destinos. No se ejecutaron ejemplos ni navegadores.

Soluciones presentes: `InstagramApiSharp.sln`.

## Configuración e integraciones


## Estado de esta copia

Conservar LICENSE y la atribución original. No se da por probado que las credenciales de ejemplo sean reales ni que las APIs externas sigan siendo compatibles. Se preserva el README original.

La revisión fue estática: no se restauraron dependencias, no se compiló ni se ejecutaron aplicaciones o pruebas. Los comandos anteriores son instrucciones de preparación, no resultados de validación. Las versiones indicadas son las del código conservado.


## Copia pública

Las credenciales originales se han retirado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Los datos locales, sesiones, certificados privados y perfiles de despliegue se omiten. Configurar servicios y credenciales propios antes de ejecutar. La compilación y el funcionamiento con servicios externos no se han validado.
