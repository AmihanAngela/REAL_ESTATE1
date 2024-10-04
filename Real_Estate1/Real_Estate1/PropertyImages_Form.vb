Public Class PropertyImages_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub PropertyImages_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Center the panel in the form
        Panel_Menu.Location = New Point(ClientSize.Width / 3 - ClientSize.Width / 4)

        'Make the panel right/left full height
        PanelLeft.Size = New Size(PanelLeft.Width, ClientSize.Height)
        PanelRight.Size = New Size(PanelRight.Width, ClientSize.Height)
        PanelRight.Location = New Point(ClientSize.Width - 5, 0)

        'Button close (upper right)
        ButtonClose.Location = New Point(ClientSize.Width - (PanelRight.Width + ButtonClose.Width + 10), 10)
    End Sub
End Class