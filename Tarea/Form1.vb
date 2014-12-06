Imports ActualMap
Imports ActualMap.Windows

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

#Region "Agregar Capas Principales"

    Public estadoBol As Boolean = False
    Private Sub BtnBolivia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBolivia.Click
        CompararExistente("BOLIVIA")
        If estadoBol = False Then
            Dim lay As New Layer
            lay = Map1.AddLayer("D:\DATOS_SIG\BOLIVIA.shp")
            cbCapas.SelectedIndex = -1
            cbCapas.Items.Add("BOLIVIA", True)
            estadoBol = True
            lay.LabelField = "G_BOLIVIA"
            lay.ShowLabels = True
            lay.LabelFont.Name = "Verdana"
            lay.LabelFont.Size = 12
            lay.LabelFont.Bold = True
            lay.LabelStyle = LabelStyle.PolygonCenter
            Map1.Refresh()
        End If
    End Sub

    Public estadoCentPob As Boolean = False
    Private Sub BtnCentrPoblados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCentrPoblados.Click
        CompararExistente("CENTROS_POBLADOS_VIVIENDA")
        If estadoCentPob = False Then
            Map1.AddLayer("D:\DATOS_SIG\CENTROS_POBLADOS_VIVIENDA.shp")
            Map1.Refresh()
            cbCapas.SelectedIndex = -1
            cbCapas.Items.Add("CENTROS_POBLADOS_VIVIENDA", True)
            estadoCentPob = True
        End If
    End Sub

    Public estadoArProt As Boolean = False
    Private Sub BtnAreasProt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAreasProt.Click
        CompararExistente("AREAS PROTEGIDAS")
        If estadoArProt = False Then
            Map1.AddLayer("D:\DATOS_SIG\Areas Protegidas.shp")
            Map1.Refresh()
            cbCapas.SelectedIndex = -1
            cbCapas.Items.Add("AREAS PROTEGIDAS", True)
            estadoArProt = True
        End If
    End Sub
