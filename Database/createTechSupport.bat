@ECHO off

:: batch file for
:: Murach's ADO.NET 4 with C# 2010
:: company: Mike Murach & Associates, Inc.
:: date:    March 5th, 2011
:: 
:: Uses SQLCMD utility to run a SQL script that creates
:: the TechSupport database.

ECHO Attempting to create the TechSupport database . . . 
sqlcmd -S MO-AXXXX-LT000 -E /i createTechSupport.sql
ECHO.
ECHO If no error message is shown, then the database was created successfully.
ECHO.
PAUSE