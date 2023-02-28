<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalc
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
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.lblPayrollTitle = New System.Windows.Forms.Label()
        Me.lblPaycheck = New System.Windows.Forms.Label()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtPayEntry = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitleFICA = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblTitleFedTax = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblTitleState = New System.Windows.Forms.Label()
        Me.lblTitleNetIncome = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = Global.Payroll_Calculator.My.Resources.Resources.payroll
        Me.picPayroll.Location = New System.Drawing.Point(-1, -1)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(400, 300)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'lblPayrollTitle
        '
        Me.lblPayrollTitle.AutoSize = True
        Me.lblPayrollTitle.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollTitle.Location = New System.Drawing.Point(417, 49)
        Me.lblPayrollTitle.Name = "lblPayrollTitle"
        Me.lblPayrollTitle.Size = New System.Drawing.Size(358, 42)
        Me.lblPayrollTitle.TabIndex = 1
        Me.lblPayrollTitle.Text = "Payroll Calculator"
        '
        'lblPaycheck
        '
        Me.lblPaycheck.AutoSize = True
        Me.lblPaycheck.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaycheck.Location = New System.Drawing.Point(501, 120)
        Me.lblPaycheck.Name = "lblPaycheck"
        Me.lblPaycheck.Size = New System.Drawing.Size(144, 31)
        Me.lblPaycheck.TabIndex = 2
        Me.lblPaycheck.Text = "Paycheck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblPaycheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculation.Location = New System.Drawing.Point(490, 173)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(172, 31)
        Me.lblCalculation.TabIndex = 3
        Me.lblCalculation.Text = "Calculation"
        Me.lblCalculation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(204, 325)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(241, 33)
        Me.lblGrossPay.TabIndex = 4
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'txtPayEntry
        '
        Me.txtPayEntry.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayEntry.Location = New System.Drawing.Point(496, 322)
        Me.txtPayEntry.Name = "txtPayEntry"
        Me.txtPayEntry.Size = New System.Drawing.Size(127, 40)
        Me.txtPayEntry.TabIndex = 5
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(86, 378)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(150, 45)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute Taxes"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(325, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 45)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(564, 378)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 45)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitleFICA
        '
        Me.lblTitleFICA.AutoSize = True
        Me.lblTitleFICA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFICA.Location = New System.Drawing.Point(82, 451)
        Me.lblTitleFICA.Name = "lblTitleFICA"
        Me.lblTitleFICA.Size = New System.Drawing.Size(54, 19)
        Me.lblTitleFICA.TabIndex = 9
        Me.lblTitleFICA.Text = "FICA:"
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(142, 451)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(42, 19)
        Me.lblFICA.TabIndex = 10
        Me.lblFICA.Text = "XXX"
        '
        'lblTitleFedTax
        '
        Me.lblTitleFedTax.AutoSize = True
        Me.lblTitleFedTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFedTax.Location = New System.Drawing.Point(302, 451)
        Me.lblTitleFedTax.Name = "lblTitleFedTax"
        Me.lblTitleFedTax.Size = New System.Drawing.Size(112, 19)
        Me.lblTitleFedTax.TabIndex = 11
        Me.lblTitleFedTax.Text = "Federal Tax:"
        '
        'lblFedTax
        '
        Me.lblFedTax.AutoSize = True
        Me.lblFedTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedTax.Location = New System.Drawing.Point(420, 451)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(42, 19)
        Me.lblFedTax.TabIndex = 12
        Me.lblFedTax.Text = "XXX"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(672, 451)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(42, 19)
        Me.lblStateTax.TabIndex = 14
        Me.lblStateTax.Text = "XXX"
        '
        'lblTitleState
        '
        Me.lblTitleState.AutoSize = True
        Me.lblTitleState.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleState.Location = New System.Drawing.Point(554, 451)
        Me.lblTitleState.Name = "lblTitleState"
        Me.lblTitleState.Size = New System.Drawing.Size(95, 19)
        Me.lblTitleState.TabIndex = 13
        Me.lblTitleState.Text = "State Tax:"
        '
        'lblTitleNetIncome
        '
        Me.lblTitleNetIncome.AutoSize = True
        Me.lblTitleNetIncome.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNetIncome.Location = New System.Drawing.Point(128, 503)
        Me.lblTitleNetIncome.Name = "lblTitleNetIncome"
        Me.lblTitleNetIncome.Size = New System.Drawing.Size(247, 25)
        Me.lblTitleNetIncome.TabIndex = 15
        Me.lblTitleNetIncome.Text = "Net Paycheck Income:"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetIncome.Location = New System.Drawing.Point(502, 503)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(130, 25)
        Me.lblNetIncome.TabIndex = 15
        Me.lblNetIncome.Text = "$XXXXX.XX"
        '
        'frmPayrollCalc
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 561)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.lblTitleNetIncome)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblTitleState)
        Me.Controls.Add(Me.lblFedTax)
        Me.Controls.Add(Me.lblTitleFedTax)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblTitleFICA)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtPayEntry)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.lblPaycheck)
        Me.Controls.Add(Me.lblPayrollTitle)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "frmPayrollCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblPayrollTitle As Label
    Friend WithEvents lblPaycheck As Label
    Friend WithEvents lblCalculation As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtPayEntry As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitleFICA As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblTitleFedTax As Label
    Friend WithEvents lblFedTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblTitleState As Label
    Friend WithEvents lblTitleNetIncome As Label
    Friend WithEvents lblNetIncome As Label
End Class
