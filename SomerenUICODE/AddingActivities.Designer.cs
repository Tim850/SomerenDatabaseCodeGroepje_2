namespace SomerenUI
{
    partial class AddingActivities
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
            this.txt_ActID = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_NumGuides = new System.Windows.Forms.TextBox();
            this.txt_NumPart = new System.Windows.Forms.TextBox();
            this.txt_ActDate = new System.Windows.Forms.TextBox();
            this.lbl_ActID = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_NumGuides = new System.Windows.Forms.Label();
            this.lbl_NumParticipant = new System.Windows.Forms.Label();
            this.lbl_ActDate = new System.Windows.Forms.Label();
            this.lbl_AddAct = new System.Windows.Forms.Label();
            this.btn_AddAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ActID
            // 
            this.txt_ActID.Location = new System.Drawing.Point(315, 72);
            this.txt_ActID.Name = "txt_ActID";
            this.txt_ActID.Size = new System.Drawing.Size(150, 22);
            this.txt_ActID.TabIndex = 0;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(315, 117);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(150, 22);
            this.txt_description.TabIndex = 1;
            // 
            // txt_NumGuides
            // 
            this.txt_NumGuides.Location = new System.Drawing.Point(315, 164);
            this.txt_NumGuides.Name = "txt_NumGuides";
            this.txt_NumGuides.Size = new System.Drawing.Size(150, 22);
            this.txt_NumGuides.TabIndex = 2;
            // 
            // txt_NumPart
            // 
            this.txt_NumPart.Location = new System.Drawing.Point(315, 207);
            this.txt_NumPart.Name = "txt_NumPart";
            this.txt_NumPart.Size = new System.Drawing.Size(150, 22);
            this.txt_NumPart.TabIndex = 3;
            // 
            // txt_ActDate
            // 
            this.txt_ActDate.Location = new System.Drawing.Point(315, 250);
            this.txt_ActDate.Name = "txt_ActDate";
            this.txt_ActDate.Size = new System.Drawing.Size(150, 22);
            this.txt_ActDate.TabIndex = 4;
            // 
            // lbl_ActID
            // 
            this.lbl_ActID.AutoSize = true;
            this.lbl_ActID.Location = new System.Drawing.Point(37, 75);
            this.lbl_ActID.Name = "lbl_ActID";
            this.lbl_ActID.Size = new System.Drawing.Size(69, 17);
            this.lbl_ActID.TabIndex = 5;
            this.lbl_ActID.Text = "Activity ID";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(37, 120);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(125, 17);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Activity description";
            // 
            // lbl_NumGuides
            // 
            this.lbl_NumGuides.AutoSize = true;
            this.lbl_NumGuides.Location = new System.Drawing.Point(37, 167);
            this.lbl_NumGuides.Name = "lbl_NumGuides";
            this.lbl_NumGuides.Size = new System.Drawing.Size(120, 17);
            this.lbl_NumGuides.TabIndex = 7;
            this.lbl_NumGuides.Text = "Number of guides";
            // 
            // lbl_NumParticipant
            // 
            this.lbl_NumParticipant.AutoSize = true;
            this.lbl_NumParticipant.Location = new System.Drawing.Point(37, 210);
            this.lbl_NumParticipant.Name = "lbl_NumParticipant";
            this.lbl_NumParticipant.Size = new System.Drawing.Size(151, 17);
            this.lbl_NumParticipant.TabIndex = 8;
            this.lbl_NumParticipant.Text = "Number of participants";
            // 
            // lbl_ActDate
            // 
            this.lbl_ActDate.AutoSize = true;
            this.lbl_ActDate.Location = new System.Drawing.Point(37, 253);
            this.lbl_ActDate.Name = "lbl_ActDate";
            this.lbl_ActDate.Size = new System.Drawing.Size(125, 17);
            this.lbl_ActDate.TabIndex = 9;
            this.lbl_ActDate.Text = "Date of the activity";
            // 
            // lbl_AddAct
            // 
            this.lbl_AddAct.AutoSize = true;
            this.lbl_AddAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddAct.Location = new System.Drawing.Point(36, 21);
            this.lbl_AddAct.Name = "lbl_AddAct";
            this.lbl_AddAct.Size = new System.Drawing.Size(461, 24);
            this.lbl_AddAct.TabIndex = 10;
            this.lbl_AddAct.Text = "Fill in the information below to add a new activity";
            // 
            // btn_AddAct
            // 
            this.btn_AddAct.Location = new System.Drawing.Point(164, 304);
            this.btn_AddAct.Name = "btn_AddAct";
            this.btn_AddAct.Size = new System.Drawing.Size(174, 38);
            this.btn_AddAct.TabIndex = 11;
            this.btn_AddAct.Text = "Add activity";
            this.btn_AddAct.UseVisualStyleBackColor = true;
            this.btn_AddAct.Click += new System.EventHandler(this.Btn_AddAct_Click);
            // 
            // AddingActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 372);
            this.Controls.Add(this.btn_AddAct);
            this.Controls.Add(this.lbl_AddAct);
            this.Controls.Add(this.lbl_ActDate);
            this.Controls.Add(this.lbl_NumParticipant);
            this.Controls.Add(this.lbl_NumGuides);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_ActID);
            this.Controls.Add(this.txt_ActDate);
            this.Controls.Add(this.txt_NumPart);
            this.Controls.Add(this.txt_NumGuides);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_ActID);
            this.Name = "AddingActivities";
            this.Text = "AddingActivities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ActID;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_NumGuides;
        private System.Windows.Forms.TextBox txt_NumPart;
        private System.Windows.Forms.TextBox txt_ActDate;
        private System.Windows.Forms.Label lbl_ActID;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_NumGuides;
        private System.Windows.Forms.Label lbl_NumParticipant;
        private System.Windows.Forms.Label lbl_ActDate;
        private System.Windows.Forms.Label lbl_AddAct;
        private System.Windows.Forms.Button btn_AddAct;
    }
}