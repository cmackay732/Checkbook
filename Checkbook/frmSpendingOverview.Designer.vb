﻿'    Checkbook is a transaction register for Windows Desktop. It keeps track of how you are spending and making money.
'    Copyright(C) 2017 Christopher Mackay

'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.

'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE. See the
'    GNU General Public License For more details.

'    You should have received a copy Of the GNU General Public License
'    along with this program. If Not, see <http: //www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSpendingOverview
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpendingOverview))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cxmnuWhatIf = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cxmnuCreateExpense = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuEditExpense = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuRemoveExpenses = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuRemoveCategories = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuCopyToNextMonth = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuCopyToRestOfYear = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuCopyToSelectedMonths = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cxmnuResetYearTotals = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuCreateEmptyScenario = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.lblYearStatus = New System.Windows.Forms.Label()
        Me.lblOverallBalance = New System.Windows.Forms.Label()
        Me.lblTotalPayments = New System.Windows.Forms.Label()
        Me.txtTotalPayments = New System.Windows.Forms.TextBox()
        Me.txtOverallBalance = New System.Windows.Forms.TextBox()
        Me.txtYearStatus = New System.Windows.Forms.TextBox()
        Me.lblTotalDeposits = New System.Windows.Forms.Label()
        Me.txtTotalDeposits = New System.Windows.Forms.TextBox()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.January = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.February = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.March = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.April = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.May = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.June = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.July = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.August = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.September = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.October = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.November = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.December = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Totals = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbModelOptions = New System.Windows.Forms.GroupBox()
        Me.rbCurrentYear = New System.Windows.Forms.RadioButton()
        Me.rbNextYear = New System.Windows.Forms.RadioButton()
        Me.cbCategoriesPayees = New System.Windows.Forms.ComboBox()
        Me.lblFilterCategoriesPayees = New System.Windows.Forms.Label()
        Me.dgvMonthly = New System.Windows.Forms.DataGridView()
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deposits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monthly = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AveMonthlyIncome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cxmnuMonthlyIncomeTable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cxmnuEditValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuRemoveValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFilterPaymentsDeposits = New System.Windows.Forms.Label()
        Me.cbPaymentsDeposits = New System.Windows.Forms.ComboBox()
        Me.lblLedgerStatus = New System.Windows.Forms.Label()
        Me.txtLedgerStatus = New System.Windows.Forms.TextBox()
        Me.gbCurrentYear = New System.Windows.Forms.GroupBox()
        Me.gbOverallDetails = New System.Windows.Forms.GroupBox()
        Me.gbFilterOptions = New System.Windows.Forms.GroupBox()
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreateExpense = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditExpense = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveExpenses = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyToNextMonth = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyToSelectedMonths = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyToRestOfYear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCreateEmptyWhatif = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCharts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetYearTotals = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportCategoryPayeeTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckbookHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSumSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cxmnuSumSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmnuWhatIf.SuspendLayout
        CType(Me.dgvCategory,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbModelOptions.SuspendLayout
        CType(Me.dgvMonthly,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cxmnuMonthlyIncomeTable.SuspendLayout
        Me.gbCurrentYear.SuspendLayout
        Me.gbOverallDetails.SuspendLayout
        Me.gbFilterOptions.SuspendLayout
        Me.mnuMenuStrip.SuspendLayout
        Me.SuspendLayout
        '
        'cxmnuWhatIf
        '
        Me.cxmnuWhatIf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cxmnuWhatIf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cxmnuCreateExpense, Me.cxmnuEditExpense, Me.cxmnuRemoveExpenses, Me.cxmnuRemoveCategories, Me.cxmnuCopyToNextMonth, Me.cxmnuCopyToRestOfYear, Me.cxmnuCopyToSelectedMonths, Me.ToolStripSeparator1, Me.cxmnuResetYearTotals, Me.cxmnuCreateEmptyScenario, Me.ToolStripSeparator4, Me.cxmnuSumSelected})
        Me.cxmnuWhatIf.Name = "cxmnuWhatIf"
        Me.cxmnuWhatIf.Size = New System.Drawing.Size(198, 236)
        '
        'cxmnuCreateExpense
        '
        Me.cxmnuCreateExpense.Image = CType(resources.GetObject("cxmnuCreateExpense.Image"),System.Drawing.Image)
        Me.cxmnuCreateExpense.Name = "cxmnuCreateExpense"
        Me.cxmnuCreateExpense.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuCreateExpense.Text = "Create Monthly Expense"
        '
        'cxmnuEditExpense
        '
        Me.cxmnuEditExpense.Image = CType(resources.GetObject("cxmnuEditExpense.Image"),System.Drawing.Image)
        Me.cxmnuEditExpense.Name = "cxmnuEditExpense"
        Me.cxmnuEditExpense.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuEditExpense.Text = "Edit Expenses"
        '
        'cxmnuRemoveExpenses
        '
        Me.cxmnuRemoveExpenses.Image = CType(resources.GetObject("cxmnuRemoveExpenses.Image"),System.Drawing.Image)
        Me.cxmnuRemoveExpenses.Name = "cxmnuRemoveExpenses"
        Me.cxmnuRemoveExpenses.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuRemoveExpenses.Text = "Remove Expenses"
        '
        'cxmnuRemoveCategories
        '
        Me.cxmnuRemoveCategories.Image = CType(resources.GetObject("cxmnuRemoveCategories.Image"),System.Drawing.Image)
        Me.cxmnuRemoveCategories.Name = "cxmnuRemoveCategories"
        Me.cxmnuRemoveCategories.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuRemoveCategories.Text = "Remove Categories"
        '
        'cxmnuCopyToNextMonth
        '
        Me.cxmnuCopyToNextMonth.Image = CType(resources.GetObject("cxmnuCopyToNextMonth.Image"),System.Drawing.Image)
        Me.cxmnuCopyToNextMonth.Name = "cxmnuCopyToNextMonth"
        Me.cxmnuCopyToNextMonth.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuCopyToNextMonth.Text = "Copy to Next Month"
        '
        'cxmnuCopyToRestOfYear
        '
        Me.cxmnuCopyToRestOfYear.Image = CType(resources.GetObject("cxmnuCopyToRestOfYear.Image"),System.Drawing.Image)
        Me.cxmnuCopyToRestOfYear.Name = "cxmnuCopyToRestOfYear"
        Me.cxmnuCopyToRestOfYear.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuCopyToRestOfYear.Text = "Copy to Rest of Year"
        '
        'cxmnuCopyToSelectedMonths
        '
        Me.cxmnuCopyToSelectedMonths.Image = CType(resources.GetObject("cxmnuCopyToSelectedMonths.Image"),System.Drawing.Image)
        Me.cxmnuCopyToSelectedMonths.Name = "cxmnuCopyToSelectedMonths"
        Me.cxmnuCopyToSelectedMonths.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuCopyToSelectedMonths.Text = "Copy To Selected Months"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'cxmnuResetYearTotals
        '
        Me.cxmnuResetYearTotals.Image = CType(resources.GetObject("cxmnuResetYearTotals.Image"),System.Drawing.Image)
        Me.cxmnuResetYearTotals.Name = "cxmnuResetYearTotals"
        Me.cxmnuResetYearTotals.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuResetYearTotals.Text = "Reset All Expenses"
        '
        'cxmnuCreateEmptyScenario
        '
        Me.cxmnuCreateEmptyScenario.Image = CType(resources.GetObject("cxmnuCreateEmptyScenario.Image"),System.Drawing.Image)
        Me.cxmnuCreateEmptyScenario.Name = "cxmnuCreateEmptyScenario"
        Me.cxmnuCreateEmptyScenario.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuCreateEmptyScenario.Text = "Create Empty Scenario"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(1140, 766)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = true
        '
        'lblYear
        '
        Me.lblYear.AutoSize = true
        Me.lblYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.lblYear.Location = New System.Drawing.Point(39, 33)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 1
        Me.lblYear.Text = "Year"
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FormattingEnabled = true
        Me.cbYear.Location = New System.Drawing.Point(39, 49)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(121, 21)
        Me.cbYear.TabIndex = 2
        '
        'lblYearStatus
        '
        Me.lblYearStatus.AutoSize = true
        Me.lblYearStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.lblYearStatus.Location = New System.Drawing.Point(277, 21)
        Me.lblYearStatus.Name = "lblYearStatus"
        Me.lblYearStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblYearStatus.TabIndex = 4
        Me.lblYearStatus.Text = "Status"
        '
        'lblOverallBalance
        '
        Me.lblOverallBalance.AutoSize = true
        Me.lblOverallBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.lblOverallBalance.Location = New System.Drawing.Point(28, 21)
        Me.lblOverallBalance.Name = "lblOverallBalance"
        Me.lblOverallBalance.Size = New System.Drawing.Size(82, 13)
        Me.lblOverallBalance.TabIndex = 0
        Me.lblOverallBalance.Text = "Overall Balance"
        '
        'lblTotalPayments
        '
        Me.lblTotalPayments.AutoSize = true
        Me.lblTotalPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.lblTotalPayments.Location = New System.Drawing.Point(65, 21)
        Me.lblTotalPayments.Name = "lblTotalPayments"
        Me.lblTotalPayments.Size = New System.Drawing.Size(80, 13)
        Me.lblTotalPayments.TabIndex = 0
        Me.lblTotalPayments.Text = "Total Payments"
        '
        'txtTotalPayments
        '
        Me.txtTotalPayments.Enabled = false
        Me.txtTotalPayments.Location = New System.Drawing.Point(65, 37)
        Me.txtTotalPayments.Name = "txtTotalPayments"
        Me.txtTotalPayments.ReadOnly = true
        Me.txtTotalPayments.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPayments.TabIndex = 1
        '
        'txtOverallBalance
        '
        Me.txtOverallBalance.Enabled = false
        Me.txtOverallBalance.Location = New System.Drawing.Point(28, 37)
        Me.txtOverallBalance.Name = "txtOverallBalance"
        Me.txtOverallBalance.ReadOnly = true
        Me.txtOverallBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtOverallBalance.TabIndex = 1
        '
        'txtYearStatus
        '
        Me.txtYearStatus.Enabled = false
        Me.txtYearStatus.Location = New System.Drawing.Point(277, 37)
        Me.txtYearStatus.Name = "txtYearStatus"
        Me.txtYearStatus.ReadOnly = true
        Me.txtYearStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtYearStatus.TabIndex = 5
        '
        'lblTotalDeposits
        '
        Me.lblTotalDeposits.AutoSize = true
        Me.lblTotalDeposits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.lblTotalDeposits.Location = New System.Drawing.Point(171, 21)
        Me.lblTotalDeposits.Name = "lblTotalDeposits"
        Me.lblTotalDeposits.Size = New System.Drawing.Size(75, 13)
        Me.lblTotalDeposits.TabIndex = 2
        Me.lblTotalDeposits.Text = "Total Deposits"
        '
        'txtTotalDeposits
        '
        Me.txtTotalDeposits.Enabled = false
        Me.txtTotalDeposits.Location = New System.Drawing.Point(171, 37)
        Me.txtTotalDeposits.Name = "txtTotalDeposits"
        Me.txtTotalDeposits.ReadOnly = true
        Me.txtTotalDeposits.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalDeposits.TabIndex = 3
        '
        'dgvCategory
        '
        Me.dgvCategory.AllowUserToAddRows = false
        Me.dgvCategory.AllowUserToDeleteRows = false
        Me.dgvCategory.AllowUserToResizeColumns = false
        Me.dgvCategory.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCategory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.January, Me.February, Me.March, Me.April, Me.May, Me.June, Me.July, Me.August, Me.September, Me.October, Me.November, Me.December, Me.Totals, Me.Percent})
        Me.dgvCategory.ContextMenuStrip = Me.cxmnuWhatIf
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategory.GridColor = System.Drawing.Color.LightGray
        Me.dgvCategory.Location = New System.Drawing.Point(12, 27)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = true
        Me.dgvCategory.RowHeadersVisible = false
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCategory.Size = New System.Drawing.Size(1203, 471)
        Me.dgvCategory.TabIndex = 3
        '
        'Item
        '
        Me.Item.HeaderText = "Category"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = true
        Me.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'January
        '
        Me.January.HeaderText = "January"
        Me.January.Name = "January"
        Me.January.ReadOnly = true
        Me.January.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'February
        '
        Me.February.HeaderText = "February"
        Me.February.Name = "February"
        Me.February.ReadOnly = true
        Me.February.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'March
        '
        Me.March.HeaderText = "March"
        Me.March.Name = "March"
        Me.March.ReadOnly = true
        Me.March.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'April
        '
        Me.April.HeaderText = "April"
        Me.April.Name = "April"
        Me.April.ReadOnly = true
        Me.April.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'May
        '
        Me.May.HeaderText = "May"
        Me.May.Name = "May"
        Me.May.ReadOnly = true
        Me.May.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'June
        '
        Me.June.HeaderText = "June"
        Me.June.Name = "June"
        Me.June.ReadOnly = true
        Me.June.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'July
        '
        Me.July.HeaderText = "July"
        Me.July.Name = "July"
        Me.July.ReadOnly = true
        Me.July.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'August
        '
        Me.August.HeaderText = "August"
        Me.August.Name = "August"
        Me.August.ReadOnly = true
        Me.August.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'September
        '
        Me.September.HeaderText = "September"
        Me.September.Name = "September"
        Me.September.ReadOnly = true
        Me.September.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'October
        '
        Me.October.HeaderText = "October"
        Me.October.Name = "October"
        Me.October.ReadOnly = true
        Me.October.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'November
        '
        Me.November.HeaderText = "November"
        Me.November.Name = "November"
        Me.November.ReadOnly = true
        Me.November.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'December
        '
        Me.December.HeaderText = "December"
        Me.December.Name = "December"
        Me.December.ReadOnly = true
        Me.December.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Totals
        '
        Me.Totals.HeaderText = "Totals"
        Me.Totals.Name = "Totals"
        Me.Totals.ReadOnly = true
        Me.Totals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Percent
        '
        Me.Percent.HeaderText = "Percent"
        Me.Percent.Name = "Percent"
        Me.Percent.ReadOnly = true
        Me.Percent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'gbModelOptions
        '
        Me.gbModelOptions.Controls.Add(Me.rbCurrentYear)
        Me.gbModelOptions.Controls.Add(Me.rbNextYear)
        Me.gbModelOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.gbModelOptions.Location = New System.Drawing.Point(1084, 589)
        Me.gbModelOptions.Name = "gbModelOptions"
        Me.gbModelOptions.Size = New System.Drawing.Size(131, 103)
        Me.gbModelOptions.TabIndex = 6
        Me.gbModelOptions.TabStop = false
        Me.gbModelOptions.Text = "Modeling Options"
        '
        'rbCurrentYear
        '
        Me.rbCurrentYear.AutoSize = true
        Me.rbCurrentYear.Checked = true
        Me.rbCurrentYear.Location = New System.Drawing.Point(23, 36)
        Me.rbCurrentYear.Name = "rbCurrentYear"
        Me.rbCurrentYear.Size = New System.Drawing.Size(84, 17)
        Me.rbCurrentYear.TabIndex = 0
        Me.rbCurrentYear.TabStop = true
        Me.rbCurrentYear.Text = "Current Year"
        Me.rbCurrentYear.UseVisualStyleBackColor = true
        '
        'rbNextYear
        '
        Me.rbNextYear.AutoSize = true
        Me.rbNextYear.Location = New System.Drawing.Point(23, 59)
        Me.rbNextYear.Name = "rbNextYear"
        Me.rbNextYear.Size = New System.Drawing.Size(72, 17)
        Me.rbNextYear.TabIndex = 1
        Me.rbNextYear.TabStop = true
        Me.rbNextYear.Text = "Next Year"
        Me.rbNextYear.UseVisualStyleBackColor = true
        '
        'cbCategoriesPayees
        '
        Me.cbCategoriesPayees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoriesPayees.FormattingEnabled = true
        Me.cbCategoriesPayees.Items.AddRange(New Object() {"Categories", "Payees"})
        Me.cbCategoriesPayees.Location = New System.Drawing.Point(166, 49)
        Me.cbCategoriesPayees.Name = "cbCategoriesPayees"
        Me.cbCategoriesPayees.Size = New System.Drawing.Size(182, 21)
        Me.cbCategoriesPayees.TabIndex = 4
        '
        'lblFilterCategoriesPayees
        '
        Me.lblFilterCategoriesPayees.AutoSize = true
        Me.lblFilterCategoriesPayees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.lblFilterCategoriesPayees.Location = New System.Drawing.Point(166, 33)
        Me.lblFilterCategoriesPayees.Name = "lblFilterCategoriesPayees"
        Me.lblFilterCategoriesPayees.Size = New System.Drawing.Size(107, 13)
        Me.lblFilterCategoriesPayees.TabIndex = 3
        Me.lblFilterCategoriesPayees.Text = "Categories or Payees"
        '
        'dgvMonthly
        '
        Me.dgvMonthly.AllowUserToAddRows = false
        Me.dgvMonthly.AllowUserToDeleteRows = false
        Me.dgvMonthly.AllowUserToResizeColumns = false
        Me.dgvMonthly.AllowUserToResizeRows = false
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvMonthly.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMonthly.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvMonthly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMonthly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonthly.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Month, Me.Payments, Me.Deposits, Me.Monthly, Me.AveMonthlyIncome})
        Me.dgvMonthly.ContextMenuStrip = Me.cxmnuMonthlyIncomeTable
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonthly.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMonthly.GridColor = System.Drawing.Color.LightGray
        Me.dgvMonthly.Location = New System.Drawing.Point(12, 504)
        Me.dgvMonthly.Name = "dgvMonthly"
        Me.dgvMonthly.ReadOnly = true
        Me.dgvMonthly.RowHeadersVisible = false
        Me.dgvMonthly.Size = New System.Drawing.Size(485, 285)
        Me.dgvMonthly.TabIndex = 4
        '
        'Month
        '
        Me.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Month.HeaderText = "Month"
        Me.Month.Name = "Month"
        Me.Month.ReadOnly = true
        Me.Month.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Month.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Payments
        '
        Me.Payments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Payments.HeaderText = "Payments"
        Me.Payments.Name = "Payments"
        Me.Payments.ReadOnly = true
        Me.Payments.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Payments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Deposits
        '
        Me.Deposits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Deposits.HeaderText = "Deposits"
        Me.Deposits.Name = "Deposits"
        Me.Deposits.ReadOnly = true
        Me.Deposits.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Deposits.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Monthly
        '
        Me.Monthly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Monthly.HeaderText = "Monthly"
        Me.Monthly.Name = "Monthly"
        Me.Monthly.ReadOnly = true
        Me.Monthly.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Monthly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'AveMonthlyIncome
        '
        Me.AveMonthlyIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AveMonthlyIncome.HeaderText = "Average Income"
        Me.AveMonthlyIncome.Name = "AveMonthlyIncome"
        Me.AveMonthlyIncome.ReadOnly = true
        Me.AveMonthlyIncome.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AveMonthlyIncome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cxmnuMonthlyIncomeTable
        '
        Me.cxmnuMonthlyIncomeTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cxmnuMonthlyIncomeTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cxmnuEditValues, Me.cxmnuRemoveValues})
        Me.cxmnuMonthlyIncomeTable.Name = "cxmnuMonthlyIncomeTable"
        Me.cxmnuMonthlyIncomeTable.Size = New System.Drawing.Size(192, 48)
        '
        'cxmnuEditValues
        '
        Me.cxmnuEditValues.Image = CType(resources.GetObject("cxmnuEditValues.Image"),System.Drawing.Image)
        Me.cxmnuEditValues.Name = "cxmnuEditValues"
        Me.cxmnuEditValues.Size = New System.Drawing.Size(191, 22)
        Me.cxmnuEditValues.Text = "Edit Selected Totals"
        '
        'cxmnuRemoveValues
        '
        Me.cxmnuRemoveValues.Image = CType(resources.GetObject("cxmnuRemoveValues.Image"),System.Drawing.Image)
        Me.cxmnuRemoveValues.Name = "cxmnuRemoveValues"
        Me.cxmnuRemoveValues.Size = New System.Drawing.Size(191, 22)
        Me.cxmnuRemoveValues.Text = "Remove Selected Totals"
        '
        'lblFilterPaymentsDeposits
        '
        Me.lblFilterPaymentsDeposits.AutoSize = true
        Me.lblFilterPaymentsDeposits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.lblFilterPaymentsDeposits.Location = New System.Drawing.Point(354, 33)
        Me.lblFilterPaymentsDeposits.Name = "lblFilterPaymentsDeposits"
        Me.lblFilterPaymentsDeposits.Size = New System.Drawing.Size(109, 13)
        Me.lblFilterPaymentsDeposits.TabIndex = 5
        Me.lblFilterPaymentsDeposits.Text = "Payments or Deposits"
        '
        'cbPaymentsDeposits
        '
        Me.cbPaymentsDeposits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaymentsDeposits.FormattingEnabled = true
        Me.cbPaymentsDeposits.Items.AddRange(New Object() {"Payments", "Deposits"})
        Me.cbPaymentsDeposits.Location = New System.Drawing.Point(354, 49)
        Me.cbPaymentsDeposits.Name = "cbPaymentsDeposits"
        Me.cbPaymentsDeposits.Size = New System.Drawing.Size(182, 21)
        Me.cbPaymentsDeposits.TabIndex = 6
        '
        'lblLedgerStatus
        '
        Me.lblLedgerStatus.AutoSize = true
        Me.lblLedgerStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.lblLedgerStatus.Location = New System.Drawing.Point(134, 21)
        Me.lblLedgerStatus.Name = "lblLedgerStatus"
        Me.lblLedgerStatus.Size = New System.Drawing.Size(73, 13)
        Me.lblLedgerStatus.TabIndex = 2
        Me.lblLedgerStatus.Text = "Ledger Status"
        '
        'txtLedgerStatus
        '
        Me.txtLedgerStatus.Enabled = false
        Me.txtLedgerStatus.Location = New System.Drawing.Point(134, 37)
        Me.txtLedgerStatus.Name = "txtLedgerStatus"
        Me.txtLedgerStatus.ReadOnly = true
        Me.txtLedgerStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtLedgerStatus.TabIndex = 3
        '
        'gbCurrentYear
        '
        Me.gbCurrentYear.Controls.Add(Me.txtTotalPayments)
        Me.gbCurrentYear.Controls.Add(Me.lblTotalPayments)
        Me.gbCurrentYear.Controls.Add(Me.txtTotalDeposits)
        Me.gbCurrentYear.Controls.Add(Me.lblTotalDeposits)
        Me.gbCurrentYear.Controls.Add(Me.txtYearStatus)
        Me.gbCurrentYear.Controls.Add(Me.lblYearStatus)
        Me.gbCurrentYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.gbCurrentYear.Location = New System.Drawing.Point(503, 504)
        Me.gbCurrentYear.Name = "gbCurrentYear"
        Me.gbCurrentYear.Size = New System.Drawing.Size(443, 79)
        Me.gbCurrentYear.TabIndex = 1
        Me.gbCurrentYear.TabStop = false
        Me.gbCurrentYear.Text = "Current Year Details"
        '
        'gbOverallDetails
        '
        Me.gbOverallDetails.Controls.Add(Me.txtOverallBalance)
        Me.gbOverallDetails.Controls.Add(Me.lblOverallBalance)
        Me.gbOverallDetails.Controls.Add(Me.txtLedgerStatus)
        Me.gbOverallDetails.Controls.Add(Me.lblLedgerStatus)
        Me.gbOverallDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.gbOverallDetails.Location = New System.Drawing.Point(952, 504)
        Me.gbOverallDetails.Name = "gbOverallDetails"
        Me.gbOverallDetails.Size = New System.Drawing.Size(263, 79)
        Me.gbOverallDetails.TabIndex = 2
        Me.gbOverallDetails.TabStop = false
        Me.gbOverallDetails.Text = "Overall Account Details"
        '
        'gbFilterOptions
        '
        Me.gbFilterOptions.Controls.Add(Me.cbYear)
        Me.gbFilterOptions.Controls.Add(Me.lblYear)
        Me.gbFilterOptions.Controls.Add(Me.cbCategoriesPayees)
        Me.gbFilterOptions.Controls.Add(Me.lblFilterPaymentsDeposits)
        Me.gbFilterOptions.Controls.Add(Me.lblFilterCategoriesPayees)
        Me.gbFilterOptions.Controls.Add(Me.cbPaymentsDeposits)
        Me.gbFilterOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(139,Byte),Integer))
        Me.gbFilterOptions.Location = New System.Drawing.Point(503, 589)
        Me.gbFilterOptions.Name = "gbFilterOptions"
        Me.gbFilterOptions.Size = New System.Drawing.Size(575, 103)
        Me.gbFilterOptions.TabIndex = 0
        Me.gbFilterOptions.TabStop = false
        Me.gbFilterOptions.Text = "Filter Options"
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(191,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.mnuMenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.ToolStripMenuItem4, Me.mnuHelp})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuMenuStrip.Size = New System.Drawing.Size(1227, 24)
        Me.mnuMenuStrip.TabIndex = 8
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuOpen, Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"),System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(183, 22)
        Me.mnuSave.Text = "&Save What If Scenario"
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = CType(resources.GetObject("mnuOpen.Image"),System.Drawing.Image)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(183, 22)
        Me.mnuOpen.Text = "&Open What If Scenario"
        '
        'mnuClose
        '
        Me.mnuClose.Image = CType(resources.GetObject("mnuClose.Image"),System.Drawing.Image)
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(183, 22)
        Me.mnuClose.Text = "&Close"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateExpense, Me.mnuEditExpense, Me.mnuRemoveExpenses, Me.mnuRemoveCategory, Me.mnuCopyToNextMonth, Me.mnuCopyToSelectedMonths, Me.mnuCopyToRestOfYear, Me.ToolStripSeparator2, Me.mnuCreateEmptyWhatif, Me.ToolStripSeparator3, Me.mnuSumSelected})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(37, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuCreateExpense
        '
        Me.mnuCreateExpense.Image = CType(resources.GetObject("mnuCreateExpense.Image"),System.Drawing.Image)
        Me.mnuCreateExpense.Name = "mnuCreateExpense"
        Me.mnuCreateExpense.Size = New System.Drawing.Size(193, 22)
        Me.mnuCreateExpense.Text = "&Create Monthly Expense"
        '
        'mnuEditExpense
        '
        Me.mnuEditExpense.Image = CType(resources.GetObject("mnuEditExpense.Image"),System.Drawing.Image)
        Me.mnuEditExpense.Name = "mnuEditExpense"
        Me.mnuEditExpense.Size = New System.Drawing.Size(193, 22)
        Me.mnuEditExpense.Text = "&Edit Expenses"
        '
        'mnuRemoveExpenses
        '
        Me.mnuRemoveExpenses.Image = CType(resources.GetObject("mnuRemoveExpenses.Image"),System.Drawing.Image)
        Me.mnuRemoveExpenses.Name = "mnuRemoveExpenses"
        Me.mnuRemoveExpenses.Size = New System.Drawing.Size(193, 22)
        Me.mnuRemoveExpenses.Text = "&Remove Expenses"
        '
        'mnuRemoveCategory
        '
        Me.mnuRemoveCategory.Image = CType(resources.GetObject("mnuRemoveCategory.Image"),System.Drawing.Image)
        Me.mnuRemoveCategory.Name = "mnuRemoveCategory"
        Me.mnuRemoveCategory.Size = New System.Drawing.Size(193, 22)
        Me.mnuRemoveCategory.Text = "Remo&ve Categories"
        '
        'mnuCopyToNextMonth
        '
        Me.mnuCopyToNextMonth.Image = CType(resources.GetObject("mnuCopyToNextMonth.Image"),System.Drawing.Image)
        Me.mnuCopyToNextMonth.Name = "mnuCopyToNextMonth"
        Me.mnuCopyToNextMonth.Size = New System.Drawing.Size(193, 22)
        Me.mnuCopyToNextMonth.Text = "Copy to &Next Month"
        '
        'mnuCopyToSelectedMonths
        '
        Me.mnuCopyToSelectedMonths.Image = CType(resources.GetObject("mnuCopyToSelectedMonths.Image"),System.Drawing.Image)
        Me.mnuCopyToSelectedMonths.Name = "mnuCopyToSelectedMonths"
        Me.mnuCopyToSelectedMonths.Size = New System.Drawing.Size(193, 22)
        Me.mnuCopyToSelectedMonths.Text = "Copy to Selected &Months"
        '
        'mnuCopyToRestOfYear
        '
        Me.mnuCopyToRestOfYear.Image = CType(resources.GetObject("mnuCopyToRestOfYear.Image"),System.Drawing.Image)
        Me.mnuCopyToRestOfYear.Name = "mnuCopyToRestOfYear"
        Me.mnuCopyToRestOfYear.Size = New System.Drawing.Size(193, 22)
        Me.mnuCopyToRestOfYear.Text = "Copy to Rest of &Year"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'mnuCreateEmptyWhatif
        '
        Me.mnuCreateEmptyWhatif.Image = CType(resources.GetObject("mnuCreateEmptyWhatif.Image"),System.Drawing.Image)
        Me.mnuCreateEmptyWhatif.Name = "mnuCreateEmptyWhatif"
        Me.mnuCreateEmptyWhatif.Size = New System.Drawing.Size(193, 22)
        Me.mnuCreateEmptyWhatif.Text = "Create Empty &Scenario"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCharts, Me.mnuResetYearTotals})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(42, 20)
        Me.mnuView.Text = "&View"
        '
        'mnuCharts
        '
        Me.mnuCharts.Image = CType(resources.GetObject("mnuCharts.Image"),System.Drawing.Image)
        Me.mnuCharts.Name = "mnuCharts"
        Me.mnuCharts.Size = New System.Drawing.Size(200, 22)
        Me.mnuCharts.Text = "Spending Overview &Charts"
        '
        'mnuResetYearTotals
        '
        Me.mnuResetYearTotals.Image = CType(resources.GetObject("mnuResetYearTotals.Image"),System.Drawing.Image)
        Me.mnuResetYearTotals.Name = "mnuResetYearTotals"
        Me.mnuResetYearTotals.Size = New System.Drawing.Size(200, 22)
        Me.mnuResetYearTotals.Text = "&Reset All Expenses"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExportCategoryPayeeTable})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(45, 20)
        Me.ToolStripMenuItem4.Text = "&Tools"
        '
        'mnuExportCategoryPayeeTable
        '
        Me.mnuExportCategoryPayeeTable.Image = CType(resources.GetObject("mnuExportCategoryPayeeTable.Image"),System.Drawing.Image)
        Me.mnuExportCategoryPayeeTable.Name = "mnuExportCategoryPayeeTable"
        Me.mnuExportCategoryPayeeTable.Size = New System.Drawing.Size(235, 22)
        Me.mnuExportCategoryPayeeTable.Text = "&Export Spending Overview Tables"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCheckbookHelp})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(41, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuCheckbookHelp
        '
        Me.mnuCheckbookHelp.Image = CType(resources.GetObject("mnuCheckbookHelp.Image"),System.Drawing.Image)
        Me.mnuCheckbookHelp.Name = "mnuCheckbookHelp"
        Me.mnuCheckbookHelp.Size = New System.Drawing.Size(154, 22)
        Me.mnuCheckbookHelp.Text = "Checkbook &Help"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(190, 6)
        '
        'mnuSumSelected
        '
        Me.mnuSumSelected.Image = Global.Checkbook.My.Resources.Resources.sum_selected
        Me.mnuSumSelected.Name = "mnuSumSelected"
        Me.mnuSumSelected.Size = New System.Drawing.Size(193, 22)
        Me.mnuSumSelected.Text = "Sum Selected"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(194, 6)
        '
        'cxmnuSumSelected
        '
        Me.cxmnuSumSelected.Image = Global.Checkbook.My.Resources.Resources.sum_selected
        Me.cxmnuSumSelected.Name = "cxmnuSumSelected"
        Me.cxmnuSumSelected.Size = New System.Drawing.Size(197, 22)
        Me.cxmnuSumSelected.Text = "Sum Selected"
        '
        'frmSpendingOverview
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(251,Byte),Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1227, 801)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Controls.Add(Me.gbFilterOptions)
        Me.Controls.Add(Me.gbOverallDetails)
        Me.Controls.Add(Me.gbModelOptions)
        Me.Controls.Add(Me.gbCurrentYear)
        Me.Controls.Add(Me.dgvMonthly)
        Me.Controls.Add(Me.dgvCategory)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(1161, 667)
        Me.Name = "frmSpendingOverview"
        Me.ShowInTaskbar = false
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Spending Overview"
        Me.cxmnuWhatIf.ResumeLayout(false)
        CType(Me.dgvCategory,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbModelOptions.ResumeLayout(false)
        Me.gbModelOptions.PerformLayout
        CType(Me.dgvMonthly,System.ComponentModel.ISupportInitialize).EndInit
        Me.cxmnuMonthlyIncomeTable.ResumeLayout(false)
        Me.gbCurrentYear.ResumeLayout(false)
        Me.gbCurrentYear.PerformLayout
        Me.gbOverallDetails.ResumeLayout(false)
        Me.gbOverallDetails.PerformLayout
        Me.gbFilterOptions.ResumeLayout(false)
        Me.gbFilterOptions.PerformLayout
        Me.mnuMenuStrip.ResumeLayout(false)
        Me.mnuMenuStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearStatus As System.Windows.Forms.Label
    Friend WithEvents lblOverallBalance As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayments As System.Windows.Forms.Label
    Friend WithEvents txtTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtOverallBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtYearStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalDeposits As System.Windows.Forms.Label
    Friend WithEvents txtTotalDeposits As System.Windows.Forms.TextBox
    Friend WithEvents cxmnuWhatIf As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cxmnuCreateExpense As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cxmnuEditExpense As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cxmnuResetYearTotals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cxmnuRemoveCategories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cxmnuRemoveExpenses As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvCategory As System.Windows.Forms.DataGridView
    Friend WithEvents cbCategoriesPayees As System.Windows.Forms.ComboBox
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents January As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents February As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents March As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents April As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents May As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents June As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents July As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents August As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents September As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents October As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents November As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents December As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Totals As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Percent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblFilterCategoriesPayees As System.Windows.Forms.Label
    Friend WithEvents dgvMonthly As System.Windows.Forms.DataGridView
    Friend WithEvents Month As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deposits As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monthly As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AveMonthlyIncome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblFilterPaymentsDeposits As System.Windows.Forms.Label
    Friend WithEvents cbPaymentsDeposits As System.Windows.Forms.ComboBox
    Friend WithEvents lblLedgerStatus As Label
    Friend WithEvents txtLedgerStatus As TextBox
    Friend WithEvents gbModelOptions As GroupBox
    Friend WithEvents rbCurrentYear As RadioButton
    Friend WithEvents rbNextYear As RadioButton
    Friend WithEvents gbCurrentYear As GroupBox
    Friend WithEvents gbOverallDetails As GroupBox
    Friend WithEvents gbFilterOptions As GroupBox
    Friend WithEvents cxmnuCreateEmptyScenario As ToolStripMenuItem
    Friend WithEvents cxmnuMonthlyIncomeTable As ContextMenuStrip
    Friend WithEvents cxmnuEditValues As ToolStripMenuItem
    Friend WithEvents cxmnuRemoveValues As ToolStripMenuItem
    Friend WithEvents cxmnuCopyToNextMonth As ToolStripMenuItem
    Friend WithEvents cxmnuCopyToRestOfYear As ToolStripMenuItem
    Friend WithEvents cxmnuCopyToSelectedMonths As ToolStripMenuItem
    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuCheckbookHelp As ToolStripMenuItem
    Friend WithEvents mnuCreateExpense As ToolStripMenuItem
    Friend WithEvents mnuEditExpense As ToolStripMenuItem
    Friend WithEvents mnuRemoveExpenses As ToolStripMenuItem
    Friend WithEvents mnuRemoveCategory As ToolStripMenuItem
    Friend WithEvents mnuCopyToNextMonth As ToolStripMenuItem
    Friend WithEvents mnuCopyToSelectedMonths As ToolStripMenuItem
    Friend WithEvents mnuCopyToRestOfYear As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuCreateEmptyWhatif As ToolStripMenuItem
    Friend WithEvents mnuCharts As ToolStripMenuItem
    Friend WithEvents mnuResetYearTotals As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents mnuExportCategoryPayeeTable As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuSumSelected As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents cxmnuSumSelected As ToolStripMenuItem
End Class
