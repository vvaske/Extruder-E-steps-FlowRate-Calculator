
namespace ExtruderEstepsCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEsteps = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtreal = new System.Windows.Forms.TextBox();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.txtmeasured = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.btnFlowRate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnewflow = new System.Windows.Forms.TextBox();
            this.txtwallThickness = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtwall4b = new System.Windows.Forms.TextBox();
            this.txtwall4a = new System.Windows.Forms.TextBox();
            this.txtwall3b = new System.Windows.Forms.TextBox();
            this.txtwall3a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtwall2b = new System.Windows.Forms.TextBox();
            this.txtwall2a = new System.Windows.Forms.TextBox();
            this.txtwall1b = new System.Windows.Forms.TextBox();
            this.txtwall1a = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEsteps);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtreal);
            this.tabPage1.Controls.Add(this.txtnew);
            this.tabPage1.Controls.Add(this.txtmeasured);
            this.tabPage1.Controls.Add(this.txtcurrent);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "E-Steps";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEsteps
            // 
            this.btnEsteps.Location = new System.Drawing.Point(163, 269);
            this.btnEsteps.Name = "btnEsteps";
            this.btnEsteps.Size = new System.Drawing.Size(153, 32);
            this.btnEsteps.TabIndex = 11;
            this.btnEsteps.Text = "Calculate New E-Steps/MM";
            this.btnEsteps.UseVisualStyleBackColor = true;
            this.btnEsteps.Click += new System.EventHandler(this.btnEsteps_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "New steps :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Real length :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Measured length :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current STEPS/MM :";
            // 
            // txtreal
            // 
            this.txtreal.ForeColor = System.Drawing.Color.Gray;
            this.txtreal.Location = new System.Drawing.Point(136, 190);
            this.txtreal.Name = "txtreal";
            this.txtreal.Size = new System.Drawing.Size(212, 20);
            this.txtreal.TabIndex = 3;
            this.txtreal.Text = "Real length";
            this.txtreal.Enter += new System.EventHandler(this.RealRemoveText);
            this.txtreal.Leave += new System.EventHandler(this.RealAddText);
            // 
            // txtnew
            // 
            this.txtnew.ForeColor = System.Drawing.Color.Gray;
            this.txtnew.Location = new System.Drawing.Point(136, 239);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(212, 20);
            this.txtnew.TabIndex = 4;
            this.txtnew.Text = "New steps of your printer";
            this.txtnew.Enter += new System.EventHandler(this.NewRemoveText);
            this.txtnew.Leave += new System.EventHandler(this.NewAddText);
            // 
            // txtmeasured
            // 
            this.txtmeasured.ForeColor = System.Drawing.Color.Gray;
            this.txtmeasured.Location = new System.Drawing.Point(136, 213);
            this.txtmeasured.Name = "txtmeasured";
            this.txtmeasured.Size = new System.Drawing.Size(212, 20);
            this.txtmeasured.TabIndex = 5;
            this.txtmeasured.Text = "Please enter the measured length";
            this.txtmeasured.Enter += new System.EventHandler(this.MeasuredRemoveText);
            this.txtmeasured.Leave += new System.EventHandler(this.MeasuredAddText);
            // 
            // txtcurrent
            // 
            this.txtcurrent.ForeColor = System.Drawing.Color.Gray;
            this.txtcurrent.Location = new System.Drawing.Point(136, 167);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(212, 20);
            this.txtcurrent.TabIndex = 6;
            this.txtcurrent.Text = "Please enter the STEPS/MM of your printer";
            this.txtcurrent.Enter += new System.EventHandler(this.CurrentRemoveText);
            this.txtcurrent.Leave += new System.EventHandler(this.CurrentAddText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.btnFlowRate);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtnewflow);
            this.tabPage2.Controls.Add(this.txtwallThickness);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtwall4b);
            this.tabPage2.Controls.Add(this.txtwall4a);
            this.tabPage2.Controls.Add(this.txtwall3b);
            this.tabPage2.Controls.Add(this.txtwall3a);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtwall2b);
            this.tabPage2.Controls.Add(this.txtwall2a);
            this.tabPage2.Controls.Add(this.txtwall1b);
            this.tabPage2.Controls.Add(this.txtwall1a);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flow Rate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(413, 117);
            this.label17.TabIndex = 26;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // btnFlowRate
            // 
            this.btnFlowRate.Location = new System.Drawing.Point(183, 267);
            this.btnFlowRate.Name = "btnFlowRate";
            this.btnFlowRate.Size = new System.Drawing.Size(143, 34);
            this.btnFlowRate.TabIndex = 25;
            this.btnFlowRate.Text = "Calculate Flow Rate";
            this.btnFlowRate.UseVisualStyleBackColor = true;
            this.btnFlowRate.Click += new System.EventHandler(this.btnFlowRate_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "New Flow Rate";
            // 
            // txtnewflow
            // 
            this.txtnewflow.ForeColor = System.Drawing.Color.Gray;
            this.txtnewflow.Location = new System.Drawing.Point(100, 275);
            this.txtnewflow.Name = "txtnewflow";
            this.txtnewflow.Size = new System.Drawing.Size(77, 20);
            this.txtnewflow.TabIndex = 23;
            this.txtnewflow.Text = "New FlowRate";
            this.txtnewflow.Enter += new System.EventHandler(this.FlowRateRemoveText);
            this.txtnewflow.Leave += new System.EventHandler(this.FlowRateAddText);
            // 
            // txtwallThickness
            // 
            this.txtwallThickness.ForeColor = System.Drawing.Color.Gray;
            this.txtwallThickness.Location = new System.Drawing.Point(100, 233);
            this.txtwallThickness.Name = "txtwallThickness";
            this.txtwallThickness.Size = new System.Drawing.Size(118, 20);
            this.txtwallThickness.TabIndex = 22;
            this.txtwallThickness.Text = "Please enter thickness";
            this.txtwallThickness.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwallThickness.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Wall thickness";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Wall 4-B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Wall 3-B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Wall 4-A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(234, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Wall 3-A";
            // 
            // txtwall4b
            // 
            this.txtwall4b.ForeColor = System.Drawing.Color.Gray;
            this.txtwall4b.Location = new System.Drawing.Point(316, 207);
            this.txtwall4b.Name = "txtwall4b";
            this.txtwall4b.Size = new System.Drawing.Size(115, 20);
            this.txtwall4b.TabIndex = 13;
            this.txtwall4b.Text = "Please enter thickness";
            this.txtwall4b.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwall4b.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // txtwall4a
            // 
            this.txtwall4a.ForeColor = System.Drawing.Color.Gray;
            this.txtwall4a.Location = new System.Drawing.Point(316, 181);
            this.txtwall4a.Name = "txtwall4a";
            this.txtwall4a.Size = new System.Drawing.Size(115, 20);
            this.txtwall4a.TabIndex = 14;
            this.txtwall4a.Text = "Please enter thickness";
            this.txtwall4a.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwall4a.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // txtwall3b
            // 
            this.txtwall3b.ForeColor = System.Drawing.Color.Gray;
            this.txtwall3b.Location = new System.Drawing.Point(316, 155);
            this.txtwall3b.Name = "txtwall3b";
            this.txtwall3b.Size = new System.Drawing.Size(115, 20);
            this.txtwall3b.TabIndex = 15;
            this.txtwall3b.Text = "Please enter thickness";
            this.txtwall3b.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwall3b.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // txtwall3a
            // 
            this.txtwall3a.ForeColor = System.Drawing.Color.Gray;
            this.txtwall3a.Location = new System.Drawing.Point(316, 129);
            this.txtwall3a.Name = "txtwall3a";
            this.txtwall3a.Size = new System.Drawing.Size(115, 20);
            this.txtwall3a.TabIndex = 16;
            this.txtwall3a.Text = "Please enter thickness";
            this.txtwall3a.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwall3a.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wall 2-B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wall 1-B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Wall 2-A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Wall 1-A";
            // 
            // txtwall2b
            // 
            this.txtwall2b.ForeColor = System.Drawing.Color.Gray;
            this.txtwall2b.Location = new System.Drawing.Point(100, 207);
            this.txtwall2b.Name = "txtwall2b";
            this.txtwall2b.Size = new System.Drawing.Size(118, 20);
            this.txtwall2b.TabIndex = 5;
            this.txtwall2b.Text = "Please enter thickness";
            this.txtwall2b.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwall2b.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // txtwall2a
            // 
            this.txtwall2a.ForeColor = System.Drawing.Color.Gray;
            this.txtwall2a.Location = new System.Drawing.Point(100, 181);
            this.txtwall2a.Name = "txtwall2a";
            this.txtwall2a.Size = new System.Drawing.Size(118, 20);
            this.txtwall2a.TabIndex = 6;
            this.txtwall2a.Text = "Please enter thickness";
            this.txtwall2a.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwall2a.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // txtwall1b
            // 
            this.txtwall1b.ForeColor = System.Drawing.Color.Gray;
            this.txtwall1b.Location = new System.Drawing.Point(100, 155);
            this.txtwall1b.Name = "txtwall1b";
            this.txtwall1b.Size = new System.Drawing.Size(118, 20);
            this.txtwall1b.TabIndex = 7;
            this.txtwall1b.Text = "Please enter thickness";
            this.txtwall1b.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwall1b.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // txtwall1a
            // 
            this.txtwall1a.ForeColor = System.Drawing.Color.Gray;
            this.txtwall1a.Location = new System.Drawing.Point(100, 129);
            this.txtwall1a.Name = "txtwall1a";
            this.txtwall1a.Size = new System.Drawing.Size(118, 20);
            this.txtwall1a.TabIndex = 8;
            this.txtwall1a.Text = "Please enter thickness";
            this.txtwall1a.Enter += new System.EventHandler(this.RemoveWallsText);
            this.txtwall1a.Leave += new System.EventHandler(this.AddWallsText);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(489, 373);
            this.MinimumSize = new System.Drawing.Size(489, 373);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Steps and FlowRate Calculator by VASKE";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtreal;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.TextBox txtmeasured;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtwall2b;
        private System.Windows.Forms.TextBox txtwall2a;
        private System.Windows.Forms.TextBox txtwall1b;
        private System.Windows.Forms.TextBox txtwall1a;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtwall4b;
        private System.Windows.Forms.TextBox txtwall4a;
        private System.Windows.Forms.TextBox txtwall3b;
        private System.Windows.Forms.TextBox txtwall3a;
        private System.Windows.Forms.TextBox txtwallThickness;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnewflow;
        private System.Windows.Forms.Button btnFlowRate;
        private System.Windows.Forms.Button btnEsteps;
        private System.Windows.Forms.Label label17;
    }
}