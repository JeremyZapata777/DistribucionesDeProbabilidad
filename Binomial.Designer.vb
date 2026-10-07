<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Binomial
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
        Txtx = New TextBox()
        Txtn = New TextBox()
        Txtp = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label8 = New Label()
        TxtPorcentaje = New TextBox()
        Label6 = New Label()
        ChkAcumulativa = New CheckBox()
        TxtDecimal = New TextBox()
        ChkExacta = New CheckBox()
        BtnBinomial = New Button()
        Label1 = New Label()
        BtnLimpiar = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(29, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 56)
        Button1.TabIndex = 4
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Txtx
        ' 
        Txtx.Anchor = AnchorStyles.None
        Txtx.Font = New Font("MS Reference Sans Serif", 12F)
        Txtx.Location = New Point(131, 308)
        Txtx.Name = "Txtx"
        Txtx.Size = New Size(195, 37)
        Txtx.TabIndex = 1
        Txtx.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txtn
        ' 
        Txtn.Anchor = AnchorStyles.None
        Txtn.Font = New Font("MS Reference Sans Serif", 12F)
        Txtn.Location = New Point(131, 217)
        Txtn.Name = "Txtn"
        Txtn.Size = New Size(195, 37)
        Txtn.TabIndex = 1
        Txtn.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txtp
        ' 
        Txtp.Anchor = AnchorStyles.None
        Txtp.Font = New Font("MS Reference Sans Serif", 12F)
        Txtp.Location = New Point(131, 392)
        Txtp.Name = "Txtp"
        Txtp.Size = New Size(195, 37)
        Txtp.TabIndex = 1
        Txtp.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label4.Location = New Point(120, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(206, 33)
        Label4.TabIndex = 0
        Label4.Text = "Porcentaje(p)"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label3.Location = New Point(78, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(301, 33)
        Label3.TabIndex = 0
        Label3.Text = "Número de éxitos(x)"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label5.Location = New Point(550, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(186, 33)
        Label5.TabIndex = 0
        Label5.Text = "Acumulativa"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label2.Location = New Point(62, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(333, 33)
        Label2.TabIndex = 0
        Label2.Text = "Número de muestra(n)"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(324, 541)
        Label8.Name = "Label8"
        Label8.Size = New Size(176, 38)
        Label8.TabIndex = 0
        Label8.Text = "Resultado"
        ' 
        ' TxtPorcentaje
        ' 
        TxtPorcentaje.Anchor = AnchorStyles.Bottom
        TxtPorcentaje.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPorcentaje.Location = New Point(460, 582)
        TxtPorcentaje.Name = "TxtPorcentaje"
        TxtPorcentaje.Size = New Size(215, 44)
        TxtPorcentaje.TabIndex = 1
        TxtPorcentaje.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold)
        Label6.Location = New Point(551, 316)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 33)
        Label6.TabIndex = 0
        Label6.Text = "Exacta"
        ' 
        ' ChkAcumulativa
        ' 
        ChkAcumulativa.Anchor = AnchorStyles.None
        ChkAcumulativa.AutoSize = True
        ChkAcumulativa.Location = New Point(762, 267)
        ChkAcumulativa.Name = "ChkAcumulativa"
        ChkAcumulativa.Size = New Size(22, 21)
        ChkAcumulativa.TabIndex = 2
        ChkAcumulativa.UseVisualStyleBackColor = True
        ' 
        ' TxtDecimal
        ' 
        TxtDecimal.Anchor = AnchorStyles.Bottom
        TxtDecimal.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtDecimal.Location = New Point(150, 582)
        TxtDecimal.Name = "TxtDecimal"
        TxtDecimal.Size = New Size(222, 44)
        TxtDecimal.TabIndex = 1
        TxtDecimal.TextAlign = HorizontalAlignment.Center
        ' 
        ' ChkExacta
        ' 
        ChkExacta.Anchor = AnchorStyles.None
        ChkExacta.AutoSize = True
        ChkExacta.Location = New Point(762, 328)
        ChkExacta.Name = "ChkExacta"
        ChkExacta.Size = New Size(22, 21)
        ChkExacta.TabIndex = 2
        ChkExacta.UseVisualStyleBackColor = True
        ' 
        ' BtnBinomial
        ' 
        BtnBinomial.Anchor = AnchorStyles.Bottom
        BtnBinomial.BackColor = Color.Silver
        BtnBinomial.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBinomial.Location = New Point(120, 476)
        BtnBinomial.Name = "BtnBinomial"
        BtnBinomial.Size = New Size(252, 62)
        BtnBinomial.TabIndex = 3
        BtnBinomial.Text = "Realizar cálculo"
        BtnBinomial.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("MS Reference Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(98, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(680, 74)
        Label1.TabIndex = 0
        Label1.Text = "Distribución Binomial"
        ' 
        ' BtnLimpiar
        ' 
        BtnLimpiar.Anchor = AnchorStyles.Bottom
        BtnLimpiar.BackColor = Color.Silver
        BtnLimpiar.Font = New Font("MS Reference Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLimpiar.Location = New Point(460, 476)
        BtnLimpiar.Name = "BtnLimpiar"
        BtnLimpiar.Size = New Size(252, 62)
        BtnLimpiar.TabIndex = 3
        BtnLimpiar.Text = "Limpiar datos"
        BtnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' Binomial
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(846, 638)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(ChkExacta)
        Controls.Add(BtnLimpiar)
        Controls.Add(BtnBinomial)
        Controls.Add(Label6)
        Controls.Add(ChkAcumulativa)
        Controls.Add(TxtDecimal)
        Controls.Add(Label5)
        Controls.Add(TxtPorcentaje)
        Controls.Add(Label2)
        Controls.Add(Txtn)
        Controls.Add(Label3)
        Controls.Add(Label8)
        Controls.Add(Txtx)
        Controls.Add(Label4)
        Controls.Add(Txtp)
        Name = "Binomial"
        Text = "Binomial"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Txtx As TextBox
    Friend WithEvents Txtn As TextBox
    Friend WithEvents Txtp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPorcentaje As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ChkAcumulativa As CheckBox
    Friend WithEvents TxtDecimal As TextBox
    Friend WithEvents ChkExacta As CheckBox
    Friend WithEvents BtnBinomial As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLimpiar As Button
End Class
