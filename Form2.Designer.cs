
namespace ProiectMardaleBiancaElena
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbNumeU = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.aU = new System.Windows.Forms.Button();
            this.errP1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(332, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Utilizator";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbID.Location = new System.Drawing.Point(66, 74);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(112, 22);
            this.tbID.TabIndex = 5;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbID.Validating += new System.ComponentModel.CancelEventHandler(this.tbID_Validating);
            // 
            // tbNume
            // 
            this.tbNume.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbNume.Location = new System.Drawing.Point(34, 161);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(206, 22);
            this.tbNume.TabIndex = 6;
            this.tbNume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNumeU
            // 
            this.tbNumeU.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbNumeU.Location = new System.Drawing.Point(34, 241);
            this.tbNumeU.Name = "tbNumeU";
            this.tbNumeU.Size = new System.Drawing.Size(206, 22);
            this.tbNumeU.TabIndex = 7;
            this.tbNumeU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbParola
            // 
            this.tbParola.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbParola.Location = new System.Drawing.Point(34, 313);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(211, 22);
            this.tbParola.TabIndex = 8;
            this.tbParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aU
            // 
            this.aU.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aU.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aU.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.aU.Location = new System.Drawing.Point(618, 186);
            this.aU.Name = "aU";
            this.aU.Size = new System.Drawing.Size(148, 45);
            this.aU.TabIndex = 10;
            this.aU.Text = "Adaugare";
            this.aU.UseVisualStyleBackColor = true;
            // 
            // errP1
            // 
            this.errP1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 92);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Image = global::ProiectMardaleBiancaElena.Properties.Resources.icons8_show_password_30;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(88, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "          Parola";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Image = global::ProiectMardaleBiancaElena.Properties.Resources.icons8_username_48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(40, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "                Nume de utilizator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Image = global::ProiectMardaleBiancaElena.Properties.Resources.icons8_autograph_26;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(40, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "          Numele dumneavoastra";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Image = global::ProiectMardaleBiancaElena.Properties.Resources.icons8_security_pass_24;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "         ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(900, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aU);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbNumeU);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Utilizator";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button aU;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.TextBox tbNumeU;
        public System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errP1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}