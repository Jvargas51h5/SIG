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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Map1 = New ActualMap.Windows.Map()
        Me.cbCapas = New System.Windows.Forms.CheckedListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerTablaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarSeleccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCrearCapa = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarCapaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CAPASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBolivia = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCentrPoblados = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAreasProt = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirCapaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombrarCapaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSeleccionarDpto = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.BtnZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.BtnCentrar = New System.Windows.Forms.ToolStripButton()
        Me.BtnColor = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminarCapa = New System.Windows.Forms.ToolStripButton()
        Me.cbColumns = New System.Windows.Forms.ComboBox()
        Me.cbValor = New System.Windows.Forms.ComboBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.tbSelect = New System.Windows.Forms.TextBox()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.BtnIgual = New System.Windows.Forms.Button()
        Me.BtnMenor = New System.Windows.Forms.Button()
        Me.BtnMayor = New System.Windows.Forms.Button()
        Me.BtnOr = New System.Windows.Forms.Button()
        Me.BtnAmd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Map1
        '
        Me.Map1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Map1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Map1.FontQuality = ActualMap.FontQuality.ClearType
        Me.Map1.Location = New System.Drawing.Point(364, 66)
        Me.Map1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Map1.Name = "Map1"
        Me.Map1.PixelPerInch = 96
        Me.Map1.ScaleBar.BarUnit = ActualMap.UnitSystem.Imperial
        Me.Map1.ScaleBar.FeetString = "ft"
        Me.Map1.ScaleBar.Font.Alignment = ActualMap.TextAlign.Left
        Me.Map1.ScaleBar.Font.Bold = False
        Me.Map1.ScaleBar.Font.Charset = 1
        Me.Map1.ScaleBar.Font.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Map1.ScaleBar.Font.Italic = False
        Me.Map1.ScaleBar.Font.Name = "Arial"
        Me.Map1.ScaleBar.Font.Outline = False
        Me.Map1.ScaleBar.Font.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Map1.ScaleBar.Font.Quality = ActualMap.FontQuality.[Default]
        Me.Map1.ScaleBar.Font.Size = 12
        Me.Map1.ScaleBar.Font.StrikeThrough = False
        Me.Map1.ScaleBar.Font.Underline = False
        Me.Map1.ScaleBar.KilometersString = "km"
        Me.Map1.ScaleBar.MaxWidth = 0
        Me.Map1.ScaleBar.MetersString = "m"
        Me.Map1.ScaleBar.MilesString = "mi"
        Me.Map1.ScaleBar.Position = ActualMap.ScaleBarPosition.BottomRight
        Me.Map1.ScaleBar.Symbol.Bitmap = ""
        Me.Map1.ScaleBar.Symbol.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Map1.ScaleBar.Symbol.FillStyle = ActualMap.FillStyle.Solid
        Me.Map1.ScaleBar.Symbol.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Map1.ScaleBar.Symbol.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Map1.ScaleBar.Symbol.LineStyle = ActualMap.LineStyle.Solid
        Me.Map1.ScaleBar.Symbol.PointStyle = ActualMap.PointStyle.Circle
        Me.Map1.ScaleBar.Symbol.Rotation = 0.0R
        Me.Map1.ScaleBar.Symbol.Size = 1
        Me.Map1.ScaleBar.Symbol.TransparentColor = System.Drawing.Color.Empty
        Me.Map1.ScaleBar.Visible = False
        Me.Map1.Size = New System.Drawing.Size(993, 631)
        Me.Map1.SmoothingMode = ActualMap.SmoothingMode.AntiAlias
        Me.Map1.TabIndex = 0
        Me.Map1.ToolShape.FillColor = System.Drawing.Color.LightGray
        Me.Map1.ToolShape.LineColor = System.Drawing.Color.Red
        Me.Map1.ToolShape.Opacity = 0.5R
        Me.Map1.ToolShape.VertexColor = System.Drawing.Color.Red
        Me.Map1.ToolShape.VirtualVertexColor = System.Drawing.Color.Green
        '
        'cbCapas
        '
        Me.cbCapas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbCapas.ContextMenuStrip = Me.ContextMenuStrip1
        Me.cbCapas.FormattingEnabled = True
        Me.cbCapas.Location = New System.Drawing.Point(13, 66)
        Me.cbCapas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cbCapas.Name = "cbCapas"
        Me.cbCapas.Size = New System.Drawing.Size(329, 252)
        Me.cbCapas.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerTablaToolStripMenuItem, Me.QuitarSeleccionToolStripMenuItem, Me.BtnCrearCapa, Me.EliminarCapaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(201, 108)
        '
        'VerTablaToolStripMenuItem
        '
        Me.VerTablaToolStripMenuItem.Name = "VerTablaToolStripMenuItem"
        Me.VerTablaToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.VerTablaToolStripMenuItem.Text = "Ver Tabla"
        '
        'QuitarSeleccionToolStripMenuItem
        '
        Me.QuitarSeleccionToolStripMenuItem.Name = "QuitarSeleccionToolStripMenuItem"
        Me.QuitarSeleccionToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.QuitarSeleccionToolStripMenuItem.Text = "Quitar Seleccion"
        '
        'BtnCrearCapa
        '
        Me.BtnCrearCapa.Name = "BtnCrearCapa"
        Me.BtnCrearCapa.Size = New System.Drawing.Size(200, 26)
        Me.BtnCrearCapa.Text = "Crear Capa"
        '
        'EliminarCapaToolStripMenuItem
        '
        Me.EliminarCapaToolStripMenuItem.Name = "EliminarCapaToolStripMenuItem"
        Me.EliminarCapaToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.EliminarCapaToolStripMenuItem.Text = "Eliminar Capa"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CAPASToolStripMenuItem, Me.CONSULTASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 35)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CAPASToolStripMenuItem
        '
        Me.CAPASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnBolivia, Me.BtnCentrPoblados, Me.BtnAreasProt, Me.AbrirCapaToolStripMenuItem, Me.NombrarCapaToolStripMenuItem})
        Me.CAPASToolStripMenuItem.Name = "CAPASToolStripMenuItem"
        Me.CAPASToolStripMenuItem.Size = New System.Drawing.Size(76, 27)
        Me.CAPASToolStripMenuItem.Text = "CAPAS"
        '
        'BtnBolivia
        '
        Me.BtnBolivia.Name = "BtnBolivia"
        Me.BtnBolivia.Size = New System.Drawing.Size(214, 28)
        Me.BtnBolivia.Text = "Bolivia"
        '
        'BtnCentrPoblados
        '
        Me.BtnCentrPoblados.Name = "BtnCentrPoblados"
        Me.BtnCentrPoblados.Size = New System.Drawing.Size(214, 28)
        Me.BtnCentrPoblados.Text = "Centros Poblados"
        '
        'BtnAreasProt
        '
        Me.BtnAreasProt.Name = "BtnAreasProt"
        Me.BtnAreasProt.Size = New System.Drawing.Size(214, 28)
        Me.BtnAreasProt.Text = "Areas Protegidas"
        '
        'AbrirCapaToolStripMenuItem
        '
        Me.AbrirCapaToolStripMenuItem.Name = "AbrirCapaToolStripMenuItem"
        Me.AbrirCapaToolStripMenuItem.Size = New System.Drawing.Size(214, 28)
        Me.AbrirCapaToolStripMenuItem.Text = "Abrir Archivo"
        '
        'NombrarCapaToolStripMenuItem
        '
        Me.NombrarCapaToolStripMenuItem.Name = "NombrarCapaToolStripMenuItem"
        Me.NombrarCapaToolStripMenuItem.Size = New System.Drawing.Size(214, 28)
        Me.NombrarCapaToolStripMenuItem.Text = "Nombrar Capa"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSeleccionarDpto})
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(124, 27)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        '
        'btnSeleccionarDpto
        '
        Me.btnSeleccionarDpto.Name = "btnSeleccionarDpto"
        Me.btnSeleccionarDpto.Size = New System.Drawing.Size(236, 28)
        Me.btnSeleccionarDpto.Text = "Consultas Espaciales"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnZoomIn, Me.BtnZoomOut, Me.BtnCentrar, Me.BtnColor, Me.BtnEliminarCapa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 35)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1370, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnZoomIn
        '
        Me.BtnZoomIn.Image = CType(resources.GetObject("BtnZoomIn.Image"), System.Drawing.Image)
        Me.BtnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnZoomIn.Name = "BtnZoomIn"
        Me.BtnZoomIn.Size = New System.Drawing.Size(72, 22)
        Me.BtnZoomIn.Text = "Zoom In"
        '
        'BtnZoomOut
        '
        Me.BtnZoomOut.Image = CType(resources.GetObject("BtnZoomOut.Image"), System.Drawing.Image)
        Me.BtnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnZoomOut.Name = "BtnZoomOut"
        Me.BtnZoomOut.Size = New System.Drawing.Size(82, 22)
        Me.BtnZoomOut.Text = "Zoom Out"
        '
        'BtnCentrar
        '
        Me.BtnCentrar.Image = CType(resources.GetObject("BtnCentrar.Image"), System.Drawing.Image)
        Me.BtnCentrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCentrar.Name = "BtnCentrar"
        Me.BtnCentrar.Size = New System.Drawing.Size(66, 22)
        Me.BtnCentrar.Text = "Centrar"
        '
        'BtnColor
        '
        Me.BtnColor.Image = CType(resources.GetObject("BtnColor.Image"), System.Drawing.Image)
        Me.BtnColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(56, 22)
        Me.BtnColor.Text = "Color"
        '
        'BtnEliminarCapa
        '
        Me.BtnEliminarCapa.Image = CType(resources.GetObject("BtnEliminarCapa.Image"), System.Drawing.Image)
        Me.BtnEliminarCapa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminarCapa.Name = "BtnEliminarCapa"
        Me.BtnEliminarCapa.Size = New System.Drawing.Size(100, 22)
        Me.BtnEliminarCapa.Text = "Eliminar Capa"
        '
        'cbColumns
        '
        Me.cbColumns.FormattingEnabled = True
        Me.cbColumns.Location = New System.Drawing.Point(14, 39)
        Me.cbColumns.Name = "cbColumns"
        Me.cbColumns.Size = New System.Drawing.Size(250, 36)
        Me.cbColumns.TabIndex = 8
        '
        'cbValor
        '
        Me.cbValor.FormattingEnabled = True
        Me.cbValor.Location = New System.Drawing.Point(15, 116)
        Me.cbValor.Name = "cbValor"
        Me.cbValor.Size = New System.Drawing.Size(250, 36)
        Me.cbValor.TabIndex = 9
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Location = New System.Drawing.Point(12, 76)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 38)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'tbSelect
        '
        Me.tbSelect.Location = New System.Drawing.Point(6, 497)
        Me.tbSelect.Multiline = True
        Me.tbSelect.Name = "tbSelect"
        Me.tbSelect.Size = New System.Drawing.Size(299, 151)
        Me.tbSelect.TabIndex = 11
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Location = New System.Drawing.Point(13, 654)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(214, 33)
        Me.BtnConsulta.TabIndex = 12
        Me.BtnConsulta.Text = "Consulta por Atributos"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'BtnIgual
        '
        Me.BtnIgual.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIgual.Location = New System.Drawing.Point(34, 81)
        Me.BtnIgual.Name = "BtnIgual"
        Me.BtnIgual.Size = New System.Drawing.Size(36, 29)
        Me.BtnIgual.TabIndex = 13
        Me.BtnIgual.Text = "="
        Me.BtnIgual.UseVisualStyleBackColor = True
        '
        'BtnMenor
        '
        Me.BtnMenor.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenor.Location = New System.Drawing.Point(76, 81)
        Me.BtnMenor.Name = "BtnMenor"
        Me.BtnMenor.Size = New System.Drawing.Size(36, 29)
        Me.BtnMenor.TabIndex = 14
        Me.BtnMenor.Text = "<="
        Me.BtnMenor.UseVisualStyleBackColor = True
        '
        'BtnMayor
        '
        Me.BtnMayor.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMayor.Location = New System.Drawing.Point(120, 81)
        Me.BtnMayor.Name = "BtnMayor"
        Me.BtnMayor.Size = New System.Drawing.Size(36, 29)
        Me.BtnMayor.TabIndex = 15
        Me.BtnMayor.Text = ">="
        Me.BtnMayor.UseVisualStyleBackColor = True
        '
        'BtnOr
        '
        Me.BtnOr.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOr.Location = New System.Drawing.Point(162, 81)
        Me.BtnOr.Name = "BtnOr"
        Me.BtnOr.Size = New System.Drawing.Size(36, 29)
        Me.BtnOr.TabIndex = 16
        Me.BtnOr.Text = "or"
        Me.BtnOr.UseVisualStyleBackColor = True
        '
        'BtnAmd
        '
        Me.BtnAmd.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAmd.Location = New System.Drawing.Point(204, 81)
        Me.BtnAmd.Name = "BtnAmd"
        Me.BtnAmd.Size = New System.Drawing.Size(46, 29)
        Me.BtnAmd.TabIndex = 17
        Me.BtnAmd.Text = "and"
        Me.BtnAmd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbColumns)
        Me.GroupBox1.Controls.Add(Me.BtnAmd)
        Me.GroupBox1.Controls.Add(Me.cbValor)
        Me.GroupBox1.Controls.Add(Me.BtnOr)
        Me.GroupBox1.Controls.Add(Me.BtnIgual)
        Me.GroupBox1.Controls.Add(Me.BtnMayor)
        Me.GroupBox1.Controls.Add(Me.BtnMenor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 164)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros de la Consulta:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(1370, 722)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Controls.Add(Me.tbSelect)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cbCapas)
        Me.Controls.Add(Me.Map1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  MANEJO DE MAPAS   -   JHON VARGAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCapas As System.Windows.Forms.CheckedListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CAPASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnBolivia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCentrPoblados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnAreasProt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnZoomIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnZoomOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnColor As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCentrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEliminarCapa As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSeleccionarDpto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbColumns As System.Windows.Forms.ComboBox
    Friend WithEvents cbValor As System.Windows.Forms.ComboBox
    Friend WithEvents Map1 As ActualMap.Windows.Map
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents tbSelect As System.Windows.Forms.TextBox
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents BtnIgual As System.Windows.Forms.Button
    Friend WithEvents BtnMenor As System.Windows.Forms.Button
    Friend WithEvents BtnMayor As System.Windows.Forms.Button
    Friend WithEvents BtnOr As System.Windows.Forms.Button
    Friend WithEvents BtnAmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerTablaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCrearCapa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarSeleccionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarCapaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirCapaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombrarCapaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
