Imports System.Linq.Expressions

Namespace Domain

    Public Interface IRepository

        Sub Add(Of T As Class)(item As T)
        Function  AllInstances(Of T As Class)() As IQueryable(Of T)
        Function Find(Of T As Class)(predicate As Expression(Of Func(Of T, Boolean))) As T
        Function NewUnitOfWork() As IUnitOfWork 
        Sub Remove(Of T As Class)(predicate As Expression(of Func(of T, boolean)))
        Sub Remove(of T As Class)(item As T)
        Function Update(of T as class)(predicate as Expression(of Func(of T, boolean)), map As Expression(Of Func(of T, T))) As Int32
        Sub Update(Of T As Class)(entity As T)
    End Interface

End NameSpace