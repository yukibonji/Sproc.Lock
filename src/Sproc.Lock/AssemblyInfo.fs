﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Sproc.Lock")>]
[<assembly: AssemblyProductAttribute("Sproc.Lock")>]
[<assembly: AssemblyDescriptionAttribute("SQL Server based distributed locking.")>]
[<assembly: AssemblyVersionAttribute("0.9.0")>]
[<assembly: AssemblyFileVersionAttribute("0.9.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.9.0"