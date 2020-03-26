namespace SomerenUI
{
    partial class EditGuide
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
            this.lbl_SelectAct = new System.Windows.Forms.Label();
            this.lbl_OldValue = new System.Windows.Forms.Label();
            this.lbl_OldAct = new System.Windows.Forms.Label();
            this.cmb_NewActivity = new System.Windows.Forms.ComboBox();
            this.lbl_NewValue = new System.Windows.Forms.Label();
            this.btn_EditGuide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SelectAct
            // 
            this.lbl_SelectAct.AutoSize = true;
            this.lbl_SelectAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectAct.Location = new System.Drawing.Point(44, 42);
            this.lbl_SelectAct.Name = "lbl_SelectAct";
            this.lbl_SelectAct.Size = new System.Drawing.Size(249, 24);
            this.lbl_SelectAct.TabIndex = 0;
            this.lbl_SelectAct.Text = "Select the new activity below";
            // 
            // lbl_OldValue
            // 
            this.lbl_OldValue.AutoSize = true;
            this.lbl_OldValue.Location = new System.Drawing.Point(45, 95);
            this.lbl_OldValue.Name = "lbl_OldValue";
            this.lbl_OldValue.Size = new System.Drawing.Size(78, 17);
            this.lbl_OldValue.TabIndex = 1;
            this.lbl_OldValue.Text = "Old Activity";
            // 
            // lbl_OldAct
            // 
            this.lbl_OldAct.AutoSize = true;
            this.lbl_OldAct.Location = new System.Drawing.Point(45, 125);
            this.lbl_OldAct.Name = "lbl_OldAct";
            this.lbl_OldAct.Size = new System.Drawing.Size(46, 17);
            this.lbl_OldAct.TabIndex = 2;
            this.lbl_OldAct.Text = "label2";
            // 
            // cmb_NewActivity
            // 
            this.cmb_NewActivity.FormattingEnabled = true;
            this.cmb_NewActivity.Location = new System.Drawing.Point(279, 122);
            this.cmb_NewActivity.Name = "cmb_NewActivity";
            this.cmb_NewActivity.Size = new System.Drawing.Size(164, 24);
            this.cmb_NewActivity.TabIndex = 3;
            // 
            // lbl_NewValue
            // 
            this.lbl_NewValue.AutoSize = true;
            this.lbl_NewValue.Location = new System.Drawing.Point(276, 95);
            this.lbl_NewValue.Name = "lbl_NewValue";
            this.lbl_NewValue.Size = new System.Drawing.Size(82, 17);
            this.lbl_NewValue.TabIndex = 4;
            this.lbl_NewValue.Text = "New activity";
            // 
            // btn_EditGuide
            // 
            this.btn_EditGuide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_EditGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditGuide.Location = new System.Drawing.Point(137, 182);
            this.btn_EditGuide.Name = "btn_EditGuide";
            this.btn_EditGuide.Size = new System.Drawing.Size(221, 39);
            this.btn_EditGuide.TabIndex = 5;
            this.btn_EditGuide.Text = "Edit Guide";
            this.btn_EditGuide.UseVisualStyleBackColor = false;
            this.btn_EditGuide.Click += new System.EventHandler(this.btn_EditGuide_Click);
            // 
            // EditGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 252);
            this.Controls.Add(this.btn_EditGuide);
            this.Controls.Add(this.lbl_NewValue);
            this.Controls.Add(this.cmb_NewActivity);
            this.Controls.Add(this.lbl_OldAct);
            this.Controls.Add(this.lbl_OldValue);
            this.Controls.Add(this.lbl_SelectAct);
            this.Name = "EditGuide";
            this.Text = "EditGuide";
            this.Load += new System.EventHandler(this.EditGuide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SelectAct;
        private System.Windows.Forms.Label lbl_OldValue;
        private System.Windows.Forms.Label lbl_OldAct;
        private System.Windows.Forms.ComboBox cmb_NewActivity;
        private System.Windows.Forms.Label lbl_NewValue;
        private System.Windows.Forms.Button btn_EditGuide;
    }
}