' Developer Express Code Central Example:
' How to convert an XtraGrid to an XtraReport at runtime
' 
' This example demonstrates how to dynamically create a report based upon the
' GridControl at runtime. This means that all filtering and sorting conditions
' selected in the grid are also applied in a report. To accomplish this task, it
' is necessary to create a report with all the necessary bands, bind it to a data
' source and adjust all the necessary options.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E108
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly:AssemblyTitle("GridReportProblem")>
<Assembly:AssemblyDescription("")>
<Assembly:AssemblyConfiguration("")>
<Assembly:AssemblyCompany("Brandtex A/S")>
<Assembly:AssemblyProduct("GridReportProblem")>
<Assembly:AssemblyCopyright("Copyright © Brandtex A/S 2006")>
<Assembly:AssemblyTrademark("")>
<Assembly:AssemblyCulture("")>
' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly:ComVisible(False)>
' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly:Guid("052eca85-a4bd-4cac-a5cf-5343e2383968")>
' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
<Assembly:AssemblyVersion("1.0.0.0")>
<Assembly:AssemblyFileVersion("1.0.0.0")>
