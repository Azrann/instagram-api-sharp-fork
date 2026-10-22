**Languages:** [English](README.md) · [Español](README.es.md)

# InstagramApiSharp

Copy of InstagramApiSharp, a C# implementation of Instagram operations, with account, media, comment, message, and story processors and authentication examples.

Documentation based on local files reviewed on 21 October 2026.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2020.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2020-05-21**, [`InstagramApiSharp/PhantomJs/Program.cs`](PhantomJs/Program.cs); preserved modification timestamp.
- First record in the original Git repository containing this code: **2018-05-15**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [PuppeteerSharp.Contrib.Extensions 2.0.0](https://www.nuget.org/packages/PuppeteerSharp.Contrib.Extensions/2.0.0), published on **2020-05-08** (declared version), in [`InstagramApiSharp/PhantomJs/PhantomJs.csproj`](PhantomJs/PhantomJs.csproj).
- Additional reference: target `netcoreapp3.1` in [`InstagramApiSharp/PhantomJs/PhantomJs.csproj`](PhantomJs/PhantomJs.csproj); its [stable release was published on 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

## Why this is worth exploring

Processors divided by accounts, media, messages, and stories make it possible to explore a large API client without starting with every operation. Challenge and two-factor examples show the authentication lifecycle's complexity.

Code entry points:

- [`src/InstagramApiSharp/API/Processors`](src/InstagramApiSharp/API/Processors/)
- [`src/InstagramApiSharp/API/Builder/InstaApiBuilder.cs`](src/InstagramApiSharp/API/Builder/InstaApiBuilder.cs)
- [`samples/TwoFactorSample/Program.cs`](samples/TwoFactorSample/Program.cs)

<!-- END project-context -->

## Structure and responsibilities

| Path | Responsibility |
| --- | --- |
| `src/InstagramApiSharp/API/` | InstaApi, builder, and processors organized by function. |
| `src/InstagramApiSharp/Classes/, src/InstagramApiSharp/Helpers/` | Models, session state, devices, and utilities. |
| `samples/` | Console, Windows Forms, UWP, VB, challenge, multiple account, Facebook, and two-factor examples. |
| `PhantomJs/` | Puppeteer/Selenium browser automation experiments. |
| `InstagramApiSharp.sln, LICENSE` | Existing solution and license. |

## Technologies and requirements

Visual Studio/MSBuild and the SDKs specified by each project. The library declares multiple .NET Standard/.NET Framework/UWP targets and build conditions; Windows examples and the .NET Core 3.1 experiment require different tools.

Targets read from project files: `netcoreapp3.1`, `netstandard2.0;net452;uap10.0;netstandard1.3`, `netstandard2.0;netstandard1.3`, `v4.5.2`, `v5.0`.

## Setup and startup

Open InstagramApiSharp.sln and first choose the library or example to prepare. Review csproj conditions before restoring all targets. No examples or browsers were run.

Solutions present: `InstagramApiSharp.sln`.

## Configuration and integrations


## Status of this copy

Preserve LICENSE and original attribution. Example credentials are not assumed to be real, and external APIs are not assumed to remain compatible. The original README is preserved.

The review was static: dependencies were not restored, and applications and tests were neither built nor run. The commands above are setup instructions, not validation results. Listed versions describe the preserved code.


## Public copy

Original credentials have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Local data, sessions, private certificates, and deployment profiles are omitted. Configure your own services and credentials before running. Building and operation with external services have not been validated.
