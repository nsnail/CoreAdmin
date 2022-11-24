rm -Confirm:$false -Recurse ../pkg/furion.pure.ns
$src = "d:\ForkedGitReps\Furion\"
git -C $src reset --hard
git -C $src clean -d -fx
dotnet build -c Release $(-Join($src, "framework\Furion.sln"))

$files = Get-ChildItem -Path $(-Join($src,"framework\nupkgs")) -Filter *.NS.*.nupkg
foreach($file in $files)
{
    nuget add $file.fullName -source ../pkg/
}
