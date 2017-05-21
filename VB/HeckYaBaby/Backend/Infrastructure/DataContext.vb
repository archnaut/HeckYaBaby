Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports Backend.Domain

Namespace Infrastructure
    Public Class DataContext
        Inherits DbContext

        Public Property Profiles As DbSet(Of ProfileEntity)

        Protected Overrides Sub OnModelCreating(builder As DbModelBuilder)
            builder.Conventions.Remove(Of PluralizingTableNameConvention)()
        End Sub

    End Class
End NameSpace