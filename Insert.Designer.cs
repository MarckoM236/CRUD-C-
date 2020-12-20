namespace CRUD
{
    partial class Insert
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
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CONTACT = new System.Windows.Forms.Label();
            this.txb_lastname = new System.Windows.Forms.TextBox();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(249, 86);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(100, 20);
            this.txb_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // CONTACT
            // 
            this.CONTACT.AutoSize = true;
            this.CONTACT.Location = new System.Drawing.Point(266, 24);
            this.CONTACT.Name = "CONTACT";
            this.CONTACT.Size = new System.Drawing.Size(58, 13);
            this.CONTACT.TabIndex = 6;
            this.CONTACT.Text = "CONTACT";
            // 
            // txb_lastname
            // 
            this.txb_lastname.Location = new System.Drawing.Point(249, 119);
            this.txb_lastname.Name = "txb_lastname";
            this.txb_lastname.Size = new System.Drawing.Size(100, 20);
            this.txb_lastname.TabIndex = 7;
            // 
            // txb_address
            // 
            this.txb_address.Location = new System.Drawing.Point(249, 157);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(100, 20);
            this.txb_address.TabIndex = 8;
            // 
            // txb_phone
            // 
            this.txb_phone.Location = new System.Drawing.Point(249, 195);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(100, 20);
            this.txb_phone.TabIndex = 9;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(249, 229);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(100, 20);
            this.txb_email.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(144, 293);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(336, 293);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.txb_lastname);
            this.Controls.Add(this.CONTACT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_name);
            this.Name = "Insert";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CONTACT;
        private System.Windows.Forms.TextBox txb_lastname;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}