#End Region

    'validacion para no abrir una capa repetida
    Sub CompararExistente(ByVal Capa As String)
        Dim con As Integer = 0
        While con < cbCapas.Items.Count
            If cbCapas.Items(con) = Capa Then
                MsgBox("La capa Ya esta agragada")
            End If
            con = con + 1
        End While
    End Sub

    Sub Color(ByVal capa As Layer)
        Dim nuevo = New ColorDialog
        If nuevo.ShowDialog = DialogResult.OK Then
            capa.Symbol.FillColor = nuevo.Color
        End If
    End Sub

    'cambiar color a capa seleccionada
    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        Dim lay As Layer
        If cbCapas.SelectedIndex > -1 Then
            If cbCapas.GetItemChecked(cbCapas.SelectedIndex) = True Then
                lay = Map1(Convert.ToString(cbCapas.SelectedItem))
                Color(lay)
                Map1.Refresh()
            Else
                MsgBox("La Capa debe estar Visible")
            End If
        Else
            MsgBox("Debe Seleccionar una Capa")
        End If
    End Sub

    'hacer visible o invisible a una capa seleccionada
    Private Sub cbCapas_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles cbCapas.ItemCheck
        Dim lay As Layer
        If cbCapas.SelectedIndex > -1 Then
            If cbCapas.GetItemChecked(cbCapas.SelectedIndex) = True Then
                lay = Map1(Convert.ToString(cbCapas.SelectedItem))
                lay.Visible = False
            Else
                lay = Map1(Convert.ToString(cbCapas.SelectedItem))
                lay.Visible = True
            End If
            Map1.Refresh()
        End If
    End Sub

    'zoom centrar
    Private Sub BtnCentrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCentrar.Click
        Map1.ZoomFull()
        Map1.Refresh()
    End Sub

    'zoom aumentar
    Private Sub BtnZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZoomIn.Click
        Map1.MapTool = MapTool.ZoomIn
    End Sub

    'zoon minimizar
    Private Sub BtnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZoomOut.Click
        Map1.MapTool = MapTool.ZoomOut
    End Sub

    'eliminar una capa seleccionada
    Private Sub BtnEliminarCapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarCapa.Click
        Dim lay As Layer
        If cbCapas.SelectedIndex > -1 Then
            lay = Map1(Convert.ToString(cbCapas.SelectedItem))
            Map1.RemoveLayer(lay)
            Map1.Refresh()
            If Convert.ToString(cbCapas.SelectedItem) = "BOLIVIA" Then
                estadoBol = False
            ElseIf Convert.ToString(cbCapas.SelectedItem) = "AREAS PROTEGIDAS" Then
                estadoArProt = False
            ElseIf Convert.ToString(cbCapas.SelectedItem) = "CENTROS_POBLADOS_VIVIENDA" Then
                estadoCentPob = False
            End If
            cbCapas.Items.Remove(cbCapas.SelectedItem)
        Else
            MsgBox("Debe Selecccionar Una Capa")
        End If
    End Sub

    'Consultas Espaciales por Interseccion FALTA HACER POR DISTANCIA
    Private Sub btnSeleccionarDpto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarDpto.Click
        'search for Dpto.
        Dim frm As frmConsEspaciales = frmConsEspaciales
        frm.ShowDialog()

        If frm.cbLayer.SelectedIndex And frm.cbLayer.SelectedIndex And frm.cbBusqu.SelectedIndex = Nothing Then
            Dim layer As Layer = Map1.FindLayer(frm.cbLayer.SelectedItem)
            Dim dpto As Recordset = layer.Recordset
            If dpto.EOF Then
                MessageBox.Show("No se encontro el Punto.")
                Return
            Else
                Do While Not dpto.EOF
                    Dim s As MapShape = Map1.MapShapes.Add(dpto.Shape)
                    's.Symbol.FillColor = Drawing.Color.Red
                    dpto.MoveNext()

                    Dim cp As Recordset
                    cp = Map1(frm.cbElement.SelectedItem).SearchShape(s.Shape, SearchMethod.Intersect)
                    Do While Not cp.EOF
                        Dim scp As MapShape = Map1.MapShapes.Add(cp.Shape)
                        scp.Symbol.FillColor = Drawing.Color.Green
                        cp.MoveNext()
                    Loop
                Loop
            End If
            ' display the state
            'Map1.Extent = dpto.RecordExtent
            Map1.Refresh()
        Else
            MsgBox("Entro")
        End If
    End Sub

    'generar tabla de atributos de una capa seleccionada
    Private Sub VerTablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTablaToolStripMenuItem.Click
        itemactivo = cbCapas.SelectedItem
        Dim layer As Layer = Map1.FindLayer(itemactivo)
        If layer IsNot Nothing Then
            Dim records As Recordset = layer.Recordset
            Dim frm As New frmTablas
            frm.dgvDatos.DataSource = records
            frm.ShowDialog()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    'quitar seleccion  DEBO QUITAR TAMBIEN LA SELECCION DE LAS CONSULTAS ESPACIALES
    Private Sub QuitarSeleccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarSeleccionToolStripMenuItem.Click
        Dim layer As Layer = Map1.FindLayer(cbCapas.SelectedItem)
        Dim state As Recordset = layer.Recordset

        If state.EOF Then
            MessageBox.Show("No se encontro el Dpto.")
            Return
        Else
            Do While Not state.EOF
                If Map1.MapShapes.Count = 0 Then
                    'MsgBox("La seleccion ya esta eliminada")
                    state.MoveNext()
                Else
                    Dim shape As MapShape = Map1.MapShapes(0)
                    Map1.MapShapes.Remove(shape)
                    state.MoveNext()
                End If
            Loop
            Map1.Refresh()
        End If
    End Sub

    'obtener filas de una capa seleccionada
    Public itemactivo As String
    Private Sub cbCapas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCapas.SelectedIndexChanged
        itemactivo = cbCapas.SelectedItem
        Dim layer As Layer = Map1.FindLayer(itemactivo)
        'layer.Visible = False
        If layer IsNot Nothing Then
            Dim records As Recordset = layer.Recordset

            Dim i As Integer
            cbColumns.Items.Clear()
            For i = 0 To records.Fields.Count - 1
                'Esto debe mostrar el nombre del campo.
                cbColumns.Items.Add(records.Fields(i).Name)
            Next i
        End If
    End Sub

    'obtener registros de una columna seleccionada
    Private Sub cbColumns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColumns.SelectedIndexChanged
        itemactivo = cbCapas.SelectedItem
        Dim layer As Layer = Map1.FindLayer(itemactivo)
        If layer IsNot Nothing Then
            Dim records As Recordset = layer.Recordset
            cbValor.Items.Clear()

            Do While Not records.EOF
                cbValor.Items.Add(records(cbColumns.SelectedItem))
                records.MoveNext()
            Loop
            tbSelect.Text = tbSelect.Text + cbColumns.Text
        End If
    End Sub

    'generar consulta by atributos

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Dim state As Recordset
        state = Map1(itemactivo).SearchExpression(tbSelect.Text)

        If state.EOF Then
            MessageBox.Show("No se encontro el Dpto.")
            Return
        Else
            Do While Not state.EOF
                Dim shape As MapShape = Map1.MapShapes.Add(state.Shape)
                Dim s As Symbol = New Symbol()
                s.FillStyle = FillStyle.Invisible
                s.LineColor = Drawing.Color.DarkGreen
                s.Size = 3
                shape.Symbol = s
                state.MoveNext()
            Loop
            Map1.Refresh()
        End If
    End Sub

