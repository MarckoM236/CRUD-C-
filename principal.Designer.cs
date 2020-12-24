namespace CRUD
{
    partial class principal
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
            this.CONTACT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CONTACT
            // 
            this.CONTACT.AutoSize = true;
            this.CONTACT.BackColor = System.Drawing.Color.Transparent;
            this.CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTACT.Location = new System.Drawing.Point(335, 35);
            this.CONTACT.Name = "CONTACT";
            this.CONTACT.Size = new System.Drawing.Size(120, 25);
            this.CONTACT.TabIndex = 7;
            this.CONTACT.Text = "CONTACT";
            // 
            // button1
            // 
            this.button1.Image = global::CRUD.Properties.Resources._new;
            this.button1.Location = new System.Drawing.Point(244, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 61);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(23, 95);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(742, 197);
            this.dgv.TabIndex = 9;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = global::CRUD.Properties.Resources.refresh;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_refresh.Location = new System.Drawing.Point(727, 53);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_refresh.Size = new System.Drawing.Size(38, 36);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // button2
            // 
            this.button2.Image = global::CRUD.Properties.Resources.update;
            this.button2.Location = new System.Drawing.Point(344, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 61);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CONTACT);
            this.Name = "principal";
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CONTACT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button button2;
    }
}