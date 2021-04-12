@echo off
setlocal

call :setDirVariables
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
for /R %%f in (*.csproj) do call :insertSection "%%~dpf"
cd %script_dir%
goto :eof

:extractRelativeProjectDir
set input_path=%~1
call set proj_path=%%input_path:%parent_dir%=%%
call set relativeDir=%%proj_path:\=/%%
echo Output: %relativeDir%
goto :eof

:setDirVariables
set "script_dir=%~dp0"
pushd %script_dir%..
set "parent_dir=%cd%"
goto :eof

:insertSection
set "relativeDir="
call :extractRelativeProjectDir %~1

echo %relativeDir%>>%script_dir%/testfile.yml

goto :eof