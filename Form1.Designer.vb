<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtSigeSa = New System.Windows.Forms.TextBox()
        Me.txtSgs = New System.Windows.Forms.Label()
        Me.txtArs = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAfp = New System.Windows.Forms.TextBox()
        Me.txtSueldoN = New System.Windows.Forms.TextBox()
        Me.txtPrecioHE = New System.Windows.Forms.TextBox()
        Me.txtPrecioHn = New System.Windows.Forms.TextBox()
        Me.txtIsr = New System.Windows.Forms.TextBox()
        Me.txtHorasE = New System.Windows.Forms.TextBox()
        Me.txtHorasN = New System.Windows.Forms.TextBox()
        Me.txtHorasT = New System.Windows.Forms.TextBox()
        Me.txtSueldoBase = New System.Windows.Forms.TextBox()
        Me.txtSueldoISR = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvNomina = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbTotalArs = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbTotalISR = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbTotalEmp = New System.Windows.Forms.Label()
        Me.lbAfp = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbTotalGenNomina = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtSigeSa)
        Me.GroupBox1.Controls.Add(Me.txtSgs)
        Me.GroupBox1.Controls.Add(Me.txtArs)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtAfp)
        Me.GroupBox1.Controls.Add(Me.txtSueldoN)
        Me.GroupBox1.Controls.Add(Me.txtPrecioHE)
        Me.GroupBox1.Controls.Add(Me.txtPrecioHn)
        Me.GroupBox1.Controls.Add(Me.txtIsr)
        Me.GroupBox1.Controls.Add(Me.txtHorasE)
        Me.GroupBox1.Controls.Add(Me.txtHorasN)
        Me.GroupBox1.Controls.Add(Me.txtHorasT)
        Me.GroupBox1.Controls.Add(Me.txtSueldoBase)
        Me.GroupBox1.Controls.Add(Me.txtSueldoISR)
        Me.GroupBox1.Controls.Add(Me.txtEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nomina Del empleado"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrativo", "Gerencia", "Informatica"})
        Me.ComboBox1.Location = New System.Drawing.Point(82, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(541, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtSigeSa
        '
        Me.txtSigeSa.Enabled = False
        Me.txtSigeSa.Location = New System.Drawing.Point(564, 143)
        Me.txtSigeSa.Name = "txtSigeSa"
        Me.txtSigeSa.ReadOnly = True
        Me.txtSigeSa.Size = New System.Drawing.Size(85, 20)
        Me.txtSigeSa.TabIndex = 27
        '
        'txtSgs
        '
        Me.txtSgs.AutoSize = True
        Me.txtSgs.Location = New System.Drawing.Point(502, 146)
        Me.txtSgs.Name = "txtSgs"
        Me.txtSgs.Size = New System.Drawing.Size(56, 13)
        Me.txtSgs.TabIndex = 26
        Me.txtSgs.Text = "Total SGS"
        '
        'txtArs
        '
        Me.txtArs.Location = New System.Drawing.Point(440, 109)
        Me.txtArs.Name = "txtArs"
        Me.txtArs.ReadOnly = True
        Me.txtArs.Size = New System.Drawing.Size(77, 20)
        Me.txtArs.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(410, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "ARS"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(541, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAfp
        '
        Me.txtAfp.Location = New System.Drawing.Point(447, 84)
        Me.txtAfp.Name = "txtAfp"
        Me.txtAfp.ReadOnly = True
        Me.txtAfp.Size = New System.Drawing.Size(70, 20)
        Me.txtAfp.TabIndex = 23
        '
        'txtSueldoN
        '
        Me.txtSueldoN.Enabled = False
        Me.txtSueldoN.Location = New System.Drawing.Point(396, 142)
        Me.txtSueldoN.Name = "txtSueldoN"
        Me.txtSueldoN.ReadOnly = True
        Me.txtSueldoN.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldoN.TabIndex = 22
        '
        'txtPrecioHE
        '
        Me.txtPrecioHE.Enabled = False
        Me.txtPrecioHE.Location = New System.Drawing.Point(447, 58)
        Me.txtPrecioHE.Name = "txtPrecioHE"
        Me.txtPrecioHE.ReadOnly = True
        Me.txtPrecioHE.Size = New System.Drawing.Size(70, 20)
        Me.txtPrecioHE.TabIndex = 21
        '
        'txtPrecioHn
        '
        Me.txtPrecioHn.Location = New System.Drawing.Point(449, 32)
        Me.txtPrecioHn.Name = "txtPrecioHn"
        Me.txtPrecioHn.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioHn.TabIndex = 20
        '
        'txtIsr
        '
        Me.txtIsr.Location = New System.Drawing.Point(258, 143)
        Me.txtIsr.Name = "txtIsr"
        Me.txtIsr.ReadOnly = True
        Me.txtIsr.Size = New System.Drawing.Size(68, 20)
        Me.txtIsr.TabIndex = 19
        '
        'txtHorasE
        '
        Me.txtHorasE.Location = New System.Drawing.Point(308, 87)
        Me.txtHorasE.Name = "txtHorasE"
        Me.txtHorasE.ReadOnly = True
        Me.txtHorasE.Size = New System.Drawing.Size(68, 20)
        Me.txtHorasE.TabIndex = 18
        '
        'txtHorasN
        '
        Me.txtHorasN.Enabled = False
        Me.txtHorasN.Location = New System.Drawing.Point(308, 58)
        Me.txtHorasN.Name = "txtHorasN"
        Me.txtHorasN.ReadOnly = True
        Me.txtHorasN.Size = New System.Drawing.Size(68, 20)
        Me.txtHorasN.TabIndex = 17
        '
        'txtHorasT
        '
        Me.txtHorasT.Location = New System.Drawing.Point(309, 31)
        Me.txtHorasT.Name = "txtHorasT"
        Me.txtHorasT.Size = New System.Drawing.Size(67, 20)
        Me.txtHorasT.TabIndex = 16
        Me.txtHorasT.Text = " "
        '
        'txtSueldoBase
        '
        Me.txtSueldoBase.Location = New System.Drawing.Point(82, 99)
        Me.txtSueldoBase.Name = "txtSueldoBase"
        Me.txtSueldoBase.ReadOnly = True
        Me.txtSueldoBase.Size = New System.Drawing.Size(129, 20)
        Me.txtSueldoBase.TabIndex = 14
        '
        'txtSueldoISR
        '
        Me.txtSueldoISR.Location = New System.Drawing.Point(116, 143)
        Me.txtSueldoISR.Name = "txtSueldoISR"
        Me.txtSueldoISR.ReadOnly = True
        Me.txtSueldoISR.Size = New System.Drawing.Size(95, 20)
        Me.txtSueldoISR.TabIndex = 13
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(70, 35)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(141, 20)
        Me.txtEmpleado.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(331, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Sueldo Neto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(414, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "AFP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(391, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Precio HE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(393, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Precio HN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(227, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ISR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hora Extra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Horas Normales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Horas Trabajadas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sueldo Antes ISR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sueldo base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Departamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado"
        '
        'dgvNomina
        '
        Me.dgvNomina.AllowUserToAddRows = False
        Me.dgvNomina.AllowUserToDeleteRows = False
        Me.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNomina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column5, Me.Column12, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgvNomina.Location = New System.Drawing.Point(2, 196)
        Me.dgvNomina.Name = "dgvNomina"
        Me.dgvNomina.ReadOnly = True
        Me.dgvNomina.Size = New System.Drawing.Size(650, 137)
        Me.dgvNomina.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Empleado"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "H.Trab"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Normales"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Extras"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "S.Base"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "AFP"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "ARS"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "D.SGS"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "S.A.ISR"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "IS"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "S.Neto"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'lbTotalArs
        '
        Me.lbTotalArs.AutoSize = True
        Me.lbTotalArs.Location = New System.Drawing.Point(332, 336)
        Me.lbTotalArs.Name = "lbTotalArs"
        Me.lbTotalArs.Size = New System.Drawing.Size(49, 13)
        Me.lbTotalArs.TabIndex = 5
        Me.lbTotalArs.Text = "_______"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(273, 336)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Total ARS"
        '
        'lbTotalISR
        '
        Me.lbTotalISR.AutoSize = True
        Me.lbTotalISR.Location = New System.Drawing.Point(453, 336)
        Me.lbTotalISR.Name = "lbTotalISR"
        Me.lbTotalISR.Size = New System.Drawing.Size(43, 13)
        Me.lbTotalISR.TabIndex = 7
        Me.lbTotalISR.Text = "______"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(395, 336)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Total ISR"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(128, 346)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Total Empleados"
        '
        'lbTotalEmp
        '
        Me.lbTotalEmp.AutoSize = True
        Me.lbTotalEmp.Location = New System.Drawing.Point(220, 346)
        Me.lbTotalEmp.Name = "lbTotalEmp"
        Me.lbTotalEmp.Size = New System.Drawing.Size(49, 13)
        Me.lbTotalEmp.TabIndex = 10
        Me.lbTotalEmp.Text = "_______"
        '
        'lbAfp
        '
        Me.lbAfp.AutoSize = True
        Me.lbAfp.Location = New System.Drawing.Point(331, 362)
        Me.lbAfp.Name = "lbAfp"
        Me.lbAfp.Size = New System.Drawing.Size(49, 13)
        Me.lbAfp.TabIndex = 12
        Me.lbAfp.Text = "_______"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(273, 362)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Total AFP"
        '
        'lbTotalGenNomina
        '
        Me.lbTotalGenNomina.AutoSize = True
        Me.lbTotalGenNomina.Location = New System.Drawing.Point(498, 362)
        Me.lbTotalGenNomina.Name = "lbTotalGenNomina"
        Me.lbTotalGenNomina.Size = New System.Drawing.Size(67, 13)
        Me.lbTotalGenNomina.TabIndex = 14
        Me.lbTotalGenNomina.Text = "__________"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(386, 362)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Total General Nomina"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 382)
        Me.Controls.Add(Me.lbTotalGenNomina)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lbAfp)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lbTotalEmp)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lbTotalISR)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbTotalArs)
        Me.Controls.Add(Me.dgvNomina)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Nomina"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvNomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSueldoBase As System.Windows.Forms.TextBox
    Friend WithEvents txtSueldoISR As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAfp As System.Windows.Forms.TextBox
    Friend WithEvents txtSueldoN As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioHE As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioHn As System.Windows.Forms.TextBox
    Friend WithEvents txtIsr As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasE As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasN As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasT As System.Windows.Forms.TextBox
    Friend WithEvents txtArs As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgvNomina As System.Windows.Forms.DataGridView
    Friend WithEvents lbTotalArs As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbTotalISR As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbTotalEmp As System.Windows.Forms.Label
    Friend WithEvents lbAfp As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbTotalGenNomina As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtSigeSa As System.Windows.Forms.TextBox
    Friend WithEvents txtSgs As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
