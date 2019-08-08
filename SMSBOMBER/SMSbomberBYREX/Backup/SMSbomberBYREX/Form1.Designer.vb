<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TargetTextBox = New System.Windows.Forms.TextBox
        Me.MessageTextBox = New System.Windows.Forms.TextBox
        Me.TargetLabel = New System.Windows.Forms.Label
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.NumberOfAttacksTextBox = New System.Windows.Forms.TextBox
        Me.NumberOfAttackLabel = New System.Windows.Forms.Label
        Me.AttackButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.TitleLabel = New System.Windows.Forms.Label
        Me.PortLabel = New System.Windows.Forms.Label
        Me.PortsComboBox = New System.Windows.Forms.ComboBox
        Me.ConnectButton = New System.Windows.Forms.Button
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumberOfSentTextBox = New System.Windows.Forms.TextBox
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.Status = New System.Windows.Forms.Label
        Me.disclaimer = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TargetTextBox
        '
        Me.TargetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetTextBox.Location = New System.Drawing.Point(74, 48)
        Me.TargetTextBox.Name = "TargetTextBox"
        Me.TargetTextBox.Size = New System.Drawing.Size(97, 20)
        Me.TargetTextBox.TabIndex = 0
        Me.TargetTextBox.Text = "+639057771868"
        '
        'MessageTextBox
        '
        Me.MessageTextBox.Location = New System.Drawing.Point(74, 83)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(306, 106)
        Me.MessageTextBox.TabIndex = 1
        '
        'TargetLabel
        '
        Me.TargetLabel.AutoSize = True
        Me.TargetLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.TargetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TargetLabel.Location = New System.Drawing.Point(12, 48)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(44, 13)
        Me.TargetLabel.TabIndex = 2
        Me.TargetLabel.Text = "Target"
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MessageLabel.Location = New System.Drawing.Point(12, 83)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(57, 13)
        Me.MessageLabel.TabIndex = 3
        Me.MessageLabel.Text = "Message"
        '
        'NumberOfAttacksTextBox
        '
        Me.NumberOfAttacksTextBox.Location = New System.Drawing.Point(74, 198)
        Me.NumberOfAttacksTextBox.Name = "NumberOfAttacksTextBox"
        Me.NumberOfAttacksTextBox.Size = New System.Drawing.Size(55, 20)
        Me.NumberOfAttacksTextBox.TabIndex = 4
        Me.NumberOfAttacksTextBox.Text = "1"
        '
        'NumberOfAttackLabel
        '
        Me.NumberOfAttackLabel.AutoSize = True
        Me.NumberOfAttackLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.NumberOfAttackLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfAttackLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.NumberOfAttackLabel.Location = New System.Drawing.Point(12, 198)
        Me.NumberOfAttackLabel.Name = "NumberOfAttackLabel"
        Me.NumberOfAttackLabel.Size = New System.Drawing.Size(56, 13)
        Me.NumberOfAttackLabel.TabIndex = 5
        Me.NumberOfAttackLabel.Text = "# of attk"
        '
        'AttackButton
        '
        Me.AttackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.AttackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AttackButton.FlatAppearance.BorderSize = 0
        Me.AttackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttackButton.ForeColor = System.Drawing.Color.White
        Me.AttackButton.Location = New System.Drawing.Point(142, 211)
        Me.AttackButton.Name = "AttackButton"
        Me.AttackButton.Size = New System.Drawing.Size(75, 23)
        Me.AttackButton.TabIndex = 6
        Me.AttackButton.Text = "Attack"
        Me.AttackButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(223, 211)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(304, 211)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(121, 10)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(177, 23)
        Me.TitleLabel.TabIndex = 9
        Me.TitleLabel.Text = "SMS BOMBER  by REX"
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.PortLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PortLabel.Location = New System.Drawing.Point(199, 48)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(30, 13)
        Me.PortLabel.TabIndex = 11
        Me.PortLabel.Text = "Port"
        '
        'PortsComboBox
        '
        Me.PortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PortsComboBox.FormattingEnabled = True
        Me.PortsComboBox.Location = New System.Drawing.Point(235, 45)
        Me.PortsComboBox.Name = "PortsComboBox"
        Me.PortsComboBox.Size = New System.Drawing.Size(64, 21)
        Me.PortsComboBox.TabIndex = 12
        '
        'ConnectButton
        '
        Me.ConnectButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ConnectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ConnectButton.FlatAppearance.BorderSize = 0
        Me.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectButton.ForeColor = System.Drawing.Color.White
        Me.ConnectButton.Location = New System.Drawing.Point(305, 43)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 13
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "sent:"
        '
        'NumberOfSentTextBox
        '
        Me.NumberOfSentTextBox.Enabled = False
        Me.NumberOfSentTextBox.Location = New System.Drawing.Point(74, 228)
        Me.NumberOfSentTextBox.Name = "NumberOfSentTextBox"
        Me.NumberOfSentTextBox.Size = New System.Drawing.Size(55, 20)
        Me.NumberOfSentTextBox.TabIndex = 15
        Me.NumberOfSentTextBox.Text = "0"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.StatusLabel.Location = New System.Drawing.Point(238, 67)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(47, 13)
        Me.StatusLabel.TabIndex = 16
        Me.StatusLabel.Text = "Status:"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(282, 67)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(81, 13)
        Me.Status.TabIndex = 17
        Me.Status.Text = "disconnected"
        '
        'disclaimer
        '
        Me.disclaimer.AutoSize = True
        Me.disclaimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.disclaimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disclaimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.disclaimer.Location = New System.Drawing.Point(146, 228)
        Me.disclaimer.Name = "disclaimer"
        Me.disclaimer.Size = New System.Drawing.Size(0, 13)
        Me.disclaimer.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(166, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 9)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "(godofping1111)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(392, 253)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.disclaimer)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.NumberOfSentTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.PortsComboBox)
        Me.Controls.Add(Me.PortLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AttackButton)
        Me.Controls.Add(Me.NumberOfAttackLabel)
        Me.Controls.Add(Me.NumberOfAttacksTextBox)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.TargetLabel)
        Me.Controls.Add(Me.MessageTextBox)
        Me.Controls.Add(Me.TargetTextBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS Bomber By REX"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TargetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TargetLabel As System.Windows.Forms.Label
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfAttacksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfAttackLabel As System.Windows.Forms.Label
    Friend WithEvents AttackButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents PortLabel As System.Windows.Forms.Label
    Friend WithEvents PortsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ConnectButton As System.Windows.Forms.Button
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumberOfSentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents disclaimer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
