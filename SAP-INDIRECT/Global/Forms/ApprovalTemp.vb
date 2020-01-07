Public Class ApprovalTemp

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        SelectionModule.iFindMulti(Me, 108, "Controlling Documents", Me.dgv_req, 173, "")
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        SelectionModule.iFindMulti(Me, 108, "Controlling Documents", Me.dgv_apv, 173, "")
    End Sub
End Class