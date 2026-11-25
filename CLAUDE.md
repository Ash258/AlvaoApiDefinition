# CLAUDE.md

Generator of the unofficial `Ash258.Alvao.Mock.API` NuGet package: C# definitions of the ALVAO API scraped from the public docfx documentation (https://doc.alvao.com/en/26/alvao-api/). See [README.md](./README.md) for the user-facing overview.

## Layout

| Path | Contents |
| :--- | :--- |
| `Program.cs`, `src/` | Generator (`scrapper.csproj`, net8.0) |
| `html/` | Cached docs pages + `toc.json`, `release-version.txt`, `database-tables.html`. The generator reads the cache, not the web |
| `overrides/` | Everything the docs cannot provide: hand-written `Alvao/**/*.cs` (copied over output) and `patches.json` |
| `Alvao/` | **Generated** library (`Alvao.csproj` + `README.md`/`DATABASE.md` are maintained by hand/generator, `API/`, `Apps/`, `Context/`, `Global/` are output) |
| `Examples/` | Official ALVAO application templates; each `<Name>/<Name>.csproj` is a **symlink** to `../shared.csproj`, which references the local `Alvao/Alvao.csproj` |
| `.alvaorc` | Package version, written by the generator from the ALVAO release notes |

## Commands

```bash
dotnet run                          # generate from cache (pass namespaces to filter, `ignore` to bypass cache)
task r:c:h                          # full refresh: clear html cache, download, generate, tidy, build, pack
task tidy                           # normalize html cache (Docker on macOS; Docker must be running)
dotnet format Alvao/ && dotnet build Alvao/   # build generated library
task examples:build                 # build all examples against the local library
```

Never edit `Alvao/API/**` by hand; it is overwritten on every run.

## How generation works (where to fix things)

- Type resolution is data-driven (`src/TypeRefs.cs`): usings/qualified names from docfx `xref` links, unlinked types from member `data-uid`, undocumented Alvao types become stubs. There is no MonkeyPatch.
- Fix in this order of preference:
  1. a generic rule in `src/` if the docs contain the information,
  2. a data entry in `overrides/patches.json` (`typeNamespaces`, `definitionUsings`, `interfaceMembers`, `fixups`),
  3. a hand-written file in `overrides/Alvao/...` (e.g. `Alvao.Apps.API` interfaces, `DbProperty`, `ArchiveStream`).
- `src/DocsInfo.cs`: version from release notes (`26.4` → `26.4.0`, `26.4 Patch` → `26.4.1`), namespaces from `toc.json`.
- `src/DatabaseSchema.cs`: enriches `Alvao.API.Common.Model.Database` models from the database docs and writes `Alvao/DATABASE.md`. Parses raw html (tidied and original must give identical output).
- Output must not depend on html formatting (tidy re-wraps text and joins lines in `<pre>`).

## Verification before committing

1. `dotnet run` → `dotnet format Alvao/` → `dotnet build Alvao/` with 0 errors.
2. `task examples:build`: all examples build, no compiler warnings (NU1903 AutoMapper advisory is known).
3. `dotnet format --verify-no-changes --include src/ Program.cs`.
4. Review `git diff --stat`; html and `Alvao/` diffs are large only on docs refreshes.

## Release

CI (`.github/workflows/ci.yml`) builds everything on each push/PR and publishes on a `v*` tag or push to `main` (`--skip-duplicate`, so only new versions are published):

- nuget.org via **Trusted Publishing** (`NuGet/login@v1`, user `Ash258`). Policy on nuget.org: owner `Ash258`, repo `AlvaoApiDefinition`, workflow file `ci.yml`, package `Ash258.Alvao.Mock.API`, scope "push only new package versions". No API key secret is needed.
- GitHub Packages via `GITHUB_TOKEN`.
- GitHub Release with the `.nupkg`, for tags only.

Steps for a new ALVAO version:

```bash
task r:c:h                                  # refresh docs; prints "ALVAO version changed from X to Y"
# fix build errors (see "where to fix things"), run verification
git switch dev
git commit ...                              # split: generator / examples / html / library / docs
git push origin dev                         # CI build only
git switch main && git merge --ff-only dev
git tag -a "v$(cat .alvaorc)" -m "Release $(cat .alvaorc)"
git push origin main "v$(cat .alvaorc)"     # CI publishes + creates GitHub release
```

The tag must equal `.alvaorc` or the publish job fails. Keep `Alvao/Alvao.csproj` `<Version>` in sync (`task library:pack` sets it).

Manual fallback (CI unavailable): `task library:pack`, then push `Alvao/bin/Release/Ash258.Alvao.Mock.API.<version>.nupkg` with a nuget.org API key kept in the maintainer's password manager. Inject the key via `op run`; never print or commit it. nuget.org keys expire after at most 365 days; a 403 "expired" means regenerate the key.

## Known pitfalls

- `/en/26/` docs always show the **latest** 26.x; refresh the whole html cache together with the version.
- Docs pages can return 403 under load; `LoadDocument` retries and never caches error pages.
- Example templates come from `Examples/ExportXmlIntoCs.ps1` (pwsh). It recreates the csproj symlinks; ALVAO 26 interfaces are async (`ShowAsync(EntityArgs, CancellationToken)` …) and live in `overrides/Alvao/Apps/API/`.
- 26.4 docs list `DbProperty` without members; the override keeps the 26.1 members (templates use `WebAppUrl`, `HTMLHeader`).
- Markdig types (`TargetBlankLinkExtension`) are stubbed on purpose; `Azure.AI.DocumentIntelligence` is a real package dependency.
- Moving the repo with tools that drop symlinks breaks `Examples/*/*.csproj`; restore with `git checkout -- Examples/`.

## Conventions

- Conventional commits (`feat(generator):`, `chore(html):`, `chore(library):`, `docs:` …), small logical commits.
- Work on `dev`; `main` is fast-forwarded to `dev` for releases (linear history).
- Ask the maintainer before committing or pushing.
