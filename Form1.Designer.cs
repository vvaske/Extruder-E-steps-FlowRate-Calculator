
namespace ExtruderEstepsCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtmeasured = new System.Windows.Forms.TextBox();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtreal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtcurrent
            // 
            this.txtcurrent.ForeColor = System.Drawing.Color.Gray;
            this.txtcurrent.Location = new System.Drawing.Point(124, 131);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(212, 20);
            this.txtcurrent.TabIndex = 1;
            this.txtcurrent.Text = "Please enter the STEPS/MM of your printer";
            this.txtcurrent.Enter += new System.EventHandler(this.CurrentRemoveText);
            this.txtcurrent.Leave += new System.EventHandler(this.CurrentAddText);
            // 
            // txtmeasured
            // 
            this.txtmeasured.ForeColor = System.Drawing.Color.Gray;
            this.txtmeasured.Location = new System.Drawing.Point(124, 177);
            this.txtmeasured.Name = "txtmeasured";
            this.txtmeasured.Size = new System.Drawing.Size(212, 20);
            this.txtmeasured.TabIndex = 1;
            this.txtmeasured.Text = "Please enter the measured length";
            this.txtmeasured.Enter += new System.EventHandler(this.MeasuredRemoveText);
            this.txtmeasured.Leave += new System.EventHandler(this.MeasuredAddText);
            // 
            // txtnew
            // 
            this.txtnew.ForeColor = System.Drawing.Color.Gray;
            this.txtnew.Location = new System.Drawing.Point(124, 203);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(212, 20);
            this.txtnew.TabIndex = 1;
            this.txtnew.Text = "New steps of your printer";
            this.txtnew.Enter += new System.EventHandler(this.NewRemoveText);
            this.txtnew.Leave += new System.EventHandler(this.NewAddText);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current STEPS/MM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Measured length :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "New steps :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate New E-Steps/MM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtreal
            // 
            this.txtreal.ForeColor = System.Drawing.Color.Gray;
            this.txtreal.Location = new System.Drawing.Point(124, 154);
            this.txtreal.Name = "txtreal";
            this.txtreal.Size = new System.Drawing.Size(212, 20);
            this.txtreal.TabIndex = 1;
            this.txtreal.Text = "Real length";
            this.txtreal.Enter += new System.EventHandler(this.RealRemoveText);
            this.txtreal.Leave += new System.EventHandler(this.RealAddText);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Real length :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtreal);
            this.Controls.Add(this.txtnew);
            this.Controls.Add(this.txtmeasured);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 304);
            this.MinimumSize = new System.Drawing.Size(365, 304);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extruder E-steps Calculator by VASKE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtmeasured;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtreal;
        private System.Windows.Forms.Label label5;
    }
}

