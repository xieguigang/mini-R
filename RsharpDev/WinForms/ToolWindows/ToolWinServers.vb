﻿Imports Microsoft.VisualBasic.Linq
Imports WeifenLuo.WinFormsUI.Docking

Public Class ToolWinServers

    Private Sub ToolWinServers_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabText = "Linux Server Resources"

        Call ApplyVsTheme()
        Call LoadServers()
        Call VisualStudio.vsWindow.Add(Me)
    End Sub

    Public Overrides Sub ApplyVsTheme()
        VisualStudioToolStripExtender1.ApplyVsTheme(ToolStrip1)
    End Sub

    Private Sub ToolStripButtonAddServer_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAddServer.Click
        Call New AddLinuxServer().ShowDialog()
        Call LoadServers()
    End Sub

    Public Sub LoadServers()
        Dim root = TreeView1.Nodes(Scan0)
        Dim serverNode As TreeNode

        root.Nodes.Clear()

        For Each server In Program.Config.server.SafeQuery
            serverNode = New TreeNode(server.name) With {.Tag = server, .ImageIndex = 2}
            root.Nodes.Add(serverNode)
        Next
    End Sub
End Class