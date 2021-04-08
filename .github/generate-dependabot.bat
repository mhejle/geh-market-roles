@echo off
set "working_dir=%~dp0"

call :generateFile
call :run
echo Done
goto :eof

:generateFile
type NUL >%working_dir%/testfile.yml
goto :eof

:run
pushd %~dp0..
echo Current dir: %~dp0
for /R %%f in (*.csproj) do call :insertSection "%%f"
goto :eof

:insertSection
echo %~1
set proj_path=%~1
echo %proj_path%>>%working_dir%/testfile.yml
goto :eof