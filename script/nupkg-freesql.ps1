rm -Confirm:$false -Recurse ../pkg/freesql.dbcontext.ns
$src = "d:\ForkedGitReps\FreeSql\"
git -C $src reset --hard
git -C $src clean -d -fx
dotnet build -c Release $(-Join($src, "FreeSql.sln"))

$files = Get-ChildItem -Path $(-Join($src,"FreeSql.DbContext\bin\Release")) -Filter *.NS.*.nupkg
foreach($file in $files)
{
    nuget add $file.fullName -source ../pkg/
}
