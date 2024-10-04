Imports System.Security.AccessControl

Public Class PropertyForm
    Dim theType As New The_Type
    Dim theProperty As New The_Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub



    Private Sub PropertyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display the property types in the combox
        ComboBoxTYPE.DataSource = theType.getAllTypes()
        ComboBoxTYPE.DisplayMember = "name"
        ComboBoxTYPE.ValueMember = "id"
    End Sub

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        ' Button to add new property
        Try
            Dim type As Integer = ComboBoxTYPE.SelectedValue
            Dim ownerId As Integer = Convert.ToInt32(TextBoxOWNER_ID.Text)
            Dim size As Integer = Convert.ToInt32(TextBoxSIZE.Text)
            Dim price As String = TextBoxPRICE.Text
            Dim address As String = TextBoxADDRESS.Text
            Dim comment As String = TextBoxCOMMENTS.Text
            Dim beds As Integer = NumericUpDownBEDS.Value
            Dim baths As Integer = NumericUpDownBATHS.Value
            Dim age As Integer = NumericUpDownAGE.Value
            Dim hasBalcony As Boolean = CheckBoxBALCONY.Checked
            Dim hasBackyard As Boolean = CheckBoxBACKYARD.Checked
            Dim hasGarage As Boolean = CheckBoxGARAGE.Checked
            Dim hasPool As Boolean = CheckBoxPOOL.Checked
            Dim hasFireplace As Boolean = CheckBoxFIREPLACE.Checked
            Dim hasElevator As Boolean = CheckBoxELEVATOR.Checked

            ' Validate inputs
            If String.IsNullOrWhiteSpace(price) OrElse String.IsNullOrWhiteSpace(address) Then
                MessageBox.Show("Price and address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Call addProperty function with all required parameters
            If theProperty.addProperty(type, ownerId, size, price, address, beds, baths, age, hasBalcony, hasBackyard, hasGarage, hasPool, hasFireplace, hasElevator, comment) Then
                MessageBox.Show("Property added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtonCLEARFIELDS.PerformClick() ' Clear fields after adding
            Else
                MessageBox.Show("Failed to add property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ButtonEDIT_Click(sender As Object, e As EventArgs) Handles ButtonEDIT.Click
        'button to edit selected  property

    End Sub

    Private Sub ButtonREMOVE_Click(sender As Object, e As EventArgs) Handles ButtonREMOVE.Click
        'button to remove selected property

    End Sub

    Private Sub ButtonCLEARFIELDS_Click(sender As Object, e As EventArgs) Handles ButtonCLEARFIELDS.Click
        'button to clear fields 
        TextBoxID.Text = ""
        TextBoxADDRESS.Text = ""
        TextBoxCOMMENTS.Text = ""
        TextBoxOWNER_ID.Text = ""
        TextBoxPRICE.Text = ""
        TextBoxSIZE.Text = ""

        'set the numericUpDown to 0
        NumericUpDownAGE.Value = 0
        NumericUpDownBATHS.Value = 0
        NumericUpDownBEDS.Value = 0


        CheckBoxBALCONY.Checked = False
        CheckBoxBACKYARD.Checked = False
        CheckBoxGARAGE.Checked = False
        CheckBoxFIREPLACE.Checked = False
        CheckBoxPOOL.Checked = False
        CheckBoxELEVATOR.Checked = False


    End Sub

    Private Sub Button_ShowAllProperty_Click(sender As Object, e As EventArgs) Handles Button_ShowAllProperty.Click
        'button to show all property

    End Sub

    Private Sub Button_ShowPropertyImage_Click(sender As Object, e As EventArgs) Handles Button_ShowPropertyImage.Click
        'button to show property image

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class