param([string] $project)

# Make sure a project was provided
if($project.Length -eq 0) {
    Write-Host 'No project given'
    return;
}

# Strip beginning or ending slashes from project name (thanks autocomplete for that)
if(($project.Substring(0, 2) -eq './') -or ($project.Substring(0, 2) -eq '.\')) {
    $project = $project.Substring(2);
}
if(($project.Substring($project.Length - 1) -eq '/') -or ($project.Substring($project.Length - 1) -eq '\')) {
    $project = $project.Substring(0, $project.Length - 1);
}

# Generate output directory
if(-not $(Test-Path -Path './Compressed')) {
    New-Item './Compressed' -ItemType Directory > $null
}

# Filter files for compression
$blacklistedFiles = @(
    "bin",
    "obj",
    ".vs"
)

# Get files to add to archive
$filesToAdd = @(Get-ChildItem -Path (".\" + $project) -Exclude $blacklistedFiles | % { $_.FullName  } ) # https://stackoverflow.com/a/42007250, https://stackoverflow.com/a/13128911

# Add files to archive
$dstFile = [System.IO.FileInfo]::new($(Get-Location).Path + '.\Compressed\' + $project + '.zip').FullName # https://github.com/PowerShell/PowerShell/issues/7197#issuecomment-401046816
Compress-Archive -Path $filesToAdd -DestinationPath $dstFile -Update
Write-Host 'Done!'

# Confirm files in zip file

Write-Host "`n${dstFile}"
[Reflection.Assembly]::LoadWithPartialName('System.IO.Compression.FileSystem') > $null # https://stackoverflow.com/a/14204577
[IO.Compression.ZipFile]::OpenRead($dstFile).Entries.FullName | % { Write-Host "  $_"}