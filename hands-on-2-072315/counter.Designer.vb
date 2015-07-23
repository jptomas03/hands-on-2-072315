<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class counter
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
        Me.CounterLabel = New System.Windows.Forms.Label()
        Me.CustomersNameTB = New System.Windows.Forms.TextBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.CustomersNameLabel = New System.Windows.Forms.Label()
        Me.NumberOfPagesLabel = New System.Windows.Forms.Label()
        Me.NumberOfPagesTB = New System.Windows.Forms.TextBox()
        Me.PricePerPageLabel = New System.Windows.Forms.Label()
        Me.PricePerPageTB = New System.Windows.Forms.TextBox()
        Me.AmountDueLabel = New System.Windows.Forms.Label()
        Me.AmountDueTB = New System.Windows.Forms.TextBox()
        Me.CompanyNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CounterLabel
        '
        Me.CounterLabel.AutoSize = True
        Me.CounterLabel.Location = New System.Drawing.Point(93, 34)
        Me.CounterLabel.Name = "CounterLabel"
        Me.CounterLabel.Size = New System.Drawing.Size(44, 13)
        Me.CounterLabel.TabIndex = 1
        Me.CounterLabel.Text = "Counter"
        '
        'CustomersNameTB
        '
        Me.CustomersNameTB.Location = New System.Drawing.Point(120, 50)
        Me.CustomersNameTB.Name = "CustomersNameTB"
        Me.CustomersNameTB.Size = New System.Drawing.Size(100, 20)
        Me.CustomersNameTB.TabIndex = 2
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(28, 154)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(192, 23)
        Me.ComputeButton.TabIndex = 3
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'CustomersNameLabel
        '
        Me.CustomersNameLabel.AutoSize = True
        Me.CustomersNameLabel.Location = New System.Drawing.Point(25, 57)
        Me.CustomersNameLabel.Name = "CustomersNameLabel"
        Me.CustomersNameLabel.Size = New System.Drawing.Size(89, 13)
        Me.CustomersNameLabel.TabIndex = 4
        Me.CustomersNameLabel.Text = "Customer's Name"
        '
        'NumberOfPagesLabel
        '
        Me.NumberOfPagesLabel.AutoSize = True
        Me.NumberOfPagesLabel.Location = New System.Drawing.Point(25, 83)
        Me.NumberOfPagesLabel.Name = "NumberOfPagesLabel"
        Me.NumberOfPagesLabel.Size = New System.Drawing.Size(89, 13)
        Me.NumberOfPagesLabel.TabIndex = 6
        Me.NumberOfPagesLabel.Text = "Number of Pages"
        '
        'NumberOfPagesTB
        '
        Me.NumberOfPagesTB.Location = New System.Drawing.Point(120, 76)
        Me.NumberOfPagesTB.Name = "NumberOfPagesTB"
        Me.NumberOfPagesTB.Size = New System.Drawing.Size(100, 20)
        Me.NumberOfPagesTB.TabIndex = 5
        '
        'PricePerPageLabel
        '
        Me.PricePerPageLabel.AutoSize = True
        Me.PricePerPageLabel.Location = New System.Drawing.Point(25, 109)
        Me.PricePerPageLabel.Name = "PricePerPageLabel"
        Me.PricePerPageLabel.Size = New System.Drawing.Size(77, 13)
        Me.PricePerPageLabel.TabIndex = 8
        Me.PricePerPageLabel.Text = "Price per Page"
        '
        'PricePerPageTB
        '
        Me.PricePerPageTB.Location = New System.Drawing.Point(120, 102)
        Me.PricePerPageTB.Name = "PricePerPageTB"
        Me.PricePerPageTB.ReadOnly = True
        Me.PricePerPageTB.Size = New System.Drawing.Size(100, 20)
        Me.PricePerPageTB.TabIndex = 7
        Me.PricePerPageTB.Text = "2.75"
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.AutoSize = True
        Me.AmountDueLabel.Location = New System.Drawing.Point(25, 135)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(66, 13)
        Me.AmountDueLabel.TabIndex = 10
        Me.AmountDueLabel.Text = "Amount Due"
        '
        'AmountDueTB
        '
        Me.AmountDueTB.Location = New System.Drawing.Point(120, 128)
        Me.AmountDueTB.Name = "AmountDueTB"
        Me.AmountDueTB.ReadOnly = True
        Me.AmountDueTB.Size = New System.Drawing.Size(100, 20)
        Me.AmountDueTB.TabIndex = 9
        '
        'CompanyNameLabel
        '
        Me.CompanyNameLabel.AutoSize = True
        Me.CompanyNameLabel.Location = New System.Drawing.Point(64, 9)
        Me.CompanyNameLabel.Name = "CompanyNameLabel"
        Me.CompanyNameLabel.Size = New System.Drawing.Size(109, 13)
        Me.CompanyNameLabel.TabIndex = 11
        Me.CompanyNameLabel.Text = "Busy Business Center"
        '
        'counter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 200)
        Me.Controls.Add(Me.CompanyNameLabel)
        Me.Controls.Add(Me.AmountDueLabel)
        Me.Controls.Add(Me.AmountDueTB)
        Me.Controls.Add(Me.PricePerPageLabel)
        Me.Controls.Add(Me.PricePerPageTB)
        Me.Controls.Add(Me.NumberOfPagesLabel)
        Me.Controls.Add(Me.NumberOfPagesTB)
        Me.Controls.Add(Me.CustomersNameLabel)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.CustomersNameTB)
        Me.Controls.Add(Me.CounterLabel)
        Me.Name = "counter"
        Me.Text = "Busy Business Center"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CounterLabel As System.Windows.Forms.Label
    Friend WithEvents CustomersNameTB As System.Windows.Forms.TextBox
    Friend WithEvents ComputeButton As System.Windows.Forms.Button
    Friend WithEvents CustomersNameLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfPagesLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfPagesTB As System.Windows.Forms.TextBox
    Friend WithEvents PricePerPageLabel As System.Windows.Forms.Label
    Friend WithEvents PricePerPageTB As System.Windows.Forms.TextBox
    Friend WithEvents AmountDueLabel As System.Windows.Forms.Label
    Friend WithEvents AmountDueTB As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameLabel As System.Windows.Forms.Label

End Class
