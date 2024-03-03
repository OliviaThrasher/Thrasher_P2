<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PicPayroll = New PictureBox()
        LabelTitle = New Label()
        BoxInput = New TextBox()
        ButtonCompute = New Button()
        ButtonClear = New Button()
        ButtonExit = New Button()
        LabelNetPay = New Label()
        BoxNetPaycheck = New TextBox()
        LabelGrossPay = New Label()
        LabelFICA = New Label()
        LabelFederal = New Label()
        LabelState = New Label()
        FicaBox = New TextBox()
        FedBox = New TextBox()
        StateBox = New TextBox()
        CType(PicPayroll, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicPayroll
        ' 
        PicPayroll.BackgroundImage = CType(resources.GetObject("PicPayroll.BackgroundImage"), Image)
        PicPayroll.BackgroundImageLayout = ImageLayout.Stretch
        PicPayroll.Location = New Point(1, 0)
        PicPayroll.Name = "PicPayroll"
        PicPayroll.Size = New Size(359, 237)
        PicPayroll.TabIndex = 0
        PicPayroll.TabStop = False
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Dubai", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.Location = New Point(454, 9)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(262, 54)
        LabelTitle.TabIndex = 1
        LabelTitle.Text = "Payroll Calculator"
        ' 
        ' BoxInput
        ' 
        BoxInput.BorderStyle = BorderStyle.FixedSingle
        BoxInput.Location = New Point(599, 131)
        BoxInput.Name = "BoxInput"
        BoxInput.Size = New Size(150, 31)
        BoxInput.TabIndex = 3
        ' 
        ' ButtonCompute
        ' 
        ButtonCompute.BackColor = Color.RoyalBlue
        ButtonCompute.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonCompute.ForeColor = SystemColors.ControlLightLight
        ButtonCompute.Location = New Point(63, 263)
        ButtonCompute.Name = "ButtonCompute"
        ButtonCompute.Size = New Size(187, 53)
        ButtonCompute.TabIndex = 4
        ButtonCompute.Text = "Compute Taxes"
        ButtonCompute.UseVisualStyleBackColor = False
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = Color.RoyalBlue
        ButtonClear.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonClear.ForeColor = SystemColors.ControlLightLight
        ButtonClear.Location = New Point(307, 263)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(187, 53)
        ButtonClear.TabIndex = 5
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' ButtonExit
        ' 
        ButtonExit.BackColor = Color.RoyalBlue
        ButtonExit.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonExit.ForeColor = SystemColors.ControlLightLight
        ButtonExit.Location = New Point(551, 263)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.Size = New Size(187, 53)
        ButtonExit.TabIndex = 6
        ButtonExit.Text = "Exit"
        ButtonExit.UseVisualStyleBackColor = False
        ' 
        ' LabelNetPay
        ' 
        LabelNetPay.AutoSize = True
        LabelNetPay.Font = New Font("Dubai Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelNetPay.Location = New Point(173, 390)
        LabelNetPay.Name = "LabelNetPay"
        LabelNetPay.Size = New Size(263, 40)
        LabelNetPay.TabIndex = 7
        LabelNetPay.Text = "Net Paycheck Income: "
        ' 
        ' BoxNetPaycheck
        ' 
        BoxNetPaycheck.BorderStyle = BorderStyle.FixedSingle
        BoxNetPaycheck.Enabled = False
        BoxNetPaycheck.Location = New Point(477, 395)
        BoxNetPaycheck.Name = "BoxNetPaycheck"
        BoxNetPaycheck.Size = New Size(150, 31)
        BoxNetPaycheck.TabIndex = 8
        ' 
        ' LabelGrossPay
        ' 
        LabelGrossPay.AutoSize = True
        LabelGrossPay.Font = New Font("Dubai Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelGrossPay.Location = New Point(366, 121)
        LabelGrossPay.Name = "LabelGrossPay"
        LabelGrossPay.Size = New Size(227, 48)
        LabelGrossPay.TabIndex = 12
        LabelGrossPay.Text = "Enter Gross Pay:"
        ' 
        ' LabelFICA
        ' 
        LabelFICA.AutoSize = True
        LabelFICA.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelFICA.Location = New Point(63, 336)
        LabelFICA.Name = "LabelFICA"
        LabelFICA.Size = New Size(58, 34)
        LabelFICA.TabIndex = 13
        LabelFICA.Text = "FICA:"
        ' 
        ' LabelFederal
        ' 
        LabelFederal.AutoSize = True
        LabelFederal.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelFederal.Location = New Point(286, 336)
        LabelFederal.Name = "LabelFederal"
        LabelFederal.Size = New Size(113, 34)
        LabelFederal.TabIndex = 14
        LabelFederal.Text = "Federal Tax:"
        ' 
        ' LabelState
        ' 
        LabelState.AutoSize = True
        LabelState.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelState.Location = New Point(566, 336)
        LabelState.Name = "LabelState"
        LabelState.Size = New Size(97, 34)
        LabelState.TabIndex = 15
        LabelState.Text = "State Tax:"
        ' 
        ' FicaBox
        ' 
        FicaBox.BackColor = SystemColors.Menu
        FicaBox.BorderStyle = BorderStyle.None
        FicaBox.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FicaBox.Location = New Point(127, 336)
        FicaBox.Name = "FicaBox"
        FicaBox.Size = New Size(153, 34)
        FicaBox.TabIndex = 19
        ' 
        ' FedBox
        ' 
        FedBox.BackColor = SystemColors.Menu
        FedBox.BorderStyle = BorderStyle.None
        FedBox.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FedBox.Location = New Point(405, 336)
        FedBox.Name = "FedBox"
        FedBox.Size = New Size(136, 34)
        FedBox.TabIndex = 20
        ' 
        ' StateBox
        ' 
        StateBox.BackColor = SystemColors.Menu
        StateBox.BorderStyle = BorderStyle.None
        StateBox.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StateBox.Location = New Point(669, 336)
        StateBox.Name = "StateBox"
        StateBox.Size = New Size(119, 34)
        StateBox.TabIndex = 21
        ' 
        ' Form1
        ' 
        AcceptButton = ButtonCompute
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = ButtonExit
        ClientSize = New Size(800, 450)
        Controls.Add(StateBox)
        Controls.Add(FedBox)
        Controls.Add(FicaBox)
        Controls.Add(LabelState)
        Controls.Add(LabelFederal)
        Controls.Add(LabelFICA)
        Controls.Add(LabelGrossPay)
        Controls.Add(BoxNetPaycheck)
        Controls.Add(LabelNetPay)
        Controls.Add(ButtonExit)
        Controls.Add(ButtonClear)
        Controls.Add(ButtonCompute)
        Controls.Add(BoxInput)
        Controls.Add(LabelTitle)
        Controls.Add(PicPayroll)
        Name = "Form1"
        Text = "Payroll Application"
        CType(PicPayroll, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicPayroll As PictureBox
    Protected WithEvents LabelTitle As Label
    Friend WithEvents BoxInput As TextBox
    Friend WithEvents ButtonCompute As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents LabelNetPay As Label
    Friend WithEvents BoxNetPaycheck As TextBox
    Friend WithEvents LabelGrossPay As Label
    Friend WithEvents LabelFICA As Label
    Friend WithEvents LabelFederal As Label
    Friend WithEvents LabelState As Label
    Friend WithEvents FicaBox As TextBox
    Friend WithEvents FedBox As TextBox
    Friend WithEvents StateBox As TextBox

End Class
