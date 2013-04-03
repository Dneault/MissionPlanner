﻿using ArdupilotMega.Controls;

namespace ArdupilotMega.GCSViews.ConfigurationView
{
    partial class ConfigAccelerometerCalibrationQuad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigAccelerometerCalibrationQuad));
            this.radioButton_Plus = new System.Windows.Forms.RadioButton();
            this.radioButton_X = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Accel_user = new System.Windows.Forms.Label();
            this.BUT_calib_accell = new ArdupilotMega.Controls.MyButton();
            this.lineSeparator2 = new ArdupilotMega.Controls.LineSeparator();
            this.lineSeparator3 = new ArdupilotMega.Controls.LineSeparator();
            this.pictureBoxPlus = new ArdupilotMega.Controls.PictureBoxWithPseudoOpacity();
            this.pictureBoxX = new ArdupilotMega.Controls.PictureBoxWithPseudoOpacity();
            this.BUT_levelac2 = new ArdupilotMega.Controls.MyButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_Trap = new System.Windows.Forms.RadioButton();
            this.pictureBoxTrap = new ArdupilotMega.Controls.PictureBoxWithPseudoOpacity();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrap)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_Plus
            // 
            resources.ApplyResources(this.radioButton_Plus, "radioButton_Plus");
            this.radioButton_Plus.Name = "radioButton_Plus";
            this.radioButton_Plus.TabStop = true;
            this.radioButton_Plus.UseVisualStyleBackColor = true;
            this.radioButton_Plus.CheckedChanged += new System.EventHandler(this.radioButton_Plus_CheckedChanged);
            // 
            // radioButton_X
            // 
            resources.ApplyResources(this.radioButton_X, "radioButton_X");
            this.radioButton_X.Name = "radioButton_X";
            this.radioButton_X.TabStop = true;
            this.radioButton_X.UseVisualStyleBackColor = true;
            this.radioButton_X.CheckedChanged += new System.EventHandler(this.radioButton_X_CheckedChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbl_Accel_user
            // 
            resources.ApplyResources(this.lbl_Accel_user, "lbl_Accel_user");
            this.lbl_Accel_user.Name = "lbl_Accel_user";
            // 
            // BUT_calib_accell
            // 
            resources.ApplyResources(this.BUT_calib_accell, "BUT_calib_accell");
            this.BUT_calib_accell.Name = "BUT_calib_accell";
            this.BUT_calib_accell.UseVisualStyleBackColor = true;
            this.BUT_calib_accell.Click += new System.EventHandler(this.BUT_calib_accell_Click);
            // 
            // lineSeparator2
            // 
            resources.ApplyResources(this.lineSeparator2, "lineSeparator2");
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Opacity1 = 0.6F;
            this.lineSeparator2.Opacity2 = 0.7F;
            this.lineSeparator2.Opacity3 = 0.1F;
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.Black;
            this.lineSeparator2.SecondaryColor = System.Drawing.Color.Gainsboro;
            // 
            // lineSeparator3
            // 
            resources.ApplyResources(this.lineSeparator3, "lineSeparator3");
            this.lineSeparator3.Name = "lineSeparator3";
            this.lineSeparator3.Opacity1 = 0.6F;
            this.lineSeparator3.Opacity2 = 0.7F;
            this.lineSeparator3.Opacity3 = 0.1F;
            this.lineSeparator3.PrimaryColor = System.Drawing.Color.Black;
            this.lineSeparator3.SecondaryColor = System.Drawing.Color.Gainsboro;
            // 
            // pictureBoxPlus
            // 
            this.pictureBoxPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlus.Image = global::ArdupilotMega.Properties.Resources.frames_plus;
            resources.ApplyResources(this.pictureBoxPlus, "pictureBoxPlus");
            this.pictureBoxPlus.Name = "pictureBoxPlus";
            this.pictureBoxPlus.TabStop = false;
            this.pictureBoxPlus.Click += new System.EventHandler(this.pictureBoxPlus_Click);
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxX.Image = global::ArdupilotMega.Properties.Resources.frames_x;
            resources.ApplyResources(this.pictureBoxX, "pictureBoxX");
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.TabStop = false;
            this.pictureBoxX.Click += new System.EventHandler(this.pictureBoxX_Click);
            // 
            // BUT_levelac2
            // 
            resources.ApplyResources(this.BUT_levelac2, "BUT_levelac2");
            this.BUT_levelac2.Name = "BUT_levelac2";
            this.BUT_levelac2.UseVisualStyleBackColor = true;
            this.BUT_levelac2.Click += new System.EventHandler(this.BUT_levelac2_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // radioButton_Trap
            // 
            resources.ApplyResources(this.radioButton_Trap, "radioButton_Trap");
            this.radioButton_Trap.Name = "radioButton_Trap";
            this.radioButton_Trap.TabStop = true;
            this.radioButton_Trap.UseVisualStyleBackColor = true;
            this.radioButton_Trap.CheckedChanged += new System.EventHandler(this.radioButton_Trap_CheckedChanged);
            // 
            // pictureBoxTrap
            // 
            this.pictureBoxTrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTrap.Image = global::ArdupilotMega.Properties.Resources.new_3DR_04;
            resources.ApplyResources(this.pictureBoxTrap, "pictureBoxTrap");
            this.pictureBoxTrap.Name = "pictureBoxTrap";
            this.pictureBoxTrap.TabStop = false;
            this.pictureBoxTrap.Click += new System.EventHandler(this.pictureBoxTrap_Click);
            // 
            // ConfigAccelerometerCalibrationQuad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton_Trap);
            this.Controls.Add(this.pictureBoxTrap);
            this.Controls.Add(this.lbl_Accel_user);
            this.Controls.Add(this.BUT_calib_accell);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.lineSeparator3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton_X);
            this.Controls.Add(this.radioButton_Plus);
            this.Controls.Add(this.pictureBoxPlus);
            this.Controls.Add(this.pictureBoxX);
            this.Controls.Add(this.BUT_levelac2);
            this.Name = "ConfigAccelerometerCalibrationQuad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxWithPseudoOpacity pictureBoxX;
        private ArdupilotMega.Controls.MyButton BUT_levelac2;
        private PictureBoxWithPseudoOpacity pictureBoxPlus;
        private System.Windows.Forms.RadioButton radioButton_Plus;
        private System.Windows.Forms.RadioButton radioButton_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LineSeparator lineSeparator3;
        private LineSeparator lineSeparator2;
        private MyButton BUT_calib_accell;
        private System.Windows.Forms.Label lbl_Accel_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_Trap;
        private PictureBoxWithPseudoOpacity pictureBoxTrap;
    }
}