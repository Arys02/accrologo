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
            this.button_clear = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.button_rightbrace = new System.Windows.Forms.Button();
            this.button_leftbrace = new System.Windows.Forms.Button();
            this.button_seven = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.draw_box)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoScroll = true;
            this.layoutPanel.Location = new System.Drawing.Point(30, 81);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(478, 453);
            this.layoutPanel.TabIndex = 2;
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(571, 649);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(100, 62);
            this.button_run.TabIndex = 3;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.test_run);
            // 
            // button_clear
            // 
            this.button_clear.Image = global::Accrologo.Properties.Resources.clear;
            this.button_clear.Location = new System.Drawing.Point(355, 555);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(53, 53);
            this.button_clear.TabIndex = 24;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_return
            // 
            this.button_return.Image = global::Accrologo.Properties.Resources._return;
            this.button_return.Location = new System.Drawing.Point(355, 614);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(53, 53);
            this.button_return.TabIndex = 23;
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.Button_return_Click);
            // 
            // button_rightbrace
            // 
            this.button_rightbrace.Image = global::Accrologo.Properties.Resources.rightbrace;
            this.button_rightbrace.Location = new System.Drawing.Point(286, 732);
            this.button_rightbrace.Name = "button_rightbrace";
            this.button_rightbrace.Size = new System.Drawing.Size(53, 53);
            this.button_rightbrace.TabIndex = 22;
            this.button_rightbrace.UseVisualStyleBackColor = true;
            this.button_rightbrace.Click += new System.EventHandler(this.button_rightbrace_Click);
            // 
            // button_leftbrace
            // 
            this.button_leftbrace.Image = global::Accrologo.Properties.Resources.leftbrace;
            this.button_leftbrace.Location = new System.Drawing.Point(148, 732);
            this.button_leftbrace.Name = "button_leftbrace";
            this.button_leftbrace.Size = new System.Drawing.Size(53, 53);
            this.button_leftbrace.TabIndex = 21;
            this.button_leftbrace.UseVisualStyleBackColor = true;
            this.button_leftbrace.Click += new System.EventHandler(this.button_leftbrace_Click);
            // 
            // button_seven
            // 
            this.button_seven.Image = global::Accrologo.Properties.Resources.sept;
            this.button_seven.Location = new System.Drawing.Point(148, 673);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(53, 53);
            this.button_seven.TabIndex = 20;
            this.button_seven.UseVisualStyleBackColor = true;
            this.button_seven.Click += new System.EventHandler(this.button_seven_Click);
            // 
            // button_eight
            // 
            this.button_eight.Image = global::Accrologo.Properties.Resources.huit;
            this.button_eight.Location = new System.Drawing.Point(217, 673);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(53, 53);
            this.button_eight.TabIndex = 19;
            this.button_eight.UseVisualStyleBackColor = true;
            this.button_eight.Click += new System.EventHandler(this.button_eight_Click);
            // 
            // button_nine
            // 
            this.button_nine.Image = global::Accrologo.Properties.Resources.neuf;
            this.button_nine.Location = new System.Drawing.Point(286, 673);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(53, 53);
            this.button_nine.TabIndex = 18;
            this.button_nine.UseVisualStyleBackColor = true;
            this.button_nine.Click += new System.EventHandler(this.button_nine_Click);
            // 
            // button_zero
            // 
            this.button_zero.Image = global::Accrologo.Properties.Resources.zero;
            this.button_zero.Location = new System.Drawing.Point(217, 732);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(53, 53);
            this.button_zero.TabIndex = 17;
            this.button_zero.UseVisualStyleBackColor = true;
            this.button_zero.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_six
            // 
            this.button_six.Image = global::Accrologo.Properties.Resources.six;
            this.button_six.Location = new System.Drawing.Point(286, 614);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(53, 53);
            this.button_six.TabIndex = 16;
            this.button_six.UseVisualStyleBackColor = true;
            this.button_six.Click += new System.EventHandler(this.button_six_Click);
            // 
            // button_right
            // 
            this.button_right.Image = global::Accrologo.Properties.Resources.Platypus;
            this.button_right.Location = new System.Drawing.Point(79, 673);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(53, 53);
            this.button_right.TabIndex = 15;
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_repeate
            // 
            this.button_repeate.Image = global::Accrologo.Properties.Resources.alpaga;
            this.button_repeate.Location = new System.Drawing.Point(79, 732);
            this.button_repeate.Name = "button_repeate";
            this.button_repeate.Size = new System.Drawing.Size(53, 53);
            this.button_repeate.TabIndex = 14;
            this.button_repeate.UseVisualStyleBackColor = true;
            this.button_repeate.Click += new System.EventHandler(this.button_repeate_Click);
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
            this.button_one.Click += new System.EventHandler(this.button_one_Click);
            // 
            // button_two
            // 
            this.button_two.Image = global::Accrologo.Properties.Resources.deux;
            this.button_two.Location = new System.Drawing.Point(217, 555);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(53, 53);
            this.button_two.TabIndex = 11;
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Click += new System.EventHandler(this.button_two_Click);
            // 
            // button_three
            // 
            this.button_three.Image = global::Accrologo.Properties.Resources.trois;
            this.button_three.Location = new System.Drawing.Point(286, 555);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(53, 53);
            this.button_three.TabIndex = 10;
            this.button_three.UseVisualStyleBackColor = true;
            this.button_three.Click += new System.EventHandler(this.button_three_Click);
            // 
            // button_four
            // 
            this.button_four.Image = global::Accrologo.Properties.Resources.quatre;
            this.button_four.Location = new System.Drawing.Point(148, 614);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(53, 53);
            this.button_four.TabIndex = 9;
            this.button_four.UseVisualStyleBackColor = true;
            this.button_four.Click += new System.EventHandler(this.button_four_Click);
            // 
            // button_five
            // 
            this.button_five.Image = global::Accrologo.Properties.Resources.cinq;
            this.button_five.Location = new System.Drawing.Point(217, 614);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(53, 53);
            this.button_five.TabIndex = 8;
            this.button_five.UseVisualStyleBackColor = true;
            this.button_five.Click += new System.EventHandler(this.button_five_Click);
            // 
            // button_left
            // 
            this.button_left.Image = global::Accrologo.Properties.Resources.pandicorn;
            this.button_left.Location = new System.Drawing.Point(79, 614);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(53, 53);
            this.button_left.TabIndex = 7;
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // draw_box
            // 
            this.draw_box.BackColor = System.Drawing.SystemColors.Window;
            this.draw_box.Location = new System.Drawing.Point(615, 81);
            this.draw_box.Name = "draw_box";
            this.draw_box.Size = new System.Drawing.Size(694, 497);
            this.draw_box.TabIndex = 1;
            this.draw_box.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 832);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_rightbrace);
            this.Controls.Add(this.button_leftbrace);
            this.Controls.Add(this.button_seven);
            this.Controls.Add(this.button_eight);
            this.Controls.Add(this.button_nine);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.button_six);
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
            this.Name = "Form1";
            this.Text = "Accrologo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.draw_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button button_six;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button button_nine;
        private System.Windows.Forms.Button button_eight;
        private System.Windows.Forms.Button button_seven;
        private System.Windows.Forms.Button button_leftbrace;
        private System.Windows.Forms.Button button_rightbrace;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_clear;
    }
}

