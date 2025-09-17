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
        gpb1 = New GroupBox()
        btnAlta = New Button()
        rdbFrioCalor = New RadioButton()
        rdbFrioSolo = New RadioButton()
        txtPais = New TextBox()
        lblPais = New Label()
        chkSplit = New CheckBox()
        txtFrigorias = New TextBox()
        lblFrigorias = New Label()
        txtMarca = New TextBox()
        lblMarca = New Label()
        gpb2 = New GroupBox()
        txtGrados = New TextBox()
        lblPower = New Label()
        lblTemperatura = New Label()
        btnMax = New Button()
        btnMin = New Button()
        btnMenos = New Button()
        btnMas = New Button()
        btnPower = New Button()
        picTemperatura = New PictureBox()
        txtModelo = New TextBox()
        lblModelo = New Label()
        gpb1.SuspendLayout()
        gpb2.SuspendLayout()
        CType(picTemperatura, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gpb1
        ' 
        gpb1.BackColor = SystemColors.ActiveCaption
        gpb1.Controls.Add(btnAlta)
        gpb1.Controls.Add(rdbFrioCalor)
        gpb1.Controls.Add(rdbFrioSolo)
        gpb1.Controls.Add(txtPais)
        gpb1.Controls.Add(lblPais)
        gpb1.Controls.Add(chkSplit)
        gpb1.Controls.Add(txtFrigorias)
        gpb1.Controls.Add(lblFrigorias)
        gpb1.Controls.Add(txtMarca)
        gpb1.Controls.Add(lblMarca)
        gpb1.Location = New Point(25, 12)
        gpb1.Name = "gpb1"
        gpb1.Size = New Size(278, 325)
        gpb1.TabIndex = 0
        gpb1.TabStop = False
        gpb1.Text = "Ingreso de Datos"
        ' 
        ' btnAlta
        ' 
        btnAlta.Location = New Point(191, 252)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(61, 35)
        btnAlta.TabIndex = 9
        btnAlta.Text = "Alta"
        btnAlta.UseVisualStyleBackColor = True
        ' 
        ' rdbFrioCalor
        ' 
        rdbFrioCalor.AutoSize = True
        rdbFrioCalor.Location = New Point(27, 255)
        rdbFrioCalor.Name = "rdbFrioCalor"
        rdbFrioCalor.Size = New Size(78, 19)
        rdbFrioCalor.TabIndex = 8
        rdbFrioCalor.TabStop = True
        rdbFrioCalor.Text = "Frio/Calor"
        rdbFrioCalor.UseVisualStyleBackColor = True
        ' 
        ' rdbFrioSolo
        ' 
        rdbFrioSolo.AutoSize = True
        rdbFrioSolo.Location = New Point(27, 230)
        rdbFrioSolo.Name = "rdbFrioSolo"
        rdbFrioSolo.Size = New Size(71, 19)
        rdbFrioSolo.TabIndex = 7
        rdbFrioSolo.TabStop = True
        rdbFrioSolo.Text = "Frio Solo"
        rdbFrioSolo.UseVisualStyleBackColor = True
        ' 
        ' txtPais
        ' 
        txtPais.Location = New Point(105, 173)
        txtPais.Name = "txtPais"
        txtPais.Size = New Size(100, 23)
        txtPais.TabIndex = 6
        ' 
        ' lblPais
        ' 
        lblPais.AutoSize = True
        lblPais.Location = New Point(37, 176)
        lblPais.Name = "lblPais"
        lblPais.Size = New Size(28, 15)
        lblPais.TabIndex = 5
        lblPais.Text = "País"
        ' 
        ' chkSplit
        ' 
        chkSplit.AutoSize = True
        chkSplit.Location = New Point(43, 137)
        chkSplit.Name = "chkSplit"
        chkSplit.Size = New Size(49, 19)
        chkSplit.TabIndex = 4
        chkSplit.Text = "Split"
        chkSplit.UseVisualStyleBackColor = True
        ' 
        ' txtFrigorias
        ' 
        txtFrigorias.Location = New Point(105, 89)
        txtFrigorias.Name = "txtFrigorias"
        txtFrigorias.Size = New Size(100, 23)
        txtFrigorias.TabIndex = 3
        ' 
        ' lblFrigorias
        ' 
        lblFrigorias.AutoSize = True
        lblFrigorias.Location = New Point(37, 92)
        lblFrigorias.Name = "lblFrigorias"
        lblFrigorias.Size = New Size(52, 15)
        lblFrigorias.TabIndex = 2
        lblFrigorias.Text = "Frigorias"
        ' 
        ' txtMarca
        ' 
        txtMarca.Location = New Point(105, 49)
        txtMarca.Name = "txtMarca"
        txtMarca.Size = New Size(100, 23)
        txtMarca.TabIndex = 1
        ' 
        ' lblMarca
        ' 
        lblMarca.AutoSize = True
        lblMarca.Location = New Point(37, 52)
        lblMarca.Name = "lblMarca"
        lblMarca.Size = New Size(40, 15)
        lblMarca.TabIndex = 0
        lblMarca.Text = "Marca"
        ' 
        ' gpb2
        ' 
        gpb2.Controls.Add(txtGrados)
        gpb2.Controls.Add(lblPower)
        gpb2.Controls.Add(lblTemperatura)
        gpb2.Controls.Add(btnMax)
        gpb2.Controls.Add(btnMin)
        gpb2.Controls.Add(btnMenos)
        gpb2.Controls.Add(btnMas)
        gpb2.Controls.Add(btnPower)
        gpb2.Controls.Add(picTemperatura)
        gpb2.Controls.Add(txtModelo)
        gpb2.Controls.Add(lblModelo)
        gpb2.Location = New Point(334, 12)
        gpb2.Name = "gpb2"
        gpb2.Size = New Size(322, 325)
        gpb2.TabIndex = 1
        gpb2.TabStop = False
        gpb2.Text = "Control Equipo"
        ' 
        ' txtGrados
        ' 
        txtGrados.Location = New Point(116, 203)
        txtGrados.Name = "txtGrados"
        txtGrados.Size = New Size(100, 23)
        txtGrados.TabIndex = 20
        ' 
        ' lblPower
        ' 
        lblPower.AutoSize = True
        lblPower.BackColor = Color.DodgerBlue
        lblPower.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPower.Location = New Point(141, 97)
        lblPower.Name = "lblPower"
        lblPower.Size = New Size(44, 25)
        lblPower.TabIndex = 19
        lblPower.Text = "OFF"
        ' 
        ' lblTemperatura
        ' 
        lblTemperatura.AutoSize = True
        lblTemperatura.BackColor = Color.DodgerBlue
        lblTemperatura.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTemperatura.Location = New Point(139, 129)
        lblTemperatura.Name = "lblTemperatura"
        lblTemperatura.Size = New Size(51, 32)
        lblTemperatura.TabIndex = 18
        lblTemperatura.Text = "0°C"
        ' 
        ' btnMax
        ' 
        btnMax.Location = New Point(175, 261)
        btnMax.Name = "btnMax"
        btnMax.Size = New Size(75, 23)
        btnMax.TabIndex = 17
        btnMax.Text = "Max"
        btnMax.UseVisualStyleBackColor = True
        ' 
        ' btnMin
        ' 
        btnMin.Location = New Point(81, 261)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(75, 23)
        btnMin.TabIndex = 16
        btnMin.Text = "Min"
        btnMin.UseVisualStyleBackColor = True
        ' 
        ' btnMenos
        ' 
        btnMenos.Location = New Point(48, 232)
        btnMenos.Name = "btnMenos"
        btnMenos.Size = New Size(75, 23)
        btnMenos.TabIndex = 15
        btnMenos.Text = "-"
        btnMenos.UseVisualStyleBackColor = True
        ' 
        ' btnMas
        ' 
        btnMas.Location = New Point(210, 232)
        btnMas.Name = "btnMas"
        btnMas.Size = New Size(75, 23)
        btnMas.TabIndex = 14
        btnMas.Text = "+"
        btnMas.UseVisualStyleBackColor = True
        ' 
        ' btnPower
        ' 
        btnPower.Location = New Point(129, 232)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(75, 23)
        btnPower.TabIndex = 13
        btnPower.Text = "POWER"
        btnPower.UseVisualStyleBackColor = True
        ' 
        ' picTemperatura
        ' 
        picTemperatura.BackColor = Color.DodgerBlue
        picTemperatura.Location = New Point(115, 97)
        picTemperatura.Name = "picTemperatura"
        picTemperatura.Size = New Size(102, 94)
        picTemperatura.TabIndex = 12
        picTemperatura.TabStop = False
        ' 
        ' txtModelo
        ' 
        txtModelo.BackColor = SystemColors.Info
        txtModelo.Enabled = False
        txtModelo.Location = New Point(117, 32)
        txtModelo.Name = "txtModelo"
        txtModelo.Size = New Size(100, 23)
        txtModelo.TabIndex = 11
        ' 
        ' lblModelo
        ' 
        lblModelo.AutoSize = True
        lblModelo.Location = New Point(49, 35)
        lblModelo.Name = "lblModelo"
        lblModelo.Size = New Size(48, 15)
        lblModelo.TabIndex = 10
        lblModelo.Text = "Modelo"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(gpb2)
        Controls.Add(gpb1)
        Name = "Form1"
        Text = "Form1"
        gpb1.ResumeLayout(False)
        gpb1.PerformLayout()
        gpb2.ResumeLayout(False)
        gpb2.PerformLayout()
        CType(picTemperatura, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gpb1 As GroupBox
    Friend WithEvents gpb2 As GroupBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents rdbFrioCalor As RadioButton
    Friend WithEvents rdbFrioSolo As RadioButton
    Friend WithEvents txtPais As TextBox
    Friend WithEvents lblPais As Label
    Friend WithEvents chkSplit As CheckBox
    Friend WithEvents txtFrigorias As TextBox
    Friend WithEvents lblFrigorias As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents btnMax As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnMas As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents picTemperatura As PictureBox
    Friend WithEvents lblPower As Label
    Friend WithEvents txtGrados As TextBox

End Class
