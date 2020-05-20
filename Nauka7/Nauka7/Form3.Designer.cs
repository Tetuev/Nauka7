namespace Nauka7
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_табеляLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label кодировкаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tableDataSet = new Nauka7.TableDataSet();
            this.табельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.табельTableAdapter = new Nauka7.TableDataSetTableAdapters.ТабельTableAdapter();
            this.tableAdapterManager = new Nauka7.TableDataSetTableAdapters.TableAdapterManager();
            this.табельBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.табельBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_табеляTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.кодировкаTextBox = new System.Windows.Forms.TextBox();
            код_табеляLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            кодировкаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельBindingNavigator)).BeginInit();
            this.табельBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_табеляLabel
            // 
            код_табеляLabel.AutoSize = true;
            код_табеляLabel.Location = new System.Drawing.Point(28, 84);
            код_табеляLabel.Name = "код_табеляLabel";
            код_табеляLabel.Size = new System.Drawing.Size(102, 20);
            код_табеляLabel.TabIndex = 1;
            код_табеляLabel.Text = "Код табеля:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(28, 117);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(52, 20);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(28, 148);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(135, 20);
            код_сотрудникаLabel.TabIndex = 5;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // кодировкаLabel
            // 
            кодировкаLabel.AutoSize = true;
            кодировкаLabel.Location = new System.Drawing.Point(28, 180);
            кодировкаLabel.Name = "кодировкаLabel";
            кодировкаLabel.Size = new System.Drawing.Size(96, 20);
            кодировкаLabel.TabIndex = 7;
            кодировкаLabel.Text = "Кодировка:";
            // 
            // tableDataSet
            // 
            this.tableDataSet.DataSetName = "TableDataSet";
            this.tableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // табельBindingSource
            // 
            this.табельBindingSource.DataMember = "Табель";
            this.табельBindingSource.DataSource = this.tableDataSet;
            // 
            // табельTableAdapter
            // 
            this.табельTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Nauka7.TableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТабельTableAdapter = this.табельTableAdapter;
            // 
            // табельBindingNavigator
            // 
            this.табельBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.табельBindingNavigator.BindingSource = this.табельBindingSource;
            this.табельBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.табельBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.табельBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.табельBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.табельBindingNavigatorSaveItem});
            this.табельBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.табельBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.табельBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.табельBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.табельBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.табельBindingNavigator.Name = "табельBindingNavigator";
            this.табельBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.табельBindingNavigator.Size = new System.Drawing.Size(483, 33);
            this.табельBindingNavigator.TabIndex = 0;
            this.табельBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // табельBindingNavigatorSaveItem
            // 
            this.табельBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.табельBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("табельBindingNavigatorSaveItem.Image")));
            this.табельBindingNavigatorSaveItem.Name = "табельBindingNavigatorSaveItem";
            this.табельBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.табельBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.табельBindingNavigatorSaveItem.Click += new System.EventHandler(this.табельBindingNavigatorSaveItem_Click);
            // 
            // код_табеляTextBox
            // 
            this.код_табеляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Код табеля", true));
            this.код_табеляTextBox.Location = new System.Drawing.Point(169, 81);
            this.код_табеляTextBox.Name = "код_табеляTextBox";
            this.код_табеляTextBox.Size = new System.Drawing.Size(200, 26);
            this.код_табеляTextBox.TabIndex = 2;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.табельBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(169, 113);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(169, 145);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(200, 26);
            this.код_сотрудникаTextBox.TabIndex = 6;
            // 
            // кодировкаTextBox
            // 
            this.кодировкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.табельBindingSource, "Кодировка", true));
            this.кодировкаTextBox.Location = new System.Drawing.Point(169, 177);
            this.кодировкаTextBox.Name = "кодировкаTextBox";
            this.кодировкаTextBox.Size = new System.Drawing.Size(200, 26);
            this.кодировкаTextBox.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 252);
            this.Controls.Add(код_табеляLabel);
            this.Controls.Add(this.код_табеляTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(кодировкаLabel);
            this.Controls.Add(this.кодировкаTextBox);
            this.Controls.Add(this.табельBindingNavigator);
            this.Name = "Form3";
            this.Text = "Табель";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельBindingNavigator)).EndInit();
            this.табельBindingNavigator.ResumeLayout(false);
            this.табельBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableDataSet tableDataSet;
        private System.Windows.Forms.BindingSource табельBindingSource;
        private TableDataSetTableAdapters.ТабельTableAdapter табельTableAdapter;
        private TableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator табельBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton табельBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_табеляTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.TextBox кодировкаTextBox;
    }
}