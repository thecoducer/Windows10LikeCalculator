<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.factorial = New System.Windows.Forms.Button()
        Me.clear_entry = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.log_10 = New System.Windows.Forms.Button()
        Me.seven = New System.Windows.Forms.Button()
        Me.four = New System.Windows.Forms.Button()
        Me.one = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.clear_all = New System.Windows.Forms.Button()
        Me.eight = New System.Windows.Forms.Button()
        Me.five = New System.Windows.Forms.Button()
        Me.two = New System.Windows.Forms.Button()
        Me.zero = New System.Windows.Forms.Button()
        Me.backspace = New System.Windows.Forms.Button()
        Me.nine = New System.Windows.Forms.Button()
        Me.six = New System.Windows.Forms.Button()
        Me.three = New System.Windows.Forms.Button()
        Me.dot = New System.Windows.Forms.Button()
        Me.divide = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.subtract = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.equals = New System.Windows.Forms.Button()
        Me.modulus = New System.Windows.Forms.Button()
        Me.square = New System.Windows.Forms.Button()
        Me.power_y = New System.Windows.Forms.Button()
        Me.squareroot = New System.Windows.Forms.Button()
        Me.x_squareroot = New System.Windows.Forms.Button()
        Me.nohistory = New System.Windows.Forms.Label()
        Me.History = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clearhistory = New System.Windows.Forms.Button()
        Me.equation = New System.Windows.Forms.Label()
        Me.negation = New System.Windows.Forms.Button()
        Me.exp = New System.Windows.Forms.Button()
        Me.tan = New System.Windows.Forms.Button()
        Me.cos = New System.Windows.Forms.Button()
        Me.sin = New System.Windows.Forms.Button()
        Me.atan = New System.Windows.Forms.Button()
        Me.acos = New System.Windows.Forms.Button()
        Me.asin = New System.Windows.Forms.Button()
        Me.one_divided_x = New System.Windows.Forms.Button()
        Me.ten_x = New System.Windows.Forms.Button()
        Me.history_view = New System.Windows.Forms.RichTextBox()
        Me.pivalue = New System.Windows.Forms.Button()
        Me.toggle = New System.Windows.Forms.Button()
        Me.cube = New System.Windows.Forms.Button()
        Me.e_power_x = New System.Windows.Forms.Button()
        Me.log_e = New System.Windows.Forms.Button()
        Me.percentage = New System.Windows.Forms.Button()
        Me.random_num = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.ForeColor = System.Drawing.Color.Black
        Me.TextBox.Location = New System.Drawing.Point(4, 77)
        Me.TextBox.MaxLength = 327677
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.Size = New System.Drawing.Size(409, 54)
        Me.TextBox.TabIndex = 12
        Me.TextBox.TabStop = False
        Me.TextBox.Text = "0"
        Me.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'factorial
        '
        Me.factorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.factorial.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.factorial.FlatAppearance.BorderSize = 0
        Me.factorial.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.factorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.factorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.factorial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.factorial.Location = New System.Drawing.Point(4, 374)
        Me.factorial.Name = "factorial"
        Me.factorial.Size = New System.Drawing.Size(77, 40)
        Me.factorial.TabIndex = 16
        Me.factorial.Text = "n!"
        Me.factorial.UseVisualStyleBackColor = False
        '
        'clear_entry
        '
        Me.clear_entry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.clear_entry.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.clear_entry.FlatAppearance.BorderSize = 0
        Me.clear_entry.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.clear_entry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.clear_entry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.clear_entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_entry.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_entry.Location = New System.Drawing.Point(87, 286)
        Me.clear_entry.Name = "clear_entry"
        Me.clear_entry.Size = New System.Drawing.Size(77, 40)
        Me.clear_entry.TabIndex = 17
        Me.clear_entry.Text = "CE"
        Me.clear_entry.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(4, 462)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 40)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "("
        Me.Button5.UseVisualStyleBackColor = False
        '
        'log_10
        '
        Me.log_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.log_10.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.log_10.FlatAppearance.BorderSize = 0
        Me.log_10.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.log_10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.log_10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.log_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.log_10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_10.Location = New System.Drawing.Point(170, 242)
        Me.log_10.Name = "log_10"
        Me.log_10.Size = New System.Drawing.Size(77, 40)
        Me.log_10.TabIndex = 19
        Me.log_10.Text = "log"
        Me.log_10.UseVisualStyleBackColor = False
        '
        'seven
        '
        Me.seven.BackColor = System.Drawing.Color.White
        Me.seven.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.seven.FlatAppearance.BorderSize = 0
        Me.seven.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.seven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seven.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seven.Location = New System.Drawing.Point(87, 330)
        Me.seven.Name = "seven"
        Me.seven.Size = New System.Drawing.Size(77, 40)
        Me.seven.TabIndex = 20
        Me.seven.Text = "7"
        Me.seven.UseVisualStyleBackColor = False
        '
        'four
        '
        Me.four.BackColor = System.Drawing.Color.White
        Me.four.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.four.FlatAppearance.BorderSize = 0
        Me.four.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.four.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.four.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.four.Location = New System.Drawing.Point(87, 374)
        Me.four.Name = "four"
        Me.four.Size = New System.Drawing.Size(77, 40)
        Me.four.TabIndex = 21
        Me.four.Text = "4"
        Me.four.UseVisualStyleBackColor = False
        '
        'one
        '
        Me.one.BackColor = System.Drawing.Color.White
        Me.one.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.one.FlatAppearance.BorderSize = 0
        Me.one.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.one.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.one.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.one.Location = New System.Drawing.Point(87, 418)
        Me.one.Name = "one"
        Me.one.Size = New System.Drawing.Size(77, 40)
        Me.one.TabIndex = 22
        Me.one.Text = "1"
        Me.one.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(87, 462)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(77, 40)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = ")"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'clear_all
        '
        Me.clear_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.clear_all.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.clear_all.FlatAppearance.BorderSize = 0
        Me.clear_all.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.clear_all.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.clear_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.clear_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_all.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_all.Location = New System.Drawing.Point(170, 286)
        Me.clear_all.Name = "clear_all"
        Me.clear_all.Size = New System.Drawing.Size(77, 40)
        Me.clear_all.TabIndex = 24
        Me.clear_all.Text = "C"
        Me.clear_all.UseVisualStyleBackColor = False
        '
        'eight
        '
        Me.eight.BackColor = System.Drawing.Color.White
        Me.eight.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.eight.FlatAppearance.BorderSize = 0
        Me.eight.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.eight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eight.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eight.Location = New System.Drawing.Point(170, 330)
        Me.eight.Name = "eight"
        Me.eight.Size = New System.Drawing.Size(77, 40)
        Me.eight.TabIndex = 25
        Me.eight.Text = "8"
        Me.eight.UseVisualStyleBackColor = False
        '
        'five
        '
        Me.five.BackColor = System.Drawing.Color.White
        Me.five.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.five.FlatAppearance.BorderSize = 0
        Me.five.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.five.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.five.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.five.Location = New System.Drawing.Point(170, 374)
        Me.five.Name = "five"
        Me.five.Size = New System.Drawing.Size(77, 40)
        Me.five.TabIndex = 26
        Me.five.Text = "5"
        Me.five.UseVisualStyleBackColor = False
        '
        'two
        '
        Me.two.BackColor = System.Drawing.Color.White
        Me.two.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.two.FlatAppearance.BorderSize = 0
        Me.two.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.two.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.two.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.two.Location = New System.Drawing.Point(170, 418)
        Me.two.Name = "two"
        Me.two.Size = New System.Drawing.Size(77, 40)
        Me.two.TabIndex = 27
        Me.two.Text = "2"
        Me.two.UseVisualStyleBackColor = False
        '
        'zero
        '
        Me.zero.BackColor = System.Drawing.Color.White
        Me.zero.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.zero.FlatAppearance.BorderSize = 0
        Me.zero.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.zero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zero.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zero.Location = New System.Drawing.Point(170, 462)
        Me.zero.Name = "zero"
        Me.zero.Size = New System.Drawing.Size(77, 40)
        Me.zero.TabIndex = 28
        Me.zero.Text = "0"
        Me.zero.UseVisualStyleBackColor = False
        '
        'backspace
        '
        Me.backspace.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.backspace.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.backspace.FlatAppearance.BorderSize = 0
        Me.backspace.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.backspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.backspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backspace.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backspace.Location = New System.Drawing.Point(253, 286)
        Me.backspace.Name = "backspace"
        Me.backspace.Size = New System.Drawing.Size(77, 40)
        Me.backspace.TabIndex = 29
        Me.backspace.Text = "⌫ "
        Me.backspace.UseVisualStyleBackColor = False
        '
        'nine
        '
        Me.nine.BackColor = System.Drawing.Color.White
        Me.nine.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.nine.FlatAppearance.BorderSize = 0
        Me.nine.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.nine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nine.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nine.Location = New System.Drawing.Point(253, 330)
        Me.nine.Name = "nine"
        Me.nine.Size = New System.Drawing.Size(77, 40)
        Me.nine.TabIndex = 30
        Me.nine.Text = "9"
        Me.nine.UseVisualStyleBackColor = False
        '
        'six
        '
        Me.six.BackColor = System.Drawing.Color.White
        Me.six.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.six.FlatAppearance.BorderSize = 0
        Me.six.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.six.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.six.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.six.Location = New System.Drawing.Point(253, 374)
        Me.six.Name = "six"
        Me.six.Size = New System.Drawing.Size(77, 40)
        Me.six.TabIndex = 31
        Me.six.Text = "6"
        Me.six.UseVisualStyleBackColor = False
        '
        'three
        '
        Me.three.BackColor = System.Drawing.Color.White
        Me.three.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.three.FlatAppearance.BorderSize = 0
        Me.three.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.three.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.three.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.three.Location = New System.Drawing.Point(253, 418)
        Me.three.Name = "three"
        Me.three.Size = New System.Drawing.Size(77, 40)
        Me.three.TabIndex = 32
        Me.three.Text = "3"
        Me.three.UseVisualStyleBackColor = False
        '
        'dot
        '
        Me.dot.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dot.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.dot.FlatAppearance.BorderSize = 0
        Me.dot.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.dot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dot.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dot.Location = New System.Drawing.Point(253, 462)
        Me.dot.Name = "dot"
        Me.dot.Size = New System.Drawing.Size(77, 40)
        Me.dot.TabIndex = 33
        Me.dot.Text = "."
        Me.dot.UseVisualStyleBackColor = False
        '
        'divide
        '
        Me.divide.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.divide.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.divide.FlatAppearance.BorderSize = 0
        Me.divide.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.divide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.divide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.divide.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divide.Location = New System.Drawing.Point(336, 286)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(77, 40)
        Me.divide.TabIndex = 34
        Me.divide.Text = "÷"
        Me.divide.UseVisualStyleBackColor = False
        '
        'multiply
        '
        Me.multiply.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.multiply.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.multiply.FlatAppearance.BorderSize = 0
        Me.multiply.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.multiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.multiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.multiply.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiply.Location = New System.Drawing.Point(336, 330)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(77, 40)
        Me.multiply.TabIndex = 35
        Me.multiply.Text = "×"
        Me.multiply.UseVisualStyleBackColor = False
        '
        'subtract
        '
        Me.subtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.subtract.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.subtract.FlatAppearance.BorderSize = 0
        Me.subtract.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.subtract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.subtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subtract.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtract.Location = New System.Drawing.Point(336, 374)
        Me.subtract.Name = "subtract"
        Me.subtract.Size = New System.Drawing.Size(77, 40)
        Me.subtract.TabIndex = 36
        Me.subtract.Text = "−"
        Me.subtract.UseVisualStyleBackColor = False
        '
        'add
        '
        Me.add.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.add.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.add.FlatAppearance.BorderSize = 0
        Me.add.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(336, 418)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(77, 40)
        Me.add.TabIndex = 37
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = False
        '
        'equals
        '
        Me.equals.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.equals.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.equals.FlatAppearance.BorderSize = 0
        Me.equals.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.equals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.equals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equals.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equals.Location = New System.Drawing.Point(336, 462)
        Me.equals.Name = "equals"
        Me.equals.Size = New System.Drawing.Size(77, 40)
        Me.equals.TabIndex = 38
        Me.equals.Text = "="
        Me.equals.UseVisualStyleBackColor = True
        '
        'modulus
        '
        Me.modulus.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.modulus.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.modulus.FlatAppearance.BorderSize = 0
        Me.modulus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.modulus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.modulus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.modulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modulus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modulus.Location = New System.Drawing.Point(336, 242)
        Me.modulus.Name = "modulus"
        Me.modulus.Size = New System.Drawing.Size(77, 40)
        Me.modulus.TabIndex = 40
        Me.modulus.Text = "Mod"
        Me.modulus.UseVisualStyleBackColor = False
        '
        'square
        '
        Me.square.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.square.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.square.FlatAppearance.BorderSize = 0
        Me.square.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.square.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.square.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.square.Location = New System.Drawing.Point(4, 198)
        Me.square.Name = "square"
        Me.square.Size = New System.Drawing.Size(77, 40)
        Me.square.TabIndex = 41
        Me.square.Text = "x²"
        Me.square.UseVisualStyleBackColor = False
        '
        'power_y
        '
        Me.power_y.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.power_y.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.power_y.FlatAppearance.BorderSize = 0
        Me.power_y.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.power_y.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.power_y.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.power_y.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.power_y.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.power_y.Location = New System.Drawing.Point(87, 198)
        Me.power_y.Name = "power_y"
        Me.power_y.Size = New System.Drawing.Size(77, 40)
        Me.power_y.TabIndex = 42
        Me.power_y.Text = "xʸ"
        Me.power_y.UseVisualStyleBackColor = False
        Me.power_y.UseWaitCursor = True
        '
        'squareroot
        '
        Me.squareroot.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.squareroot.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.squareroot.FlatAppearance.BorderSize = 0
        Me.squareroot.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.squareroot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.squareroot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.squareroot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.squareroot.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.squareroot.Location = New System.Drawing.Point(4, 242)
        Me.squareroot.Name = "squareroot"
        Me.squareroot.Size = New System.Drawing.Size(77, 40)
        Me.squareroot.TabIndex = 43
        Me.squareroot.Text = "√"
        Me.squareroot.UseVisualStyleBackColor = False
        '
        'x_squareroot
        '
        Me.x_squareroot.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.x_squareroot.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.x_squareroot.FlatAppearance.BorderSize = 0
        Me.x_squareroot.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.x_squareroot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.x_squareroot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.x_squareroot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.x_squareroot.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x_squareroot.Location = New System.Drawing.Point(87, 198)
        Me.x_squareroot.Name = "x_squareroot"
        Me.x_squareroot.Size = New System.Drawing.Size(77, 40)
        Me.x_squareroot.TabIndex = 44
        Me.x_squareroot.Text = "˟√"
        Me.x_squareroot.UseVisualStyleBackColor = False
        '
        'nohistory
        '
        Me.nohistory.AutoSize = True
        Me.nohistory.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nohistory.Location = New System.Drawing.Point(477, 58)
        Me.nohistory.Name = "nohistory"
        Me.nohistory.Size = New System.Drawing.Size(174, 23)
        Me.nohistory.TabIndex = 45
        Me.nohistory.Text = "There's no history yet"
        '
        'History
        '
        Me.History.AutoSize = True
        Me.History.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.History.Location = New System.Drawing.Point(477, 22)
        Me.History.Name = "History"
        Me.History.Size = New System.Drawing.Size(66, 23)
        Me.History.TabIndex = 46
        Me.History.Text = "History"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(563, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 47
        '
        'clearhistory
        '
        Me.clearhistory.FlatAppearance.BorderSize = 0
        Me.clearhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearhistory.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearhistory.Location = New System.Drawing.Point(695, 462)
        Me.clearhistory.Name = "clearhistory"
        Me.clearhistory.Size = New System.Drawing.Size(39, 42)
        Me.clearhistory.TabIndex = 49
        Me.clearhistory.Text = "🗑"
        Me.clearhistory.UseVisualStyleBackColor = True
        '
        'equation
        '
        Me.equation.AutoSize = True
        Me.equation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equation.ForeColor = System.Drawing.Color.DimGray
        Me.equation.Location = New System.Drawing.Point(403, 33)
        Me.equation.Name = "equation"
        Me.equation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.equation.Size = New System.Drawing.Size(0, 20)
        Me.equation.TabIndex = 50
        Me.equation.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'negation
        '
        Me.negation.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.negation.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.negation.FlatAppearance.BorderSize = 0
        Me.negation.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.negation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.negation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.negation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.negation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.negation.Location = New System.Drawing.Point(4, 418)
        Me.negation.Name = "negation"
        Me.negation.Size = New System.Drawing.Size(77, 40)
        Me.negation.TabIndex = 51
        Me.negation.Text = "±"
        Me.negation.UseVisualStyleBackColor = False
        '
        'exp
        '
        Me.exp.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.exp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.exp.FlatAppearance.BorderSize = 0
        Me.exp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.exp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.exp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exp.Location = New System.Drawing.Point(253, 242)
        Me.exp.Name = "exp"
        Me.exp.Size = New System.Drawing.Size(77, 40)
        Me.exp.TabIndex = 52
        Me.exp.Text = "Exp"
        Me.exp.UseVisualStyleBackColor = False
        '
        'tan
        '
        Me.tan.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tan.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.tan.FlatAppearance.BorderSize = 0
        Me.tan.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.tan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.tan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.tan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tan.Location = New System.Drawing.Point(336, 198)
        Me.tan.Name = "tan"
        Me.tan.Size = New System.Drawing.Size(77, 40)
        Me.tan.TabIndex = 53
        Me.tan.Text = "tan"
        Me.tan.UseVisualStyleBackColor = False
        '
        'cos
        '
        Me.cos.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cos.FlatAppearance.BorderSize = 0
        Me.cos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.cos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cos.Location = New System.Drawing.Point(253, 198)
        Me.cos.Name = "cos"
        Me.cos.Size = New System.Drawing.Size(77, 40)
        Me.cos.TabIndex = 54
        Me.cos.Text = "cos"
        Me.cos.UseVisualStyleBackColor = False
        '
        'sin
        '
        Me.sin.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.sin.FlatAppearance.BorderSize = 0
        Me.sin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.sin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.sin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sin.Location = New System.Drawing.Point(170, 198)
        Me.sin.Name = "sin"
        Me.sin.Size = New System.Drawing.Size(77, 40)
        Me.sin.TabIndex = 55
        Me.sin.Text = "sin"
        Me.sin.UseVisualStyleBackColor = False
        '
        'atan
        '
        Me.atan.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.atan.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.atan.FlatAppearance.BorderSize = 0
        Me.atan.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.atan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.atan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.atan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atan.Location = New System.Drawing.Point(336, 198)
        Me.atan.Name = "atan"
        Me.atan.Size = New System.Drawing.Size(77, 40)
        Me.atan.TabIndex = 56
        Me.atan.Text = "tan⁻¹"
        Me.atan.UseVisualStyleBackColor = False
        '
        'acos
        '
        Me.acos.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.acos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.acos.FlatAppearance.BorderSize = 0
        Me.acos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.acos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.acos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.acos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.acos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acos.Location = New System.Drawing.Point(253, 198)
        Me.acos.Name = "acos"
        Me.acos.Size = New System.Drawing.Size(77, 40)
        Me.acos.TabIndex = 57
        Me.acos.Text = "cos⁻¹"
        Me.acos.UseVisualStyleBackColor = False
        '
        'asin
        '
        Me.asin.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.asin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.asin.FlatAppearance.BorderSize = 0
        Me.asin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.asin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.asin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.asin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.asin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asin.Location = New System.Drawing.Point(170, 198)
        Me.asin.Name = "asin"
        Me.asin.Size = New System.Drawing.Size(77, 40)
        Me.asin.TabIndex = 58
        Me.asin.Text = "sin⁻¹"
        Me.asin.UseVisualStyleBackColor = False
        '
        'one_divided_x
        '
        Me.one_divided_x.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.one_divided_x.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.one_divided_x.FlatAppearance.BorderSize = 0
        Me.one_divided_x.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.one_divided_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.one_divided_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.one_divided_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.one_divided_x.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.one_divided_x.Location = New System.Drawing.Point(4, 242)
        Me.one_divided_x.Name = "one_divided_x"
        Me.one_divided_x.Size = New System.Drawing.Size(77, 40)
        Me.one_divided_x.TabIndex = 59
        Me.one_divided_x.Text = "1/x"
        Me.one_divided_x.UseVisualStyleBackColor = False
        '
        'ten_x
        '
        Me.ten_x.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ten_x.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ten_x.FlatAppearance.BorderSize = 0
        Me.ten_x.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.ten_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.ten_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ten_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ten_x.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ten_x.Location = New System.Drawing.Point(87, 242)
        Me.ten_x.Name = "ten_x"
        Me.ten_x.Size = New System.Drawing.Size(77, 40)
        Me.ten_x.TabIndex = 60
        Me.ten_x.Text = "10˟"
        Me.ten_x.UseVisualStyleBackColor = False
        '
        'history_view
        '
        Me.history_view.BackColor = System.Drawing.Color.Gainsboro
        Me.history_view.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.history_view.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.history_view.ForeColor = System.Drawing.Color.Black
        Me.history_view.Location = New System.Drawing.Point(481, 84)
        Me.history_view.Name = "history_view"
        Me.history_view.ReadOnly = True
        Me.history_view.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.history_view.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.history_view.Size = New System.Drawing.Size(251, 400)
        Me.history_view.TabIndex = 48
        Me.history_view.Text = ""
        '
        'pivalue
        '
        Me.pivalue.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pivalue.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.pivalue.FlatAppearance.BorderSize = 0
        Me.pivalue.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.pivalue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.pivalue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.pivalue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pivalue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pivalue.Location = New System.Drawing.Point(4, 330)
        Me.pivalue.Name = "pivalue"
        Me.pivalue.Size = New System.Drawing.Size(77, 40)
        Me.pivalue.TabIndex = 62
        Me.pivalue.Text = "π"
        Me.pivalue.UseVisualStyleBackColor = False
        '
        'toggle
        '
        Me.toggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.toggle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.toggle.FlatAppearance.BorderSize = 0
        Me.toggle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toggle.Font = New System.Drawing.Font("Segoe UI Symbol", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toggle.Location = New System.Drawing.Point(4, 286)
        Me.toggle.Name = "toggle"
        Me.toggle.Size = New System.Drawing.Size(77, 40)
        Me.toggle.TabIndex = 63
        Me.toggle.Text = "↑"
        Me.toggle.UseVisualStyleBackColor = False
        '
        'cube
        '
        Me.cube.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cube.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cube.FlatAppearance.BorderSize = 0
        Me.cube.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.cube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.cube.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cube.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cube.Location = New System.Drawing.Point(4, 198)
        Me.cube.Name = "cube"
        Me.cube.Size = New System.Drawing.Size(77, 40)
        Me.cube.TabIndex = 64
        Me.cube.Text = "x³"
        Me.cube.UseVisualStyleBackColor = False
        '
        'e_power_x
        '
        Me.e_power_x.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.e_power_x.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.e_power_x.FlatAppearance.BorderSize = 0
        Me.e_power_x.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.e_power_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.e_power_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.e_power_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.e_power_x.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_power_x.Location = New System.Drawing.Point(87, 242)
        Me.e_power_x.Name = "e_power_x"
        Me.e_power_x.Size = New System.Drawing.Size(77, 40)
        Me.e_power_x.TabIndex = 65
        Me.e_power_x.Text = "e˟"
        Me.e_power_x.UseVisualStyleBackColor = False
        '
        'log_e
        '
        Me.log_e.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.log_e.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.log_e.FlatAppearance.BorderSize = 0
        Me.log_e.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.log_e.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.log_e.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.log_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.log_e.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_e.Location = New System.Drawing.Point(170, 242)
        Me.log_e.Name = "log_e"
        Me.log_e.Size = New System.Drawing.Size(77, 40)
        Me.log_e.TabIndex = 66
        Me.log_e.Text = "ln"
        Me.log_e.UseVisualStyleBackColor = False
        '
        'percentage
        '
        Me.percentage.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.percentage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.percentage.FlatAppearance.BorderSize = 0
        Me.percentage.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.percentage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.percentage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.percentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.percentage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentage.Location = New System.Drawing.Point(253, 242)
        Me.percentage.Name = "percentage"
        Me.percentage.Size = New System.Drawing.Size(77, 40)
        Me.percentage.TabIndex = 67
        Me.percentage.Text = "%"
        Me.percentage.UseVisualStyleBackColor = False
        '
        'random_num
        '
        Me.random_num.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.random_num.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.random_num.FlatAppearance.BorderSize = 0
        Me.random_num.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.random_num.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.random_num.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.random_num.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.random_num.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.random_num.Location = New System.Drawing.Point(336, 242)
        Me.random_num.Name = "random_num"
        Me.random_num.Size = New System.Drawing.Size(77, 40)
        Me.random_num.TabIndex = 68
        Me.random_num.Text = "Ran#"
        Me.random_num.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(695, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 36)
        Me.Button1.TabIndex = 69
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.equals
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(744, 506)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.random_num)
        Me.Controls.Add(Me.percentage)
        Me.Controls.Add(Me.log_e)
        Me.Controls.Add(Me.e_power_x)
        Me.Controls.Add(Me.cube)
        Me.Controls.Add(Me.toggle)
        Me.Controls.Add(Me.pivalue)
        Me.Controls.Add(Me.ten_x)
        Me.Controls.Add(Me.one_divided_x)
        Me.Controls.Add(Me.asin)
        Me.Controls.Add(Me.acos)
        Me.Controls.Add(Me.atan)
        Me.Controls.Add(Me.sin)
        Me.Controls.Add(Me.cos)
        Me.Controls.Add(Me.tan)
        Me.Controls.Add(Me.exp)
        Me.Controls.Add(Me.negation)
        Me.Controls.Add(Me.equation)
        Me.Controls.Add(Me.clearhistory)
        Me.Controls.Add(Me.history_view)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.History)
        Me.Controls.Add(Me.nohistory)
        Me.Controls.Add(Me.x_squareroot)
        Me.Controls.Add(Me.squareroot)
        Me.Controls.Add(Me.power_y)
        Me.Controls.Add(Me.square)
        Me.Controls.Add(Me.modulus)
        Me.Controls.Add(Me.equals)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.subtract)
        Me.Controls.Add(Me.multiply)
        Me.Controls.Add(Me.divide)
        Me.Controls.Add(Me.dot)
        Me.Controls.Add(Me.three)
        Me.Controls.Add(Me.six)
        Me.Controls.Add(Me.nine)
        Me.Controls.Add(Me.backspace)
        Me.Controls.Add(Me.zero)
        Me.Controls.Add(Me.two)
        Me.Controls.Add(Me.five)
        Me.Controls.Add(Me.eight)
        Me.Controls.Add(Me.clear_all)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.one)
        Me.Controls.Add(Me.four)
        Me.Controls.Add(Me.seven)
        Me.Controls.Add(Me.log_10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.clear_entry)
        Me.Controls.Add(Me.factorial)
        Me.Controls.Add(Me.TextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WowCalci"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox As TextBox
    Friend WithEvents factorial As Button
    Friend WithEvents clear_entry As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents log_10 As Button
    Friend WithEvents seven As Button
    Friend WithEvents four As Button
    Friend WithEvents one As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents clear_all As Button
    Friend WithEvents eight As Button
    Friend WithEvents five As Button
    Friend WithEvents two As Button
    Friend WithEvents zero As Button
    Friend WithEvents backspace As Button
    Friend WithEvents nine As Button
    Friend WithEvents six As Button
    Friend WithEvents three As Button
    Friend WithEvents dot As Button
    Friend WithEvents divide As Button
    Friend WithEvents multiply As Button
    Friend WithEvents subtract As Button
    Friend WithEvents add As Button
    Friend WithEvents equals As Button
    Friend WithEvents modulus As Button
    Friend WithEvents square As Button
    Friend WithEvents power_y As Button
    Friend WithEvents squareroot As Button
    Friend WithEvents x_squareroot As Button
    Friend WithEvents nohistory As Label
    Friend WithEvents History As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents clearhistory As Button
    Friend WithEvents equation As Label
    Friend WithEvents negation As Button
    Friend WithEvents exp As Button
    Friend WithEvents tan As Button
    Friend WithEvents cos As Button
    Friend WithEvents sin As Button
    Friend WithEvents atan As Button
    Friend WithEvents acos As Button
    Friend WithEvents asin As Button
    Friend WithEvents one_divided_x As Button
    Friend WithEvents ten_x As Button
    Friend WithEvents history_view As RichTextBox
    Friend WithEvents pivalue As Button
    Friend WithEvents toggle As Button
    Friend WithEvents cube As Button
    Friend WithEvents e_power_x As Button
    Friend WithEvents log_e As Button
    Friend WithEvents percentage As Button
    Friend WithEvents random_num As Button
    Friend WithEvents Button1 As Button
End Class
