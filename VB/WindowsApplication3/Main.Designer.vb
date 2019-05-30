Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.Location = New System.Drawing.Point(12, 12)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Size = New System.Drawing.Size(358, 136)
			Me.pictureEdit1.StyleController = Me.layoutControl1
			Me.pictureEdit1.TabIndex = 0
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.pictureEdit1)
			Me.layoutControl1.Controls.Add(Me.simpleButton2)
			Me.layoutControl1.Controls.Add(Me.simpleButton1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(1032, 160)
			Me.layoutControl1.TabIndex = 3
			Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Image = Resources._2
            Me.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.simpleButton2.Location = New System.Drawing.Point(729, 12)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(291, 136)
			Me.simpleButton2.StyleController = Me.layoutControl1
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "simpleButton2"
            '			Me.simpleButton2.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnSimpleButtonMouseDown);
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Image = Resources._3
            Me.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.simpleButton1.Location = New System.Drawing.Point(374, 12)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(351, 136)
			Me.simpleButton1.StyleController = Me.layoutControl1
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "simpleButton1"
'			Me.simpleButton1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnSimpleButtonMouseDown);
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(1032, 160)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.simpleButton1
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(362, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(355, 140)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.simpleButton2
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(717, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(295, 140)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.pictureEdit1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(362, 140)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1032, 160)
			Me.Controls.Add(Me.layoutControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "PictureEdit Drag&Drop"
'			Me.Load += New System.EventHandler(Me.OnLoad);
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.OnFormClosing);
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

