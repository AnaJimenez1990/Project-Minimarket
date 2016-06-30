<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ContrasenaLabel As System.Windows.Forms.Label
        Dim NombreUsuarioLabel As System.Windows.Forms.Label
        Dim CodigoEmpleadoLabel As System.Windows.Forms.Label
        Dim NombreEmpleadoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Me.ContrasenaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        ContrasenaLabel = New System.Windows.Forms.Label()
        NombreUsuarioLabel = New System.Windows.Forms.Label()
        CodigoEmpleadoLabel = New System.Windows.Forms.Label()
        NombreEmpleadoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ContrasenaLabel
        '
        ContrasenaLabel.AutoSize = True
        ContrasenaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContrasenaLabel.Location = New System.Drawing.Point(187, 492)
        ContrasenaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ContrasenaLabel.Name = "ContrasenaLabel"
        ContrasenaLabel.Size = New System.Drawing.Size(111, 24)
        ContrasenaLabel.TabIndex = 57
        ContrasenaLabel.Text = "Contrasena:"
        '
        'ContrasenaTextBox
        '
        Me.ContrasenaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContrasenaTextBox.Location = New System.Drawing.Point(370, 492)
        Me.ContrasenaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ContrasenaTextBox.Name = "ContrasenaTextBox"
        Me.ContrasenaTextBox.Size = New System.Drawing.Size(219, 28)
        Me.ContrasenaTextBox.TabIndex = 58
        Me.ContrasenaTextBox.UseSystemPasswordChar = True
        '
        'NombreUsuarioLabel
        '
        NombreUsuarioLabel.AutoSize = True
        NombreUsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreUsuarioLabel.Location = New System.Drawing.Point(161, 445)
        NombreUsuarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreUsuarioLabel.Name = "NombreUsuarioLabel"
        NombreUsuarioLabel.Size = New System.Drawing.Size(150, 24)
        NombreUsuarioLabel.TabIndex = 54
        NombreUsuarioLabel.Text = "nombre Usuario:"
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(370, 445)
        Me.NombreUsuarioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(219, 28)
        Me.NombreUsuarioTextBox.TabIndex = 56
        '
        'CodigoEmpleadoLabel
        '
        CodigoEmpleadoLabel.AutoSize = True
        CodigoEmpleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoEmpleadoLabel.Location = New System.Drawing.Point(103, 126)
        CodigoEmpleadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CodigoEmpleadoLabel.Name = "CodigoEmpleadoLabel"
        CodigoEmpleadoLabel.Size = New System.Drawing.Size(165, 24)
        CodigoEmpleadoLabel.TabIndex = 45
        CodigoEmpleadoLabel.Text = "codigo Empleado:"
        '
        'CodigoEmpleadoTextBox
        '
        Me.CodigoEmpleadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoEmpleadoTextBox.Location = New System.Drawing.Point(287, 126)
        Me.CodigoEmpleadoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CodigoEmpleadoTextBox.Name = "CodigoEmpleadoTextBox"
        Me.CodigoEmpleadoTextBox.Size = New System.Drawing.Size(260, 28)
        Me.CodigoEmpleadoTextBox.TabIndex = 46
        '
        'NombreEmpleadoLabel
        '
        NombreEmpleadoLabel.AutoSize = True
        NombreEmpleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreEmpleadoLabel.Location = New System.Drawing.Point(103, 158)
        NombreEmpleadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreEmpleadoLabel.Name = "NombreEmpleadoLabel"
        NombreEmpleadoLabel.Size = New System.Drawing.Size(173, 24)
        NombreEmpleadoLabel.TabIndex = 47
        NombreEmpleadoLabel.Text = "nombre Empleado:"
        '
        'NombreEmpleadoTextBox
        '
        Me.NombreEmpleadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreEmpleadoTextBox.Location = New System.Drawing.Point(287, 158)
        Me.NombreEmpleadoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreEmpleadoTextBox.Name = "NombreEmpleadoTextBox"
        Me.NombreEmpleadoTextBox.Size = New System.Drawing.Size(260, 28)
        Me.NombreEmpleadoTextBox.TabIndex = 48
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(103, 190)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(95, 24)
        DireccionLabel.TabIndex = 49
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(287, 190)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(260, 28)
        Me.DireccionTextBox.TabIndex = 50
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(103, 222)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(90, 24)
        TelefonoLabel.TabIndex = 51
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(287, 222)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(260, 28)
        Me.TelefonoTextBox.TabIndex = 52
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(103, 254)
        CorreoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(73, 24)
        CorreoLabel.TabIndex = 53
        CorreoLabel.Text = "Correo:"
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextBox.Location = New System.Drawing.Point(287, 254)
        Me.CorreoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(260, 28)
        Me.CorreoTextBox.TabIndex = 55
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(459, 348)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 28)
        Me.RadioButton2.TabIndex = 44
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Usuario"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(309, 348)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(118, 28)
        Me.RadioButton1.TabIndex = 43
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Empleado"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 351)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 24)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "¿Empleado o usuario?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 46)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Registro de empleados"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(497, 739)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 37)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(497, 677)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 37)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Consultar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(349, 677)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 37)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(215, 677)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 37)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(85, 677)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 37)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 823)
        Me.Controls.Add(ContrasenaLabel)
        Me.Controls.Add(Me.ContrasenaTextBox)
        Me.Controls.Add(NombreUsuarioLabel)
        Me.Controls.Add(Me.NombreUsuarioTextBox)
        Me.Controls.Add(CodigoEmpleadoLabel)
        Me.Controls.Add(Me.CodigoEmpleadoTextBox)
        Me.Controls.Add(NombreEmpleadoLabel)
        Me.Controls.Add(Me.NombreEmpleadoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Registro Empleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContrasenaTextBox As TextBox
    Friend WithEvents NombreUsuarioTextBox As TextBox
    Friend WithEvents CodigoEmpleadoTextBox As TextBox
    Friend WithEvents NombreEmpleadoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
