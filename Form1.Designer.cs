
namespace ProiectMardaleBiancaElena
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDrepturi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbIdGrup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lvU = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bStergere = new System.Windows.Forms.Button();
            this.errP1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bModificare = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(400, 113);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(108, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descriere Grupuri";
            // 
            // tbDrepturi
            // 
            this.tbDrepturi.BackColor = System.Drawing.Color.White;
            this.tbDrepturi.FormattingEnabled = true;
            this.tbDrepturi.Location = new System.Drawing.Point(578, 109);
            this.tbDrepturi.Name = "tbDrepturi";
            this.tbDrepturi.Size = new System.Drawing.Size(121, 24);
            this.tbDrepturi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(464, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Drepturi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(464, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Grup";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(497, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Adaugare drepturi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbIdGrup
            // 
            this.tbIdGrup.BackColor = System.Drawing.Color.White;
            this.tbIdGrup.ForeColor = System.Drawing.Color.Black;
            this.tbIdGrup.Location = new System.Drawing.Point(578, 31);
            this.tbIdGrup.Name = "tbIdGrup";
            this.tbIdGrup.Size = new System.Drawing.Size(121, 22);
            this.tbIdGrup.TabIndex = 9;
            this.tbIdGrup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbIdGrup.Validating += new System.ComponentModel.CancelEventHandler(this.tbIdGrup_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(464, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Drepturi adaugate pana acum: 0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(497, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Adaugare Id";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvU
            // 
            this.lvU.BackColor = System.Drawing.Color.White;
            this.lvU.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvU.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvU.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lvU.GridLines = true;
            this.lvU.HideSelection = false;
            this.lvU.Location = new System.Drawing.Point(422, 225);
            this.lvU.Name = "lvU";
            this.lvU.Size = new System.Drawing.Size(366, 112);
            this.lvU.TabIndex = 13;
            this.lvU.UseCompatibleStateImageBehavior = false;
            this.lvU.View = System.Windows.Forms.View.Details;
            this.lvU.SelectedIndexChanged += new System.EventHandler(this.lvU_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume ";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nume Utilizator";
            this.columnHeader3.Width = 157;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareTextToolStripMenuItem,
            this.deschidereTextToolStripMenuItem,
            this.salvareBinarToolStripMenuItem,
            this.deschidereBinarToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareTextToolStripMenuItem
            // 
            this.salvareTextToolStripMenuItem.Name = "salvareTextToolStripMenuItem";
            this.salvareTextToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvareTextToolStripMenuItem.Text = "Salvare text";
            this.salvareTextToolStripMenuItem.Click += new System.EventHandler(this.salvareTextToolStripMenuItem_Click);
            // 
            // deschidereTextToolStripMenuItem
            // 
            this.deschidereTextToolStripMenuItem.Name = "deschidereTextToolStripMenuItem";
            this.deschidereTextToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deschidereTextToolStripMenuItem.Text = "Deschide text";
            this.deschidereTextToolStripMenuItem.Click += new System.EventHandler(this.deschidereTextToolStripMenuItem_Click);
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvareBinarToolStripMenuItem.Text = "Salvare binar";
            this.salvareBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareBinarToolStripMenuItem_Click);
            // 
            // deschidereBinarToolStripMenuItem
            // 
            this.deschidereBinarToolStripMenuItem.Name = "deschidereBinarToolStripMenuItem";
            this.deschidereBinarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deschidereBinarToolStripMenuItem.Text = "Deschidere binar";
            this.deschidereBinarToolStripMenuItem.Click += new System.EventHandler(this.deschidereBinarToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bStergere
            // 
            this.bStergere.BackColor = System.Drawing.Color.PowderBlue;
            this.bStergere.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStergere.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bStergere.Location = new System.Drawing.Point(497, 366);
            this.bStergere.Name = "bStergere";
            this.bStergere.Size = new System.Drawing.Size(160, 32);
            this.bStergere.TabIndex = 17;
            this.bStergere.Text = "Stergere utilizator";
            this.bStergere.UseVisualStyleBackColor = false;
            this.bStergere.Click += new System.EventHandler(this.bStergere_Click);
            // 
            // errP1
            // 
            this.errP1.ContainerControl = this;
            // 
            // bModificare
            // 
            this.bModificare.BackColor = System.Drawing.Color.PowderBlue;
            this.bModificare.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bModificare.Location = new System.Drawing.Point(497, 415);
            this.bModificare.Name = "bModificare";
            this.bModificare.Size = new System.Drawing.Size(160, 32);
            this.bModificare.TabIndex = 18;
            this.bModificare.Text = "Modificare utilizator";
            this.bModificare.UseVisualStyleBackColor = false;
            this.bModificare.Click += new System.EventHandler(this.bModificare_Click);
            // 
            // bexit
            // 
            this.bexit.Image = global::ProiectMardaleBiancaElena.Properties.Resources.icons8_close_window_24;
            this.bexit.Location = new System.Drawing.Point(770, 0);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(30, 28);
            this.bexit.TabIndex = 15;
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PowderBlue;
            this.button5.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button5.Image = global::ProiectMardaleBiancaElena.Properties.Resources.icons8_add_30;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(128, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 52);
            this.button5.TabIndex = 14;
            this.button5.Text = "Adaugare Grup";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Image = global::ProiectMardaleBiancaElena.Properties.Resources.icons8_info_30;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(128, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 57);
            this.button4.TabIndex = 12;
            this.button4.Text = "Informatii Grupuri";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Image = global::ProiectMardaleBiancaElena.Properties.Resources.icons8_user_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(128, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adaugare Utilizator";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bModificare);
            this.Controls.Add(this.bStergere);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lvU);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIdGrup);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDrepturi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Grup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tbDrepturi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbIdGrup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.ListView lvU;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareTextToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem deschidereTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereBinarToolStripMenuItem;
        private System.Windows.Forms.Button bStergere;
        private System.Windows.Forms.ErrorProvider errP1;
        private System.Windows.Forms.Button bModificare;
    }
}

