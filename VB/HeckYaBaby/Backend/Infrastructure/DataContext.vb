Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports Backend.Domain

Namespace Infrastructure
    Public Class DataContext
        Inherits DbContext

        Public Property Profiles As DbSet(Of ProfileEntity)

        Protected Overrides Sub OnModelCreating(builder As DbModelBuilder)
            builder.Conventions.Remove(Of PluralizingTableNameConvention)()
        End Sub

        Public Overrides Function SaveChanges() As Integer

            Dim context = CType(Me, IObjectContextAdapter).ObjectContext

            Dim entries = context.
                ObjectStateManager.
                GetObjectStateEntries(EntityState.Added Or EntityState.Modified).
                Where(Function(x) Not x.IsRelationship).
                Where(Function(x) x.Entity IsNot Nothing).
                Where(Function(x) TypeOf x.Entity Is IAuditable).
                ToList()

            Dim dt As Date  = Date.Now

            entries.
                Select(Function(x) x.Entity).
                Cast(Of IAuditable).
                ToList().
                ForEach(Sub(x) x.RowDate = dt)

            entries.
                Where(Function(x) x.State = EntityState.Modified).
                Select(Function(x) x.Entity).
                Cast(Of IAuditable).ToList().
                ForEach(Sub(x) x.RowStatus = "UPDATED")

            entries.
                Where(Function(x) x.State = EntityState.Added).
                Select(Function(x) x.Entity).
                Cast(Of IAuditable).
                ToList().
                ForEach(Sub(x) x.RowStatus = "INSERTED")

            return MyBase.SaveChanges()

       End Function

    End Class
End NameSpace