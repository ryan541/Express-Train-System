<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingPage))
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdBookingTrain = New System.Windows.Forms.Button()
        Me.txtDestination = New System.Windows.Forms.ComboBox()
        Me.txtDeparture = New System.Windows.Forms.ComboBox()
        Me.txtTrainType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.CalendarFont = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(377, 276)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(200, 20)
        Me.txtDate.TabIndex = 17
        '
        'cmdBookingTrain
        '
        Me.cmdBookingTrain.BackColor = System.Drawing.Color.Blue
        Me.cmdBookingTrain.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBookingTrain.ForeColor = System.Drawing.Color.White
        Me.cmdBookingTrain.Location = New System.Drawing.Point(331, 329)
        Me.cmdBookingTrain.Name = "cmdBookingTrain"
        Me.cmdBookingTrain.Size = New System.Drawing.Size(103, 53)
        Me.cmdBookingTrain.TabIndex = 16
        Me.cmdBookingTrain.Text = "Book Train"
        Me.cmdBookingTrain.UseVisualStyleBackColor = False
        '
        'txtDestination
        '
        Me.txtDestination.FormattingEnabled = True
        Me.txtDestination.Items.AddRange(New Object() {"Mombasa Terminus", "Nairobi Terminus"})
        Me.txtDestination.Location = New System.Drawing.Point(331, 212)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(121, 21)
        Me.txtDestination.TabIndex = 15
        '
        'txtDeparture
        '
        Me.txtDeparture.FormattingEnabled = True
        Me.txtDeparture.Items.AddRange(New Object() {"Mombasa Terminus ", "Nairobi Terminus"})
        Me.txtDeparture.Location = New System.Drawing.Point(331, 145)
        Me.txtDeparture.Name = "txtDeparture"
        Me.txtDeparture.Size = New System.Drawing.Size(121, 21)
        Me.txtDeparture.TabIndex = 14
        '
        'txtTrainType
        '
        Me.txtTrainType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTrainType.FormattingEnabled = True
        Me.txtTrainType.Items.AddRange(New Object() {"Inter-County Train", "Express Train"})
        Me.txtTrainType.Location = New System.Drawing.Point(331, 83)
        Me.txtTrainType.Name = "txtTrainType"
        Me.txtTrainType.Size = New System.Drawing.Size(121, 21)
        Me.txtTrainType.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Departure Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(229, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Train Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(128, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(510, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "EXPRESSTRAIN BOOKING SYSTEM"
        '
        'BookingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.cmdBookingTrain)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtDeparture)
        Me.Controls.Add(Me.txtTrainType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BookingPage"
        Me.Text = "LoginPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents cmdBookingTrain As Button
    Friend WithEvents txtDestination As ComboBox
    Friend WithEvents txtDeparture As ComboBox
    Friend WithEvents txtTrainType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
