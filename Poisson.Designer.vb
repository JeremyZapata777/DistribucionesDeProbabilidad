<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Poisson
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ChkExacta = New CheckBox()
        ChkAcumulativa = New CheckBox()
        Label6 = New Label()
        Label5 = New Label()
        Txtx = New TextBox()
        Txtm = New TextBox()
        BtnPoisson = New Button()
        TxtPorcentaje = New TextBox()
        TxtDecimal = New TextBox()
        Label8 = New Label()
        Button1 = New Button()
        BtnLimpiar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(754, 74)
        Label1.TabIndex = 1
        Label1.Text = "Distribución De Poisson"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label2.Location = New Point(122, 196)
        Label2.MaximumSize = New Size(304, 38)
        Label2.MinimumSize = New Size(241, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(263, 33)
        Label2.TabIndex = 1
        Label2.Text = "Promedio o Media"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label3.Location = New Point(96, 324)
        Label3.Name = "Label3"
        Label3.Size = New Size(311, 33)
        Label3.TabIndex = 1
        Label3.Text = "Número de éxitos (x)"
        ' 
        ' ChkExacta
        ' 
        ChkExacta.Anchor = AnchorStyles.None
        ChkExacta.AutoSize = True
        ChkExacta.Location = New Point(665, 310)
        ChkExacta.Name = "ChkExacta"
        ChkExacta.Size = New Size(22, 21)
        ChkExacta.TabIndex = 7
        ChkExacta.UseVisualStyleBackColor = True
        ' 
        ' ChkAcumulativa
        ' 
        ChkAcumulativa.Anchor = AnchorStyles.None
        ChkAcumulativa.AutoSize = True
        ChkAcumulativa.Location = New Point(665, 259)
        ChkAcumulativa.Name = "ChkAcumulativa"
        ChkAcumulativa.Size = New Size(22, 21)
        ChkAcumulativa.TabIndex = 8
        ChkAcumulativa.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label6.Location = New Point(473, 300)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 33)
        Label6.TabIndex = 4
        Label6.Text = "Exacta"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label5.Location = New Point(473, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(186, 33)
        Label5.TabIndex = 5
        Label5.Text = "Acumulativa"
        ' 
        ' Txtx
        ' 
        Txtx.Anchor = AnchorStyles.None
        Txtx.Font = New Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txtx.Location = New Point(154, 374)
        Txtx.Name = "Txtx"
        Txtx.Size = New Size(196, 37)
        Txtx.TabIndex = 9
        Txtx.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txtm
        ' 
        Txtm.Anchor = AnchorStyles.None
        Txtm.Font = New Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txtm.Location = New Point(154, 249)
        Txtm.Name = "Txtm"
        Txtm.Size = New Size(196, 37)
        Txtm.TabIndex = 10
        Txtm.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnPoisson
        ' 
        BtnPoisson.Anchor = AnchorStyles.Bottom
        BtnPoisson.BackColor = Color.Silver
        BtnPoisson.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPoisson.Location = New Point(145, 447)
        BtnPoisson.Name = "BtnPoisson"
        BtnPoisson.Size = New Size(253, 66)
        BtnPoisson.TabIndex = 14
        BtnPoisson.Text = "Realizar cálculo"
        BtnPoisson.UseVisualStyleBackColor = False
        ' 
        ' TxtPorcentaje
        ' 
        TxtPorcentaje.Anchor = AnchorStyles.Bottom
        TxtPorcentaje.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPorcentaje.Location = New Point(486, 580)
        TxtPorcentaje.Name = "TxtPorcentaje"
        TxtPorcentaje.Size = New Size(177, 44)
        TxtPorcentaje.TabIndex = 12
        TxtPorcentaje.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtDecimal
        ' 
        TxtDecimal.Anchor = AnchorStyles.Bottom
        TxtDecimal.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtDecimal.Location = New Point(195, 580)
        TxtDecimal.Name = "TxtDecimal"
        TxtDecimal.Size = New Size(177, 44)
        TxtDecimal.TabIndex = 13
        TxtDecimal.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(339, 525)
        Label8.Name = "Label8"
        Label8.Size = New Size(176, 38)
        Label8.TabIndex = 11
        Label8.Text = "Resultado"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 60)
        Button1.TabIndex = 15
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BtnLimpiar
        ' 
        BtnLimpiar.Anchor = AnchorStyles.Bottom
        BtnLimpiar.BackColor = Color.Silver
        BtnLimpiar.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLimpiar.Location = New Point(455, 447)
        BtnLimpiar.Name = "BtnLimpiar"
        BtnLimpiar.Size = New Size(253, 66)
        BtnLimpiar.TabIndex = 14
        BtnLimpiar.Text = "Limpiar datos"
        BtnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' Poisson
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(868, 694)
        Controls.Add(Label1)
        Controls.Add(Txtx)
        Controls.Add(ChkExacta)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(ChkAcumulativa)
        Controls.Add(TxtDecimal)
        Controls.Add(TxtPorcentaje)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Txtm)
        Controls.Add(Label3)
        Controls.Add(BtnLimpiar)
        Controls.Add(BtnPoisson)
        Controls.Add(Label8)
        FormBorderStyle = FormBorderStyle.None
        Name = "Poisson"
        Text = "Poisson"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ChkMayor As CheckBox
    Friend WithEvents ChkExacta As CheckBox
    Friend WithEvents ChkAcumulativa As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtx As TextBox
    Friend WithEvents Txtm As TextBox
    Friend WithEvents BtnPoisson As Button
    Friend WithEvents TxtPorcentaje As TextBox
    Friend WithEvents TxtDecimal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnLimpiar As Button
End Class
