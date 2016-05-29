namespace LevelSiege
{
    partial class JUEGO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JUEGO));
            this.d = new System.Windows.Forms.Panel();
            this.paneljohn = new System.Windows.Forms.Panel();
            this.barma = new System.Windows.Forms.Button();
            this.tiempod = new System.Windows.Forms.Timer(this.components);
            this.tiempom = new System.Windows.Forms.Timer(this.components);
            this.crear = new System.Windows.Forms.Timer(this.components);
            this.compcoli = new System.Windows.Forms.Timer(this.components);
            this.pbjohn = new System.Windows.Forms.ProgressBar();
            this.d.SuspendLayout();
            this.SuspendLayout();
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("d.BackgroundImage")));
            this.d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d.Controls.Add(this.pbjohn);
            this.d.Controls.Add(this.paneljohn);
            this.d.Controls.Add(this.barma);
            this.d.Location = new System.Drawing.Point(2, 0);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(977, 381);
            this.d.TabIndex = 1;
            this.d.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.d.MouseMove += new System.Windows.Forms.MouseEventHandler(this.d_MouseMove);
            // 
            // paneljohn
            // 
            this.paneljohn.BackColor = System.Drawing.Color.Transparent;
            this.paneljohn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneljohn.BackgroundImage")));
            this.paneljohn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneljohn.Location = new System.Drawing.Point(892, 139);
            this.paneljohn.Name = "paneljohn";
            this.paneljohn.Size = new System.Drawing.Size(69, 64);
            this.paneljohn.TabIndex = 1;
            // 
            // barma
            // 
            this.barma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barma.Location = new System.Drawing.Point(273, 313);
            this.barma.Name = "barma";
            this.barma.Size = new System.Drawing.Size(75, 23);
            this.barma.TabIndex = 0;
            this.barma.Text = "SHOT";
            this.barma.UseVisualStyleBackColor = true;
            this.barma.Click += new System.EventHandler(this.barma_Click);
            // 
            // tiempod
            // 
            this.tiempod.Tick += new System.EventHandler(this.tiempod_Tick);
            // 
            // tiempom
            // 
            this.tiempom.Enabled = true;
            this.tiempom.Tick += new System.EventHandler(this.tiempom_Tick);
            // 
            // crear
            // 
            this.crear.Enabled = true;
            this.crear.Tick += new System.EventHandler(this.crear_Tick);
            // 
            // compcoli
            // 
            this.compcoli.Enabled = true;
            this.compcoli.Tick += new System.EventHandler(this.compcoli_Tick);
            // 
            // pbjohn
            // 
            this.pbjohn.Location = new System.Drawing.Point(892, 123);
            this.pbjohn.Name = "pbjohn";
            this.pbjohn.Size = new System.Drawing.Size(69, 10);
            this.pbjohn.TabIndex = 2;
            this.pbjohn.Value = 100;
            // 
            // JUEGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 383);
            this.Controls.Add(this.d);
            this.DoubleBuffered = true;
            this.Name = "JUEGO";
            this.Text = "JUEGO";
            this.d.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel d;
        private System.Windows.Forms.Button barma;
        private System.Windows.Forms.Timer tiempod;
        private System.Windows.Forms.Timer tiempom;
        private System.Windows.Forms.Timer crear;
        private System.Windows.Forms.Timer compcoli;
        private System.Windows.Forms.Panel paneljohn;
        private System.Windows.Forms.ProgressBar pbjohn;
    }
}