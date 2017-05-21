Imports System.Runtime.CompilerServices
Imports TechTalk.SpecFlow

Public Module ExtensionMethods
    <Extension>
    Public Function ToDictionary( table As Table) As Dictionary(Of string, string)
        Return table.Rows.ToDictionary(Function(row) row(0), Function(row) row(1))
    End Function
End Module