﻿namespace GUI_Template_fix.Popup_Windows
{
    partial class GUITemplate_popupExceptionForm1
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTop = new System.Windows.Forms.Label();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxWarning = new FontAwesome.Sharp.IconPictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelStackTrace = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(2)))), ((int)(((byte)(29)))));
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Controls.Add(this.iconButtonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(834, 35);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(2)))), ((int)(((byte)(29)))));
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.Location = new System.Drawing.Point(55, 0);
            this.labelTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(736, 35);
            this.labelTop.TabIndex = 4;
            this.labelTop.Text = "Error while reading XML file from folder";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTop_MouseMove);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconSize = 16;
            this.iconButtonExit.Location = new System.Drawing.Point(799, 0);
            this.iconButtonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(35, 35);
            this.iconButtonExit.TabIndex = 5;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            this.iconButtonExit.MouseEnter += new System.EventHandler(this.iconButtonExit_MouseEnter);
            this.iconButtonExit.MouseLeave += new System.EventHandler(this.iconButtonExit_MouseLeave);
            // 
            // iconPictureBoxWarning
            // 
            this.iconPictureBoxWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.iconPictureBoxWarning.Cursor = System.Windows.Forms.Cursors.No;
            this.iconPictureBoxWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.iconPictureBoxWarning.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconPictureBoxWarning.IconColor = System.Drawing.Color.IndianRed;
            this.iconPictureBoxWarning.IconSize = 105;
            this.iconPictureBoxWarning.Location = new System.Drawing.Point(12, 47);
            this.iconPictureBoxWarning.Name = "iconPictureBoxWarning";
            this.iconPictureBoxWarning.Size = new System.Drawing.Size(110, 105);
            this.iconPictureBoxWarning.TabIndex = 3;
            this.iconPictureBoxWarning.TabStop = false;
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMessage.Location = new System.Drawing.Point(150, 64);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(542, 68);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "labelMessage";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStackTrace
            // 
            this.labelStackTrace.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStackTrace.Location = new System.Drawing.Point(34, 165);
            this.labelStackTrace.Name = "labelStackTrace";
            this.labelStackTrace.Size = new System.Drawing.Size(766, 166);
            this.labelStackTrace.TabIndex = 5;
            this.labelStackTrace.Text = " labelStackTrace";
            this.labelStackTrace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 5);
            this.panel1.TabIndex = 6;
            // 
            // GUITemplate_popupExceptionForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelStackTrace);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.iconPictureBoxWarning);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(850, 400);
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "GUITemplate_popupExceptionForm1";
            this.Text = "popupXMLReadException";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Label labelTop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxWarning;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelStackTrace;
        private System.Windows.Forms.Panel panel1;
    }
}