namespace Accrologo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_button1 = new System.Windows.Forms.Button();
            this.draw_box = new System.Windows.Forms.PictureBox();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.draw_box)).BeginInit();
            this.SuspendLayout();
            // 
            // m_button1
            // 
            this.m_button1.Image = global::Accrologo.Properties.Resources.discord1;
            this.m_button1.Location = new System.Drawing.Point(40, 570);
            this.m_button1.Name = "m_button1";
            this.m_button1.Size = new System.Drawing.Size(53, 53);
            this.m_button1.TabIndex = 0;
            this.m_button1.UseVisualStyleBackColor = true;
            this.m_button1.Click += new System.EventHandler(this.button1_clic);
            // 
            // draw_box
            // 
            this.draw_box.Location = new System.Drawing.Point(330, 81);
            this.draw_box.Name = "draw_box";
            this.draw_box.Size = new System.Drawing.Size(621, 453);
            this.draw_box.TabIndex = 1;
            this.draw_box.TabStop = false;
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoScroll = true;
            this.layoutPanel.Location = new System.Drawing.Point(30, 81);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(280, 453);
            this.layoutPanel.TabIndex = 2;
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(524, 599);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 3;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.test_run);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 832);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.draw_box);
            this.Controls.Add(this.m_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.draw_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_button1;
        private System.Windows.Forms.PictureBox draw_box;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Button button_run;
    }
}

