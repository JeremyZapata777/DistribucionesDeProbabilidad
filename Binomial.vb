Public Class Binomial
    Dim n As Integer
    Dim x As Integer
    Dim p As Double
    Dim resultado As Double
    Dim resultado2 As Double
    Dim entero As Integer
    Dim decimales As Double
    Private Sub BtnBinomial_Click(sender As Object, e As EventArgs) Handles BtnBinomial.Click
        n = Convert.ToInt32(Txtn.Text)
        x = Convert.ToInt32(Txtx.Text)
        p = Convert.ToDouble(Txtp.Text)
        resultado = BinomialAcumulado(n, x, p)
        resultado2 = Binomial(n, x, p)

        If n < 0 Or x < 0 Or p < 0 Then
            MessageBox.Show("No se pueden ingresar valores negativos en ninguno de los datos.")
        ElseIf p > 1 Then
            MessageBox.Show("El porcentaje no puede superar el número 1.")
        ElseIf x > n Then
            MessageBox.Show("El número de éxitos (x) no puede ser mayor que la muestra (n).")
        ElseIf ChkAcumulativa.Checked = True And ChkExacta.Checked = True Then
            MessageBox.Show("No puedes seleccionar dos o más operaciones a la vez.")
        End If

        If ChkAcumulativa.Checked = True Then
            TxtDecimal.Text = resultado.ToString("F4")
            TxtPorcentaje.Text = resultado.ToString("P2")
        ElseIf ChkExacta.Checked = True Then
            TxtDecimal.Text = resultado2.ToString("F4")
            TxtPorcentaje.Text = resultado2.ToString("P2")
        Else
            MessageBox.Show("Error al hacer el cálculo.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txtn.Clear()
        Txtx.Clear()
        Txtp.Clear()
        TxtPorcentaje.Clear()
        TxtDecimal.Clear()
    End Sub

    Private Function Factorial1(ByVal n As Integer) As Integer

        Dim f As Integer = 1
        If n > 0 Then
            For i = n To 1 Step -1
                f *= i
            Next
        Else
            f = 1
        End If

        Return f
    End Function

    Private Function Factorial2(ByVal x As Integer) As Integer

        Dim f As Integer = 1

        If x > 0 Then
            For i = x To 1 Step -1
                f *= i
            Next
        Else
            f = 1
        End If

        Return f
    End Function

    Private Function Factorial3(ByVal n As Integer, ByVal x As Integer) As Integer

        Dim resta As Integer
        Dim f As Integer = 1
        resta = n - x

        If resta > 0 Then
            For i As Integer = 1 To resta
                f *= i
            Next
        Else
            f = 1
        End If

        Return f
    End Function

    Private Function Combinatorio(ByVal n As Integer, ByVal x As Integer) As Integer

        Dim z As Integer

        z = Factorial1(n) / (Factorial2(x) * Factorial3(n, x))

        Return z
    End Function

    Private Function Binomial(ByVal n As Integer, ByVal x As Integer, ByVal p As Double) As Double
        Dim q As Double = 1 - p
        Dim b As Double

        b = Combinatorio(n, x) * Math.Pow(p, x) * Math.Pow(q, n - x)

        Return b
    End Function

    Private Function BinomialAcumulado(ByVal n As Integer, ByVal x As Integer, ByVal p As Double) As Double
        Dim q As Double = 1 - p
        Dim a As Double

        For i As Integer = 0 To x
            a += Combinatorio(n, i) * Math.Pow(p, i) * Math.Pow(q, n - i)
        Next

        Return a
    End Function

    Private Sub Txtn_LostFocus(sender As Object, e As EventArgs) Handles Txtn.LostFocus
        If Integer.TryParse(Txtn.Text, entero) Then
            Txtn.Text = entero.ToString()
        Else
            Txtn.Text = "0"
        End If
    End Sub

    Private Sub Txtx_LostFocus(sender As Object, e As EventArgs) Handles Txtx.LostFocus
        If Integer.TryParse(Txtx.Text, entero) Then
            Txtx.Text = entero.ToString()
        Else
            Txtx.Text = "0"
        End If
    End Sub

    Private Sub Txtp_LostFocus(sender As Object, e As EventArgs) Handles Txtp.LostFocus
        If Double.TryParse(Txtp.Text, decimales) Then
            Txtp.Text = decimales.ToString()
        Else
            Txtp.Text = "0.00"
        End If
    End Sub

    Private Sub TxtDecimal_LostFocus(sender As Object, e As EventArgs) Handles TxtDecimal.LostFocus
        If Double.TryParse(Txtx.Text, decimales) Then
            TxtDecimal.Text = decimales.ToString()
        Else
            TxtDecimal.Text = "0.0000"
        End If
    End Sub
End Class