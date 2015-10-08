del *.nupkg
$files = Get-ChildItem FubarDev.*\*.nuspec
ForEach ($file in $files)
{
	$proj = [System.IO.Path]::ChangeExtension($file, ".csproj")
	# write-host $proj
	& nuget pack -Symbols -IncludeReferencedProjects -Properties Configuration=Release $proj
}
