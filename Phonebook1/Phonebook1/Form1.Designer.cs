namespace Phonebook1
{
    partial class Form1
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
            this.imelabel = new System.Windows.Forms.Label();
            this.imetextBox = new System.Windows.Forms.TextBox();
            this.newbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.telefonlabel = new System.Windows.Forms.Label();
            this.telefontextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.prezimelabel = new System.Windows.Forms.Label();
            this.prezimetextBox = new System.Windows.Forms.TextBox();
            this.loadbutton = new System.Windows.Forms.Button();
            this.contactsDataGrid = new System.Windows.Forms.DataGridView();
            this.oiblabel = new System.Windows.Forms.Label();
            this.oibtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // imelabel
            // 
            this.imelabel.AutoSize = true;
            this.imelabel.Location = new System.Drawing.Point(45, 19);
            this.imelabel.Name = "imelabel";
            this.imelabel.Size = new System.Drawing.Size(24, 13);
            this.imelabel.TabIndex = 8;
            this.imelabel.Text = "Ime";
            // 
            // imetextBox
            // 
            this.imetextBox.Location = new System.Drawing.Point(123, 12);
            this.imetextBox.Name = "imetextBox";
            this.imetextBox.Size = new System.Drawing.Size(557, 20);
            this.imetextBox.TabIndex = 7;
            // 
            // newbutton
            // 
            this.newbutton.Location = new System.Drawing.Point(707, 19);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(75, 20);
            this.newbutton.TabIndex = 6;
            this.newbutton.Text = "New";
            this.newbutton.UseVisualStyleBackColor = true;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "E-mail";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(123, 90);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(557, 20);
            this.emailtextBox.TabIndex = 10;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(707, 97);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 20);
            this.deletebutton.TabIndex = 9;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // telefonlabel
            // 
            this.telefonlabel.AutoSize = true;
            this.telefonlabel.Location = new System.Drawing.Point(45, 71);
            this.telefonlabel.Name = "telefonlabel";
            this.telefonlabel.Size = new System.Drawing.Size(43, 13);
            this.telefonlabel.TabIndex = 14;
            this.telefonlabel.Text = "Telefon";
            // 
            // telefontextBox
            // 
            this.telefontextBox.Location = new System.Drawing.Point(123, 64);
            this.telefontextBox.Name = "telefontextBox";
            this.telefontextBox.Size = new System.Drawing.Size(557, 20);
            this.telefontextBox.TabIndex = 13;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(707, 71);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 20);
            this.savebutton.TabIndex = 12;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // prezimelabel
            // 
            this.prezimelabel.AutoSize = true;
            this.prezimelabel.Location = new System.Drawing.Point(45, 45);
            this.prezimelabel.Name = "prezimelabel";
            this.prezimelabel.Size = new System.Drawing.Size(44, 13);
            this.prezimelabel.TabIndex = 17;
            this.prezimelabel.Text = "Prezime";
            // 
            // prezimetextBox
            // 
            this.prezimetextBox.Location = new System.Drawing.Point(123, 38);
            this.prezimetextBox.Name = "prezimetextBox";
            this.prezimetextBox.Size = new System.Drawing.Size(557, 20);
            this.prezimetextBox.TabIndex = 16;
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(707, 45);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(75, 20);
            this.loadbutton.TabIndex = 15;
            this.loadbutton.Text = "Load";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // contactsDataGrid
            // 
            this.contactsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGrid.Location = new System.Drawing.Point(13, 142);
            this.contactsDataGrid.Name = "contactsDataGrid";
            this.contactsDataGrid.Size = new System.Drawing.Size(769, 296);
            this.contactsDataGrid.TabIndex = 18;
            this.contactsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // oiblabel
            // 
            this.oiblabel.AutoSize = true;
            this.oiblabel.Location = new System.Drawing.Point(45, 123);
            this.oiblabel.Name = "oiblabel";
            this.oiblabel.Size = new System.Drawing.Size(25, 13);
            this.oiblabel.TabIndex = 21;
            this.oiblabel.Text = "OIB";
            // 
            // oibtextBox
            // 
            this.oibtextBox.Location = new System.Drawing.Point(123, 116);
            this.oibtextBox.Name = "oibtextBox";
            this.oibtextBox.Size = new System.Drawing.Size(557, 20);
            this.oibtextBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oiblabel);
            this.Controls.Add(this.oibtextBox);
            this.Controls.Add(this.contactsDataGrid);
            this.Controls.Add(this.prezimelabel);
            this.Controls.Add(this.prezimetextBox);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.telefonlabel);
            this.Controls.Add(this.telefontextBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.imelabel);
            this.Controls.Add(this.imetextBox);
            this.Controls.Add(this.newbutton);
            this.Name = "Form1";
            this.Text = "Telefonski imenik";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imelabel;
        private System.Windows.Forms.TextBox imetextBox;
        private System.Windows.Forms.Button newbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label telefonlabel;
        private System.Windows.Forms.TextBox telefontextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label prezimelabel;
        private System.Windows.Forms.TextBox prezimetextBox;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.DataGridView contactsDataGrid;
        private System.Windows.Forms.Label oiblabel;
        private System.Windows.Forms.TextBox oibtextBox;
    }
}

