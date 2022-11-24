rm -Confirm:$false -Recurse ../pkg/nsext
$src = "d:\ForkedGitReps\ns-ext\"
git -C $src reset --hard
git -C $src clean -d -fx
dotnet build -c Release $(-Join($src, "src\NSExt.sln"))

$files = Get-ChildItem -Path $(-Join($src,"build\nupkgs\")) -Filter *.nupkg
foreach($file in $files)
{
    nuget add $file.fullName -source ../pkg/
}
