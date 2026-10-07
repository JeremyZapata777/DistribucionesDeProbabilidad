Public Class Poisson
    Dim Entero As Integer
    Dim Decimales As Double
    Dim m As Double
    Dim x As Integer
    Dim n As String
    Dim euler As Double = 2.7182818281
    Dim resultado As Double
    Dim resultado2 As Double

    Private Sub BtnPoisson_Click(sender As Object, e As EventArgs) Handles BtnPoisson.Click
        m = Convert.ToDouble(Txtm.Text)
        x = Convert.ToInt32(Txtx.Text)
        resultado = PoissonTotal(m, x)
        resultado2 = Poisson(m, x)
        Dim resultadominimo As Double = 1 - resultado

        If m < 0 Or x < 0 Then
            MessageBox.Show("No se pueden ingresar valores negativos en ninguno de los datos.")
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
            MessageBox.Show("Error al realizar el cálculo.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtDecimal.Clear()
        Txtm.Clear()
        TxtPorcentaje.Clear()
        Txtx.Clear()
    End Sub

    Private Sub Txtm_LostFocus(sender As Object, e As EventArgs) Handles Txtm.LostFocus
        If Double.TryParse(Txtm.Text, Decimales) Then
            Txtm.Text = Decimales.ToString()
        Else
            Txtm.Text = "0.00"
        End If
    End Sub

    Private Sub Txtx_LostFocus(sender As Object, e As EventArgs) Handles Txtx.LostFocus
        If Integer.TryParse(Txtx.Text, Entero) Then
            Txtx.Text = Entero.ToString()
        Else
            Txtx.Text = "0"
        End If
    End Sub

    Private Function Factorial(x As Integer)
        Dim f = 1
        If x > 0 Then
            For i = x To 1 Step -1
                f *= i
            Next
        Else
            f = 1
        End If

        Return f
    End Function

    Private Function Poisson(ByVal m As Double, ByVal x As Integer) As Double
        Dim y As Double
        y = Math.Pow(m, x) * Math.Pow(euler, -m) / Factorial(x)

        Return y
    End Function

    Private Function PoissonTotal(ByVal m As Double, ByVal x As Integer) As Double
        Dim y As Double = 0.00

        For i As Integer = 0 To x Step 1
            y += Math.Pow(m, i) * Math.Pow(euler, -m) / Factorial(i)
        Next

        Return y
    End Function
    Private Sub TxtDecimal_LostFocus(sender As Object, e As EventArgs) Handles TxtDecimal.LostFocus
        If Double.TryParse(TxtDecimal.Text, Decimales) Then
            TxtDecimal.Text = Decimales.ToString("0.000")
        Else
            TxtDecimal.Text = "0.0000"
        End If
    End Sub
End Class