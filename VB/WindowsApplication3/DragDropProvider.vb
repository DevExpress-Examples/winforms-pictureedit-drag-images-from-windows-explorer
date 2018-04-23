Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.IO

Namespace DXSample

	Public Class DragDropProvider
		Private draggedImage As Image
		Private edit As PictureEdit

		<DllImport("GdiPlus.dll", CharSet := CharSet.Unicode, ExactSpelling := True)> _
		Private Shared Function GdipCreateBitmapFromGdiDib(ByVal pBIH As IntPtr, ByVal pPix As IntPtr, <System.Runtime.InteropServices.Out()> ByRef pBitmap As IntPtr) As Integer
		End Function

		Public Sub New(ByVal edit As PictureEdit)
			Me.edit = edit
			edit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
		End Sub

		Public Sub EnableDragDrop()
			edit.AllowDrop = True
			AddHandler edit.DragEnter, AddressOf OnDragEnter
			AddHandler edit.DragDrop, AddressOf OnDragDrop
		End Sub

		Private Sub OnDragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
			SetDragDropEffects(e)
		End Sub

		Private Sub OnDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			If (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy Then
				edit.Image = draggedImage
				draggedImage = Nothing
			End If
		End Sub

		Private Sub SetDragDropEffects(ByVal e As DragEventArgs)
			e.Effect = DragDropEffects.None

			Dim str As MemoryStream = TryCast(e.Data.GetData(DataFormats.Dib), MemoryStream)
			If str IsNot Nothing Then
				Try
					Dim handle As GCHandle = GCHandle.Alloc(str.ToArray(), GCHandleType.Pinned)
					draggedImage = BitmapFromDIB(handle.AddrOfPinnedObject())
					If draggedImage IsNot Nothing Then
						e.Effect = DragDropEffects.Copy
					End If
				Catch
					draggedImage = Nothing
				End Try
			Else
				Dim fileName() As String = TryCast(e.Data.GetData("FileName"), String())
				If fileName IsNot Nothing Then
					Try
						draggedImage = Image.FromFile(fileName(0))
						e.Effect = DragDropEffects.Copy
					Catch
						draggedImage = Nothing
					End Try
				Else
					Dim bmp As Object = e.Data.GetData("Bitmap")
					If bmp IsNot Nothing Then
						draggedImage = CType(bmp, Image)
						e.Effect = DragDropEffects.Copy
					End If
				End If
			End If
		End Sub

		Public Function BitmapFromDIB(ByVal pDIB As IntPtr) As Bitmap

			Dim pPix As IntPtr = GetPixelInfo(pDIB)
			Dim mi As MethodInfo = GetType(Bitmap).GetMethod("FromGDIplus", BindingFlags.Static Or BindingFlags.NonPublic)
			If mi Is Nothing Then
				Return Nothing
			End If
			Dim pBmp As IntPtr = IntPtr.Zero
			Dim status As Integer = GdipCreateBitmapFromGdiDib(pDIB, pPix, pBmp)
			If (status = 0) AndAlso (pBmp <> IntPtr.Zero) Then
				Return CType(mi.Invoke(Nothing, New Object() { pBmp }), Bitmap)
			Else
				Return Nothing
			End If
		End Function


		Private Function GetPixelInfo(ByVal bmpPtr As IntPtr) As IntPtr
			Dim bmi As BITMAPINFOHEADER = CType(Marshal.PtrToStructure(bmpPtr, GetType(BITMAPINFOHEADER)), BITMAPINFOHEADER)
			If bmi.biSizeImage = 0 Then
				bmi.biSizeImage = CUInt(((((bmi.biWidth * bmi.biBitCount) + 31) And (Not 31)) >> 3) * bmi.biHeight)
			End If
			Dim p As Integer = CInt(Fix(bmi.biClrUsed))
			If (p = 0) AndAlso (bmi.biBitCount <= 8) Then
				p = 1 << bmi.biBitCount
			End If
				p = (p * 4) + CInt(Fix(bmi.biSize)) + CInt(Fix(bmpPtr))
			Return New IntPtr(p)
		End Function

		Public Sub DisableDragDrop()
			RemoveHandler edit.DragEnter, AddressOf OnDragEnter
			RemoveHandler edit.DragDrop, AddressOf OnDragDrop
		End Sub
	End Class

	<StructLayout(LayoutKind.Sequential, Pack := 1)> _
	Public Structure BITMAPINFOHEADER
		Public biSize As UInteger
		Public biWidth As Integer
		Public biHeight As Integer
		Public biPlanes As UShort
		Public biBitCount As UShort
		Public biCompression As UInteger
		Public biSizeImage As UInteger
		Public biXPelsPerMeter As Integer
		Public biYPelsPerMeter As Integer
		Public biClrUsed As UInteger
		Public biClrImportant As UInteger

		Public Sub Init()
			biSize = CUInt(Marshal.SizeOf(Me))
		End Sub
	End Structure
End Namespace