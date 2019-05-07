<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.xt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.txt_cuil_cuit = New System.Windows.Forms.TextBox()
        Me.txt_apellido_nombre = New System.Windows.Forms.TextBox()
        Me.lista_categoria = New System.Windows.Forms.ComboBox()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.lbl_cuil_cuit = New System.Windows.Forms.Label()
        Me.lbl_apellido_nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_tipo_factura = New System.Windows.Forms.Label()
        Me.lista_tipo_factura = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'xt_direccion
        '
        Me.xt_direccion.Location = New System.Drawing.Point(182, 248)
        Me.xt_direccion.Name = "xt_direccion"
        Me.xt_direccion.Size = New System.Drawing.Size(121, 20)
        Me.xt_direccion.TabIndex = 21
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(182, 305)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(121, 20)
        Me.txt_telefono.TabIndex = 20
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(47, 306)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(62, 16)
        Me.lbl_telefono.TabIndex = 19
        Me.lbl_telefono.Text = "Teléfono"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion.Location = New System.Drawing.Point(47, 249)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(65, 16)
        Me.lbl_direccion.TabIndex = 18
        Me.lbl_direccion.Text = "Dirección"
        '
        'txt_cuil_cuit
        '
        Me.txt_cuil_cuit.Location = New System.Drawing.Point(182, 143)
        Me.txt_cuil_cuit.Name = "txt_cuil_cuit"
        Me.txt_cuil_cuit.Size = New System.Drawing.Size(121, 20)
        Me.txt_cuil_cuit.TabIndex = 17
        '
        'txt_apellido_nombre
        '
        Me.txt_apellido_nombre.Location = New System.Drawing.Point(182, 90)
        Me.txt_apellido_nombre.Name = "txt_apellido_nombre"
        Me.txt_apellido_nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_apellido_nombre.TabIndex = 16
        '
        'lista_categoria
        '
        Me.lista_categoria.FormattingEnabled = True
        Me.lista_categoria.Location = New System.Drawing.Point(182, 188)
        Me.lista_categoria.Name = "lista_categoria"
        Me.lista_categoria.Size = New System.Drawing.Size(121, 21)
        Me.lista_categoria.TabIndex = 15
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(47, 189)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(67, 16)
        Me.lbl_categoria.TabIndex = 14
        Me.lbl_categoria.Text = "Categoría"
        '
        'lbl_cuil_cuit
        '
        Me.lbl_cuil_cuit.AutoSize = True
        Me.lbl_cuil_cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuil_cuit.Location = New System.Drawing.Point(42, 144)
        Me.lbl_cuil_cuit.Name = "lbl_cuil_cuit"
        Me.lbl_cuil_cuit.Size = New System.Drawing.Size(72, 16)
        Me.lbl_cuil_cuit.TabIndex = 13
        Me.lbl_cuil_cuit.Text = "CUIL/CUIT"
        '
        'lbl_apellido_nombre
        '
        Me.lbl_apellido_nombre.AutoSize = True
        Me.lbl_apellido_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido_nombre.Location = New System.Drawing.Point(40, 91)
        Me.lbl_apellido_nombre.Name = "lbl_apellido_nombre"
        Me.lbl_apellido_nombre.Size = New System.Drawing.Size(110, 16)
        Me.lbl_apellido_nombre.TabIndex = 12
        Me.lbl_apellido_nombre.Text = "Apellido, nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Datos del Cliente"
        '
        'lbl_tipo_factura
        '
        Me.lbl_tipo_factura.AutoSize = True
        Me.lbl_tipo_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_factura.Location = New System.Drawing.Point(47, 352)
        Me.lbl_tipo_factura.Name = "lbl_tipo_factura"
        Me.lbl_tipo_factura.Size = New System.Drawing.Size(84, 16)
        Me.lbl_tipo_factura.TabIndex = 22
        Me.lbl_tipo_factura.Text = "Tipo Factura"
        '
        'lista_tipo_factura
        '
        Me.lista_tipo_factura.FormattingEnabled = True
        Me.lista_tipo_factura.Location = New System.Drawing.Point(182, 351)
        Me.lista_tipo_factura.Name = "lista_tipo_factura"
        Me.lista_tipo_factura.Size = New System.Drawing.Size(121, 21)
        Me.lista_tipo_factura.TabIndex = 23
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lista_tipo_factura)
        Me.Controls.Add(Me.lbl_tipo_factura)
        Me.Controls.Add(Me.xt_direccion)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.txt_cuil_cuit)
        Me.Controls.Add(Me.txt_apellido_nombre)
        Me.Controls.Add(Me.lista_categoria)
        Me.Controls.Add(Me.lbl_categoria)
        Me.Controls.Add(Me.lbl_cuil_cuit)
        Me.Controls.Add(Me.lbl_apellido_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents xt_direccion As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents txt_cuil_cuit As TextBox
    Friend WithEvents txt_apellido_nombre As TextBox
    Friend WithEvents lista_categoria As ComboBox
    Friend WithEvents lbl_categoria As Label
    Friend WithEvents lbl_cuil_cuit As Label
    Friend WithEvents lbl_apellido_nombre As Label
    Friend WithEvents Label1 As Label

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido_nombre.TextChanged

    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents lbl_tipo_factura As Label
    Friend WithEvents lista_tipo_factura As ComboBox
End Class
