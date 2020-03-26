namespace SomerenUI
{
    partial class EditActivity
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
            this.btn_EditAct = new System.Windows.Forms.Button();
            this.lbl_AddAct = new System.Windows.Forms.Label();
            this.lbl_ActDate = new System.Windows.Forms.Label();
            this.lbl_NumParticipant = new System.Windows.Forms.Label();
            this.lbl_NumGuides = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_ActDate = new System.Windows.Forms.TextBox();
            this.txt_NumPart = new System.Windows.Forms.TextBox();
            this.txt_NumGuides = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_InfoInput = new System.Windows.Forms.Label();
            this.lbl_OldDescr = new System.Windows.Forms.Label();
            this.lbl_OldNumGuides = new System.Windows.Forms.Label();
            this.lbl_OldNumPart = new System.Windows.Forms.Label();
            this.lbl_OldActDate = new System.Windows.Forms.Label();
            this.lbl_OldValues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EditAct
            // 
            this.btn_EditAct.Location = new System.Drawing.Point(217, 332);
            this.btn_EditAct.Name = "btn_EditAct";
            this.btn_EditAct.Size = new System.Drawing.Size(174, 38);
            this.btn_EditAct.TabIndex = 23;
            this.btn_EditAct.Text = "Edit activity";
            this.btn_EditAct.UseVisualStyleBackColor = true;
            this.btn_EditAct.Click += new System.EventHandler(this.Btn_EditAct_Click);
            // 
            // lbl_AddAct
            // 
            this.lbl_AddAct.AutoSize = true;
            this.lbl_AddAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddAct.Location = new System.Drawing.Point(40, 22);
            this.lbl_AddAct.Name = "lbl_AddAct";
            this.lbl_AddAct.Size = new System.Drawing.Size(427, 24);
            this.lbl_AddAct.TabIndex = 22;
            this.lbl_AddAct.Text = "Fill in the information below to edit an activity";
            // 
            // lbl_ActDate
            // 
            this.lbl_ActDate.AutoSize = true;
            this.lbl_ActDate.Location = new System.Drawing.Point(43, 268);
            this.lbl_ActDate.Name = "lbl_ActDate";
            this.lbl_ActDate.Size = new System.Drawing.Size(125, 17);
            this.lbl_ActDate.TabIndex = 21;
            this.lbl_ActDate.Text = "Date of the activity";
            // 
            // lbl_NumParticipant
            // 
            this.lbl_NumParticipant.AutoSize = true;
            this.lbl_NumParticipant.Location = new System.Drawing.Point(43, 225);
            this.lbl_NumParticipant.Name = "lbl_NumParticipant";
            this.lbl_NumParticipant.Size = new System.Drawing.Size(151, 17);
            this.lbl_NumParticipant.TabIndex = 20;
            this.lbl_NumParticipant.Text = "Number of participants";
            // 
            // lbl_NumGuides
            // 
            this.lbl_NumGuides.AutoSize = true;
            this.lbl_NumGuides.Location = new System.Drawing.Point(43, 182);
            this.lbl_NumGuides.Name = "lbl_NumGuides";
            this.lbl_NumGuides.Size = new System.Drawing.Size(120, 17);
            this.lbl_NumGuides.TabIndex = 19;
            this.lbl_NumGuides.Text = "Number of guides";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(41, 145);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(125, 17);
            this.lbl_description.TabIndex = 18;
            this.lbl_description.Text = "Activity description";
            // 
            // txt_ActDate
            // 
            this.txt_ActDate.Location = new System.Drawing.Point(446, 265);
            this.txt_ActDate.Name = "txt_ActDate";
            this.txt_ActDate.Size = new System.Drawing.Size(150, 22);
            this.txt_ActDate.TabIndex = 16;
            // 
            // txt_NumPart
            // 
            this.txt_NumPart.Location = new System.Drawing.Point(446, 225);
            this.txt_NumPart.Name = "txt_NumPart";
            this.txt_NumPart.Size = new System.Drawing.Size(150, 22);
            this.txt_NumPart.TabIndex = 15;
            // 
            // txt_NumGuides
            // 
            this.txt_NumGuides.Location = new System.Drawing.Point(446, 179);
            this.txt_NumGuides.Name = "txt_NumGuides";
            this.txt_NumGuides.Size = new System.Drawing.Size(150, 22);
            this.txt_NumGuides.TabIndex = 14;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(446, 142);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(150, 22);
            this.txt_description.TabIndex = 13;
            // 
            // lbl_InfoInput
            // 
            this.lbl_InfoInput.AutoSize = true;
            this.lbl_InfoInput.Location = new System.Drawing.Point(41, 55);
            this.lbl_InfoInput.Name = "lbl_InfoInput";
            this.lbl_InfoInput.Size = new System.Drawing.Size(475, 34);
            this.lbl_InfoInput.TabIndex = 24;
            this.lbl_InfoInput.Text = "Fill the textboxes with the NEW values\r\nYou can leave the textboxes empty if you " +
    "do not want to change that value\r\n";
            // 
            // lbl_OldDescr
            // 
            this.lbl_OldDescr.AutoSize = true;
            this.lbl_OldDescr.Location = new System.Drawing.Point(281, 145);
            this.lbl_OldDescr.Name = "lbl_OldDescr";
            this.lbl_OldDescr.Size = new System.Drawing.Size(46, 17);
            this.lbl_OldDescr.TabIndex = 26;
            this.lbl_OldDescr.Text = "label3";
            // 
            // lbl_OldNumGuides
            // 
            this.lbl_OldNumGuides.AutoSize = true;
            this.lbl_OldNumGuides.Location = new System.Drawing.Point(281, 182);
            this.lbl_OldNumGuides.Name = "lbl_OldNumGuides";
            this.lbl_OldNumGuides.Size = new System.Drawing.Size(46, 17);
            this.lbl_OldNumGuides.TabIndex = 27;
            this.lbl_OldNumGuides.Text = "label4";
            // 
            // lbl_OldNumPart
            // 
            this.lbl_OldNumPart.AutoSize = true;
            this.lbl_OldNumPart.Location = new System.Drawing.Point(281, 225);
            this.lbl_OldNumPart.Name = "lbl_OldNumPart";
            this.lbl_OldNumPart.Size = new System.Drawing.Size(46, 17);
            this.lbl_OldNumPart.TabIndex = 28;
            this.lbl_OldNumPart.Text = "label5";
            // 
            // lbl_OldActDate
            // 
            this.lbl_OldActDate.AutoSize = true;
            this.lbl_OldActDate.Location = new System.Drawing.Point(281, 268);
            this.lbl_OldActDate.Name = "lbl_OldActDate";
            this.lbl_OldActDate.Size = new System.Drawing.Size(46, 17);
            this.lbl_OldActDate.TabIndex = 29;
            this.lbl_OldActDate.Text = "label6";
            // 
            // lbl_OldValues
            // 
            this.lbl_OldValues.AutoSize = true;
            this.lbl_OldValues.Location = new System.Drawing.Point(266, 105);
            this.lbl_OldValues.Name = "lbl_OldValues";
            this.lbl_OldValues.Size = new System.Drawing.Size(77, 17);
            this.lbl_OldValues.TabIndex = 30;
            this.lbl_OldValues.Text = "Old Values";
            // 
            // EditActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 402);
            this.Controls.Add(this.lbl_OldValues);
            this.Controls.Add(this.lbl_OldActDate);
            this.Controls.Add(this.lbl_OldNumPart);
            this.Controls.Add(this.lbl_OldNumGuides);
            this.Controls.Add(this.lbl_OldDescr);
            this.Controls.Add(this.lbl_InfoInput);
            this.Controls.Add(this.btn_EditAct);
            this.Controls.Add(this.lbl_AddAct);
            this.Controls.Add(this.lbl_ActDate);
            this.Controls.Add(this.lbl_NumParticipant);
            this.Controls.Add(this.lbl_NumGuides);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_ActDate);
            this.Controls.Add(this.txt_NumPart);
            this.Controls.Add(this.txt_NumGuides);
            this.Controls.Add(this.txt_description);
            this.Name = "EditActivity";
            this.Text = "EditActivity";
            this.Load += new System.EventHandler(this.EditActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditAct;
        private System.Windows.Forms.Label lbl_AddAct;
        private System.Windows.Forms.Label lbl_ActDate;
        private System.Windows.Forms.Label lbl_NumParticipant;
        private System.Windows.Forms.Label lbl_NumGuides;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_ActDate;
        private System.Windows.Forms.TextBox txt_NumPart;
        private System.Windows.Forms.TextBox txt_NumGuides;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_InfoInput;
        private System.Windows.Forms.Label lbl_OldDescr;
        private System.Windows.Forms.Label lbl_OldNumGuides;
        private System.Windows.Forms.Label lbl_OldNumPart;
        private System.Windows.Forms.Label lbl_OldActDate;
        private System.Windows.Forms.Label lbl_OldValues;
    }
}