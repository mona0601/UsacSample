<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SampleForm2
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Vol.2のサンプル"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 45)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "引数の値型／参照型"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 45)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "モジュール"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(428, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 45)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "プロパティ設定"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(29, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 45)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "アプリケーション構成ファイル"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(226, 112)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(174, 45)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "設定ファイル"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(428, 112)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(174, 45)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "iniファイル"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(614, 50)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(174, 45)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "デバッグ　例外ハンドリング"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(428, 181)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(174, 45)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "iniファイル"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'SampleForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 278)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SampleForm2"
        Me.Text = "Form2"
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
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
