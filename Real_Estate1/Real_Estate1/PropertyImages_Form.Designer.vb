<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyImages_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertyImages_Form))
        Panel_Menu = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Button_ShowProperty = New Button()
        ButtonREMOVE = New Button()
        ButtonADD = New Button()
        Button_SelectImage = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox_PropertyImage = New PictureBox()
        ListBox_Images = New ListBox()
        DataGridViewProperties = New DataGridView()
        DataGridViewType = New DataGridView()
        ButtonClose = New Button()
        MySqlCommandBuilder1 = New MySqlConnector.MySqlCommandBuilder()
        PanelLeft = New Panel()
        PanelRight = New Panel()
        Panel_Menu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox_PropertyImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewProperties, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewType, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel_Menu
        ' 
        Panel_Menu.BackColor = Color.LightPink
        Panel_Menu.Controls.Add(Panel2)
        Panel_Menu.Controls.Add(Label1)
        Panel_Menu.Controls.Add(PictureBox1)
        Panel_Menu.Location = New Point(135, 12)
        Panel_Menu.Name = "Panel_Menu"
        Panel_Menu.Size = New Size(1649, 950)
        Panel_Menu.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(12, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1585, 10)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(84, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(645, 76)
        Label1.TabIndex = 1
        Label1.Text = "PROPERTY IMAGES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-46, -10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 123)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(Button_ShowProperty)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(Button_SelectImage)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(PictureBox_PropertyImage)
        Panel3.Controls.Add(ListBox_Images)
        Panel3.Controls.Add(DataGridViewProperties)
        Panel3.Controls.Add(DataGridViewType)
        Panel3.Location = New Point(62, 121)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1722, 800)
        Panel3.TabIndex = 4
        ' 
        ' Button_ShowProperty
        ' 
        Button_ShowProperty.BackColor = Color.MediumTurquoise
        Button_ShowProperty.ForeColor = Color.White
        Button_ShowProperty.Location = New Point(441, 724)
        Button_ShowProperty.Name = "Button_ShowProperty"
        Button_ShowProperty.Size = New Size(330, 50)
        Button_ShowProperty.TabIndex = 17
        Button_ShowProperty.Text = "Show This Property Images"
        Button_ShowProperty.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.Red
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(866, 724)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(296, 50)
        ButtonREMOVE.TabIndex = 16
        ButtonREMOVE.Text = "REMOVE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.YellowGreen
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(1337, 669)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(286, 50)
        ButtonADD.TabIndex = 15
        ButtonADD.Text = "Add Image"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' Button_SelectImage
        ' 
        Button_SelectImage.BackColor = Color.DarkKhaki
        Button_SelectImage.ForeColor = Color.White
        Button_SelectImage.Location = New Point(1337, 613)
        Button_SelectImage.Name = "Button_SelectImage"
        Button_SelectImage.Size = New Size(286, 50)
        Button_SelectImage.TabIndex = 14
        Button_SelectImage.Text = "Select Image"
        Button_SelectImage.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1447, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 23)
        Label5.TabIndex = 7
        Label5.Text = "IMAGE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(982, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 23)
        Label4.TabIndex = 6
        Label4.Text = "IMAGES"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(555, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 23)
        Label3.TabIndex = 5
        Label3.Text = "PROPERTIES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(180, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 23)
        Label2.TabIndex = 4
        Label2.Text = "Types"
        ' 
        ' PictureBox_PropertyImage
        ' 
        PictureBox_PropertyImage.BackColor = Color.MistyRose
        PictureBox_PropertyImage.Location = New Point(1240, 89)
        PictureBox_PropertyImage.Name = "PictureBox_PropertyImage"
        PictureBox_PropertyImage.Size = New Size(450, 518)
        PictureBox_PropertyImage.TabIndex = 3
        PictureBox_PropertyImage.TabStop = False
        ' 
        ' ListBox_Images
        ' 
        ListBox_Images.FormattingEnabled = True
        ListBox_Images.ItemHeight = 25
        ListBox_Images.Location = New Point(837, 90)
        ListBox_Images.Name = "ListBox_Images"
        ListBox_Images.Size = New Size(352, 629)
        ListBox_Images.TabIndex = 2
        ' 
        ' DataGridViewProperties
        ' 
        DataGridViewProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProperties.Location = New Point(430, 90)
        DataGridViewProperties.Name = "DataGridViewProperties"
        DataGridViewProperties.RowHeadersWidth = 62
        DataGridViewProperties.Size = New Size(365, 629)
        DataGridViewProperties.TabIndex = 1
        ' 
        ' DataGridViewType
        ' 
        DataGridViewType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewType.Location = New Point(38, 88)
        DataGridViewType.Name = "DataGridViewType"
        DataGridViewType.RowHeadersWidth = 62
        DataGridViewType.Size = New Size(353, 631)
        DataGridViewType.TabIndex = 0
        ' 
        ' ButtonClose
        ' 
        ButtonClose.BackColor = Color.White
        ButtonClose.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonClose.Location = New Point(1758, 1)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(48, 44)
        ButtonClose.TabIndex = 6
        ButtonClose.Text = "X"
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' MySqlCommandBuilder1
        ' 
        MySqlCommandBuilder1.DataAdapter = Nothing
        MySqlCommandBuilder1.QuotePrefix = "`"
        MySqlCommandBuilder1.QuoteSuffix = "`"
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.RosyBrown
        PanelLeft.Location = New Point(0, 1)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(5, 261)
        PanelLeft.TabIndex = 4
        ' 
        ' PanelRight
        ' 
        PanelRight.BackColor = Color.RosyBrown
        PanelRight.Location = New Point(1813, 1)
        PanelRight.Name = "PanelRight"
        PanelRight.Size = New Size(5, 261)
        PanelRight.TabIndex = 5
        ' 
        ' PropertyImages_Form
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(1818, 1050)
        Controls.Add(Panel3)
        Controls.Add(ButtonClose)
        Controls.Add(PanelRight)
        Controls.Add(PanelLeft)
        Controls.Add(Panel_Menu)
        Name = "PropertyImages_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PropertyImages_Form"
        WindowState = FormWindowState.Maximized
        Panel_Menu.ResumeLayout(False)
        Panel_Menu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox_PropertyImage, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewProperties, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewType, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox_PropertyImage As PictureBox
    Friend WithEvents ListBox_Images As ListBox
    Friend WithEvents DataGridViewProperties As DataGridView
    Friend WithEvents DataGridViewType As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonADD As Button
    Friend WithEvents Button_SelectImage As Button
    Friend WithEvents MySqlCommandBuilder1 As MySqlConnector.MySqlCommandBuilder
    Friend WithEvents Button_ShowProperty As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelRight As Panel
End Class
