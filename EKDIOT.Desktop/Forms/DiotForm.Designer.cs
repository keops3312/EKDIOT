namespace EKDIOT.Desktop.Forms
{
    partial class DiotForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiotForm));
            this.cmbEmpresas = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.listEjercicios = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtIVA = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmpresas
            // 
            this.cmbEmpresas.DisplayMember = "Text";
            this.cmbEmpresas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmpresas.FormattingEnabled = true;
            this.cmbEmpresas.ItemHeight = 14;
            this.cmbEmpresas.Location = new System.Drawing.Point(31, 61);
            this.cmbEmpresas.Name = "cmbEmpresas";
            this.cmbEmpresas.Size = new System.Drawing.Size(241, 20);
            this.cmbEmpresas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbEmpresas.TabIndex = 0;
            this.cmbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresas_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(31, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(163, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "labelX1";
            // 
            // listEjercicios
            // 
            // 
            // 
            // 
            this.listEjercicios.Border.Class = "ListViewBorder";
            this.listEjercicios.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listEjercicios.DisabledBackColor = System.Drawing.Color.Empty;
            this.listEjercicios.Location = new System.Drawing.Point(31, 127);
            this.listEjercicios.Name = "listEjercicios";
            this.listEjercicios.Size = new System.Drawing.Size(241, 191);
            this.listEjercicios.TabIndex = 2;
            this.listEjercicios.UseCompatibleStateImageBehavior = false;
            this.listEjercicios.SelectedIndexChanged += new System.EventHandler(this.listEjercicios_SelectedIndexChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(31, 98);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(163, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Seleccione Ejercicio";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(31, 343);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "labelX3";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(31, 372);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "labelX4";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(31, 401);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 6;
            this.labelX5.Text = "labelX5";
            // 
            // dataGridViewX1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(341, 73);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.Size = new System.Drawing.Size(656, 293);
            this.dataGridViewX1.TabIndex = 7;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(866, 431);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(131, 45);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "buttonX1";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Checked = true;
            this.checkBoxX1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX1.CheckValue = "Y";
            this.checkBoxX1.Location = new System.Drawing.Point(385, 441);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 9;
            this.checkBoxX1.Text = "Excel";
            // 
            // checkBoxX2
            // 
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.Checked = true;
            this.checkBoxX2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX2.CheckValue = "Y";
            this.checkBoxX2.Location = new System.Drawing.Point(519, 441);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 10;
            this.checkBoxX2.Text = "Reporte";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "database24.fw.png");
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Location = new System.Drawing.Point(31, 456);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(241, 20);
            this.txtEjercicio.TabIndex = 11;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(266, 98);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "labelX6";
            // 
            // txtIVA
            // 
            // 
            // 
            // 
            this.txtIVA.Border.Class = "TextBoxBorder";
            this.txtIVA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIVA.Location = new System.Drawing.Point(182, 404);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.PreventEnterBeep = true;
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 13;
            // 
            // DiotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 488);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.checkBoxX2);
            this.Controls.Add(this.checkBoxX1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.listEjercicios);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbEmpresas);
            this.DoubleBuffered = true;
            this.Name = "DiotForm";
            this.Text = "DiotForm";
            this.Load += new System.EventHandler(this.DiotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbEmpresas;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ListViewEx listEjercicios;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtEjercicio;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIVA;
    }
}