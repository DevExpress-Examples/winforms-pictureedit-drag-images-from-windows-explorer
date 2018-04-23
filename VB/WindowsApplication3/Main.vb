Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.IO


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Private provider As DragDropProvider

		Private Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			provider = New DragDropProvider(pictureEdit1)
			provider.EnableDragDrop()
		End Sub

		Private Sub OnSimpleButtonMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles simpleButton2.MouseDown, simpleButton1.MouseDown
			Dim btn As SimpleButton = TryCast(sender, SimpleButton)
			pictureEdit1.DoDragDrop(btn.Image, DragDropEffects.Copy)
		End Sub

		Private Sub OnFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			If provider IsNot Nothing Then
				provider.DisableDragDrop()
			End If
		End Sub
	End Class
End Namespace
