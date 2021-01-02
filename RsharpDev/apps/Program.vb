﻿Imports RDev
Imports SMRUCC.Rsharp.Interpreter

Friend NotInheritable Class Program

    Public Shared ReadOnly Property REngine As New RInterpreter
    Public Shared ReadOnly Property Solution As Solution

    Shared Sub New()
        Call RDev.Description.SetEngine(REngine)
    End Sub

    Public Shared Sub Initialize()

    End Sub

End Class
