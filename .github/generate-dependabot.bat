@echo off
setlocal

set testvar="C:\Projects\Energinet\geh-market-roles\source\shared\messaging\source\GreenEnergyHub.Messaging.Protobuf.Tests\GreenEnergyHub.Messaging.Protobuf.Tests.csproj:Projects=tests"
set output=%testvar:Projects=tests%
echo Res: %output%
goto :eof


call :setDirVariables
echo %script_dir%
echo %parent_dir%
call :generateFile
call :run
echo Done
endlocal
goto :eof

:generateFile
type NUL >%script_dir%/testfile.yml
goto :eof

:run
cd %parent_dir%
for /R %%f in (*.csproj) do call :insertSection "%%f"
cd %script_dir%
goto :eof

:insertSection
echo %~1
call set proj_path=%%~1:Projects=tests%
echo %proj_path%>>%script_dir%/testfile.yml
goto :eof

:setDirVariables
set "script_dir=%~dp0"
pushd %script_dir%..
set "parent_dir=%cd%"
goto :eof
