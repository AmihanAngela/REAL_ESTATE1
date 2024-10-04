<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyTypeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertyTypeForm))
        Panel1 = New Panel()
        Panel3 = New Panel()
        ListBoxTypes = New ListBox()
        ButtonCLEARFIELDS = New Button()
        ButtonREMOVE = New Button()
        ButtonEDIT = New Button()
        ButtonADD = New Button()
        TextBoxDESCRIPTION = New TextBox()
        Label7 = New Label()
        TextBoxNAME = New TextBox()
        Label3 = New Label()
        TextBoxID = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.YellowGreen
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(50, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1186, 1021)
        Panel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(ListBoxTypes)
        Panel3.Controls.Add(ButtonCLEARFIELDS)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonEDIT)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(TextBoxDESCRIPTION)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBoxNAME)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBoxID)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1169, 577)
        Panel3.TabIndex = 3
        ' 
        ' ListBoxTypes
        ' 
        ListBoxTypes.FormattingEnabled = True
        ListBoxTypes.ItemHeight = 25
        ListBoxTypes.Location = New Point(672, 41)
        ListBoxTypes.Name = "ListBoxTypes"
        ListBoxTypes.Size = New Size(438, 479)
        ListBoxTypes.TabIndex = 17
        ' 
        ' ButtonCLEARFIELDS
        ' 
        ButtonCLEARFIELDS.BackColor = Color.Gold
        ButtonCLEARFIELDS.ForeColor = Color.Black
        ButtonCLEARFIELDS.Location = New Point(63, 435)
        ButtonCLEARFIELDS.Name = "ButtonCLEARFIELDS"
        ButtonCLEARFIELDS.Size = New Size(527, 63)
        ButtonCLEARFIELDS.TabIndex = 16
        ButtonCLEARFIELDS.Text = "Clear Fields"
        ButtonCLEARFIELDS.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.Red
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(398, 366)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(192, 63)
        ButtonREMOVE.TabIndex = 15
        ButtonREMOVE.Text = "REMOVE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonEDIT
        ' 
        ButtonEDIT.BackColor = Color.DeepSkyBlue
        ButtonEDIT.ForeColor = Color.White
        ButtonEDIT.Location = New Point(231, 366)
        ButtonEDIT.Name = "ButtonEDIT"
        ButtonEDIT.Size = New Size(169, 63)
        ButtonEDIT.TabIndex = 14
        ButtonEDIT.Text = "EDIT"
        ButtonEDIT.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.YellowGreen
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(63, 366)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(169, 63)
        ButtonADD.TabIndex = 13
        ButtonADD.Text = "ADD"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' TextBoxDESCRIPTION
        ' 
        TextBoxDESCRIPTION.Location = New Point(189, 218)
        TextBoxDESCRIPTION.Multiline = True
        TextBoxDESCRIPTION.Name = "TextBoxDESCRIPTION"
        TextBoxDESCRIPTION.Size = New Size(368, 128)
        TextBoxDESCRIPTION.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(56, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 30)
        Label7.TabIndex = 10
        Label7.Text = "Description:"
        ' 
        ' TextBoxNAME
        ' 
        TextBoxNAME.Location = New Point(189, 144)
        TextBoxNAME.Multiline = True
        TextBoxNAME.Name = "TextBoxNAME"
        TextBoxNAME.Size = New Size(249, 43)
        TextBoxNAME.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(102, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 30)
        Label3.TabIndex = 2
        Label3.Text = "Name:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(189, 76)
        TextBoxID.Multiline = True
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(249, 44)
        TextBoxID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(139, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 30)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(12, 106)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1585, 10)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Gill Sans Ultra Bold", 26.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(98, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 76)
        Label1.TabIndex = 1
        Label1.Text = "TYPES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1233, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(54, 44)
        Button1.TabIndex = 6
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PropertyTypeForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.YellowGreen
        ClientSize = New Size(1299, 1035)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PropertyTypeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PropertyTypeForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonCLEARFIELDS As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonEDIT As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents TextBoxDESCRIPTION As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxNAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBoxTypes As ListBox
End Class
