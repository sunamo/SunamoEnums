# Automatically add XML documentation to all public types and members

param(
    [string]$Path = "E:\vs\Projects\PlatformIndependentNuGetPackages\SunamoEnums\SunamoEnums\Enums"
)

$filesProcessed = 0

Get-ChildItem -Path $Path -Filter "*.cs" -Recurse | ForEach-Object {
    $filePath = $_.FullName
    $lines = Get-Content -Path $filePath

    $newLines = @()
    $modified = $false
    $insideEnum = $false
    $lastLineWasXmlDoc = $false

    for ($i = 0; $i -lt $lines.Count; $i++) {
        $line = $lines[$i]
        $trimmed = $line.Trim()

        # Check if this line is already XML documentation
        if ($trimmed -match '^\s*///') {
            $lastLineWasXmlDoc = $true
            $newLines += $line
            continue
        }

        # Check for public enum or public class declaration
        if ($trimmed -match '^public\s+(enum|class)\s+(\w+)') {
            $typeName = $Matches[2]
            if (-not $lastLineWasXmlDoc) {
                # Add XML doc for the type
                $indent = $line -replace '\S.*$', ''
                $newLines += "$indent/// <summary>"
                $newLines += "$indent/// $typeName"
                $newLines += "$indent/// </summary>"
                $modified = $true
            }
            $insideEnum = $true
            $newLines += $line
            $lastLineWasXmlDoc = $false
            continue
        }

        # Check for enum values (lines that are identifiers, possibly with = value)
        if ($insideEnum -and $trimmed -match '^(\w+)(\s*=\s*.+?)?,?\s*$' -and $trimmed -notmatch '^\{' -and $trimmed -notmatch '^\}') {
            $valueName = $Matches[1]
            if (-not $lastLineWasXmlDoc) {
                # Add XML doc for the value
                $indent = $line -replace '\S.*$', ''
                $newLines += "$indent/// <summary>$valueName</summary>"
                $modified = $true
            }
            $newLines += $line
            $lastLineWasXmlDoc = $false
            continue
        }

        # Check for closing brace (end of enum/class)
        if ($trimmed -eq '}') {
            $insideEnum = $false
        }

        $newLines += $line
        $lastLineWasXmlDoc = $false
    }

    if ($modified) {
        $newLines | Set-Content -Path $filePath
        Write-Host "PROCESSED: $($_.Name)" -ForegroundColor Green
        $filesProcessed++
    }
}

Write-Host "`nSummary: Processed $filesProcessed files" -ForegroundColor Cyan
