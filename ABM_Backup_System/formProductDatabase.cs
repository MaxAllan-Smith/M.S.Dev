using ABM_Backup_System_Library.DataAccess;
using ABM_Backup_System_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Automation;

namespace ABM_Backup_System
{
    public partial class formProductDatabase : Form
    {
        public formProductDatabase()
        {
            InitializeComponent();
        }

        private void PartNumberExist()
        {

        }

        private bool ValidateForm()
        {
            bool result = false;

            if (textBox_PartNumber.Text != "")
            {
                result = true;
            }

            return result;
        }

        private void ClearForm()
        {
            textBox_PartNumber.Clear();
            textBox_KnownAs.Clear();
            textBox_Description.Clear();
            textBox_ProductGroup.Clear();
            textBox_RangeCode.Clear();
            textBox_PN_BinLocation.Clear();
            textBox_PN_UnitOfIssue.Clear();
            textBox_MinimumStock.Clear();
            textBox_MaximumStock.Clear();
            textBox_FreeStock.Clear();
            textBox_BarCode.Clear();
            textBox_Width.Clear();
            textBox_Depth.Clear();
            textBox_Length.Clear();
            comboBox_BranchName.Text = null;

            textBox_PartNumber.Focus();
        }
        
        private void formProductDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                BranchModel branchModel = new BranchModel();
                SqlConnector sqlConnector = new SqlConnector();
                var result = sqlConnector.GetBranches(branchModel);
                comboBox_BranchName.Items.Add(result[0].BranchName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void tabControl_ProductDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_ProductDatabase.SelectedIndex == 0)
            {
                textBox_PartNumber.Select();
            }
        }

        private void textBox_PartNumber_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void textBox_PartNumber_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    ProductModel model = new ProductModel();
                    model.PartNumber = textBox_PartNumber.Text;
                    SqlConnector sqlConnector = new SqlConnector();
                    var result = sqlConnector.GetProducts(model);

                    if (result.Count <= 0)
                    {
                        textBox_DateSetup.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        textBox_PartNumber.Text = result[0].PartNumber;
                        textBox_KnownAs.Text = result[0].KnownAs;
                        textBox_Description.Text = result[0].Description;
                        textBox_ProductGroup.Text = result[0].ProdGroupPrefix;
                        textBox_RangeCode.Text = result[0].RangeCode;
                        textBox_PN_BinLocation.Text = result[0].BinLocation;
                        textBox_PN_UnitOfIssue.Text = result[0].UOI.ToString();
                        textBox_MinimumStock.Text = result[0].MinStock.ToString();
                        textBox_MaximumStock.Text = result[0].MaxStock.ToString();
                        textBox_FreeStock.Text = result[0].StockQty.ToString();
                        textBox_BarCode.Text = result[0].BarCode;
                        textBox_Width.Text = result[0].Width.ToString();
                        textBox_Depth.Text = result[0].Depth.ToString();
                        textBox_Length.Text = result[0].Length.ToString();
                        comboBox_BranchName.Text = result[0].BranchName;
                        textBox_DateSetup.Text = result[0].DateSetup.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void toolStripButton_OK_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    SqlConnector sqlConnector = new SqlConnector();

                    ProductModel model = new ProductModel();
                    model.PartNumber = textBox_PartNumber.Text;
                    model.KnownAs = textBox_KnownAs.Text;
                    model.Description = textBox_Description.Text;
                    model.ProdGroupPrefix = textBox_ProductGroup.Text;
                    model.BinLocation = textBox_PN_BinLocation.Text;
                    model.RangeCode = textBox_RangeCode.Text;
                    model.UOI = Int32.Parse(textBox_PN_UnitOfIssue.Text);
                    model.MinStock = Int32.Parse(textBox_MinimumStock.Text);
                    model.MaxStock = Int32.Parse(textBox_MaximumStock.Text);
                    model.DateSetup = DateTime.Now.ToString("dd/MM/yyyy");
                    model.BarCode = textBox_BarCode.Text;
                    model.BranchName = comboBox_BranchName.Text;
                    model.Width = Int32.Parse(textBox_Width.Text);
                    model.Depth = Int32.Parse(textBox_Depth.Text);
                    model.Length = Int32.Parse(textBox_Length.Text);

                    sqlConnector.AddNewProduct(model);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}
