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
/// This program is designed to maintain Product customer form. It allows for the
/// user to Add, Modify and Remove line item from the database.
/// When a user clicks on Add, it opens up a form that a user can enter the info
/// needed. 
/// A user can also Modify a line item by selecting a record and then do an
/// update.
/// It also allows to delete a record from the list on selected item.
/// 
/// Date: May 5, 2021
/// Author: Cecilia Santiago    
/// </summary>
/// 
namespace Lab3_ProductMaintenance
{
    public partial class FrmProdMaint : Form
    {
        TechSupportContext context;                     //use this context from the db
        FrmUpdate updateFrm = new FrmUpdate();          //use UpdateForm 
        Product currProd;                               //holds the current Product
                
        string[] heading = new string[4];               //placeholder for headers

        public FrmProdMaint()
        {
            InitializeComponent();
        }

        // Exit all application
        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        //Product list is display when the Product Maintenance form loads
        private void FrmProdMaint_Load(object sender, EventArgs e)
        {
            context = new TechSupportContext();
            heading[0] = "Product Code";
            heading[1] = "Name";
            heading[2] = "Version";
            heading[3] = "Release Date";
            LblHeaders.Text = heading[0].PadRight(15) + heading[1].PadRight(60) +
                              heading[2].PadRight(10) + heading[3].PadRight(25);            

            DisplayProduct();
            
        }

        //Reads from Product table and display each record in the Listbox
        private void DisplayProduct()
        {
            LstData.Items.Clear();
            List<Product> allprod = context.Products.ToList();
            foreach (Product product in allprod)
                LstData.Items.Add(product);
        }

        /// <summary>
        /// Opens up the Add Product Form and all defaults are set
        /// Once values are entered it will then be saved to the Database
        /// and refreshes the listbox items with new information
        /// </summary>

        private void MnuAdd_Click(object sender, EventArgs e)
        {
             
            updateFrm.TxtProdcode.Enabled = true;
            updateFrm.Text = "Add Product";
            updateFrm.TxtProdcode.Text = "";
            updateFrm.TxtName.Text = "";
            updateFrm.TxtVersion.Text = "";
            updateFrm.DtTimePickRelease.Text = "";
            
            updateFrm.ShowDialog();                                 //Loads the Add Product form

            if (updateFrm.btnsent == "OK") {                        //new record is being created from all inputs
                currProd = context.Products.First();
                currProd.ProductCode = updateFrm.TxtProdcode.Text;
                currProd.Name = updateFrm.TxtName.Text;
                currProd.Version = Convert.ToDecimal(updateFrm.TxtVersion.Text);
                currProd.ReleaseDate = Convert.ToDateTime(updateFrm.DtTimePickRelease.Text);
                context.Products.Add(currProd);                     //add all inputs as new record in the database
                context.SaveChanges();
                DisplayProduct();
            }
        }

        /// <summary>
        /// Opens up the Modify Product Form of the selected item
        /// so update can be done and then saves the updated info in the database
        /// The listbox is refreshed with new info
        /// </summary>
        private void MnuModify_Click(object sender, EventArgs e)
        {
            
            updateFrm.Text = "Modify Product";

            currProd = (Product)LstData.SelectedItem;
            if (currProd is null) return;
            updateFrm.TxtProdcode.Text = currProd.ProductCode;
            updateFrm.TxtProdcode.Enabled = false;            
            updateFrm.TxtName.Text = currProd.Name;
            updateFrm.TxtVersion.Text = currProd.Version.ToString();
            updateFrm.DtTimePickRelease.Text = currProd.ReleaseDate.ToString();

            updateFrm.ShowDialog();                                 //Loads the Modify Product form
                                                                    //which displays the selected record from the list

            if (updateFrm.btnsent == "OK")                           //selected record is being updated
            {
                currProd.Name = updateFrm.TxtName.Text;
                currProd.Version = Convert.ToDecimal(updateFrm.TxtVersion.Text);
                currProd.ReleaseDate = Convert.ToDateTime(updateFrm.DtTimePickRelease.Text);
                DisplayProduct();
                context.SaveChanges();                              //selected record is updated in the database
            }
        }


        /// <summary>
        /// The selected item is removed from the Listbox and the database
        /// </summary> 
        private void MnuRemove_Click(object sender, EventArgs e)
        {
            currProd = currProd = (Product)LstData.SelectedItem;
            if (currProd is null) return;
            context.Products.Remove(currProd);
            context.SaveChanges();
            currProd = context.Products.First();   // Load the first Customer            
            DisplayProduct();
            
        }
    }
}
