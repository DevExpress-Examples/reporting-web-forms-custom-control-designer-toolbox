Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.Localization
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI
Imports System.ComponentModel
Imports System.Drawing

Public Enum MyEnum
    One
    Two
    Three
End Enum

Public Class MyControl
    Inherits XRLabel

    Public Shared ReadOnly InitSizeF As SizeF = New SizeF(200, 50)

    <XtraSerializableProperty, DefaultValue(True), Favorite(True), SRCategory(ReportStringId.CatBehavior)>
    Public Property BoolProp As Boolean

    <XtraSerializableProperty, DefaultValue(MyEnum.One)>
    Public Property EnumProp As MyEnum

    <XtraSerializableProperty>
    Public Property ArrayProp As Item()

    Protected Overrides Sub PutStateToBrick(ByVal brick As VisualBrick, ByVal ps As PrintingSystemBase)
        MyBase.PutStateToBrick(brick, ps)
        brick.Text = EnumProp.ToString()
    End Sub

    Public Class Item

        <XtraSerializableProperty>
        Public Property PropA As Integer
    End Class
End Class
