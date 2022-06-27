
namespace DBMS_Final
{
    partial class Travel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_Edit = new System.Windows.Forms.TextBox();
            this.TCostTb = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.ComboBox();
            this.Source = new System.Windows.Forms.ComboBox();
            this.TCode = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TravDate = new System.Windows.Forms.DateTimePicker();
            this.button_WOC4 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.TravelDGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ID_Edit);
            this.panel1.Controls.Add(this.TCostTb);
            this.panel1.Controls.Add(this.Destination);
            this.panel1.Controls.Add(this.Source);
            this.panel1.Controls.Add(this.TCode);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TravDate);
            this.panel1.Controls.Add(this.button_WOC4);
            this.panel1.Controls.Add(this.button_WOC2);
            this.panel1.Controls.Add(this.button_WOC1);
            this.panel1.Controls.Add(this.TravelDGV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 614);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Travel Code:";
            // 
            // ID_Edit
            // 
            this.ID_Edit.Location = new System.Drawing.Point(482, 198);
            this.ID_Edit.Name = "ID_Edit";
            this.ID_Edit.Size = new System.Drawing.Size(100, 20);
            this.ID_Edit.TabIndex = 22;
            // 
            // TCostTb
            // 
            this.TCostTb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCostTb.Location = new System.Drawing.Point(775, 132);
            this.TCostTb.Name = "TCostTb";
            this.TCostTb.Size = new System.Drawing.Size(190, 32);
            this.TCostTb.TabIndex = 21;
            // 
            // Destination
            // 
            this.Destination.FormattingEnabled = true;
            this.Destination.Items.AddRange(new object[] {
            "North Avenue",
            "Quezon Avenue",
            "GMA Kamuning",
            "Cubao",
            "Santolan-Annapolis",
            "Ortigas",
            "Ortigas",
            "Shaw Boulevard",
            "Boni",
            "Guadalupe",
            "Buendia",
            "Ayala",
            "Magallanes",
            "Taft Avenue"});
            this.Destination.Location = new System.Drawing.Point(591, 143);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(136, 21);
            this.Destination.TabIndex = 20;
            // 
            // Source
            // 
            this.Source.FormattingEnabled = true;
            this.Source.Items.AddRange(new object[] {
            "North Avenue",
            "Quezon Avenue",
            "GMA Kamuning",
            "Cubao",
            "Santolan-Annapolis",
            "Ortigas",
            "Ortigas",
            "Shaw Boulevard",
            "Boni",
            "Guadalupe",
            "Buendia",
            "Ayala",
            "Magallanes",
            "Taft Avenue"});
            this.Source.Location = new System.Drawing.Point(417, 143);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(136, 21);
            this.Source.TabIndex = 20;
            this.Source.SelectedIndexChanged += new System.EventHandler(this.Source_SelectedIndexChanged);
            // 
            // TCode
            // 
            this.TCode.FormattingEnabled = true;
            this.TCode.Location = new System.Drawing.Point(247, 143);
            this.TCode.Name = "TCode";
            this.TCode.Size = new System.Drawing.Size(136, 21);
            this.TCode.TabIndex = 20;
            this.TCode.SelectedIndexChanged += new System.EventHandler(this.TCode_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // TravDate
            // 
            this.TravDate.Location = new System.Drawing.Point(13, 134);
            this.TravDate.Name = "TravDate";
            this.TravDate.Size = new System.Drawing.Size(200, 20);
            this.TravDate.TabIndex = 18;
            // 
            // button_WOC4
            // 
            this.button_WOC4.BackColor = System.Drawing.Color.Green;
            this.button_WOC4.BorderColor = System.Drawing.Color.Black;
            this.button_WOC4.ButtonColor = System.Drawing.Color.Crimson;
            this.button_WOC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC4.Location = new System.Drawing.Point(775, 193);
            this.button_WOC4.Name = "button_WOC4";
            this.button_WOC4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC4.OnHoverButtonColor = System.Drawing.Color.White;
            this.button_WOC4.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC4.Size = new System.Drawing.Size(164, 36);
            this.button_WOC4.TabIndex = 14;
            this.button_WOC4.Text = "Reset";
            this.button_WOC4.TextColor = System.Drawing.Color.Black;
            this.button_WOC4.UseVisualStyleBackColor = false;
            this.button_WOC4.Click += new System.EventHandler(this.button_WOC4_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.Green;
            this.button_WOC2.BorderColor = System.Drawing.Color.Black;
            this.button_WOC2.ButtonColor = System.Drawing.Color.Crimson;
            this.button_WOC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC2.Location = new System.Drawing.Point(439, 218);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.White;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC2.Size = new System.Drawing.Size(164, 36);
            this.button_WOC2.TabIndex = 14;
            this.button_WOC2.Text = "Edit";
            this.button_WOC2.TextColor = System.Drawing.Color.Black;
            this.button_WOC2.UseVisualStyleBackColor = false;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Green;
            this.button_WOC1.BorderColor = System.Drawing.Color.Black;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Green;
            this.button_WOC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1.Location = new System.Drawing.Point(115, 193);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.White;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC1.Size = new System.Drawing.Size(164, 36);
            this.button_WOC1.TabIndex = 14;
            this.button_WOC1.Text = "Add";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // TravelDGV
            // 
            this.TravelDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TravelDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TravelDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TravelDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TravelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelDGV.Location = new System.Drawing.Point(13, 284);
            this.TravelDGV.Name = "TravelDGV";
            this.TravelDGV.Size = new System.Drawing.Size(977, 315);
            this.TravelDGV.TabIndex = 13;
            this.TravelDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TravelDGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Travels";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(771, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Travel Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Train Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Travel Master";
            // 
            // Travel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1005, 659);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Travel";
            this.Text = "Travel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC button_WOC4;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.DataGridView TravelDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TravDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Destination;
        private System.Windows.Forms.ComboBox Source;
        private System.Windows.Forms.ComboBox TCode;
        private System.Windows.Forms.TextBox TCostTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID_Edit;
    }
}