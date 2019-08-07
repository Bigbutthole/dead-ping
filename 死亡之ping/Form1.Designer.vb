<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Stops = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Many = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Stops
        '
        Me.Stops.Location = New System.Drawing.Point(238, 151)
        Me.Stops.Name = "Stops"
        Me.Stops.Size = New System.Drawing.Size(75, 23)
        Me.Stops.TabIndex = 0
        Me.Stops.Text = "停止攻击"
        Me.Stops.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(35, 151)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "开始攻击"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(134, 23)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(113, 21)
        Me.Address.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ip address :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "线程数："
        '
        'Many
        '
        Me.Many.Location = New System.Drawing.Point(134, 74)
        Me.Many.Name = "Many"
        Me.Many.Size = New System.Drawing.Size(113, 21)
        Me.Many.TabIndex = 5
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(149, 156)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(0, 12)
        Me.Label.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "攻击目标"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(339, 216)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Many)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Stops)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.75R
        Me.ShowIcon = False
        Me.Text = "Death ping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Stops As Windows.Forms.Button
    Friend WithEvents Start As Windows.Forms.Button
    Friend WithEvents Address As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Many As Windows.Forms.TextBox
    Friend WithEvents Label As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
End Class
