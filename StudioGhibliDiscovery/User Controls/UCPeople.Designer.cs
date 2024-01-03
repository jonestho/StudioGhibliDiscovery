namespace StudioGhibliDiscovery
{
    partial class UCPeople
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.peopleDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sortByFilm = new System.Windows.Forms.ComboBox();
            this.sortBySpecies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sortByGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.applyFilter = new System.Windows.Forms.Button();
            this.resetFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.Font = new System.Drawing.Font("Javanese Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(10, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 72);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(343, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(681, 109);
            this.label2.TabIndex = 4;
            this.label2.Text = "Currently Archived Characters";
            // 
            // peopleDataGrid
            // 
            this.peopleDataGrid.AllowUserToAddRows = false;
            this.peopleDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.peopleDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.peopleDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peopleDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peopleDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.peopleDataGrid.Location = new System.Drawing.Point(408, 92);
            this.peopleDataGrid.Name = "peopleDataGrid";
            this.peopleDataGrid.ReadOnly = true;
            this.peopleDataGrid.RowHeadersVisible = false;
            this.peopleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.peopleDataGrid.Size = new System.Drawing.Size(585, 623);
            this.peopleDataGrid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(118, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(76, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Film:";
            // 
            // sortByFilm
            // 
            this.sortByFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortByFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortByFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByFilm.ForeColor = System.Drawing.SystemColors.Window;
            this.sortByFilm.FormattingEnabled = true;
            this.sortByFilm.Location = new System.Drawing.Point(146, 267);
            this.sortByFilm.Name = "sortByFilm";
            this.sortByFilm.Size = new System.Drawing.Size(121, 23);
            this.sortByFilm.TabIndex = 9;
            // 
            // sortBySpecies
            // 
            this.sortBySpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortBySpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBySpecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBySpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBySpecies.ForeColor = System.Drawing.SystemColors.Window;
            this.sortBySpecies.FormattingEnabled = true;
            this.sortBySpecies.Location = new System.Drawing.Point(146, 432);
            this.sortBySpecies.Name = "sortBySpecies";
            this.sortBySpecies.Size = new System.Drawing.Size(121, 23);
            this.sortBySpecies.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(41, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Species:";
            // 
            // sortByGender
            // 
            this.sortByGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortByGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortByGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByGender.ForeColor = System.Drawing.SystemColors.Window;
            this.sortByGender.FormattingEnabled = true;
            this.sortByGender.Location = new System.Drawing.Point(146, 349);
            this.sortByGender.Name = "sortByGender";
            this.sortByGender.Size = new System.Drawing.Size(121, 23);
            this.sortByGender.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(41, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender:";
            // 
            // applyFilter
            // 
            this.applyFilter.BackColor = System.Drawing.Color.Black;
            this.applyFilter.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.applyFilter.Location = new System.Drawing.Point(59, 517);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(99, 49);
            this.applyFilter.TabIndex = 14;
            this.applyFilter.Text = "Apply";
            this.applyFilter.UseVisualStyleBackColor = false;
            this.applyFilter.Click += new System.EventHandler(this.applyFilter_Click);
            // 
            // resetFilter
            // 
            this.resetFilter.BackColor = System.Drawing.Color.Black;
            this.resetFilter.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetFilter.Location = new System.Drawing.Point(168, 517);
            this.resetFilter.Name = "resetFilter";
            this.resetFilter.Size = new System.Drawing.Size(99, 49);
            this.resetFilter.TabIndex = 15;
            this.resetFilter.Text = "Reset";
            this.resetFilter.UseVisualStyleBackColor = false;
            // 
            // UCPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudioGhibliDiscovery.Properties.Resources.Background;
            this.Controls.Add(this.resetFilter);
            this.Controls.Add(this.applyFilter);
            this.Controls.Add(this.sortByGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sortBySpecies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortByFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peopleDataGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Name = "UCPeople";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView peopleDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sortByFilm;
        private System.Windows.Forms.ComboBox sortBySpecies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sortByGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.Button resetFilter;
    }
}
