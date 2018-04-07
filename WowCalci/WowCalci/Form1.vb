Public Class Form1

    Dim assign_input As Double = 0.0
    Dim operation As String
    Dim found_expression As Boolean
    Dim firstnum, secondnum, q As String
    Dim eql As Boolean

    Private Sub Numbers_Click(sender As Object, e As EventArgs) Handles zero.Click, two.Click, three.Click, six.Click, seven.Click, one.Click, nine.Click, four.Click, five.Click, eight.Click
        Dim b As Button = sender 'creating an object
        If (TextBox.Text = "0") Or (found_expression) Then
            TextBox.Clear()
            TextBox.Text = b.Text
            found_expression = False
        ElseIf (b.Text = ".") Then
            If (Not TextBox.Text.Contains(".")) Then
                TextBox.Text = TextBox.Text + b.Text
            End If
        Else
            TextBox.Text = TextBox.Text + b.Text
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Dev_Credits.LinkClicked
        Try
            System.Diagnostics.Process.Start("https://thecoducer.github.io/")
        Catch
            MessageBox.Show("Unable to open the link.", "Oops!")
        End Try
    End Sub

    Private Sub clear_entry_Click(sender As Object, e As EventArgs) Handles clear_entry.Click
        TextBox.Text = "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles clear_all.Click
        TextBox.Text = "0"
        equation.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles dot.Click
        If Not (TextBox.Text.Contains(".")) Then
            TextBox.Text += "."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearhistory.Visible = False
    End Sub

    Private Sub operation_click(sender As Object, e As EventArgs) Handles subtract.Click, multiply.Click, divide.Click, add.Click
        Dim b As Button = sender
        If (assign_input <> 0) Then
            eql = False
            equals.PerformClick()
            found_expression = True
            operation = b.Text
            equation.Text = assign_input & "  " & operation
        Else
            operation = b.Text
            assign_input = Double.Parse(TextBox.Text) 'converts string into double
            found_expression = True
            equation.Text = assign_input & "  " & operation
        End If

        q = equation.Text
    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click

        secondnum = TextBox.Text
        equation.Text = ""

        Select Case operation
            Case "+"
                TextBox.Text = (assign_input + Double.Parse(TextBox.Text)).ToString()
                eql = True
            Case "−"
                TextBox.Text = (assign_input - Double.Parse(TextBox.Text)).ToString()
                eql = True
            Case "×"
                TextBox.Text = (assign_input * Double.Parse(TextBox.Text)).ToString()
                eql = True
            Case "÷"
                TextBox.Text = (assign_input / Double.Parse(TextBox.Text)).ToString()
                eql = True
        End Select

        assign_input = Double.Parse(TextBox.Text)
        operation = ""
        '************************************************
        clearhistory.Visible = True
        'history_view.AppendText(equation.Text & "  " & TextBox.Text & vbNewLine)
        If eql = True Then
            history_view.AppendText(q & "  " & secondnum & "  =  " & vbNewLine)
            history_view.AppendText(vbTab & TextBox.Text & vbNewLine & vbNewLine)
            nohistory.Text = ""
        End If

    End Sub

    Private Sub percentage_Click(sender As Object, e As EventArgs) Handles percentage.Click
        Dim a As Double
        a = Convert.ToDouble(TextBox.Text) / Convert.ToDouble(100)
        TextBox.Text = System.Convert.ToString(a)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles squareroot.Click
        Dim a As Double
        equation.Text = "√(" & (TextBox.Text) & ")"
        a = Math.Sqrt(TextBox.Text)
        TextBox.Text = System.Convert.ToString(a)
    End Sub

    'Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
    '    Dim x1 As Double
    '    Dim x2 As Double
    '    Dim power As Double

    '    x1 =
    '    power = Convert.ToDouble(TextBox.Text)
    'End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles sin.Click
        Dim s As Double = Double.Parse(TextBox.Text)
        equation.Text = "sin(" & s & ")"
        s = Math.Sin((Math.PI * s / 180)) 'convert degrees into radians and then find the sine
        TextBox.Text = System.Convert.ToString(s)
    End Sub

    Private Sub cos_Click(sender As Object, e As EventArgs) Handles cos.Click
        Dim s As Double = Double.Parse(TextBox.Text)
        equation.Text = "cos(" & s & ")"
        s = Math.Cos((Math.PI * s / 180)) 'convert degrees into radians and then find the cosine
        TextBox.Text = System.Convert.ToString(s)
    End Sub

    Private Sub tan_Click(sender As Object, e As EventArgs) Handles tan.Click
        Dim s As Double = Double.Parse(TextBox.Text)
        equation.Text = "tan(" & s & ")"
        If s = 90 Then
            TextBox.Text = "NaN"
        Else
            s = Math.Tan((Math.PI * s / 180)) 'convert degrees into radians and then find the tan
            TextBox.Text = System.Convert.ToString(s)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles asin.Click
        Dim s As Double = Double.Parse(TextBox.Text)
        equation.Text = "sin⁻¹(" & s & ")"
        s = Math.Asin((Math.PI * s / 180)) 'convert degrees into radians and then find the sin inverse
        TextBox.Text = System.Convert.ToString(s)
    End Sub

    Private Sub acos_Click(sender As Object, e As EventArgs) Handles acos.Click
        Dim s As Double = Double.Parse(TextBox.Text)
        equation.Text = "cos⁻¹(" & s & ")"
        s = Math.Acos((Math.PI * s / 180)) 'convert degrees into radians and then find the cos inverse
        TextBox.Text = System.Convert.ToString(s)
    End Sub

    Private Sub atan_Click(sender As Object, e As EventArgs) Handles atan.Click
        Dim s As Double = Double.Parse(TextBox.Text)
        equation.Text = "tan⁻¹(" & s & ")"
        s = Math.Atan((Math.PI * s / 180)) 'convert degrees into radians and then find the tan inverse
        TextBox.Text = System.Convert.ToString(s)
    End Sub

    Private Sub log10_Click(sender As Object, e As EventArgs) Handles log10.Click
        Dim a As Double = Double.Parse(TextBox.Text)
        equation.Text = "log(" & a & ")"
        a = Math.Log10(a)
        TextBox.Text = System.Convert.ToString(a)
    End Sub

    Private Sub backspace_Click(sender As Object, e As EventArgs) Handles backspace.Click
        If TextBox.Text.Length > 0 Then
            TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1, 1)
        ElseIf TextBox.Text = "" Then
            TextBox.Text = "0"
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode.Equals(Keys.NumPad0)) Or (e.KeyCode.Equals(Keys.D0)) Then
            zero.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad1)) Or (e.KeyCode.Equals(Keys.D1)) Then
            one.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad2)) Or (e.KeyCode.Equals(Keys.D2)) Then
            two.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad3)) Or (e.KeyCode.Equals(Keys.D3)) Then
            three.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad4)) Or (e.KeyCode.Equals(Keys.D4)) Then
            four.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad5)) Or (e.KeyCode.Equals(Keys.D5)) Then
            five.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad6)) Or (e.KeyCode.Equals(Keys.D6)) Then
            six.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad7)) Or (e.KeyCode.Equals(Keys.D7)) Then
            seven.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad8)) Or (e.KeyCode.Equals(Keys.D8)) Then
            eight.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.NumPad9)) Or (e.KeyCode.Equals(Keys.D9)) Then
            nine.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.Decimal)) Then
            dot.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.Back)) Then
            backspace.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.Enter)) Then
            'MessageBox.Show("Hello")
            equals.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.Add)) Then
            add.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.Subtract)) Then
            subtract.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.Multiply)) Then
            multiply.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.Divide)) Then
            divide.PerformClick()
        ElseIf (e.KeyCode.Equals(Keys.Delete)) Then
            clear_all.PerformClick()
        End If
    End Sub

    Private Sub history_view_TextChanged(sender As Object, e As EventArgs) Handles history_view.TextChanged
        history_view.SelectAll()
        history_view.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub clearhistory_Click(sender As Object, e As EventArgs) Handles clearhistory.Click
        history_view.Text = ""
        nohistory.Text = "There's no history yet"
        clearhistory.Visible = False
    End Sub

    Private Sub factorial_Click(sender As Object, e As EventArgs) Handles factorial.Click
        Dim a As Double
        Dim s As Double = 1
        Dim i As Integer
        a = Double.Parse(TextBox.Text)
        For i = 1 To a
            s = s * i
        Next
        TextBox.Text = System.Convert.ToString(s)
        equation.Text = "Fact(" & a & ")"
        history_view.AppendText("Fact(" & a & ") =" & vbNewLine & s & vbNewLine)

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub nohistory_Click(sender As Object, e As EventArgs) Handles nohistory.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles History.Click

    End Sub
End Class
