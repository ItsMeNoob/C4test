using C4test.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C4test
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        GridView grid = new GridView();
        Query data = new Query();
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();

            gridControl1.DataSource = data.GetData();
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            using (EditCreateForm f2 = new EditCreateForm(gridView1.GetFocusedDataRow()))
            {
                this.Hide();

                f2.ShowDialog();
            }
        }
        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            using (EditCreateForm f2 = new EditCreateForm(grid.GetFocusedDataRow()))
            {
                this.Hide();
                f2.ShowDialog();
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = data.GetData();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            using (EditCreateForm f2 = new EditCreateForm(gridView1.GetFocusedDataRow()))
            {
                this.Hide();

                f2.ShowDialog();
            }
        }
    }
}
