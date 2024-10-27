
namespace Lb6.Forms
{
    partial class MainDataForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStripData = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.еditingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridViewData = new System.Windows.Forms.DataGridView();
			this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCours = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnFormEducat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStripData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripData
			// 
			this.menuStripData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.menuStripData.Font = new System.Drawing.Font("Verdana", 9F);
			this.menuStripData.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStripData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.menuStripData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.еditingFileToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.deleteTableToolStripMenuItem,
            this.taskToolStripMenuItem});
			this.menuStripData.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.menuStripData.Location = new System.Drawing.Point(0, 0);
			this.menuStripData.Name = "menuStripData";
			this.menuStripData.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStripData.Size = new System.Drawing.Size(1021, 26);
			this.menuStripData.TabIndex = 0;
			this.menuStripData.Text = "menuStripDate";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.createToolStripMenuItem,
            this.saveAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.fileToolStripMenuItem.Text = "Файл";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.openToolStripMenuItem.Text = "Открыть";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.saveToolStripMenuItem.Text = "Сохранить";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// createToolStripMenuItem
			// 
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.createToolStripMenuItem.Text = "Создать";
			this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.saveAsToolStripMenuItem.Text = "Сохранить как";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			// 
			// еditingFileToolStripMenuItem
			// 
			this.еditingFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
			this.еditingFileToolStripMenuItem.Name = "еditingFileToolStripMenuItem";
			this.еditingFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.еditingFileToolStripMenuItem.Text = "Редактирование";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
			this.deleteToolStripMenuItem.Text = "Удалить";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
			this.editToolStripMenuItem.Text = "Изменить/Просмотреть";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
			// 
			// AddToolStripMenuItem
			// 
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
			this.AddToolStripMenuItem.Text = "Добавить";
			this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
			// 
			// deleteTableToolStripMenuItem
			// 
			this.deleteTableToolStripMenuItem.Name = "deleteTableToolStripMenuItem";
			this.deleteTableToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.deleteTableToolStripMenuItem.Text = "Удалить таблицу";
			this.deleteTableToolStripMenuItem.Click += new System.EventHandler(this.DeleteTableToolStripMenuItem_Click);
			// 
			// taskToolStripMenuItem
			// 
			this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
			this.taskToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
			this.taskToolStripMenuItem.Text = "Задача";
			this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
			// 
			// dataGridViewData
			// 
			this.dataGridViewData.AccessibleName = "";
			this.dataGridViewData.AllowUserToAddRows = false;
			this.dataGridViewData.AllowUserToDeleteRows = false;
			this.dataGridViewData.AllowUserToResizeColumns = false;
			this.dataGridViewData.AllowUserToResizeRows = false;
			this.dataGridViewData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.dataGridViewData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnFIO,
            this.ColumnGroup,
            this.ColumnCours,
            this.ColumnFormEducat});
			this.dataGridViewData.Cursor = System.Windows.Forms.Cursors.No;
			this.dataGridViewData.EnableHeadersVisualStyles = false;
			this.dataGridViewData.GridColor = System.Drawing.Color.SkyBlue;
			this.dataGridViewData.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.dataGridViewData.Location = new System.Drawing.Point(10, 30);
			this.dataGridViewData.Name = "dataGridViewData";
			this.dataGridViewData.ReadOnly = true;
			this.dataGridViewData.RowHeadersWidth = 5;
			this.dataGridViewData.RowTemplate.Height = 24;
			this.dataGridViewData.Size = new System.Drawing.Size(1008, 460);
			this.dataGridViewData.TabIndex = 1;
			// 
			// ColumnNumber
			// 
			this.ColumnNumber.HeaderText = "№";
			this.ColumnNumber.MinimumWidth = 6;
			this.ColumnNumber.Name = "ColumnNumber";
			this.ColumnNumber.ReadOnly = true;
			this.ColumnNumber.Width = 30;
			// 
			// ColumnFIO
			// 
			this.ColumnFIO.HeaderText = "ФИО";
			this.ColumnFIO.MinimumWidth = 6;
			this.ColumnFIO.Name = "ColumnFIO";
			this.ColumnFIO.ReadOnly = true;
			this.ColumnFIO.Width = 400;
			// 
			// ColumnGroup
			// 
			this.ColumnGroup.HeaderText = "Группа";
			this.ColumnGroup.MinimumWidth = 6;
			this.ColumnGroup.Name = "ColumnGroup";
			this.ColumnGroup.ReadOnly = true;
			this.ColumnGroup.Width = 80;
			// 
			// ColumnCours
			// 
			this.ColumnCours.HeaderText = "Курс";
			this.ColumnCours.MinimumWidth = 6;
			this.ColumnCours.Name = "ColumnCours";
			this.ColumnCours.ReadOnly = true;
			this.ColumnCours.Width = 80;
			// 
			// ColumnFormEducat
			// 
			this.ColumnFormEducat.HeaderText = "Форма обучения";
			this.ColumnFormEducat.MinimumWidth = 6;
			this.ColumnFormEducat.Name = "ColumnFormEducat";
			this.ColumnFormEducat.ReadOnly = true;
			this.ColumnFormEducat.Width = 150;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// MainDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1021, 506);
			this.Controls.Add(this.dataGridViewData);
			this.Controls.Add(this.menuStripData);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStripData;
			this.Name = "MainDataForm";
			this.Text = "Данные";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormData_FormClosed);
			this.Load += new System.EventHandler(this.FormData_Load);
			this.menuStripData.ResumeLayout(false);
			this.menuStripData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripData;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem еditingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormEducat;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem deleteTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
    }
}

