namespace Filling_station_project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfphoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfJoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsStaff1 = new Filling_station_project.fsStaff();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsStaff1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.BackColor = System.Drawing.Color.Gold;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.Black;
            this.btn_load.Location = new System.Drawing.Point(37, 37);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(115, 33);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.Gold;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(37, 99);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 30);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Edit";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.Gold;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(37, 227);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 32);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Gold;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(37, 167);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 32);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT staff.*\r\nFROM     staff";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-1KG4E74;Initial Catalog=Filling_Station_Management_system;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@staffID", System.Data.SqlDbType.Char, 0, "staffID"),
            new System.Data.SqlClient.SqlParameter("@stf_Name", System.Data.SqlDbType.VarChar, 0, "stf_Name"),
            new System.Data.SqlClient.SqlParameter("@stf_Gender", System.Data.SqlDbType.Char, 0, "stf_Gender"),
            new System.Data.SqlClient.SqlParameter("@stf_phoneNo", System.Data.SqlDbType.VarChar, 0, "stf_phoneNo"),
            new System.Data.SqlClient.SqlParameter("@stf_Join", System.Data.SqlDbType.VarChar, 0, "stf_Join"),
            new System.Data.SqlClient.SqlParameter("@stf_Position", System.Data.SqlDbType.VarChar, 0, "stf_Position"),
            new System.Data.SqlClient.SqlParameter("@stf_Age", System.Data.SqlDbType.Int, 0, "stf_Age")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@staffID", System.Data.SqlDbType.Char, 0, "staffID"),
            new System.Data.SqlClient.SqlParameter("@stf_Name", System.Data.SqlDbType.VarChar, 0, "stf_Name"),
            new System.Data.SqlClient.SqlParameter("@stf_Gender", System.Data.SqlDbType.Char, 0, "stf_Gender"),
            new System.Data.SqlClient.SqlParameter("@stf_phoneNo", System.Data.SqlDbType.VarChar, 0, "stf_phoneNo"),
            new System.Data.SqlClient.SqlParameter("@stf_Join", System.Data.SqlDbType.VarChar, 0, "stf_Join"),
            new System.Data.SqlClient.SqlParameter("@stf_Position", System.Data.SqlDbType.VarChar, 0, "stf_Position"),
            new System.Data.SqlClient.SqlParameter("@stf_Age", System.Data.SqlDbType.Int, 0, "stf_Age"),
            new System.Data.SqlClient.SqlParameter("@Original_staffID", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "staffID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_Gender", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_Gender", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Gender", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Gender", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_phoneNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_phoneNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_phoneNo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_phoneNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_Join", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_Join", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Join", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Join", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_Position", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_Position", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Position", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Position", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_Age", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_Age", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Age", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Age", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_staffID", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "staffID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_Gender", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_Gender", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Gender", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Gender", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_phoneNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_phoneNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_phoneNo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_phoneNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_Join", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_Join", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Join", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Join", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_Position", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_Position", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Position", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Position", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_stf_Age", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "stf_Age", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_stf_Age", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "stf_Age", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "staff", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("staffID", "staffID"),
                        new System.Data.Common.DataColumnMapping("stf_Name", "stf_Name"),
                        new System.Data.Common.DataColumnMapping("stf_Gender", "stf_Gender"),
                        new System.Data.Common.DataColumnMapping("stf_phoneNo", "stf_phoneNo"),
                        new System.Data.Common.DataColumnMapping("stf_Join", "stf_Join"),
                        new System.Data.Common.DataColumnMapping("stf_Position", "stf_Position"),
                        new System.Data.Common.DataColumnMapping("stf_Age", "stf_Age")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.stfNameDataGridViewTextBoxColumn,
            this.stfGenderDataGridViewTextBoxColumn,
            this.stfphoneNoDataGridViewTextBoxColumn,
            this.stfJoinDataGridViewTextBoxColumn,
            this.stfPositionDataGridViewTextBoxColumn,
            this.stfAgeDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "staff";
            this.dataGridView1.DataSource = this.fsStaff1;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(230, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // stfNameDataGridViewTextBoxColumn
            // 
            this.stfNameDataGridViewTextBoxColumn.DataPropertyName = "stf_Name";
            this.stfNameDataGridViewTextBoxColumn.HeaderText = "stf_Name";
            this.stfNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stfNameDataGridViewTextBoxColumn.Name = "stfNameDataGridViewTextBoxColumn";
            this.stfNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stfGenderDataGridViewTextBoxColumn
            // 
            this.stfGenderDataGridViewTextBoxColumn.DataPropertyName = "stf_Gender";
            this.stfGenderDataGridViewTextBoxColumn.HeaderText = "stf_Gender";
            this.stfGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stfGenderDataGridViewTextBoxColumn.Name = "stfGenderDataGridViewTextBoxColumn";
            this.stfGenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // stfphoneNoDataGridViewTextBoxColumn
            // 
            this.stfphoneNoDataGridViewTextBoxColumn.DataPropertyName = "stf_phoneNo";
            this.stfphoneNoDataGridViewTextBoxColumn.HeaderText = "stf_phoneNo";
            this.stfphoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stfphoneNoDataGridViewTextBoxColumn.Name = "stfphoneNoDataGridViewTextBoxColumn";
            this.stfphoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // stfJoinDataGridViewTextBoxColumn
            // 
            this.stfJoinDataGridViewTextBoxColumn.DataPropertyName = "stf_Join";
            this.stfJoinDataGridViewTextBoxColumn.HeaderText = "stf_Join";
            this.stfJoinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stfJoinDataGridViewTextBoxColumn.Name = "stfJoinDataGridViewTextBoxColumn";
            this.stfJoinDataGridViewTextBoxColumn.Width = 125;
            // 
            // stfPositionDataGridViewTextBoxColumn
            // 
            this.stfPositionDataGridViewTextBoxColumn.DataPropertyName = "stf_Position";
            this.stfPositionDataGridViewTextBoxColumn.HeaderText = "stf_Position";
            this.stfPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stfPositionDataGridViewTextBoxColumn.Name = "stfPositionDataGridViewTextBoxColumn";
            this.stfPositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // stfAgeDataGridViewTextBoxColumn
            // 
            this.stfAgeDataGridViewTextBoxColumn.DataPropertyName = "stf_Age";
            this.stfAgeDataGridViewTextBoxColumn.HeaderText = "stf_Age";
            this.stfAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stfAgeDataGridViewTextBoxColumn.Name = "stfAgeDataGridViewTextBoxColumn";
            this.stfAgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fsStaff1
            // 
            this.fsStaff1.DataSetName = "fsStaff";
            this.fsStaff1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gold;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(37, 289);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(115, 29);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit\r\n";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 545);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.Text = "Staff Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsStaff1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfphoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfJoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfAgeDataGridViewTextBoxColumn;
        private fsStaff fsStaff1;
        private System.Windows.Forms.Button Exit;
    }
}