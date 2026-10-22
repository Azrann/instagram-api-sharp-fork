**Languages:** [English](README.md) · [Español](README.es.md)

# instagram-api-sharp-fork

Historical copy of the InstagramApiSharp library.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2020.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2020-05-21**, [`InstagramApiSharp/PhantomJs/Program.cs`](InstagramApiSharp/PhantomJs/Program.cs); preserved modification timestamp.
- First record in the original Git repository containing this code: **2018-05-15**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [PuppeteerSharp.Contrib.Extensions 2.0.0](https://www.nuget.org/packages/PuppeteerSharp.Contrib.Extensions/2.0.0), published on **2020-05-08** (declared version), in [`InstagramApiSharp/PhantomJs/PhantomJs.csproj`](InstagramApiSharp/PhantomJs/PhantomJs.csproj).
- Additional reference: target `netcoreapp3.1` in [`InstagramApiSharp/PhantomJs/PhantomJs.csproj`](InstagramApiSharp/PhantomJs/PhantomJs.csproj); its [stable release was published on 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

## Why this is worth exploring

Processors divided by accounts, media, messages, and stories make it possible to explore a large API client without starting with every operation. Challenge and two-factor examples show the authentication lifecycle's complexity.

Code entry points:

- [`src/InstagramApiSharp/API/Processors`](InstagramApiSharp/src/InstagramApiSharp/API/Processors/)
- [`src/InstagramApiSharp/API/Builder/InstaApiBuilder.cs`](InstagramApiSharp/src/InstagramApiSharp/API/Builder/InstaApiBuilder.cs)
- [`samples/TwoFactorSample/Program.cs`](InstagramApiSharp/samples/TwoFactorSample/Program.cs)

<!-- END project-context -->

## Contents

| Directory | Function |
| --- | --- |
| [`InstagramApiSharp/`](InstagramApiSharp/) | Copy of InstagramApiSharp, a C# implementation of Instagram operations, with account, media, comment, message, and story processors and authentication examples. |

Imported derivative of ramtinak/InstagramApiSharp. Existing licenses are retained. The previous local history is not published.

## Requirements and setup

.NET, NuGet, and sample projects.

This is a historical copy. Consult each component's project files and README for versions and dependencies. Restore NuGet/npm from the appropriate folder; internal libraries may need rebuilding. Prepare databases and external services using your own accounts.

Preserved solutions:

- `InstagramApiSharp/InstagramApiSharp.sln`

## Configuration and security

Original secrets have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Search for this marker before running and provide values through local configuration or environment variables. Sessions, private keys, signing certificates, databases, logs, deployment profiles, and binary packages are not published. The `.gitignore` protects these local files.

A fresh history is published: old commits remain only in the original local copy. Example values cannot connect to the original services.

## Validation status

A static review and secret scan were performed before publication. Applications, trading operations, deployments, and tests contacting external services were not run. Building with current tools is not guaranteed. Some projects need historical dependencies and assets that are not included.

## Licenses and provenance

Third-party licenses and attributions present in the code are retained. No blanket license is added to components that lacked one. This import preserves local sources and does not claim to be a current version of the original project.

Upstream project: [original source](https://github.com/ramtinak/InstagramApiSharp). This is an independent import of the local copy, with a fresh history.
