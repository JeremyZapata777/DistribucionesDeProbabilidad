<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hipergeometrica
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
        Button1 = New Button()
        Txtm = New TextBox()
        TxtN = New TextBox()
        Txta = New TextBox()
        Label1 = New Label()
        Txtx = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        TxtDecimal = New TextBox()
        BtnBinomial = New Button()
        TxtPorcentaje = New TextBox()
        Label4 = New Label()
        BtnLimpiar = New Button()
        ChkExacta = New CheckBox()
        Label6 = New Label()
        ChkAcumulativa = New CheckBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.FlatAppearance.MouseDownBackColor = Color.Silver
        Button1.FlatAppearance.MouseOverBackColor = Color.Silver
        Button1.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 56)
        Button1.TabIndex = 14
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Txtm
        ' 
        Txtm.Anchor = AnchorStyles.None
        Txtm.Font = New Font("MS Reference Sans Serif", 12F)
        Txtm.Location = New Point(197, 257)
        Txtm.Name = "Txtm"
        Txtm.Size = New Size(147, 37)
        Txtm.TabIndex = 11
        Txtm.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtN
        ' 
        TxtN.Anchor = AnchorStyles.None
        TxtN.Font = New Font("MS Reference Sans Serif", 12F)
        TxtN.Location = New Point(197, 181)
        TxtN.Name = "TxtN"
        TxtN.Size = New Size(149, 37)
        TxtN.TabIndex = 12
        TxtN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txta
        ' 
        Txta.Anchor = AnchorStyles.None
        Txta.Font = New Font("MS Reference Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txta.Location = New Point(197, 351)
        Txta.Name = "Txta"
        Txta.Size = New Size(149, 34)
        Txta.TabIndex = 10
        Txta.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(792, 61)
        Label1.TabIndex = 2
        Label1.Text = "Distribución Hipergeométrica"
        ' 
        ' Txtx
        ' 
        Txtx.Anchor = AnchorStyles.None
        Txtx.Font = New Font("MS Reference Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txtx.Location = New Point(197, 440)
        Txtx.Name = "Txtx"
        Txtx.Size = New Size(144, 34)
        Txtx.TabIndex = 10
        Txtx.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(110, 404)
        Label5.Name = "Label5"
        Label5.Size = New Size(301, 33)
        Label5.TabIndex = 4
        Label5.Text = "Número de éxitos(x)"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(91, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(333, 33)
        Label3.TabIndex = 6
        Label3.Text = "Número de muestra(n)"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(335, 574)
        Label8.Name = "Label8"
        Label8.Size = New Size(176, 38)
        Label8.TabIndex = 5
        Label8.Text = "Resultado"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(174, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 33)
        Label2.TabIndex = 7
        Label2.Text = "Población(N)"
        ' 
        ' TxtDecimal
        ' 
        TxtDecimal.Anchor = AnchorStyles.Bottom
        TxtDecimal.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtDecimal.Location = New Point(192, 626)
        TxtDecimal.Name = "TxtDecimal"
        TxtDecimal.Size = New Size(176, 44)
        TxtDecimal.TabIndex = 9
        TxtDecimal.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnBinomial
        ' 
        BtnBinomial.Anchor = AnchorStyles.Bottom
        BtnBinomial.BackColor = Color.Silver
        BtnBinomial.FlatAppearance.BorderColor = Color.Black
        BtnBinomial.FlatAppearance.MouseDownBackColor = Color.Silver
        BtnBinomial.FlatAppearance.MouseOverBackColor = Color.Silver
        BtnBinomial.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBinomial.Location = New Point(141, 491)
        BtnBinomial.Name = "BtnBinomial"
        BtnBinomial.Size = New Size(252, 62)
        BtnBinomial.TabIndex = 13
        BtnBinomial.Text = "Realizar cálculo"
        BtnBinomial.UseVisualStyleBackColor = False
        ' 
        ' TxtPorcentaje
        ' 
        TxtPorcentaje.Anchor = AnchorStyles.Bottom
        TxtPorcentaje.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPorcentaje.Location = New Point(480, 626)
        TxtPorcentaje.Name = "TxtPorcentaje"
        TxtPorcentaje.Size = New Size(176, 44)
        TxtPorcentaje.TabIndex = 8
        TxtPorcentaje.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(8, 315)
        Label4.Name = "Label4"
        Label4.Size = New Size(499, 33)
        Label4.TabIndex = 4
        Label4.Text = "Número de éxitos comprobados(a)"
        ' 
        ' BtnLimpiar
        ' 
        BtnLimpiar.Anchor = AnchorStyles.Bottom
        BtnLimpiar.BackColor = Color.Silver
        BtnLimpiar.FlatAppearance.BorderColor = Color.Black
        BtnLimpiar.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnLimpiar.FlatAppearance.MouseOverBackColor = Color.Silver
        BtnLimpiar.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLimpiar.Location = New Point(456, 491)
        BtnLimpiar.Name = "BtnLimpiar"
        BtnLimpiar.Size = New Size(252, 62)
        BtnLimpiar.TabIndex = 13
        BtnLimpiar.Text = "Limpiar datos"
        BtnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' ChkExacta
        ' 
        ChkExacta.Anchor = AnchorStyles.None
        ChkExacta.AutoSize = True
        ChkExacta.Location = New Point(760, 303)
        ChkExacta.Name = "ChkExacta"
        ChkExacta.Size = New Size(22, 21)
        ChkExacta.TabIndex = 17
        ChkExacta.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label6.Location = New Point(549, 291)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 33)
        Label6.TabIndex = 15
        Label6.Text = "Exacta"
        ' 
        ' ChkAcumulativa
        ' 
        ChkAcumulativa.Anchor = AnchorStyles.None
        ChkAcumulativa.AutoSize = True
        ChkAcumulativa.Location = New Point(760, 242)
        ChkAcumulativa.Name = "ChkAcumulativa"
        ChkAcumulativa.Size = New Size(22, 21)
        ChkAcumulativa.TabIndex = 18
        ChkAcumulativa.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label7.Location = New Point(548, 232)
        Label7.Name = "Label7"
        Label7.Size = New Size(186, 33)
        Label7.TabIndex = 16
        Label7.Text = "Acumulativa"
        ' 
        ' Hipergeometrica
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(868, 694)
        Controls.Add(ChkExacta)
        Controls.Add(Label6)
        Controls.Add(ChkAcumulativa)
        Controls.Add(Label7)
        Controls.Add(BtnLimpiar)
        Controls.Add(BtnBinomial)
        Controls.Add(TxtPorcentaje)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(TxtDecimal)
        Controls.Add(Button1)
        Controls.Add(Txtx)
        Controls.Add(Txta)
        Controls.Add(Label5)
        Controls.Add(Txtm)
        Controls.Add(Label1)
        Controls.Add(TxtN)
        Controls.Add(Label2)
        Controls.Add(Label3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Hipergeometrica"
        Text = "Hipergeometrica"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Txtm As TextBox
    Friend WithEvents TxtN As TextBox
    Friend WithEvents Txta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDecimal As TextBox
    Friend WithEvents BtnBinomial As Button
    Friend WithEvents TxtPorcentaje As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents ChkExacta As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ChkAcumulativa As CheckBox
    Friend WithEvents Label7 As Label
End Class
