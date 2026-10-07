<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Minimizar = New Button()
        BtnMaximizar = New Button()
        BtnNormal = New Button()
        BtnCerrar = New Button()
        Label1 = New Label()
        BtnHipergeometrica = New Button()
        BtnPoisson = New Button()
        BtnBinomial = New Button()
        Panel3 = New Panel()
        Panel2 = New Panel()
        PanelContenedor = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Minimizar)
        Panel1.Controls.Add(BtnMaximizar)
        Panel1.Controls.Add(BtnNormal)
        Panel1.Controls.Add(BtnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1200, 56)
        Panel1.TabIndex = 0
        ' 
        ' Minimizar
        ' 
        Minimizar.BackgroundImage = CType(resources.GetObject("Minimizar.BackgroundImage"), Image)
        Minimizar.BackgroundImageLayout = ImageLayout.Stretch
        Minimizar.Dock = DockStyle.Right
        Minimizar.FlatAppearance.MouseOverBackColor = Color.Gray
        Minimizar.FlatStyle = FlatStyle.Flat
        Minimizar.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Minimizar.Location = New Point(976, 0)
        Minimizar.Name = "Minimizar"
        Minimizar.Size = New Size(56, 56)
        Minimizar.TabIndex = 3
        Minimizar.UseVisualStyleBackColor = True
        ' 
        ' BtnMaximizar
        ' 
        BtnMaximizar.BackgroundImage = CType(resources.GetObject("BtnMaximizar.BackgroundImage"), Image)
        BtnMaximizar.BackgroundImageLayout = ImageLayout.Stretch
        BtnMaximizar.Dock = DockStyle.Right
        BtnMaximizar.FlatAppearance.MouseOverBackColor = Color.Gray
        BtnMaximizar.FlatStyle = FlatStyle.Flat
        BtnMaximizar.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnMaximizar.Location = New Point(1032, 0)
        BtnMaximizar.Name = "BtnMaximizar"
        BtnMaximizar.Size = New Size(56, 56)
        BtnMaximizar.TabIndex = 2
        BtnMaximizar.UseVisualStyleBackColor = True
        BtnMaximizar.Visible = False
        ' 
        ' BtnNormal
        ' 
        BtnNormal.BackgroundImage = CType(resources.GetObject("BtnNormal.BackgroundImage"), Image)
        BtnNormal.BackgroundImageLayout = ImageLayout.Stretch
        BtnNormal.Dock = DockStyle.Right
        BtnNormal.FlatAppearance.MouseOverBackColor = Color.Gray
        BtnNormal.FlatStyle = FlatStyle.Flat
        BtnNormal.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNormal.Location = New Point(1088, 0)
        BtnNormal.Name = "BtnNormal"
        BtnNormal.Size = New Size(56, 56)
        BtnNormal.TabIndex = 1
        BtnNormal.UseVisualStyleBackColor = True
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), Image)
        BtnCerrar.BackgroundImageLayout = ImageLayout.Stretch
        BtnCerrar.Dock = DockStyle.Right
        BtnCerrar.FlatAppearance.MouseOverBackColor = Color.Gray
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCerrar.Location = New Point(1144, 0)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(56, 56)
        BtnCerrar.TabIndex = 0
        BtnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("MS Reference Sans Serif", 35F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(32, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(1137, 86)
        Label1.TabIndex = 0
        Label1.Text = "Distribuciones De Probabilidad"
        ' 
        ' BtnHipergeometrica
        ' 
        BtnHipergeometrica.BackColor = Color.Black
        BtnHipergeometrica.Dock = DockStyle.Top
        BtnHipergeometrica.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnHipergeometrica.FlatAppearance.MouseOverBackColor = Color.Gray
        BtnHipergeometrica.FlatStyle = FlatStyle.Flat
        BtnHipergeometrica.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnHipergeometrica.ForeColor = Color.White
        BtnHipergeometrica.Location = New Point(0, 210)
        BtnHipergeometrica.Name = "BtnHipergeometrica"
        BtnHipergeometrica.Size = New Size(300, 105)
        BtnHipergeometrica.TabIndex = 2
        BtnHipergeometrica.Text = "Distribución Hipergeométrica"
        BtnHipergeometrica.UseVisualStyleBackColor = False
        ' 
        ' BtnPoisson
        ' 
        BtnPoisson.BackColor = Color.Black
        BtnPoisson.Dock = DockStyle.Top
        BtnPoisson.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnPoisson.FlatAppearance.MouseOverBackColor = Color.Gray
        BtnPoisson.FlatStyle = FlatStyle.Flat
        BtnPoisson.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnPoisson.ForeColor = Color.White
        BtnPoisson.Location = New Point(0, 0)
        BtnPoisson.Name = "BtnPoisson"
        BtnPoisson.Size = New Size(300, 105)
        BtnPoisson.TabIndex = 1
        BtnPoisson.Text = "Distribución De Poisson"
        BtnPoisson.UseVisualStyleBackColor = False
        ' 
        ' BtnBinomial
        ' 
        BtnBinomial.BackColor = Color.Black
        BtnBinomial.Dock = DockStyle.Top
        BtnBinomial.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnBinomial.FlatAppearance.MouseOverBackColor = Color.Gray
        BtnBinomial.FlatStyle = FlatStyle.Flat
        BtnBinomial.Font = New Font("MS Reference Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBinomial.ForeColor = Color.White
        BtnBinomial.Location = New Point(0, 105)
        BtnBinomial.Name = "BtnBinomial"
        BtnBinomial.Size = New Size(300, 105)
        BtnBinomial.TabIndex = 0
        BtnBinomial.Text = "Distribución Binomial"
        BtnBinomial.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 56)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1200, 130)
        Panel3.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(BtnHipergeometrica)
        Panel2.Controls.Add(BtnBinomial)
        Panel2.Controls.Add(BtnPoisson)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 186)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 770)
        Panel2.TabIndex = 4
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.Transparent
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(300, 186)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(900, 770)
        PanelContenedor.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 956)
        ControlBox = False
        Controls.Add(PanelContenedor)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1200, 956)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnBinomial As Button
    Friend WithEvents BtnPoisson As Button
    Friend WithEvents BtnHipergeometrica As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnNormal As Button

End Class
