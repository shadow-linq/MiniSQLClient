# MiniSQLClient
Very minimalistic MSSQL Client, written in C# for use with C2 systems.

Not sure what connection string to use? Here are some examples - https://www.connectionstrings.com/sql-server/

# Building via Mono
```
mono-csc MiniSQLClient.cs -reference:System.Data.dll
```

# Usage
```
MiniSQLClient.exe <connectionstring> <query>
```
