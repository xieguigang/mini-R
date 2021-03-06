﻿
Partial Class ToolWindow
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
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
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FloatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualStudioToolStripExtender1 = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)

        Me.contextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FloatToolStripMenuItem, Me.HideToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(104, 70)
        '
        'FloatToolStripMenuItem
        '
        Me.FloatToolStripMenuItem.Name = "FloatToolStripMenuItem"
        Me.FloatToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.FloatToolStripMenuItem.Text = "Float"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VisualStudioToolStripExtender1
        '
        Me.VisualStudioToolStripExtender1.DefaultRenderer = Nothing
        '
        'ToolWindow
        '
        Me.ClientSize = New System.Drawing.Size(597, 403)
        Me.DockAreas = CType(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float Or WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) _
            Or WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) _
            Or WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) _
            Or WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom), WeifenLuo.WinFormsUI.Docking.DockAreas)
        Me.Name = "ToolWindow"
        Me.TabPageContextMenuStrip = Me.contextMenuStrip1
        Me.TabText = "ToolWindow"
        Me.Text = "ToolWindow"
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private contextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Private WithEvents FloatToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Private WithEvents HideToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Private WithEvents CloseToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualStudioToolStripExtender1 As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender

End Class

