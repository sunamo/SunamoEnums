# Add "// variables names: ok" comment to all enum files that don't have it yet

$enumsPath = "E:\vs\Projects\PlatformIndependentNuGetPackages\SunamoEnums\SunamoEnums\Enums"
$filesProcessed = 0
$filesSkipped = 0

Get-ChildItem -Path $enumsPath -Filter "*.cs" | ForEach-Object {
    $filePath = $_.FullName
    $content = Get-Content -Path $filePath -Raw

    # Check if file already has the comment
    if ($content -match "^// variables names: ok") {
        Write-Host "SKIP: $($_.Name) (already has comment)" -ForegroundColor Yellow
        $filesSkipped++
    }
    else {
        # Add comment at the beginning
        $newContent = "// variables names: ok`n" + $content
        Set-Content -Path $filePath -Value $newContent -NoNewline
        Write-Host "ADDED: $($_.Name)" -ForegroundColor Green
        $filesProcessed++
    }
}

Write-Host "`nSummary:" -ForegroundColor Cyan
Write-Host "  Files processed: $filesProcessed" -ForegroundColor Green
Write-Host "  Files skipped: $filesSkipped" -ForegroundColor Yellow
