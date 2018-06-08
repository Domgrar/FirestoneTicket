namespace FirestoneTicketing
{
    partial class TicketViewerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTechName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOriginalTech = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.labelIsProject = new System.Windows.Forms.Label();
            this.labelTicketID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Viewer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(15, 283);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(627, 129);
            this.richTextBoxDesc.TabIndex = 1;
            this.richTextBoxDesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tech Working on This Ticket";
            // 
            // textBoxTechName
            // 
            this.textBoxTechName.Location = new System.Drawing.Point(24, 82);
            this.textBoxTechName.Name = "textBoxTechName";
            this.textBoxTechName.ReadOnly = true;
            this.textBoxTechName.Size = new System.Drawing.Size(171, 20);
            this.textBoxTechName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comment:";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(12, 431);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(627, 129);
            this.richTextBoxComment.TabIndex = 5;
            this.richTextBoxComment.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Original Technician";
            // 
            // textBoxOriginalTech
            // 
            this.textBoxOriginalTech.Location = new System.Drawing.Point(24, 137);
            this.textBoxOriginalTech.Name = "textBoxOriginalTech";
            this.textBoxOriginalTech.ReadOnly = true;
            this.textBoxOriginalTech.Size = new System.Drawing.Size(171, 20);
            this.textBoxOriginalTech.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(24, 226);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 13);
            this.label.TabIndex = 10;
            this.label.Text = "IsProject? : ";
            // 
            // labelIsProject
            // 
            this.labelIsProject.AutoSize = true;
            this.labelIsProject.Location = new System.Drawing.Point(94, 226);
            this.labelIsProject.Name = "labelIsProject";
            this.labelIsProject.Size = new System.Drawing.Size(21, 13);
            this.labelIsProject.TabIndex = 11;
            this.labelIsProject.Text = "No";
            // 
            // labelTicketID
            // 
            this.labelTicketID.AutoSize = true;
            this.labelTicketID.Location = new System.Drawing.Point(255, 65);
            this.labelTicketID.Name = "labelTicketID";
            this.labelTicketID.Size = new System.Drawing.Size(0, 13);
            this.labelTicketID.TabIndex = 12;
            // 
            // TicketViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 589);
            this.Controls.Add(this.labelTicketID);
            this.Controls.Add(this.labelIsProject);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxOriginalTech);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTechName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.label1);
            this.Name = "TicketViewerForm";
            this.Text = "TicketViewerForm";
            this.Load += new System.EventHandler(this.TicketViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTechName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOriginalTech;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelIsProject;
        private System.Windows.Forms.Label labelTicketID;
    }
}