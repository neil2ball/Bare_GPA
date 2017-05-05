Public Class gradePointForm

    Dim aPlus As Single = 4.0
    Const a As Single = 4.0
    Dim aMinus As Single = 4.0

    Dim bPlus As Single = 3.0
    Const b As Single = 3.0
    Dim bMinus As Single = 3.0

    Dim cPlus As Single = 2.0
    Const c As Single = 2.0
    Dim cMinus As Single = 2.0

    Dim dPlus As Single = 1.0
    Const d As Single = 1.0
    Dim dMinus As Single = 1.0

    Const f As Single = 0.0

    Private Sub gradePointForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ActualDataSet.Actual' table. You can move, or remove it, as needed.
        Me.ActualTableAdapter.Fill(Me.ActualDataSet.Actual)

        UpdateScore()

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click

        UpdateScore()

    End Sub

    Private Sub UpdateScore()

        GradePoints()

        coursesTakenTextBox.Text = "0"
        totalCreditsTextBox.Text = "0"
        qualityPointsTextBox.Text = "0"
        cumulativeGpaTextBox.Text = "0"

        For Each row As DataGridViewRow In classCreditsGradeDataGridView.Rows
            If Not row.IsNewRow Then
                coursesTakenTextBox.Text = CStr(CInt(coursesTakenTextBox.Text) + 1)
                totalCreditsTextBox.Text = CStr(CInt(totalCreditsTextBox.Text) + CInt(row.Cells(1).Value.ToString()))
                qualityPointsTextBox.Text = CStr(CSng(qualityPointsTextBox.Text) + (CSng(row.Cells(1).Value.ToString()) * GpaConvert(row.Cells(2).Value.ToString())))
            End If
        Next

        If CSng(totalCreditsTextBox.Text) > 0 Then
            cumulativeGpaTextBox.Text = CStr(CSng(qualityPointsTextBox.Text) / CSng(totalCreditsTextBox.Text))
        End If

    End Sub

    Private Sub GradePoints()

        aPlus = 4.0
        aMinus = 4.0
        bPlus = 3.0
        bMinus = 3.0
        cPlus = 2.0
        cMinus = 2.0
        dPlus = 1.0
        dMinus = 1.0


        If ucfRadioButton.Checked Then

            If aplusCheckBox.Checked Then
                aPlus = 4.25
            End If

            aMinus = 3.75
            bPlus = 3.25
            bMinus = 2.75
            cPlus = 2.25
            cMinus = 1.75
            dPlus = 1.25
            dMinus = 0.75

        ElseIf umRadioButton.Checked Then

            If aplusCheckBox.Checked Then
                aPlus = 4.3
            End If

            aMinus = 3.7
            bPlus = 3.3
            bMinus = 2.7
            cPlus = 2.3
            cMinus = 1.7
            dPlus = 1.3
            dMinus = 0.7

        ElseIf ufRadioButton.Checked Then

            If aplusCheckBox.Checked Then
                aPlus = 4.33
            End If

            aMinus = 3.67
            bPlus = 3.33
            bMinus = 2.67
            cPlus = 2.33
            cMinus = 1.67
            dPlus = 1.33
            dMinus = 0.67

        End If


    End Sub

    Private Function GpaConvert(ByRef gpa As String) As Single

        Select Case gpa.ToLower()
            Case "a+"
                Return aPlus
            Case "a"
                Return a
            Case "a-"
                Return aMinus
            Case "b+"
                Return bPlus
            Case "b"
                Return b
            Case "b-"
                Return bMinus
            Case "c+"
                Return cPlus
            Case "c"
                Return c
            Case "c-"
                Return cMinus
            Case "d+"
                Return dPlus
            Case "d"
                Return d
            Case "d-"
                Return dMinus
            Case "f"
                Return f
        End Select

        Return 0.0
    End Function

    Private Sub saveDbButton_Click(sender As Object, e As EventArgs) Handles saveDbButton.Click
        Try
            Me.Validate()
            Me.ActualBindingSource.EndEdit()
            Me.ActualTableAdapter.Update(Me.ActualDataSet.Actual)
            MsgBox("Update successful")
        Catch ex As Exception
            MsgBox("Update failed: " + ex.ToString())
        End Try

    End Sub
End Class
