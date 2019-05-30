Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm
        Private provider As DragDropProvider

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnMainFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If provider IsNot Nothing Then
                provider.DisableDragDrop()
            End If
        End Sub

        Private Sub OnMainLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            provider = New DragDropProvider(pictureEdit1)
            provider.EnableDragDrop()
        End Sub

        Private Sub OnSimpleButtonMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles simpleButton2.MouseDown, simpleButton1.MouseDown
            Dim btn As SimpleButton = TryCast(sender, SimpleButton)
            pictureEdit1.DoDragDrop(btn.Image, DragDropEffects.Copy)
        End Sub
    End Class
End Namespace
