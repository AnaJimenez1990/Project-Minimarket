<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRedVenta = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegCompra = New System.Windows.Forms.Button()
        Me.lblRegProducto = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblRegEmple = New System.Windows.Forms.Label()
        Me.lblRegProve = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(287, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu principal"
        '
        'lblRedVenta
        '
        Me.lblRedVenta.AutoSize = True
        Me.lblRedVenta.BackColor = System.Drawing.Color.Transparent
        Me.lblRedVenta.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedVenta.ForeColor = System.Drawing.Color.Lime
        Me.lblRedVenta.Location = New System.Drawing.Point(51, 222)
        Me.lblRedVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRedVenta.Name = "lblRedVenta"
        Me.lblRedVenta.Size = New System.Drawing.Size(105, 32)
        Me.lblRedVenta.TabIndex = 1
        Me.lblRedVenta.Text = "Facturar"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(57, 126)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 92)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(192, 222)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Factura Compras"
        '
        'lblRegCompra
        '
        Me.lblRegCompra.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.productos
        Me.lblRegCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblRegCompra.Location = New System.Drawing.Point(57, 314)
        Me.lblRegCompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRegCompra.Name = "lblRegCompra"
        Me.lblRegCompra.Size = New System.Drawing.Size(100, 87)
        Me.lblRegCompra.TabIndex = 4
        Me.lblRegCompra.TabStop = False
        Me.lblRegCompra.UseVisualStyleBackColor = True
        '
        'lblRegProducto
        '
        Me.lblRegProducto.AutoSize = True
        Me.lblRegProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblRegProducto.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegProducto.ForeColor = System.Drawing.Color.Lime
        Me.lblRegProducto.Location = New System.Drawing.Point(40, 393)
        Me.lblRegProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegProducto.Name = "lblRegProducto"
        Me.lblRegProducto.Size = New System.Drawing.Size(123, 32)
        Me.lblRegProducto.TabIndex = 5
        Me.lblRegProducto.Text = "Productos"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.compra
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(261, 126)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 92)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblRegEmple
        '
        Me.lblRegEmple.AutoSize = True
        Me.lblRegEmple.BackColor = System.Drawing.Color.Transparent
        Me.lblRegEmple.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegEmple.ForeColor = System.Drawing.Color.Lime
        Me.lblRegEmple.Location = New System.Drawing.Point(255, 391)
        Me.lblRegEmple.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegEmple.Name = "lblRegEmple"
        Me.lblRegEmple.Size = New System.Drawing.Size(130, 32)
        Me.lblRegEmple.TabIndex = 7
        Me.lblRegEmple.Text = "Empleados"
        '
        'lblRegProve
        '
        Me.lblRegProve.AutoSize = True
        Me.lblRegProve.BackColor = System.Drawing.Color.Transparent
        Me.lblRegProve.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegProve.ForeColor = System.Drawing.Color.Lime
        Me.lblRegProve.Location = New System.Drawing.Point(451, 393)
        Me.lblRegProve.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegProve.Name = "lblRegProve"
        Me.lblRegProve.Size = New System.Drawing.Size(145, 32)
        Me.lblRegProve.TabIndex = 9
        Me.lblRegProve.Text = "Proveedores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(451, 222)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 32)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pedidos"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Product_sale_report_icon
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(457, 126)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 92)
        Me.Button5.TabIndex = 12
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(656, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Inventario"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.inventario
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(663, 126)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 92)
        Me.Button6.TabIndex = 14
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnEmpleado
        '
        Me.btnEmpleado.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.empleados
        Me.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmpleado.Location = New System.Drawing.Point(261, 300)
        Me.btnEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(100, 92)
        Me.btnEmpleado.TabIndex = 15
        Me.btnEmpleado.TabStop = False
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.proveedor
        Me.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProveedores.Location = New System.Drawing.Point(457, 300)
        Me.btnProveedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(100, 92)
        Me.btnProveedores.TabIndex = 16
        Me.btnProveedores.TabStop = False
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._exit
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(663, 300)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 92)
        Me.Button4.TabIndex = 17
        Me.Button4.TabStop = False
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(656, 393)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 32)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Salir"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back1
        Me.ClientSize = New System.Drawing.Size(785, 591)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnProveedores)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblRegProve)
        Me.Controls.Add(Me.lblRegEmple)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblRegProducto)
        Me.Controls.Add(Me.lblRegCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblRedVenta)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MenuPrincipal"
        Me.Text = "."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRedVenta As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRegCompra As System.Windows.Forms.Button
    Friend WithEvents lblRegProducto As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblRegEmple As System.Windows.Forms.Label
    Friend WithEvents lblRegProve As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnProveedores As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
