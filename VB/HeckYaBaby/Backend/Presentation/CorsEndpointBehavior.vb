Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.ServiceModel.Description
Imports System.ServiceModel.Dispatcher

Public Class CorsEndpointBehavior
    Implements IDispatchMessageInspector, IEndpointBehavior

    Private ReadOnly _allowOrigin as String

    Public Sub New(allowOrigin As String)
        _allowOrigin = allowOrigin
    End Sub

    Public Function AfterReceiveRequest(ByRef request As Message, channel As IClientChannel, instanceContext As InstanceContext) As Object Implements IDispatchMessageInspector.AfterReceiveRequest
        Return Nothing
    End Function

    Public Sub BeforeSendReply(ByRef reply As Message, correlationState As Object) Implements IDispatchMessageInspector.BeforeSendReply

        Dim httpProp As HttpResponseMessageProperty

        If reply.Properties.ContainsKey(HttpResponseMessageProperty.Name) Then
            httpProp = CType(reply.Properties(HttpResponseMessageProperty.Name), HttpResponseMessageProperty)
        Else
            httpProp = new HttpResponseMessageProperty()
            reply.Properties.Add(HttpResponseMessageProperty.Name, httpProp)
        End If

        httpProp.Headers.Add("Access-Control-Allow-Origin", _allowOrigin)   

    End Sub

    Public Sub Validate(endpoint As ServiceEndpoint) Implements IEndpointBehavior.Validate
    End Sub

    Public Sub AddBindingParameters(endpoint As ServiceEndpoint, bindingParameters As BindingParameterCollection) Implements IEndpointBehavior.AddBindingParameters
    End Sub

    Public Sub ApplyDispatchBehavior(endpoint As ServiceEndpoint, endpointDispatcher As EndpointDispatcher) Implements IEndpointBehavior.ApplyDispatchBehavior
        endpointDispatcher.DispatchRuntime.MessageInspectors.Add(Me)
    End Sub

    Public Sub ApplyClientBehavior(endpoint As ServiceEndpoint, clientRuntime As ClientRuntime) Implements IEndpointBehavior.ApplyClientBehavior
    End Sub
End Class