﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_AsientoContableVentas
    Inherits Modelos.ModeloF00

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_AsientoContableVentas))
        Dim cbSucursal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.SuperTabGeneral = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.grComprobante = New Janus.Windows.GridEX.GridEX()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupPanelBanco = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grVentas = New Janus.Windows.GridEX.GridEX()
        Me.GrDatos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.cbSucursal = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.btnNuevoTipoCambio = New DevComponents.DotNetBar.ButtonX()
        Me.btActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.tbFechaF = New System.Windows.Forms.DateTimePicker()
        Me.tbNumi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbTipoCambio = New DevComponents.Editors.DoubleInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.tbFechaI = New System.Windows.Forms.DateTimePicker()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grmovimientos = New Janus.Windows.GridEX.GridEX()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MSuperTabControlPanel1.SuspendLayout()
        CType(Me.MSuperTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBuscador.SuspendLayout()
        CType(Me.SuperTabGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabGeneral.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.grComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupPanelBanco.SuspendLayout()
        CType(Me.grVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrDatos.SuspendLayout()
        CType(Me.cbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.grmovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        Me.PanelSuperior.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackgroundImage = CType(resources.GetObject("PanelSuperior.StyleMouseOver.BackgroundImage"), System.Drawing.Image)
        '
        'PanelInferior
        '
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.ReadOnly = True
        Me.TxtNombreUsu.Text = "DEFAULT"
        '
        'btnSalir
        '
        '
        'btnGrabar
        '
        '
        'btnEliminar
        '
        '
        'btnModificar
        '
        '
        'btnNuevo
        '
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.Panel1, 0)
        '
        'btnImprimir
        '
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(171, 0)
        '
        'btnSiguiente
        '
        '
        'btnAnterior
        '
        '
        'btnPrimero
        '
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.SuperTabGeneral)
        Me.PanelContent.Controls.Add(Me.Panel2)
        Me.PanelContent.Size = New System.Drawing.Size(1275, 553)
        '
        'MSuperTabControlPanel1
        '
        Me.MSuperTabControlPanel1.Size = New System.Drawing.Size(1275, 553)
        '
        'MSuperTabControl
        '
        '
        '
        '
        '
        '
        '
        Me.MSuperTabControl.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.MSuperTabControl.ControlBox.MenuBox.Name = ""
        Me.MSuperTabControl.ControlBox.Name = ""
        Me.MSuperTabControl.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MSuperTabControl.ControlBox.MenuBox, Me.MSuperTabControl.ControlBox.CloseBox})
        Me.MSuperTabControl.SelectedTabIndex = 1
        Me.MSuperTabControl.Controls.SetChildIndex(Me.MSuperTabControlPanel1, 0)
        '
        'PanelBuscador
        '
        Me.PanelBuscador.Controls.Add(Me.GroupPanel2)
        Me.PanelBuscador.Size = New System.Drawing.Size(1275, 553)
        '
        'SuperTabGeneral
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabGeneral.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabGeneral.ControlBox.MenuBox.Name = ""
        Me.SuperTabGeneral.ControlBox.Name = ""
        Me.SuperTabGeneral.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabGeneral.ControlBox.MenuBox, Me.SuperTabGeneral.ControlBox.CloseBox})
        Me.SuperTabGeneral.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabGeneral.Location = New System.Drawing.Point(0, 281)
        Me.SuperTabGeneral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SuperTabGeneral.Name = "SuperTabGeneral"
        Me.SuperTabGeneral.ReorderTabsEnabled = True
        Me.SuperTabGeneral.SelectedTabFont = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabGeneral.SelectedTabIndex = 0
        Me.SuperTabGeneral.Size = New System.Drawing.Size(1275, 272)
        Me.SuperTabGeneral.TabFont = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabGeneral.TabIndex = 2
        Me.SuperTabGeneral.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem2})
        Me.SuperTabGeneral.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabGeneral.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.grComprobante)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 29)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1275, 243)
        Me.SuperTabControlPanel2.TabIndex = 1
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'grComprobante
        '
        Me.grComprobante.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grComprobante.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grComprobante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grComprobante.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grComprobante.Location = New System.Drawing.Point(0, 0)
        Me.grComprobante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grComprobante.Name = "grComprobante"
        Me.grComprobante.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grComprobante.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grComprobante.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grComprobante.Size = New System.Drawing.Size(1275, 243)
        Me.grComprobante.TabIndex = 0
        Me.grComprobante.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Detalle Asiento General"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupPanelBanco)
        Me.Panel2.Controls.Add(Me.GrDatos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1275, 281)
        Me.Panel2.TabIndex = 244
        '
        'GroupPanelBanco
        '
        Me.GroupPanelBanco.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelBanco.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelBanco.Controls.Add(Me.grVentas)
        Me.GroupPanelBanco.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelBanco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelBanco.Location = New System.Drawing.Point(900, 0)
        Me.GroupPanelBanco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupPanelBanco.Name = "GroupPanelBanco"
        Me.GroupPanelBanco.Size = New System.Drawing.Size(375, 281)
        '
        '
        '
        Me.GroupPanelBanco.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelBanco.Style.BackColorGradientAngle = 90
        Me.GroupPanelBanco.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelBanco.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBanco.Style.BorderBottomWidth = 1
        Me.GroupPanelBanco.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelBanco.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBanco.Style.BorderLeftWidth = 1
        Me.GroupPanelBanco.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBanco.Style.BorderRightWidth = 1
        Me.GroupPanelBanco.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBanco.Style.BorderTopWidth = 1
        Me.GroupPanelBanco.Style.CornerDiameter = 4
        Me.GroupPanelBanco.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBanco.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBanco.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelBanco.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBanco.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBanco.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelBanco.TabIndex = 2
        Me.GroupPanelBanco.Text = "VENTAS"
        '
        'grVentas
        '
        Me.grVentas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grVentas.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grVentas.Location = New System.Drawing.Point(0, 0)
        Me.grVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grVentas.Name = "grVentas"
        Me.grVentas.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grVentas.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grVentas.RowFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grVentas.Size = New System.Drawing.Size(369, 254)
        Me.grVentas.TabIndex = 0
        Me.grVentas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GrDatos
        '
        Me.GrDatos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GrDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GrDatos.Controls.Add(Me.LabelX17)
        Me.GrDatos.Controls.Add(Me.cbSucursal)
        Me.GrDatos.Controls.Add(Me.btnNuevoTipoCambio)
        Me.GrDatos.Controls.Add(Me.btActualizar)
        Me.GrDatos.Controls.Add(Me.LabelX5)
        Me.GrDatos.Controls.Add(Me.tbFechaF)
        Me.GrDatos.Controls.Add(Me.tbNumi)
        Me.GrDatos.Controls.Add(Me.tbTipoCambio)
        Me.GrDatos.Controls.Add(Me.LabelX4)
        Me.GrDatos.Controls.Add(Me.LabelX1)
        Me.GrDatos.Controls.Add(Me.LabelX3)
        Me.GrDatos.Controls.Add(Me.tbFechaI)
        Me.GrDatos.DisabledBackColor = System.Drawing.Color.Empty
        Me.GrDatos.Dock = System.Windows.Forms.DockStyle.Left
        Me.GrDatos.Location = New System.Drawing.Point(0, 0)
        Me.GrDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrDatos.Name = "GrDatos"
        Me.GrDatos.Size = New System.Drawing.Size(900, 281)
        '
        '
        '
        Me.GrDatos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GrDatos.Style.BackColorGradientAngle = 90
        Me.GrDatos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GrDatos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrDatos.Style.BorderBottomWidth = 1
        Me.GrDatos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GrDatos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrDatos.Style.BorderLeftWidth = 1
        Me.GrDatos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrDatos.Style.BorderRightWidth = 1
        Me.GrDatos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrDatos.Style.BorderTopWidth = 1
        Me.GrDatos.Style.CornerDiameter = 4
        Me.GrDatos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GrDatos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GrDatos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GrDatos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GrDatos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GrDatos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GrDatos.TabIndex = 0
        Me.GrDatos.Text = "DATOS"
        '
        'LabelX17
        '
        Me.LabelX17.AutoSize = True
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX17.Location = New System.Drawing.Point(357, 7)
        Me.LabelX17.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX17.Size = New System.Drawing.Size(68, 20)
        Me.LabelX17.TabIndex = 242
        Me.LabelX17.Text = "Modulo:"
        '
        'cbSucursal
        '
        cbSucursal_DesignTimeLayout.LayoutString = resources.GetString("cbSucursal_DesignTimeLayout.LayoutString")
        Me.cbSucursal.DesignTimeLayout = cbSucursal_DesignTimeLayout
        Me.cbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Location = New System.Drawing.Point(453, 4)
        Me.cbSucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbSucursal.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbSucursal.SelectedIndex = -1
        Me.cbSucursal.SelectedItem = Nothing
        Me.cbSucursal.Size = New System.Drawing.Size(300, 26)
        Me.cbSucursal.TabIndex = 241
        Me.cbSucursal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btnNuevoTipoCambio
        '
        Me.btnNuevoTipoCambio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoTipoCambio.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoTipoCambio.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnNuevoTipoCambio.Image = Global.Presentacion.My.Resources.Resources.anadir
        Me.btnNuevoTipoCambio.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnNuevoTipoCambio.Location = New System.Drawing.Point(205, 33)
        Me.btnNuevoTipoCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoTipoCambio.Name = "btnNuevoTipoCambio"
        Me.btnNuevoTipoCambio.Size = New System.Drawing.Size(45, 36)
        Me.btnNuevoTipoCambio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevoTipoCambio.TabIndex = 240
        Me.btnNuevoTipoCambio.Visible = False
        '
        'btActualizar
        '
        Me.btActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizar.BackColor = System.Drawing.Color.SkyBlue
        Me.btActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btActualizar.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActualizar.Image = Global.Presentacion.My.Resources.Resources.reload_5
        Me.btActualizar.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.btActualizar.Location = New System.Drawing.Point(133, 117)
        Me.btActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btActualizar.Size = New System.Drawing.Size(141, 60)
        Me.btActualizar.SubItemsExpandWidth = 10
        Me.btActualizar.TabIndex = 239
        Me.btActualizar.Text = "CARGAR DATOS"
        Me.btActualizar.TextColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(271, 74)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(23, 18)
        Me.LabelX5.TabIndex = 130
        Me.LabelX5.Text = "AL:"
        '
        'tbFechaF
        '
        Me.tbFechaF.CalendarMonthBackground = System.Drawing.Color.White
        Me.tbFechaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaF.Location = New System.Drawing.Point(301, 71)
        Me.tbFechaF.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFechaF.Name = "tbFechaF"
        Me.tbFechaF.Size = New System.Drawing.Size(132, 23)
        Me.tbFechaF.TabIndex = 129
        '
        'tbNumi
        '
        '
        '
        '
        Me.tbNumi.Border.Class = "TextBoxBorder"
        Me.tbNumi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNumi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumi.Location = New System.Drawing.Point(133, 4)
        Me.tbNumi.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNumi.Name = "tbNumi"
        Me.tbNumi.PreventEnterBeep = True
        Me.tbNumi.Size = New System.Drawing.Size(96, 23)
        Me.tbNumi.TabIndex = 123
        Me.tbNumi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTipoCambio
        '
        '
        '
        '
        Me.tbTipoCambio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTipoCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTipoCambio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTipoCambio.Increment = 1.0R
        Me.tbTipoCambio.Location = New System.Drawing.Point(133, 39)
        Me.tbTipoCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTipoCambio.Name = "tbTipoCambio"
        Me.tbTipoCambio.Size = New System.Drawing.Size(76, 23)
        Me.tbTipoCambio.TabIndex = 122
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(24, 39)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(96, 18)
        Me.LabelX4.TabIndex = 128
        Me.LabelX4.Text = "TIPO CAMBIO:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(24, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 28)
        Me.LabelX1.TabIndex = 124
        Me.LabelX1.Text = "ID:"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(24, 76)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(53, 18)
        Me.LabelX3.TabIndex = 127
        Me.LabelX3.Text = "FECHA:"
        '
        'tbFechaI
        '
        Me.tbFechaI.CalendarMonthBackground = System.Drawing.Color.White
        Me.tbFechaI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaI.Location = New System.Drawing.Point(133, 71)
        Me.tbFechaI.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFechaI.Name = "tbFechaI"
        Me.tbFechaI.Size = New System.Drawing.Size(132, 23)
        Me.tbFechaI.TabIndex = 121
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.grmovimientos)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1275, 553)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 4
        Me.GroupPanel2.Text = "BUSCADOR"
        '
        'grmovimientos
        '
        Me.grmovimientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grmovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grmovimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grmovimientos.FlatBorderColor = System.Drawing.Color.DodgerBlue
        Me.grmovimientos.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grmovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grmovimientos.GridLineColor = System.Drawing.Color.DodgerBlue
        Me.grmovimientos.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grmovimientos.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.grmovimientos.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grmovimientos.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grmovimientos.Location = New System.Drawing.Point(0, 0)
        Me.grmovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.grmovimientos.Name = "grmovimientos"
        Me.grmovimientos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grmovimientos.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grmovimientos.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grmovimientos.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grmovimientos.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.grmovimientos.Size = New System.Drawing.Size(1269, 526)
        Me.grmovimientos.TabIndex = 0
        Me.grmovimientos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'F1_AsientoContableVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 690)
        Me.Name = "F1_AsientoContableVentas"
        Me.Text = "F1_AsientoContableVentas"
        Me.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MSuperTabControlPanel1.ResumeLayout(False)
        CType(Me.MSuperTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControl.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBuscador.ResumeLayout(False)
        CType(Me.SuperTabGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabGeneral.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.grComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupPanelBanco.ResumeLayout(False)
        CType(Me.grVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrDatos.ResumeLayout(False)
        Me.GrDatos.PerformLayout()
        CType(Me.cbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.grmovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SuperTabGeneral As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents grComprobante As Janus.Windows.GridEX.GridEX
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupPanelBanco As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents grVentas As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrDatos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbSucursal As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents btnNuevoTipoCambio As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFechaF As DateTimePicker
    Friend WithEvents tbNumi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbTipoCambio As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFechaI As DateTimePicker
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents grmovimientos As Janus.Windows.GridEX.GridEX
End Class
