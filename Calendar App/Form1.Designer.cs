namespace Calendar_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtPerson = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblStartTime = new Label();
            lblEndDate = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            lblPerson = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(112, 73);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(204, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(112, 102);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(204, 23);
            txtDescription.TabIndex = 3;
            // 
            // txtPerson
            // 
            txtPerson.Location = new Point(112, 134);
            txtPerson.Name = "txtPerson";
            txtPerson.Size = new Size(204, 23);
            txtPerson.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(112, 15);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(112, 44);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(204, 23);
            dtpEndDate.TabIndex = 6;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(15, 21);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(64, 15);
            lblStartTime.TabIndex = 7;
            lblStartTime.Text = "Start Time:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(22, 44);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(57, 15);
            lblEndDate.TabIndex = 8;
            lblEndDate.Text = "End Date:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(46, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 15);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 105);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(33, 134);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(46, 15);
            lblPerson.TabIndex = 11;
            lblPerson.Text = "Person:";
            lblPerson.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(141, 160);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 23);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Create Event";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lblPerson);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartTime);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txtPerson);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtPerson;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblStartTime;
        private Label lblEndDate;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblPerson;
        private Button btnSubmit;
    }
}
