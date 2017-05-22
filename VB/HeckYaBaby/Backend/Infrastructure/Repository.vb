Imports System.Data.Entity
Imports System.Linq.Expressions
Imports Backend.Domain
Imports EntityFramework.Extensions

Public Class Repository
    Implements IRepository

    Private ReadOnly _context As DbContext

    Sub New(context As DbContext)
        _context = context
    End Sub

    Public Sub Add (Of T As Class)(item As T) Implements IRepository.Add
        _context.Set(Of T).Add(item)
    End Sub

    Public Function AllInstances (Of T As Class)() As IQueryable(Of T) Implements IRepository.AllInstances
        return _context.Set(Of T)
    End Function

    Public Function Find (Of T As Class)(predicate As Expression(Of Func(Of T,Boolean))) As T Implements IRepository.Find
        return _context.Set(Of T).FirstOrDefault(predicate)
    End Function

    Public Function NewUnitOfWork() As IUnitOfWork Implements IRepository.NewUnitOfWork
        return new UnitOfWork(_context)
    End Function


    Public Sub Remove (Of T As Class)(predicate As Expression(Of Func(Of T,Boolean))) Implements IRepository.Remove
        _context.Set(Of T).
            Where(predicate).
            Delete()
    End Sub

    Public Sub Remove (Of T As Class)(item As T) Implements IRepository.Remove
        _context.Set(Of T).Remove(item)
    End Sub

    Public Function Update (Of T As Class)(predicate As Expression(Of Func(Of T,Boolean)), map As Expression(Of Func(Of T,T))) As Integer Implements IRepository.Update
        return _context.Set(Of T).
            Where(predicate).
            Update(map)
    End Function

    Private Class UnitOfWork
        Implements IUnitOfWork

        Private ReadOnly _context As DbContext

        Public Sub New(context As DbContext)
            _context = context
        End Sub

        public Sub Commit() Implements IUnitOfWork.Commit
            _context.SaveChanges()
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
        End Sub
    End Class
End Class