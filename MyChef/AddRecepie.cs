using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChef
{
    public partial class AddRecepie : Form
    {
        public Recepie Recepie { get; set; }
        public AddRecepie()
        {
            InitializeComponent();
        }

        private void AddRecepie_Load(object sender, EventArgs e)
        {

        }

        

        private void saveRecepie_Click(object sender, EventArgs e)
        {
            Recepie = new Recepie(Name.Text,contextBox.Text,(int)timeForPreparing.Value,categoryBox.SelectedItem.ToString(), tasteBox.SelectedItem.ToString(),(int)totalPersons.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
           
                if (Name.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(Name, "Не смеете да го оставите полето празно!");
                    e.Cancel = true;
                }
            else if (Name.Text.Trim().Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(Name, "Насловот не смее да содржи бројки!");
            }
            else
                {
                    errorProvider1.SetError(Name, null);
                    e.Cancel = false;
                
            }
        }

        private void contextBox_Validating(object sender, CancelEventArgs e)
        {
            if (contextBox.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(contextBox, "Не смеете да го оставите полето празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(contextBox, null);
                e.Cancel = false;

            }
        }

       
    }
}
