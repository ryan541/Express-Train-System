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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.CalendarFont = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(503, 340)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(265, 22)
        Me.txtDate.TabIndex = 4
        '
        'cmdBookingTrain
        '
        Me.cmdBookingTrain.BackColor = System.Drawing.Color.Blue
        Me.cmdBookingTrain.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBookingTrain.ForeColor = System.Drawing.Color.White
        Me.cmdBookingTrain.Location = New System.Drawing.Point(441, 405)
        Me.cmdBookingTrain.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBookingTrain.Name = "cmdBookingTrain"
        Me.cmdBookingTrain.Size = New System.Drawing.Size(137, 65)
        Me.cmdBookingTrain.TabIndex = 5
        Me.cmdBookingTrain.Text = "Book Train"
        Me.cmdBookingTrain.UseVisualStyleBackColor = False
        '
        'txtDestination
        '
        Me.txtDestination.FormattingEnabled = True
        Me.txtDestination.Items.AddRange(New Object() {"Mombasa Terminus", "Nairobi Terminus"})
        Me.txtDestination.Location = New System.Drawing.Point(441, 282)
        Me.txtDestination.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(160, 24)
        Me.txtDestination.TabIndex = 3
        '
        'txtDeparture
        '
        Me.txtDeparture.FormattingEnabled = True
        Me.txtDeparture.Items.AddRange(New Object() {"Mombasa Terminus ", "Nairobi Terminus"})
        Me.txtDeparture.Location = New System.Drawing.Point(441, 214)
        Me.txtDeparture.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeparture.Name = "txtDeparture"
        Me.txtDeparture.Size = New System.Drawing.Size(160, 24)
        Me.txtDeparture.TabIndex = 2
        '
        'txtTrainType
        '
        Me.txtTrainType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTrainType.FormattingEnabled = True
        Me.txtTrainType.Items.AddRange(New Object() {"Inter-County Train", "Express Train"})
        Me.txtTrainType.Location = New System.Drawing.Point(441, 139)
        Me.txtTrainType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrainType.Name = "txtTrainType"
        Me.txtTrainType.Size = New System.Drawing.Size(160, 24)
        Me.txtTrainType.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 340)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Departure Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(297, 282)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 214)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Train Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(171, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(660, 42)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "EXPRESSTRAIN BOOKING SYSTEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ID Number"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(441, 75)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(160, 22)
        Me.txtID.TabIndex = 0
        '
        'BookingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookingPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookingPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBookingTrain As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents txtDate As DateTimePicker
    Public WithEvents txtDestination As ComboBox
    Public WithEvents txtDeparture As ComboBox
    Public WithEvents txtTrainType As ComboBox
    Public WithEvents txtID As TextBox
End Class
