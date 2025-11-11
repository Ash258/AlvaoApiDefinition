#!/usr/bin/env pwsh
param()

$baseUrl = "https://doc.alvao.com"

Write-Host 'Extract XMLs from website'
$content = Invoke-WebRequest -Uri "${baseUrl}/en/25/modules/alvao-am-custom-apps/applications/templates"
$mm = Select-String -InputObject $content.RawContent -Pattern '<a href="(?<link>[^"]+\.xml)"' -AllMatches

Write-Host "Downloading $($mm.Matches.Count) XML files"
foreach ($m in $mm.Matches) {
    $link = $baseUrl + $m.Groups["link"].Value
    $f = [System.IO.Path]::GetFileName($link)
    # Invoke-WebRequest -Uri $link -OutFile ([System.IO.Path]::Combine($PSScriptRoot, $f))
}

$files = Get-ChildItem -Path . -Filter *.xml
$sharedCsproj = Join-Path $PSScriptRoot 'shared.csproj'

foreach ($f in $files) {
    $examplePath = Join-Path -Path $PSScriptRoot -ChildPath $f.BaseName
    $csproj = Join-Path $examplePath "$($f.BaseName).csproj"

    if (!(Test-Path -Path $examplePath)) {
        New-Item -Path $examplePath -ItemType Directory | Out-Null
    }
    if (!(Test-Path -Path $csproj)) {
        New-Item -ItemType SymbolicLink -Value $sharedCsproj -Path $csproj | Out-Null
    }

    [xml] $x = Get-Content -Path $f.FullName -Raw
    # One XML, should not contain multiple applications, but XML schema allows it, skip it for now
    $node = $x.SelectNodes("/AlvaoApplication/Applications/Application")
    $scripts = $node[0].SelectNodes("./Scripts/Script")
    foreach ($s in $scripts) {
        $name = $s.SelectSingleNode("./Name").InnerText
        $code = $s.SelectSingleNode("./Code").InnerText

        Set-Content -Path (Join-Path -Path $examplePath -ChildPath "$name.cs") -Value $code -Force
    }
}

Remove-Item $files
