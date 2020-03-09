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
        Me.DataGridViewItem = New System.Windows.Forms.DataGridView()
        Me.ColumnItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonApples = New System.Windows.Forms.Button()
        Me.ButtonBiscuits = New System.Windows.Forms.Button()
        Me.ButtonBakedBeans = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewItem
        '
        Me.DataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnItemCode, Me.ColumnItem, Me.ColumnQuantity})
        Me.DataGridViewItem.Location = New System.Drawing.Point(12, 108)
        Me.DataGridViewItem.Name = "DataGridViewItem"
        Me.DataGridViewItem.Size = New System.Drawing.Size(746, 150)
        Me.DataGridViewItem.TabIndex = 0
        '
        'ColumnItemCode
        '
        Me.ColumnItemCode.DataPropertyName = "ItemCode"
        Me.ColumnItemCode.HeaderText = "Item Code"
        Me.ColumnItemCode.Name = "ColumnItemCode"
        '
        'ColumnItem
        '
        Me.ColumnItem.DataPropertyName = "Item"
        Me.ColumnItem.HeaderText = "Item"
        Me.ColumnItem.Name = "ColumnItem"
        '
        'ColumnQuantity
        '
        Me.ColumnQuantity.DataPropertyName = "Price"
        Me.ColumnQuantity.HeaderText = "Unit Price"
        Me.ColumnQuantity.Name = "ColumnQuantity"
        '
        'ButtonApples
        '
        Me.ButtonApples.Location = New System.Drawing.Point(13, 412)
        Me.ButtonApples.Name = "ButtonApples"
        Me.ButtonApples.Size = New System.Drawing.Size(75, 23)
        Me.ButtonApples.TabIndex = 2
        Me.ButtonApples.Text = "Scan Apples"
        Me.ButtonApples.UseVisualStyleBackColor = True
        '
        'ButtonBiscuits
        '
        Me.ButtonBiscuits.Location = New System.Drawing.Point(130, 412)
        Me.ButtonBiscuits.Name = "ButtonBiscuits"
        Me.ButtonBiscuits.Size = New System.Drawing.Size(96, 23)
        Me.ButtonBiscuits.TabIndex = 3
        Me.ButtonBiscuits.Text = "Scan Biscuits"
        Me.ButtonBiscuits.UseVisualStyleBackColor = True
        '
        'ButtonBakedBeans
        '
        Me.ButtonBakedBeans.Location = New System.Drawing.Point(260, 412)
        Me.ButtonBakedBeans.Name = "ButtonBakedBeans"
        Me.ButtonBakedBeans.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBakedBeans.TabIndex = 4
        Me.ButtonBakedBeans.Text = "Scan Beans"
        Me.ButtonBakedBeans.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(12, 275)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonBakedBeans)
        Me.Controls.Add(Me.ButtonBiscuits)
        Me.Controls.Add(Me.ButtonApples)
        Me.Controls.Add(Me.DataGridViewItem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewItem As DataGridView
    Friend WithEvents ColumnItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ColumnItem As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQuantity As DataGridViewTextBoxColumn
    Friend WithEvents ButtonApples As Button
    Friend WithEvents ButtonBiscuits As Button
    Friend WithEvents ButtonBakedBeans As Button
    Friend WithEvents ButtonClear As Button
End Class
