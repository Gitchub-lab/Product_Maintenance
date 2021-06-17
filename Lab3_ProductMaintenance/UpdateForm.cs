using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3_ProductMaintenance.Models;


/// <summary>
/// This is the Form Update which opens up the Add Product form when Add is clicked from
/// the Product Maintenance form. Modify Product opens up when Modify is clicked from
/// the Product Maintenance form.
/// This form allows for all the edits to be done to the database
///  
/// Date: May 5, 2021
/// Author: Cecilia Santiago    
/// </summary>
///
namespace Lab3_ProductMaintenance
{
    public partial class FrmUpdate : Form
    {
        public string btnsent;
        public FrmUpdate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates all the data entered using the Validator Class library.
        /// Once valid it then allows to close the form and back to the
        /// Product Maintenance form
        /// </summary> 
        private void Btn_Add_Modify(object sender, EventArgs e)
        {
            
            btnsent = BtnOk.Text;

            if (Validator.IsPresent(TxtProdcode, LblValidProdc) &&
                Validator.IsMore10(TxtProdcode, LblValidProdc) &&
                Validator.IsPresent(TxtName, LblValidName) &&
                Validator.IsMore50(TxtName, LblValidName) &&
                Validator.IsPresent(TxtVersion, LblValidVersion) &&
                Validator.IsNotAlpha(TxtVersion, LblValidVersion) &&
                Validator.IsPositive(TxtVersion, LblValidVersion) &&
                Validator.IsDecimal(TxtVersion, LblValidVersion) &&                
                Validator.IsValidDate(DtTimePickRelease.Value.ToString(), LblValidDate))

            this.Close();
            
        }

        //Closes the Add amd Modify Product form when cancel, no data was saved
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            btnsent = BtnCancel.Text; 
            this.Close();
        }

        //Sets all input values to blank when Add Product form is opened
        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            if (this.Text == "Add Product")
            {
                LblValidProdc.Text = "";
                LblValidName.Text = "";
                LblValidVersion.Text = "";
                LblValidDate.Text = "";
                TxtName.Text = "";
                TxtProdcode.Text = "";
                TxtVersion.Text = "";    
            }
        }
         
    }
}
