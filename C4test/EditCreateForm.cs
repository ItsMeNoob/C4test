﻿using C4test.Classes;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4test
{
    public partial class EditCreateForm : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        Query q = new Query();
        private DataRow _DataRow;
        int RowId;
        int typeimg1;
        int projectEnb;
        
        MainView form1 = new MainView();
        public DataRow DataRow
        {
            get
            {
                return _DataRow;
            }
            set
            {
                if (_DataRow == value) return;
                _DataRow = value;
             
            }
        }
        public EditCreateForm(DataRow dataRow)
        {
            InitializeComponent();

            DataRow = dataRow;
            if (dataRow==null)
            {
                labelEditCreate.Text = "Create PROJECT";

            }
            else
            {
                labelEditCreate.Text = "Edit PROJECT";
                this.Text = string.Format("Edit project ");
                txtProjectName.Text = string.Format(DataRow[1].ToString());
                Int32.TryParse(dataRow[0].ToString(), out RowId);
                if (int.TryParse(dataRow[3].ToString(), out int x))
                {
                    if (x == 1)
                    {
                        cbAcceptingNewVisits.Checked = true;
                    }
                    else
                    {
                        cbAcceptingNewVisits.Checked = false;
                    }
                }
                else
                {
                    cbAcceptingNewVisits.Checked = true;
                }
               // cbAcceptingNewVisits.Checked = bool.Parse(DataRow[2].ToString());

                cbSupportediTypes.Text = string.Format(DataRow[4].ToString());
                if (string.Format(DataRow[2].ToString()) == "YES")
                {
                    cbProjectEnabled.Checked = true;
                }
                else
                {
                    cbProjectEnabled.Checked = false;
                }
                
                
            }
          
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            form1.Show();
            this.Dispose();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            //if (cbSupportediTypes.Text == "JPG"){ typeimg1 = 1;} else { typeimg1 = 2; }
            if (int.TryParse(cbSupportediTypes.SelectedValue.ToString(), out typeimg1) == false)
            { typeimg1 = 3;  }
            
             if (cbProjectEnabled.Checked == true) { projectEnb = 1; } else { projectEnb = 0; }

            if (DataRow==null)
            {
                SaveProject();
            }
            else
            {
                UpdateProject();
            }
          
        }

        private void CanclelBtn_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Dispose();
        }

        private void EditCreateForm_Load(object sender, EventArgs e)
        {
            if (cbAcceptingNewVisits.Checked)
            {
                cbSupportediTypes.Enabled = true;
            }
            else
            {
                cbSupportediTypes.Enabled = false;
            }
        }

        private void cbAcceptingNewVisits_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAcceptingNewVisits.Checked)
            {
                cbSupportediTypes.Enabled = true;
            }
            else
            {
                cbSupportediTypes.SelectedIndex = 3;
                cbSupportediTypes.Enabled = false;
            }
        }

        public void SaveProject()
        {
            if (txtProjectName.Text.Length > 0)
            {
                if (q.insertdata(txtProjectName.Text, typeimg1, projectEnb, cbAcceptingNewVisits.Checked) == false)
                {
                    Reqinfolab.Text = "Server error";
                }
                else
                {
                    Reqinfolab.Text = "Project entered successfully";
                }

            }
            else
            {
                RequiredField();
            }




        }

        public void UpdateProject()
        {
            if (txtProjectName.Text.Length > 0)
            {
                if (q.updatedata(RowId, txtProjectName.Text, typeimg1, projectEnb, cbAcceptingNewVisits.Checked) == false)
                {
                    Reqinfolab.Text = "Server error";
                }
                else
                {
                    Reqinfolab.Text = "Project updated successfully";
                }

            }
            else
            {
                RequiredField();
            }
        }
        public void RequiredField()
        {
            Reqinfolab.Text = "Project name is required field";
            txtProjectName.BackColor = Color.Red;

        }
    }
}