#Region "Condiciones para consultas by atributos"
    Private Sub cbValor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbValor.SelectedIndexChanged
        tbSelect.Text = tbSelect.Text + """" + Convert.ToString(cbValor.SelectedItem) + """"
    End Sub

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click
        tbSelect.Text = tbSelect.Text + " = "
    End Sub

    Private Sub BtnMenor_Click(sender As Object, e As EventArgs) Handles BtnMenor.Click
        tbSelect.Text = tbSelect.Text + " <= "
    End Sub

    Private Sub BtnMayor_Click(sender As Object, e As EventArgs) Handles BtnMayor.Click
        tbSelect.Text = tbSelect.Text + " >= "
    End Sub

    Private Sub BtnOr_Click(sender As Object, e As EventArgs) Handles BtnOr.Click
        tbSelect.Text = tbSelect.Text + " or "
    End Sub

    Private Sub BtnAmd_Click(sender As Object, e As EventArgs) Handles BtnAmd.Click
        tbSelect.Text = tbSelect.Text + " and "
    End Sub
#End Region

    'crear una capa a partir de una seleccion QUIERO ASIGNARLE EL NOMBRE ANTES DE CREAR
    'hacer if para cuando no este seleccionada ninguna capa
    Private Sub BtnCrearCapa_Click(sender As Object, e As EventArgs) Handles BtnCrearCapa.Click
        itemactivo = cbCapas.SelectedItem
        Dim layer As Layer = Map1.FindLayer(itemactivo)
        Dim records As Recordset = Map1(itemactivo).SearchExpression(tbSelect.Text)
        If Not records.EOF Then
            Dim str As String = ""
            str = Interaction.InputBox("Nombre de la Capa", " Ingrese el Nombre", " aqui ", 350, 350)
            records.Export("D:\DATOS_SIG\" + str + ".shp""")
            Tarea.frmTablas.Refresh()
            Dim str1 As String = "D:\DATOS_SIG\" + str + ".shp"
            Map1.AddLayer(str1)
            Map1.Refresh()
            cbCapas.SelectedIndex = -1
            cbCapas.Items.Add(str, True)
        Else
            MsgBox("mal")
        End If
    End Sub



    'Eliminar una capa seleccionada
    Private Sub EliminarCapaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarCapaToolStripMenuItem.Click
        Dim lay As Layer
        If cbCapas.SelectedIndex > -1 Then
            lay = Map1(Convert.ToString(cbCapas.SelectedItem))
            Map1.RemoveLayer(lay)
            Map1.Refresh()
            If Convert.ToString(cbCapas.SelectedItem) = "BOLIVIA" Then
                estadoBol = False
            ElseIf Convert.ToString(cbCapas.SelectedItem) = "AREAS PROTEGIDAS" Then
                estadoArProt = False
            ElseIf Convert.ToString(cbCapas.SelectedItem) = "CENTROS_POBLADOS_VIVIENDA" Then
                estadoCentPob = False
            End If
            cbCapas.Items.Remove(cbCapas.SelectedItem)
        Else
            MsgBox("Debe Selecccionar Una Capa")
        End If
    End Sub

    'Abrir el frm de consultas espaciales
    Private Sub ConsultasEspacialesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmConsEspaciales
        frm.ShowDialog()
    End Sub

    Function CortarExtension(ByVal Nombre As String) As String
        Dim c As Integer = 0
        Dim nom As String = ""
        While c < Nombre.Length - 4
            nom = nom + Nombre(c)
            c = c + 1
        End While
        Return nom
    End Function

    Private Sub AbrirCapaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCapaToolStripMenuItem.Click
        Dim Open = New OpenFileDialog()
        Dim myStreamReader = Nothing
        Open.Filter = "Text [*.shp*]|*.shp|All Files [*,*]|*,*"
        Open.CheckFileExists = True
        Open.Title = "Abrir sheapfile"
        Open.ShowDialog()
        MsgBox(CortarExtension(Open.SafeFileName))

        Try  'tratar de realizar
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            MsgBox(Open.FileName)
        Catch exc As Exception
            'en caso de errores o persibir
        End Try

        Dim lay As New Layer
        lay = Map1.AddLayer(Open.FileName)
        cbCapas.SelectedIndex = -1
        cbCapas.Items.Add(CortarExtension(Open.SafeFileName), True)
        estadoBol = True
        Map1.Refresh()

    End Sub

    Private Sub NombrarCapaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombrarCapaToolStripMenuItem.Click
        Dim str As String = ""
        str = Interaction.InputBox("Dimension del Vector", " Ingrese la dimension del vector ", " aqui ", 350, 350)
    End Sub
End Class
