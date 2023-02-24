# BudgetBook.Account.Contracts

$version="1.0.0"
$owner="Brocker591"
$gh_pat="[PAT HERE]"

C:\Spielwiese\Project\BudgetBook.Account.Contracts\BudgetBook.Account.Contracts

dotnet pack BudgetBook.Account.Contracts\ --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/BudgetBook.Account.Contracts -o ..\packages

dotnet nuget push ..\packages\BudgetBook.Account.Contracts.$version.nupkg --api-key $gh_pat --source "github"
