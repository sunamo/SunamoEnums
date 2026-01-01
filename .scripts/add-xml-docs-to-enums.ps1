# Add XML documentation to public enum types

$enumsPath = "E:\vs\Projects\PlatformIndependentNuGetPackages\SunamoEnums\SunamoEnums\Enums"
$filesProcessed = 0
$filesSkipped = 0

Get-ChildItem -Path $enumsPath -Filter "*.cs" | ForEach-Object {
    $filePath = $_.FullName
    $content = Get-Content -Path $filePath -Raw
    $modified = $false

    # Match public enum declarations without XML documentation
    $pattern = '(?m)^((?!///\s*<summary>).)*\n(public\s+(enum|class)\s+(\w+))'

    if ($content -match $pattern) {
        # Extract enum/class name
        if ($content -match 'public\s+(enum|class)\s+(\w+)') {
            $typeName = $Matches[2]
            $typeKind = $Matches[1]

            # Check if already has /// <summary> right before declaration
            $checkPattern = "///\s*<summary>.*?</summary>\s*\n\s*public\s+$typeKind\s+$typeName"

            if ($content -notmatch $checkPattern) {
                # Add XML documentation
                $replacement = @"
/// <summary>
/// Enum representing $typeName values
/// </summary>
public $typeKind $typeName
"@
                $content = $content -replace "public\s+$typeKind\s+$typeName", $replacement
                $modified = $true
            }
        }
    }

    if ($modified) {
        Set-Content -Path $filePath -Value $content -NoNewline
        Write-Host "ADDED XML docs: $($_.Name)" -ForegroundColor Green
        $filesProcessed++
    } else {
        Write-Host "SKIP: $($_.Name)" -ForegroundColor Yellow
        $filesSkipped++
    }
}

Write-Host "`nSummary:" -ForegroundColor Cyan
Write-Host "  Files processed: $filesProcessed" -ForegroundColor Green
Write-Host "  Files skipped: $filesSkipped" -ForegroundColor Yellow
