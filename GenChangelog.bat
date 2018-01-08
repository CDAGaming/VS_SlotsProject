:: Generates Changelog.md
@echo off
title Changelog Generator
goto Start

:Start
echo WARNING: Download skywinder/github_changelog_generator Gem or this won't work.
set INPUT=
set /p INPUT=Enter GitHub Username (Owner of Repo Your Generating this On): %=%
set USERNAME=%INPUT%
set INPUT=
set /p INPUT=Enter GitHub Repo Name (Name of Repo Your Generating this On): %=%
set REPOSITORY=%INPUT%
set INPUT=
set /p INPUT=Enter GitHub Token or Leave Blank for None: %=%
set TOKEN=%INPUT%

:Confirm
echo You are Using '%TOKEN%' as your GitHub Token to generate a changelog for '%USERNAME%/%REPOSITORY%'.
set INPUT=
set /p INPUT=Is this Correct? (Y/N) %=%
If /I "%INPUT%"=="Y" goto Generate
If /I "%INPUT%"=="N" goto Start
echo Incorrect Input, Input is Case-Sensitive! & goto Start

:Generate
github_changelog_generator --user %USER% --project %REPOSITORY% --token %TOKEN%
