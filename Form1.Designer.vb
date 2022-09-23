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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Kode = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.gapok = New System.Windows.Forms.TextBox()
        Me.gol = New System.Windows.Forms.TextBox()
        Me.ComboGol = New System.Windows.Forms.ComboBox()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.hitung = New System.Windows.Forms.Button()
        Me.LvKaryawan = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(57, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(182, 29)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Kode Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Gaji"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tunjungan Gol."
        '
        'Kode
        '
        Me.Kode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Kode.Location = New System.Drawing.Point(273, 40)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(187, 26)
        Me.Kode.TabIndex = 0
        '
        'nama
        '
        Me.nama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nama.Location = New System.Drawing.Point(273, 87)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(273, 26)
        Me.nama.TabIndex = 1
        '
        'gapok
        '
        Me.gapok.Location = New System.Drawing.Point(273, 136)
        Me.gapok.Name = "gapok"
        Me.gapok.Size = New System.Drawing.Size(187, 26)
        Me.gapok.TabIndex = 2
        '
        'gol
        '
        Me.gol.Location = New System.Drawing.Point(420, 189)
        Me.gol.Name = "gol"
        Me.gol.ReadOnly = True
        Me.gol.Size = New System.Drawing.Size(112, 26)
        Me.gol.TabIndex = 4
        '
        'ComboGol
        '
        Me.ComboGol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboGol.FormattingEnabled = True
        Me.ComboGol.Items.AddRange(New Object() {"Golongan I", "Golongan II", "Golongan III", "Golongan IV"})
        Me.ComboGol.Location = New System.Drawing.Point(273, 187)
        Me.ComboGol.Name = "ComboGol"
        Me.ComboGol.Size = New System.Drawing.Size(121, 28)
        Me.ComboGol.TabIndex = 3
        '
        'Tambah
        '
        Me.Tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tambah.Location = New System.Drawing.Point(560, 136)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(115, 60)
        Me.Tambah.TabIndex = 5
        Me.Tambah.Text = "Tambah Data"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'hitung
        '
        Me.hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hitung.Location = New System.Drawing.Point(699, 136)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(115, 60)
        Me.hitung.TabIndex = 6
        Me.hitung.Text = "Hitung Gaji"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'LvKaryawan
        '
        Me.LvKaryawan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LvKaryawan.GridLines = True
        Me.LvKaryawan.HideSelection = False
        Me.LvKaryawan.Location = New System.Drawing.Point(62, 239)
        Me.LvKaryawan.Name = "LvKaryawan"
        Me.LvKaryawan.Size = New System.Drawing.Size(752, 199)
        Me.LvKaryawan.TabIndex = 7
        Me.LvKaryawan.UseCompatibleStateImageBehavior = False
        Me.LvKaryawan.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Karyawan"
        Me.ColumnHeader1.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Karyawan"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah Gapok"
        Me.ColumnHeader3.Width = 121
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Gol."
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tunjangan"
        Me.ColumnHeader5.Width = 188
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 450)
        Me.Controls.Add(Me.LvKaryawan)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.Tambah)
        Me.Controls.Add(Me.ComboGol)
        Me.Controls.Add(Me.gol)
        Me.Controls.Add(Me.gapok)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Kode As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents gapok As TextBox
    Friend WithEvents gol As TextBox
    Friend WithEvents ComboGol As ComboBox
    Friend WithEvents Tambah As Button
    Friend WithEvents hitung As Button
    Friend WithEvents LvKaryawan As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
