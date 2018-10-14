namespace Contacts_App
{
    partial class EditEntry
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
            this.accpt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.RichTextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accpt
            // 
            this.accpt.Location = new System.Drawing.Point(214, 352);
            this.accpt.Name = "accpt";
            this.accpt.Size = new System.Drawing.Size(116, 28);
            this.accpt.TabIndex = 29;
            this.accpt.Text = "Accept";
            this.accpt.UseVisualStyleBackColor = true;
            this.accpt.Click += new System.EventHandler(this.accpt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Notes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Phone #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(12, 172);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(318, 155);
            this.note.TabIndex = 21;
            this.note.Text = "";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 124);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(317, 20);
            this.email.TabIndex = 20;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(244, 80);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(85, 20);
            this.phone.TabIndex = 19;
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(97, 80);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(140, 20);
            this.addr.TabIndex = 18;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(12, 81);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(78, 20);
            this.dob.TabIndex = 17;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(167, 37);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(162, 20);
            this.lName.TabIndex = 16;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(12, 37);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(148, 20);
            this.fName.TabIndex = 15;
            // 
            // EditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 398);
            this.Controls.Add(this.accpt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Name = "EditEntry";
            this.Text = "EditEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accpt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox fName;
    }
}