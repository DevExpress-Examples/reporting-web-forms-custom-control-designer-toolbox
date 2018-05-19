' Developer Express Code Central Example:
' How to: Add a Custom Control in the Web Report Designer
' 
' This example shows how to create a custom control and register it in the Web
' Report Designer
' (https://documentation.devexpress.com/#XtraReports/CustomDocument17103)'s
' Toolbox (https://documentation.devexpress.com/#XtraReports/CustomDocument17559).
' The example illustrates the steps to expand a set of native report controls by
' deriving from existing ones.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T209289

Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Utils.Serializing

Namespace Sample
    Public Class CustomLabel
        Inherits XRLabel

        Private _someProperty As String
        Private _bindableProperty As String

        <Browsable(True), Bindable(False), Category("Data"), XtraSerializableProperty, DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always)> _
        Public Property SomeProperty() As String
            Get
                Return Me._someProperty
            End Get
            Set(ByVal value As String)
                Me._someProperty = value
            End Set
        End Property

        <Browsable(True), Bindable(False), Category("Data"), XtraSerializableProperty, DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always)> _
        Public Property BindableProperty() As String
            Get
                Return Me._bindableProperty
            End Get
            Set(ByVal value As String)
                Me._bindableProperty = value
            End Set
        End Property
    End Class
End Namespace