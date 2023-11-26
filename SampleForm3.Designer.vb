<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampleForm3
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Vol.3のサンプル"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 45)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OLE DB接続"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 45)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "DBデータ登録"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(397, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 45)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "DBデータ読み込み"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 95)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 45)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "データセット１"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(205, 95)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(174, 45)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "データセット２"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(397, 95)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(174, 45)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "XMLドキュメントコメント"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'SampleForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SampleForm3"
        Me.Text = "SampleForm3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
