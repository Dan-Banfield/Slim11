namespace Slim11.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fixTelemetryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.restoreTelemetryButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restoreDiagnosticDataButton = new System.Windows.Forms.Button();
            this.fixDiagnosticDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.restoreAutomaticUpdatesButton = new System.Windows.Forms.Button();
            this.fixAutomaticUpdatesButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(26, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(69, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Slim11";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(27, 70);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 379);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Privacy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fixTelemetryButton
            // 
            this.fixTelemetryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixTelemetryButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.fixTelemetryButton.Location = new System.Drawing.Point(16, 35);
            this.fixTelemetryButton.Name = "fixTelemetryButton";
            this.fixTelemetryButton.Size = new System.Drawing.Size(78, 31);
            this.fixTelemetryButton.TabIndex = 3;
            this.fixTelemetryButton.TabStop = false;
            this.fixTelemetryButton.Text = "Fix";
            this.fixTelemetryButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.restoreTelemetryButton);
            this.groupBox1.Controls.Add(this.fixTelemetryButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telemetry";
            this.toolTip.SetToolTip(this.groupBox1, "Your computer periodically collects technical information and sends it to Microso" +
        "ft.\r\nDisabling this process can speed up your computer and conserve valuable res" +
        "ources.");
            // 
            // restoreTelemetryButton
            // 
            this.restoreTelemetryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreTelemetryButton.ForeColor = System.Drawing.Color.Crimson;
            this.restoreTelemetryButton.Location = new System.Drawing.Point(100, 35);
            this.restoreTelemetryButton.Name = "restoreTelemetryButton";
            this.restoreTelemetryButton.Size = new System.Drawing.Size(78, 31);
            this.restoreTelemetryButton.TabIndex = 4;
            this.restoreTelemetryButton.TabStop = false;
            this.restoreTelemetryButton.Text = "Restore";
            this.restoreTelemetryButton.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.restoreDiagnosticDataButton);
            this.groupBox2.Controls.Add(this.fixDiagnosticDataButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnostic Data";
            this.toolTip.SetToolTip(this.groupBox2, "By fixing, you\'ll disable tailored experiences that provide tips and recommendati" +
        "ons based on your diagnostic data.\r\nSome users refer to this as telemetry or eve" +
        "n spying");
            // 
            // restoreDiagnosticDataButton
            // 
            this.restoreDiagnosticDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreDiagnosticDataButton.ForeColor = System.Drawing.Color.Crimson;
            this.restoreDiagnosticDataButton.Location = new System.Drawing.Point(100, 35);
            this.restoreDiagnosticDataButton.Name = "restoreDiagnosticDataButton";
            this.restoreDiagnosticDataButton.Size = new System.Drawing.Size(78, 31);
            this.restoreDiagnosticDataButton.TabIndex = 4;
            this.restoreDiagnosticDataButton.TabStop = false;
            this.restoreDiagnosticDataButton.Text = "Restore";
            this.restoreDiagnosticDataButton.UseVisualStyleBackColor = true;
            // 
            // fixDiagnosticDataButton
            // 
            this.fixDiagnosticDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixDiagnosticDataButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.fixDiagnosticDataButton.Location = new System.Drawing.Point(16, 35);
            this.fixDiagnosticDataButton.Name = "fixDiagnosticDataButton";
            this.fixDiagnosticDataButton.Size = new System.Drawing.Size(78, 31);
            this.fixDiagnosticDataButton.TabIndex = 3;
            this.fixDiagnosticDataButton.TabStop = false;
            this.fixDiagnosticDataButton.Text = "Fix";
            this.fixDiagnosticDataButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(573, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "*This program is designed for Windows 11.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.restoreAutomaticUpdatesButton);
            this.groupBox3.Controls.Add(this.fixAutomaticUpdatesButton);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 84);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automatic Updates";
            this.toolTip.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // restoreAutomaticUpdatesButton
            // 
            this.restoreAutomaticUpdatesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreAutomaticUpdatesButton.ForeColor = System.Drawing.Color.Crimson;
            this.restoreAutomaticUpdatesButton.Location = new System.Drawing.Point(100, 35);
            this.restoreAutomaticUpdatesButton.Name = "restoreAutomaticUpdatesButton";
            this.restoreAutomaticUpdatesButton.Size = new System.Drawing.Size(78, 31);
            this.restoreAutomaticUpdatesButton.TabIndex = 4;
            this.restoreAutomaticUpdatesButton.TabStop = false;
            this.restoreAutomaticUpdatesButton.Text = "Restore";
            this.restoreAutomaticUpdatesButton.UseVisualStyleBackColor = true;
            // 
            // fixAutomaticUpdatesButton
            // 
            this.fixAutomaticUpdatesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixAutomaticUpdatesButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.fixAutomaticUpdatesButton.Location = new System.Drawing.Point(16, 35);
            this.fixAutomaticUpdatesButton.Name = "fixAutomaticUpdatesButton";
            this.fixAutomaticUpdatesButton.Size = new System.Drawing.Size(78, 31);
            this.fixAutomaticUpdatesButton.TabIndex = 3;
            this.fixAutomaticUpdatesButton.TabStop = false;
            this.fixAutomaticUpdatesButton.Text = "Fix";
            this.fixAutomaticUpdatesButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(293, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 84);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Location Tracking";
            this.toolTip.SetToolTip(this.groupBox4, "Wherever you are, Windows 11 is tracking your location.");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(100, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(16, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 31);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Fix";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slim11";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button fixTelemetryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button restoreTelemetryButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button restoreDiagnosticDataButton;
        private System.Windows.Forms.Button fixDiagnosticDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button restoreAutomaticUpdatesButton;
        private System.Windows.Forms.Button fixAutomaticUpdatesButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

