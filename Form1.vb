Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class Form1
    ' Declaraciones de la API de Windows para mover la ventana
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCHITTEST As Integer = &H84
        Const HTLEFT As Integer = 10
        Const HTRIGHT As Integer = 11
        Const HTTOP As Integer = 12
        Const HTTOPLEFT As Integer = 13
        Const HTTOPRIGHT As Integer = 14
        Const HTBOTTOM As Integer = 15
        Const HTBOTTOMLEFT As Integer = 16
        Const HTBOTTOMRIGHT As Integer = 17

        ' Llama al procedimiento base primero
        MyBase.WndProc(m)

        ' Si el mensaje es para verificar dónde está el mouse...
        If m.Msg = WM_NCHITTEST Then
            Dim mousePos As Point = Me.PointToClient(Cursor.Position)
            Dim resizeArea As Integer = 10 ' El grosor en píxeles de la zona sensible para estirar

            ' Esquina inferior derecha (la más común)
            If mousePos.X >= Me.ClientSize.Width - resizeArea AndAlso mousePos.Y >= Me.ClientSize.Height - resizeArea Then
                m.Result = New IntPtr(HTBOTTOMRIGHT)
                ' Esquina inferior izquierda
            ElseIf mousePos.X <= resizeArea AndAlso mousePos.Y >= Me.ClientSize.Height - resizeArea Then
                m.Result = New IntPtr(HTBOTTOMLEFT)
                ' Esquina superior derecha
            ElseIf mousePos.X >= Me.ClientSize.Width - resizeArea AndAlso mousePos.Y <= resizeArea Then
                m.Result = New IntPtr(HTTOPRIGHT)
                ' Esquina superior izquierda
            ElseIf mousePos.X <= resizeArea AndAlso mousePos.Y <= resizeArea Then
                m.Result = New IntPtr(HTTOPLEFT)
                ' Borde izquierdo
            ElseIf mousePos.X <= resizeArea Then
                m.Result = New IntPtr(HTLEFT)
                ' Borde derecho
            ElseIf mousePos.X >= Me.ClientSize.Width - resizeArea Then
                m.Result = New IntPtr(HTRIGHT)
                ' Borde superior
            ElseIf mousePos.Y <= resizeArea Then
                m.Result = New IntPtr(HTTOP)
                ' Borde inferior
            ElseIf mousePos.Y >= Me.ClientSize.Height - resizeArea Then
                m.Result = New IntPtr(HTBOTTOM)
            End If
        End If
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ' Si usas un Panel como barra de título, cambia "Handles MyBase.MouseDown" por "Handles MiPanel.MouseDown"
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private IsDragging As Boolean = False

    Private MouseOffset As Point

    Private formulario As Form = Nothing
    Private Sub AbrirFormulario(formulariohijo As Form)
        If formulario IsNot Nothing Then formulario.Close()
        formulario = formulariohijo
        formulariohijo.TopLevel = False
        formulariohijo.FormBorderStyle = FormBorderStyle.None
        formulariohijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(formulariohijo)
        PanelContenedor.Tag = formulariohijo
        formulariohijo.Show()
    End Sub

    Private Sub BtnBinomial_Click_1(sender As Object, e As EventArgs) Handles BtnBinomial.Click
        AbrirFormulario(New Binomial)
    End Sub

    Private Sub BtnPoisson_Click(sender As Object, e As EventArgs) Handles BtnPoisson.Click
        AbrirFormulario(New Poisson)
    End Sub

    Private Sub BtnHipergeometrica_Click(sender As Object, e As EventArgs) Handles BtnHipergeometrica.Click
        AbrirFormulario(New Hipergeometrica)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnNormal_Click(sender As Object, e As EventArgs) Handles BtnNormal.Click
        If Me.WindowState = FormWindowState.Maximized Then
            BtnNormal.Visible = False
            BtnMaximizar.Visible = True
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        If Me.WindowState = FormWindowState.Normal Then
            BtnMaximizar.Visible = False
            BtnNormal.Visible = True
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left AndAlso Me.WindowState = FormWindowState.Normal Then
            ReleaseCapture()
            SendMessage(Me.Handle, &H112, &HF012&, 0)
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If IsDragging Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(MouseOffset.X, MouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        IsDragging = False
    End Sub
End Class
