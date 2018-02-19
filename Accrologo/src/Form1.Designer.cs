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
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_run = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_repeate = new System.Windows.Forms.Button();
            this.button_forward = new System.Windows.Forms.Button();
            this.button_one = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.draw_box = new System.Windows.Forms.PictureBox();
            this.m_button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.draw_box)).BeginInit();
            this.SuspendLayout();
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
            this.button_run.Location = new System.Drawing.Point(470, 673);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 3;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.test_run);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(286, 614);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 53);
            this.button10.TabIndex = 16;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(217, 732);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 53);
            this.button11.TabIndex = 17;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(286, 673);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(53, 53);
            this.button12.TabIndex = 18;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(217, 673);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(53, 53);
            this.button13.TabIndex = 19;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(148, 673);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(53, 53);
            this.button14.TabIndex = 20;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button_right
            // 
            this.button_right.Image = global::Accrologo.Properties.Resources.Platypus;
            this.button_right.Location = new System.Drawing.Point(79, 673);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(53, 53);
            this.button_right.TabIndex = 15;
            this.button_right.UseVisualStyleBackColor = true;
            // 
            // button_repeate
            // 
            this.button_repeate.Image = global::Accrologo.Properties.Resources.alpaga;
            this.button_repeate.Location = new System.Drawing.Point(79, 732);
            this.button_repeate.Name = "button_repeate";
            this.button_repeate.Size = new System.Drawing.Size(53, 53);
            this.button_repeate.TabIndex = 14;
            this.button_repeate.UseVisualStyleBackColor = true;
            // 
            // button_forward
            // 
            this.button_forward.Image = global::Accrologo.Properties.Resources.dolphin;
            this.button_forward.Location = new System.Drawing.Point(79, 555);
            this.button_forward.Name = "button_forward";
            this.button_forward.Size = new System.Drawing.Size(53, 53);
            this.button_forward.TabIndex = 13;
            this.button_forward.UseVisualStyleBackColor = true;
            this.button_forward.Click += new System.EventHandler(this.forwardClick);
            // 
            // button_one
            // 
            this.button_one.Image = global::Accrologo.Properties.Resources.un;
            this.button_one.Location = new System.Drawing.Point(148, 555);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(53, 53);
            this.button_one.TabIndex = 12;
            this.button_one.UseVisualStyleBackColor = true;
            // 
            // button_two
            // 
            this.button_two.Image = global::Accrologo.Properties.Resources.deux;
            this.button_two.Location = new System.Drawing.Point(217, 555);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(53, 53);
            this.button_two.TabIndex = 11;
            this.button_two.UseVisualStyleBackColor = true;
            // 
            // button_three
            // 
            this.button_three.Image = global::Accrologo.Properties.Resources.trois;
            this.button_three.Location = new System.Drawing.Point(286, 555);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(53, 53);
            this.button_three.TabIndex = 10;
            this.button_three.UseVisualStyleBackColor = true;
            // 
            // button_four
            // 
            this.button_four.Image = global::Accrologo.Properties.Resources.quatre;
            this.button_four.Location = new System.Drawing.Point(148, 614);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(53, 53);
            this.button_four.TabIndex = 9;
            this.button_four.UseVisualStyleBackColor = true;
            // 
            // button_five
            // 
            this.button_five.Image = global::Accrologo.Properties.Resources.cinq;
            this.button_five.Location = new System.Drawing.Point(217, 614);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(53, 53);
            this.button_five.TabIndex = 8;
            this.button_five.UseVisualStyleBackColor = true;
            // 
            // button_left
            // 
            this.button_left.Image = global::Accrologo.Properties.Resources.pandicorn;
            this.button_left.Location = new System.Drawing.Point(79, 614);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(53, 53);
            this.button_left.TabIndex = 7;
            this.button_left.UseVisualStyleBackColor = true;
            // 
            // draw_box
            // 
            this.draw_box.Location = new System.Drawing.Point(342, 81);
            this.draw_box.Name = "draw_box";
            this.draw_box.Size = new System.Drawing.Size(621, 453);
            this.draw_box.TabIndex = 1;
            this.draw_box.TabStop = false;
            // 
            // m_button1
            // 
            this.m_button1.Image = global::Accrologo.Properties.Resources.discord1;
            this.m_button1.Location = new System.Drawing.Point(773, 643);
            this.m_button1.Name = "m_button1";
            this.m_button1.Size = new System.Drawing.Size(53, 53);
            this.m_button1.TabIndex = 0;
            this.m_button1.UseVisualStyleBackColor = true;
            this.m_button1.Click += new System.EventHandler(this.button1_clic);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 832);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_repeate);
            this.Controls.Add(this.button_forward);
            this.Controls.Add(this.button_one);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_four);
            this.Controls.Add(this.button_five);
            this.Controls.Add(this.button_left);
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
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_five;
        private System.Windows.Forms.Button button_four;
        private System.Windows.Forms.Button button_three;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Button button_forward;
        private System.Windows.Forms.Button button_repeate;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

