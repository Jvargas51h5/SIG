<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsEspaciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsEspaciales))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbLayer = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbElement = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbBusqu = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbDistancia = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDistancia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.lbl_titulo)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(542, 68)
        Me.Panel2.TabIndex = 36
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(129, 9)
        Me.lbl_titulo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(313, 50)
        Me.lbl_titulo.TabIndex = 3
        Me.lbl_titulo.Text = "Consultas Espaciales"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'cbLayer
        '
        Me.cbLayer.FormattingEnabled = True
        Me.cbLayer.Location = New System.Drawing.Point(29, 52)
        Me.cbLayer.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cbLayer.Name = "cbLayer"
        Me.cbLayer.Size = New System.Drawing.Size(435, 34)
        Me.cbLayer.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbLayer)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 205)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(490, 112)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CAPA DE BUSQUEDA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbElement)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 80)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(490, 113)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CAPA DE SELECCION"
        '
        'cbElement
        '
        Me.cbElement.FormattingEnabled = True
        Me.cbElement.Location = New System.Drawing.Point(40, 49)
        Me.cbElement.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cbElement.Name = "cbElement"
        Me.cbElement.Size = New System.Drawing.Size(424, 34)
        Me.cbElement.TabIndex = 37
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbBusqu)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 329)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(490, 106)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "METODO DE SELECCION ESPACIAL"
        '
        'cbBusqu
        '
        Me.cbBusqu.FormattingEnabled = True
        Me.cbBusqu.Items.AddRange(New Object() {"Seleccionar Elementos de una Interseccion", "Seleccionar elementos a una Determinada Distancia"})
        Me.cbBusqu.Location = New System.Drawing.Point(35, 49)
        Me.cbBusqu.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cbBusqu.Name = "cbBusqu"
        Me.cbBusqu.Size = New System.Drawing.Size(424, 34)
        Me.cbBusqu.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 576)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 37)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Consulta Espacial"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Distancia:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(123, 42)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(68, 34)
        Me.NumericUpDown1.TabIndex = 45
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 26)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Kilometros"
        '
        'gbDistancia
        '
        Me.gbDistancia.Controls.Add(Me.NumericUpDown1)
        Me.gbDistancia.Controls.Add(Me.Label2)
        Me.gbDistancia.Controls.Add(Me.Label1)
        Me.gbDistancia.Enabled = False
        Me.gbDistancia.Location = New System.Drawing.Point(20, 444)
        Me.gbDistancia.Name = "gbDistancia"
        Me.gbDistancia.Size = New System.Drawing.Size(309, 100)
        Me.gbDistancia.TabIndex = 47
        Me.gbDistancia.TabStop = False
        Me.gbDistancia.Text = "Seleccionar la Distancia"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(304, 576)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(221, 37)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmConsEspaciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(539, 641)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.gbDistancia)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmConsEspaciales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsEspaciales"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDistancia.ResumeLayout(False)
        Me.gbDistancia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbLayer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbElement As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbBusqu As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbDistancia As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
