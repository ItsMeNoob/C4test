namespace C4test
{
    partial class EditCreateForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.labelEditCreate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProjectEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.cbAcceptingNewVisits = new DevExpress.XtraEditors.CheckEdit();
            this.txtProjectName = new DevExpress.XtraEditors.TextEdit();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.imagesTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.CanclelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cbSupportediTypes = new System.Windows.Forms.ComboBox();
            this.Reqinfolab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbProjectEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAcceptingNewVisits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditCreate
            // 
            this.labelEditCreate.AutoSize = true;
            this.labelEditCreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditCreate.Location = new System.Drawing.Point(72, 71);
            this.labelEditCreate.Name = "labelEditCreate";
            this.labelEditCreate.Size = new System.Drawing.Size(144, 19);
            this.labelEditCreate.TabIndex = 0;
            this.labelEditCreate.Text = "Create PROJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supported images types:";
            // 
            // cbProjectEnabled
            // 
            this.cbProjectEnabled.EditValue = true;
            this.cbProjectEnabled.Location = new System.Drawing.Point(79, 152);
            this.cbProjectEnabled.Name = "cbProjectEnabled";
            this.cbProjectEnabled.Properties.Caption = "Project enabled:";
            this.cbProjectEnabled.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbProjectEnabled.Properties.ReadOnly = true;
            this.cbProjectEnabled.Properties.ValueGrayed = true;
            this.cbProjectEnabled.Size = new System.Drawing.Size(149, 20);
            this.cbProjectEnabled.TabIndex = 3;
            // 
            // cbAcceptingNewVisits
            // 
            this.cbAcceptingNewVisits.Location = new System.Drawing.Point(79, 179);
            this.cbAcceptingNewVisits.Name = "cbAcceptingNewVisits";
            this.cbAcceptingNewVisits.Properties.Caption = "Accepting new visits:";
            this.cbAcceptingNewVisits.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbAcceptingNewVisits.Size = new System.Drawing.Size(149, 20);
            this.cbAcceptingNewVisits.TabIndex = 4;
            this.cbAcceptingNewVisits.CheckedChanged += new System.EventHandler(this.cbAcceptingNewVisits_CheckedChanged);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(210, 124);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtProjectName.Properties.Appearance.Options.UseBackColor = true;
            this.txtProjectName.Size = new System.Drawing.Size(175, 20);
            this.txtProjectName.TabIndex = 5;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Db_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "TypeID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"103\" />";
            table1.Name = "ImagesTypes";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "TypeName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "ImagesTypes";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IkltYWdlc1R5cGVzIj48Rmllb" +
    "GQgTmFtZT0iVHlwZUlEIiBUeXBlPSJJbnQzMiIgLz48RmllbGQgTmFtZT0iVHlwZU5hbWUiIFR5cGU9I" +
    "lN0cmluZyIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // imagesTypesBindingSource
            // 
            this.imagesTypesBindingSource.DataMember = "ImagesTypes";
            this.imagesTypesBindingSource.DataSource = this.sqlDataSource1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(126, 289);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(142, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CanclelBtn
            // 
            this.CanclelBtn.Location = new System.Drawing.Point(361, 289);
            this.CanclelBtn.Name = "CanclelBtn";
            this.CanclelBtn.Size = new System.Drawing.Size(142, 23);
            this.CanclelBtn.TabIndex = 11;
            this.CanclelBtn.Text = "Cancel";
            this.CanclelBtn.Click += new System.EventHandler(this.CanclelBtn_Click);
            // 
            // cbSupportediTypes
            // 
            this.cbSupportediTypes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sqlDataSource1, "ImagesTypes.TypeID", true));
            this.cbSupportediTypes.DataSource = this.sqlDataSource1;
            this.cbSupportediTypes.DisplayMember = "ImagesTypes.TypeName";
            this.cbSupportediTypes.FormattingEnabled = true;
            this.cbSupportediTypes.Location = new System.Drawing.Point(210, 213);
            this.cbSupportediTypes.Name = "cbSupportediTypes";
            this.cbSupportediTypes.Size = new System.Drawing.Size(175, 21);
            this.cbSupportediTypes.TabIndex = 12;
            this.cbSupportediTypes.ValueMember = "ImagesTypes.TypeID";
            // 
            // Reqinfolab
            // 
            this.Reqinfolab.AutoSize = true;
            this.Reqinfolab.Location = new System.Drawing.Point(115, 244);
            this.Reqinfolab.Name = "Reqinfolab";
            this.Reqinfolab.Size = new System.Drawing.Size(0, 13);
            this.Reqinfolab.TabIndex = 13;
            // 
            // EditCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 451);
            this.Controls.Add(this.Reqinfolab);
            this.Controls.Add(this.cbSupportediTypes);
            this.Controls.Add(this.CanclelBtn);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.cbAcceptingNewVisits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEditCreate);
            this.Controls.Add(this.cbProjectEnabled);
            this.Name = "EditCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCreateForm";
            this.Load += new System.EventHandler(this.EditCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbProjectEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAcceptingNewVisits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CheckEdit cbProjectEnabled;
        private DevExpress.XtraEditors.CheckEdit cbAcceptingNewVisits;
        private DevExpress.XtraEditors.TextEdit txtProjectName;
        private System.Windows.Forms.BindingSource imagesTypesBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton CanclelBtn;
        private System.Windows.Forms.ComboBox cbSupportediTypes;
        private System.Windows.Forms.Label Reqinfolab;
    }
}