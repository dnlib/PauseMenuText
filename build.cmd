@echo off
pushd Client
dotnet publish -c Release
popd

rmdir /s /q dist
mkdir dist

copy /y fxmanifest.lua dist
copy /y config.json dist
xcopy /y /e Client\bin\Release\net452\publish dist\