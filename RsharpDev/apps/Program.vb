﻿Imports Microsoft.VisualBasic.Linq
Imports My
Imports RDev
Imports RibbonLib.Interop
Imports SMRUCC.Rsharp.Interpreter
Imports WeifenLuo.WinFormsUI.Docking

Friend NotInheritable Class Program

    Public Shared ReadOnly Property REngine As New RInterpreter
    Public Shared ReadOnly Property Solution As Solution

    Shared Sub New()
        Call RDev.DescriptionTooltip.SetEngine(REngine)
    End Sub

    Public Shared Sub LoadSolution(Rproj As String)
        Dim ribbon = MyApplication.RStudio.ribbon

        _Solution = Solution.LoadRproj(Rproj)

        VisualStudio.SolutionView.TreeView1.Nodes(Scan0).Text = $"Solution '{Solution.LoadInformation.Package}'"
        VisualStudio.SolutionView.DockState = DockState.DockRight

        ribbon.SoluationTabGroup.ContextAvailable = ContextAvailability.Active
        ribbon.SoluationTabGroup.Label = $"Solution [{Solution.LoadInformation.Package}]"
        ribbon.SolutionTab.Label = ribbon.SoluationTabGroup.Label

        MyApplication.RStudio.Text = $"R# Develop Studio [{Rproj}]"

        VisualStudio.SolutionView.TreeView1.Nodes(Scan0).Nodes.Clear()
        VisualStudio.SolutionView.TreeView1.Nodes(Scan0).DoCall(Sub(root) listFolder(root, Rproj.ParentPath))
    End Sub

    Private Shared Sub listFolder(explorer As TreeNode, folder As String)
        For Each dir As String In folder.ListDirectory
            Dim dirNode As New TreeNode With {
                .Text = dir.BaseName,
                .ImageIndex = VisualStudio.FolderClose
            }

            explorer.Nodes.Add(dirNode)
            listFolder(dirNode, dir)
        Next

        For Each file As String In folder.EnumerateFiles
            Dim fileNode As New TreeNode With {.Text = file.FileName, .Tag = file}

            explorer.Nodes.Add(fileNode)
        Next
    End Sub

    Public Shared Sub Initialize()

    End Sub

End Class
