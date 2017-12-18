# Parameters
You must provide the below parameters.

```
 -? | -h | --help               Show help information                            
 -cs | --connection-string      Connection string to connect SQL Server database.
 -t | --table                   Table name.                                      
 -id | --identification-column  ID column name.                                  
 -d | --description-column      Description column name.                         
 -csf | --csharp-file           C# export filename.                              
 -tsf | --typescript-file       Typescript export filename.                      
 -c | --class-name              Class name of object.                            
 -ns | --name-space             Namespace of object.                             
 -i | --imports                 Namespace to imports.                            
 -bw | --black-words            Exclude black words.                             
```

- One of parameters __-csf__ -and __tsf__ must be provided to generate output file.
- The parameter __-c__ must be provied when the __-csf__ was specified.

# How to run

```bash
dotnet table2enum.dll ^
    --table=CADSUF_TIPO_REQUERIMENTO ^
    -id TRE_ID ^
    -d TRE_DS ^
    -cs="data source=172.24.128.19;initial catalog=cadsuf-fase2;persist security info=True;user id=cadsuf-fase2;password=cadsuf-fase2;MultipleActiveResultSets=True" ^
    -csf "C:\TFS\AM_SUFRAMA\CADSUF\Fontes\src\Suframa.Cadsuf.CrossCutting.DataTransferObject\Enum\EnumTipoRequerimento.cs" ^
    -tsf "C:\TFS\AM_SUFRAMA\CADSUF\Fontes\src\Suframa.Cadsuf.UserInterface\www\app\shared\enums\EnumTipoRequerimento.ts" ^
    -c EnumTipoRequerimento ^
    -ns Suframa.Cadsuf.CrossCutting.DataTransferObject.Enum ^
    -i System.ComponentModel
```

## External packages

* Dapper (https://github.com/StackExchange/Dapper)
* Ensure.That (https://github.com/danielwertheim/Ensure.That)
* Humanizer (https://github.com/Humanizr/Humanizer)
* Microsoft.Extensions.CommandLineUtils (https://www.nuget.org/packages/Microsoft.Extensions.CommandLineUtils/)