﻿namespace FileSenderGUI
{
    partial class Window
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.sendTab = new System.Windows.Forms.TabPage();
            this.send_Status = new System.Windows.Forms.Label();
            this.send_sendButton = new System.Windows.Forms.Button();
            this.send_fileSelectButton = new System.Windows.Forms.Button();
            this.receiveTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.settings_listenPortInput_label = new System.Windows.Forms.Label();
            this.settings_serverPortInput_label = new System.Windows.Forms.Label();
            this.settings_serverAddressInput_label = new System.Windows.Forms.Label();
            this.settings_listenPortInput = new System.Windows.Forms.NumericUpDown();
            this.settings_serverPortInput = new System.Windows.Forms.NumericUpDown();
            this.settings_serverAddressInput = new System.Windows.Forms.TextBox();
            this.settings_saveSettingsButton = new System.Windows.Forms.Button();
            this.send_fileSelect = new System.Windows.Forms.OpenFileDialog();
            this.Tabs.SuspendLayout();
            this.sendTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_listenPortInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_serverPortInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.sendTab);
            this.Tabs.Controls.Add(this.receiveTab);
            this.Tabs.Controls.Add(this.settingsTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(462, 417);
            this.Tabs.TabIndex = 0;
            // 
            // sendTab
            // 
            this.sendTab.BackColor = System.Drawing.SystemColors.Control;
            this.sendTab.Controls.Add(this.send_Status);
            this.sendTab.Controls.Add(this.send_sendButton);
            this.sendTab.Controls.Add(this.send_fileSelectButton);
            this.sendTab.Location = new System.Drawing.Point(4, 29);
            this.sendTab.Name = "sendTab";
            this.sendTab.Padding = new System.Windows.Forms.Padding(3);
            this.sendTab.Size = new System.Drawing.Size(454, 384);
            this.sendTab.TabIndex = 0;
            this.sendTab.Text = "Send";
            // 
            // send_Status
            // 
            this.send_Status.AutoSize = true;
            this.send_Status.Location = new System.Drawing.Point(30, 162);
            this.send_Status.Name = "send_Status";
            this.send_Status.Size = new System.Drawing.Size(121, 20);
            this.send_Status.TabIndex = 2;
            this.send_Status.Text = "Waiting for file...";
            this.send_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // send_sendButton
            // 
            this.send_sendButton.Location = new System.Drawing.Point(185, 22);
            this.send_sendButton.Name = "send_sendButton";
            this.send_sendButton.Size = new System.Drawing.Size(92, 71);
            this.send_sendButton.TabIndex = 1;
            this.send_sendButton.Text = "Send";
            this.send_sendButton.UseVisualStyleBackColor = true;
            this.send_sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // send_fileSelectButton
            // 
            this.send_fileSelectButton.Location = new System.Drawing.Point(83, 22);
            this.send_fileSelectButton.Name = "send_fileSelectButton";
            this.send_fileSelectButton.Size = new System.Drawing.Size(96, 71);
            this.send_fileSelectButton.TabIndex = 0;
            this.send_fileSelectButton.Text = "Select File";
            this.send_fileSelectButton.UseVisualStyleBackColor = true;
            this.send_fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // receiveTab
            // 
            this.receiveTab.BackColor = System.Drawing.SystemColors.Control;
            this.receiveTab.Location = new System.Drawing.Point(4, 29);
            this.receiveTab.Name = "receiveTab";
            this.receiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.receiveTab.Size = new System.Drawing.Size(454, 384);
            this.receiveTab.TabIndex = 1;
            this.receiveTab.Text = "Receive";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.settingsTab.Controls.Add(this.settings_listenPortInput_label);
            this.settingsTab.Controls.Add(this.settings_serverPortInput_label);
            this.settingsTab.Controls.Add(this.settings_serverAddressInput_label);
            this.settingsTab.Controls.Add(this.settings_listenPortInput);
            this.settingsTab.Controls.Add(this.settings_serverPortInput);
            this.settingsTab.Controls.Add(this.settings_serverAddressInput);
            this.settingsTab.Controls.Add(this.settings_saveSettingsButton);
            this.settingsTab.Location = new System.Drawing.Point(4, 29);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(454, 384);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            // 
            // settings_listenPortInput_label
            // 
            this.settings_listenPortInput_label.AutoSize = true;
            this.settings_listenPortInput_label.Location = new System.Drawing.Point(178, 108);
            this.settings_listenPortInput_label.Name = "settings_listenPortInput_label";
            this.settings_listenPortInput_label.Size = new System.Drawing.Size(99, 20);
            this.settings_listenPortInput_label.TabIndex = 6;
            this.settings_listenPortInput_label.Text = "Receive Port";
            // 
            // settings_serverPortInput_label
            // 
            this.settings_serverPortInput_label.AutoSize = true;
            this.settings_serverPortInput_label.Location = new System.Drawing.Point(178, 46);
            this.settings_serverPortInput_label.Name = "settings_serverPortInput_label";
            this.settings_serverPortInput_label.Size = new System.Drawing.Size(88, 20);
            this.settings_serverPortInput_label.TabIndex = 5;
            this.settings_serverPortInput_label.Text = "Server Port";
            // 
            // settings_serverAddressInput_label
            // 
            this.settings_serverAddressInput_label.AutoSize = true;
            this.settings_serverAddressInput_label.Location = new System.Drawing.Point(178, 15);
            this.settings_serverAddressInput_label.Name = "settings_serverAddressInput_label";
            this.settings_serverAddressInput_label.Size = new System.Drawing.Size(118, 20);
            this.settings_serverAddressInput_label.TabIndex = 4;
            this.settings_serverAddressInput_label.Text = "Server Address";
            // 
            // settings_listenPortInput
            // 
            this.settings_listenPortInput.Location = new System.Drawing.Point(8, 106);
            this.settings_listenPortInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.settings_listenPortInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.settings_listenPortInput.Name = "settings_listenPortInput";
            this.settings_listenPortInput.Size = new System.Drawing.Size(164, 26);
            this.settings_listenPortInput.TabIndex = 3;
            this.settings_listenPortInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // settings_serverPortInput
            // 
            this.settings_serverPortInput.Location = new System.Drawing.Point(8, 44);
            this.settings_serverPortInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.settings_serverPortInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.settings_serverPortInput.Name = "settings_serverPortInput";
            this.settings_serverPortInput.Size = new System.Drawing.Size(164, 26);
            this.settings_serverPortInput.TabIndex = 2;
            this.settings_serverPortInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // settings_serverAddressInput
            // 
            this.settings_serverAddressInput.Location = new System.Drawing.Point(8, 12);
            this.settings_serverAddressInput.Name = "settings_serverAddressInput";
            this.settings_serverAddressInput.Size = new System.Drawing.Size(164, 26);
            this.settings_serverAddressInput.TabIndex = 1;
            // 
            // settings_saveSettingsButton
            // 
            this.settings_saveSettingsButton.Location = new System.Drawing.Point(371, 6);
            this.settings_saveSettingsButton.Name = "settings_saveSettingsButton";
            this.settings_saveSettingsButton.Size = new System.Drawing.Size(75, 32);
            this.settings_saveSettingsButton.TabIndex = 0;
            this.settings_saveSettingsButton.Text = "Save";
            this.settings_saveSettingsButton.UseVisualStyleBackColor = true;
            this.settings_saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // send_fileSelect
            // 
            this.send_fileSelect.ReadOnlyChecked = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 417);
            this.Controls.Add(this.Tabs);
            this.MinimumSize = new System.Drawing.Size(300, 240);
            this.Name = "Window";
            this.Text = "File Sender";
            this.Tabs.ResumeLayout(false);
            this.sendTab.ResumeLayout(false);
            this.sendTab.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_listenPortInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_serverPortInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage sendTab;
        private System.Windows.Forms.TabPage receiveTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.OpenFileDialog send_fileSelect;
        private System.Windows.Forms.Button send_sendButton;
        private System.Windows.Forms.Button send_fileSelectButton;
        private System.Windows.Forms.NumericUpDown settings_listenPortInput;
        private System.Windows.Forms.NumericUpDown settings_serverPortInput;
        private System.Windows.Forms.TextBox settings_serverAddressInput;
        private System.Windows.Forms.Button settings_saveSettingsButton;
        private System.Windows.Forms.Label settings_listenPortInput_label;
        private System.Windows.Forms.Label settings_serverPortInput_label;
        private System.Windows.Forms.Label settings_serverAddressInput_label;
        private System.Windows.Forms.Label send_Status;
    }
}

