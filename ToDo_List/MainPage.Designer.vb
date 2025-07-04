<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        txtEventName = New TextBox()
        lblNewEvent = New Label()
        dtpEventDate = New DateTimePicker()
        lblEventDate = New Label()
        btnAddEvent = New Button()
        lvwEventList = New ListView()
        lblUpcomingEvents = New Label()
        SuspendLayout()
        ' 
        ' txtEventName
        ' 
        txtEventName.Location = New Point(12, 45)
        txtEventName.Name = "txtEventName"
        txtEventName.Size = New Size(402, 27)
        txtEventName.TabIndex = 0
        ' 
        ' lblNewEvent
        ' 
        lblNewEvent.AutoSize = True
        lblNewEvent.Location = New Point(12, 22)
        lblNewEvent.Name = "lblNewEvent"
        lblNewEvent.Size = New Size(82, 20)
        lblNewEvent.TabIndex = 1
        lblNewEvent.Text = "New Event:"
        ' 
        ' dtpEventDate
        ' 
        dtpEventDate.Location = New Point(420, 45)
        dtpEventDate.Name = "dtpEventDate"
        dtpEventDate.Size = New Size(250, 27)
        dtpEventDate.TabIndex = 2
        ' 
        ' lblEventDate
        ' 
        lblEventDate.AutoSize = True
        lblEventDate.Location = New Point(420, 22)
        lblEventDate.Name = "lblEventDate"
        lblEventDate.Size = New Size(132, 20)
        lblEventDate.TabIndex = 3
        lblEventDate.Text = "Date Of The Event:"
        ' 
        ' btnAddEvent
        ' 
        btnAddEvent.Location = New Point(676, 43)
        btnAddEvent.Name = "btnAddEvent"
        btnAddEvent.Size = New Size(125, 29)
        btnAddEvent.TabIndex = 4
        btnAddEvent.Text = "Add Event"
        btnAddEvent.UseVisualStyleBackColor = True
        ' 
        ' lvwEventList
        ' 
        lvwEventList.Location = New Point(12, 108)
        lvwEventList.Name = "lvwEventList"
        lvwEventList.Size = New Size(1031, 578)
        lvwEventList.TabIndex = 5
        lvwEventList.UseCompatibleStateImageBehavior = False
        ' 
        ' lblUpcomingEvents
        ' 
        lblUpcomingEvents.AutoSize = True
        lblUpcomingEvents.Location = New Point(12, 85)
        lblUpcomingEvents.Name = "lblUpcomingEvents"
        lblUpcomingEvents.Size = New Size(129, 20)
        lblUpcomingEvents.TabIndex = 6
        lblUpcomingEvents.Text = "UpComing Events:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1055, 698)
        Controls.Add(lblUpcomingEvents)
        Controls.Add(lvwEventList)
        Controls.Add(btnAddEvent)
        Controls.Add(lblEventDate)
        Controls.Add(dtpEventDate)
        Controls.Add(lblNewEvent)
        Controls.Add(txtEventName)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "To Do List"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEventName As TextBox
    Friend WithEvents lblNewEvent As Label
    Friend WithEvents dtpEventDate As DateTimePicker
    Friend WithEvents lblEventDate As Label
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents lvwEventList As ListView
    Friend WithEvents lblUpcomingEvents As Label

End Class
