namespace Rh
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnusu = new System.Windows.Forms.Button();
            this.btnsetor = new System.Windows.Forms.Button();
            this.btnper = new System.Windows.Forms.Button();
            this.btnfun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tfun = new System.Windows.Forms.ToolStripMenuItem();
            this.tpe = new System.Windows.Forms.ToolStripMenuItem();
            this.tu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts = new System.Windows.Forms.ToolStripMenuItem();
            this.tSair = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.groupBox1.BackgroundImage = global::Rh.Properties.Resources.fundo_login;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnusu);
            this.groupBox1.Controls.Add(this.btnsetor);
            this.groupBox1.Controls.Add(this.btnper);
            this.groupBox1.Controls.Add(this.btnfun);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(5, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnusu
            // 
            this.btnusu.Location = new System.Drawing.Point(6, 150);
            this.btnusu.Name = "btnusu";
            this.btnusu.Size = new System.Drawing.Size(125, 41);
            this.btnusu.TabIndex = 2;
            this.btnusu.Text = "Usuario";
            this.btnusu.UseVisualStyleBackColor = true;
            this.btnusu.Click += new System.EventHandler(this.btnusu_Click);
            // 
            // btnsetor
            // 
            this.btnsetor.Location = new System.Drawing.Point(7, 207);
            this.btnsetor.Name = "btnsetor";
            this.btnsetor.Size = new System.Drawing.Size(124, 42);
            this.btnsetor.TabIndex = 0;
            this.btnsetor.Text = "Setor";
            this.btnsetor.UseVisualStyleBackColor = true;
            // 
            // btnper
            // 
            this.btnper.Location = new System.Drawing.Point(6, 82);
            this.btnper.Name = "btnper";
            this.btnper.Size = new System.Drawing.Size(125, 44);
            this.btnper.TabIndex = 1;
            this.btnper.Text = "Perfil";
            this.btnper.UseVisualStyleBackColor = true;
            // 
            // btnfun
            // 
            this.btnfun.Location = new System.Drawing.Point(7, 19);
            this.btnfun.Name = "btnfun";
            this.btnfun.Size = new System.Drawing.Size(125, 44);
            this.btnfun.TabIndex = 0;
            this.btnfun.Text = "funcionarios";
            this.btnfun.UseVisualStyleBackColor = true;
            this.btnfun.Click += new System.EventHandler(this.btnfun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Rh.Properties.Resources.fundo_login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 418);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tfun,
            this.tpe,
            this.tu,
            this.ts});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Cadastrar";
            // 
            // tfun
            // 
            this.tfun.Name = "tfun";
            this.tfun.Size = new System.Drawing.Size(152, 22);
            this.tfun.Text = "Funcionarios";
            this.tfun.Click += new System.EventHandler(this.tfun_Click);
            // 
            // tpe
            // 
            this.tpe.Name = "tpe";
            this.tpe.Size = new System.Drawing.Size(152, 22);
            this.tpe.Text = "Perfil";
            // 
            // tu
            // 
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(152, 22);
            this.tu.Text = "Usuario";
            this.tu.Click += new System.EventHandler(this.tu_Click);
            // 
            // ts
            // 
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(152, 22);
            this.ts.Text = "Setor";
            // 
            // tSair
            // 
            this.tSair.Name = "tSair";
            this.tSair.Size = new System.Drawing.Size(38, 20);
            this.tSair.Text = "Sair";
            this.tSair.Click += new System.EventHandler(this.tSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfun;
        private System.Windows.Forms.Button btnusu;
        private System.Windows.Forms.Button btnper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsetor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tfun;
        private System.Windows.Forms.ToolStripMenuItem tpe;
        private System.Windows.Forms.ToolStripMenuItem tu;
        private System.Windows.Forms.ToolStripMenuItem ts;
        private System.Windows.Forms.ToolStripMenuItem tSair;
    }
}