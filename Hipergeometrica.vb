Public Class Hipergeometrica
    Dim x, a, N, m, entero As Integer
    Dim resultado, decimales, resultado2 As Double

    Private Sub BtnBinomial_Click(sender As Object, e As EventArgs) Handles BtnBinomial.Click
        x = Convert.ToInt32(Txtx.Text)
        a = Convert.ToInt32(Txta.Text)
        N = Convert.ToInt32(TxtN.Text)
        m = Convert.ToInt32(Txtm.Text)
        resultado = Hipergeometrica(N, a, m, x)
        resultado2 = HipergeometricaTotal(N, a, m, x)

        If a < 0 Or x < 0 Or N < 0 Or m < 0 Then
            MessageBox.Show("No puedes ingresar valores negativos.")
        ElseIf a > N Then
            MessageBox.Show("El múmero de éxitos comprobados no puede ser mayor a la población.")
        ElseIf x > a Then
            MessageBox.Show("El número de éxitos no puede ser superior al número de éxitos comprobados.")
        ElseIf m > N Then
            MessageBox.Show("La muestra no puede ser mayor a la población.")
        ElseIf x > N Then
            MessageBox.Show("El múmero de éxitos no puede ser mayor a la población.")
        ElseIf x > m Then
            MessageBox.Show("El múmero de éxitos no puede ser mayor a la muestra.")
        ElseIf a < m Then
            MessageBox.Show("El múmero de éxitos comprobados debe ser mayor a la muestra.")
        ElseIf ChkExacta.Checked = True Then
            TxtDecimal.Text = resultado.ToString("F4")
            TxtPorcentaje.Text = resultado.ToString("P2")
        ElseIf ChkAcumulativa.Checked = True Then
            TxtDecimal.Text = resultado2.ToString("F4")
            TxtPorcentaje.Text = resultado2.ToString("P2")
        ElseIf ChkAcumulativa.Checked = True And ChkExacta.Checked = True Then
            MessageBox.Show("No puedes seleccionar ambas opciones a la vez.")
        ElseIf ChkAcumulativa.Checked = False And ChkExacta.Checked = False Then
            MessageBox.Show("Debes seleccionar una de las dos opciones.")
        Else
            MessageBox.Show("Error al hacer la operación.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txta.Clear()
        TxtDecimal.Clear()
        Txtm.Clear()
        TxtN.Clear()
        TxtPorcentaje.Clear()
        Txtx.Clear()
    End Sub

    Private Sub TxtN_LostFocus(sender As Object, e As EventArgs) Handles TxtN.LostFocus
        If Integer.TryParse(TxtN.Text, entero) Then
            TxtN.Text = entero.ToString()
        Else
            TxtN.Text = "0"
        End If
    End Sub

    Private Sub Txtm_LostFocus(sender As Object, e As EventArgs) Handles Txtm.LostFocus
        If Integer.TryParse(Txtm.Text, entero) Then
            Txtm.Text = entero.ToString()
        Else
            Txtm.Text = "0"
        End If
    End Sub

    Private Sub Txta_LostFocus(sender As Object, e As EventArgs) Handles Txta.LostFocus
        If Integer.TryParse(Txta.Text, entero) Then
            Txta.Text = entero.ToString()
        Else
            Txta.Text = "0"
        End If
    End Sub

    Private Sub Txtx_LostFocus(sender As Object, e As EventArgs) Handles Txtx.LostFocus
        If Integer.TryParse(Txtx.Text, entero) Then
            Txtx.Text = entero.ToString()
        Else
            Txtx.Text = "0"
        End If
    End Sub

    Private Sub TxtDecimal_LostFocus(sender As Object, e As EventArgs) Handles TxtDecimal.LostFocus
        If Double.TryParse(TxtDecimal.Text, decimales) Then
            TxtDecimal.Text = decimales.ToString()
        Else
            TxtDecimal.Text = "0.0000"
        End If
    End Sub

    Private Function Factorial(num As Integer) As Double
        Dim r As Double = 1
        If num > 0 Then
            For i As Integer = num To 1 Step -1
                r *= i
            Next
        Else
            r = 1
        End If

        Return r
    End Function

    Private Function Combinatoria1(ByVal a As Integer, ByVal x As Integer) As Double
        Dim g As Double

        g = Factorial(a) / (Factorial(x) * Factorial(a - x))

        Return g
    End Function

    Private Function Combinatoria2(ByVal N As Integer, ByVal a As Integer, ByVal m As Integer, ByVal x As Integer) As Double
        Dim s As Double
        Dim b As Double = N - a
        Dim v As Double = m - x
        s = Factorial(N - a) / (Factorial(m - x) * Factorial((N - a) - (m - x)))

        Return s
    End Function

    Private Function Combinatoria3(ByVal N As Integer, ByVal m As Integer) As Double
        Dim h As Double

        h = Factorial(N) / (Factorial(m) * Factorial(N - m))

        Return h
    End Function

    Private Function Hipergeometrica(ByVal N As Integer, ByVal a As Integer, ByVal m As Integer, ByVal x As Integer) As Double
        Dim y As Double

        y = (Combinatoria1(a, x) * Combinatoria2(N, a, m, x)) / Combinatoria3(N, m)

        Return y
    End Function

    Private Function HipergeometricaTotal(ByVal N As Integer, ByVal a As Integer, ByVal m As Integer, ByVal x As Integer) As Double
        Dim c As Double = 0.00

        For i As Integer = 0 To x Step 1
            c += (Combinatoria1(a, i) * Combinatoria2(N, a, m, i)) / Combinatoria3(N, m)
        Next

        Return c
    End Function
End Class