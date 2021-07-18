namespace Accounting_hotel_rooms_Windows
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.to_form_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.output_ExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tableaddreport = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1294, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MenuToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuToolStripMenuItem.BackgroundImage")));
            this.MenuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.to_form_ToolStripMenuItem,
            this.output_ExToolStripMenuItem});
            this.MenuToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.MenuToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.MenuToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.MenuToolStripMenuItem.Text = "МЕНЮ";
            this.MenuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.MenuToolStripMenuItem.Click += new System.EventHandler(this.MenuToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.AddToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddToolStripMenuItem.BackgroundImage")));
            this.AddToolStripMenuItem.Checked = true;
            this.AddToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.AddToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(294, 32);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // to_form_ToolStripMenuItem
            // 
            this.to_form_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.to_form_ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("to_form_ToolStripMenuItem.BackgroundImage")));
            this.to_form_ToolStripMenuItem.Checked = true;
            this.to_form_ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.to_form_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.to_form_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.to_form_ToolStripMenuItem.Name = "to_form_ToolStripMenuItem";
            this.to_form_ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.to_form_ToolStripMenuItem.Size = new System.Drawing.Size(294, 32);
            this.to_form_ToolStripMenuItem.Text = "Сформировать отчет";
            this.to_form_ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.to_form_ToolStripMenuItem.Click += new System.EventHandler(this.To_form_ToolStripMenuItem_Click);
            // 
            // output_ExToolStripMenuItem
            // 
            this.output_ExToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.output_ExToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output_ExToolStripMenuItem.BackgroundImage")));
            this.output_ExToolStripMenuItem.Checked = true;
            this.output_ExToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.output_ExToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.output_ExToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.output_ExToolStripMenuItem.Name = "output_ExToolStripMenuItem";
            this.output_ExToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.output_ExToolStripMenuItem.Size = new System.Drawing.Size(294, 32);
            this.output_ExToolStripMenuItem.Text = "Выход";
            this.output_ExToolStripMenuItem.Click += new System.EventHandler(this.OutputToolStripMenuItem_Click);
            // 
            // Tableaddreport
            // 
            this.Tableaddreport.AllowDrop = true;
            this.Tableaddreport.AutoScroll = true;
            this.Tableaddreport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tableaddreport.BackColor = System.Drawing.SystemColors.Info;
            this.Tableaddreport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tableaddreport.BackgroundImage")));
            this.Tableaddreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tableaddreport.ColumnCount = 9;
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tableaddreport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tableaddreport.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tableaddreport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tableaddreport.Location = new System.Drawing.Point(0, 41);
            this.Tableaddreport.Margin = new System.Windows.Forms.Padding(0);
            this.Tableaddreport.Name = "Tableaddreport";
            this.Tableaddreport.RowCount = 2;
            this.Tableaddreport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tableaddreport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tableaddreport.Size = new System.Drawing.Size(1294, 621);
            this.Tableaddreport.TabIndex = 1;
            this.Tableaddreport.Paint += new System.Windows.Forms.PaintEventHandler(this.Tableaddreport_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1294, 661);
            this.Controls.Add(this.Tableaddreport);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem to_form_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem output_ExToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel Tableaddreport;
    }
}

