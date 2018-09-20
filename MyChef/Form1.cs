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
    public partial class Form1 : Form
    {
        Recepie selectedRecepie;
        public Form1()
        {
            InitializeComponent();
            Recepie r = new Recepie("Пилешки прсти", "Вклучете ја рерната на 200 степени. Пилешкото филе исечете го на долги парчиња, налик на „прсти“. Посолете, побиберете и ставете во сад. Додајте павлака, мајонез, сенф, оригано, пипер. Измешајте и оставете малку да отстои. Наредете ги прстите во плех обложен со хартија за печење.Печете 45 минути на 200 степени. Сервирајте со лимон, салата или сос од павлака, јогурт, сенф и мајонез",30,"Лесно", "Главни јадења", 5);
            listRecepies.Items.Add(r);
           r = new Recepie("Домашни крофни", "Изматете го јогуртот со брашното, прашокот за пециво и солта. Со лажица од смесата ставајте во врело масло и испржете ги крофните рамномерно од сите страни.", 60, "Лесно", "Десерт", 4);
            listRecepies.Items.Add(r);
            r = new Recepie("Домашен ролат", "Главна состојка им е шербет, мелени бисквити и мелени ореви, се се меша, плус се додава нешто шарено внатре, може локум или што ви се наоѓа по дома, значи вкусот не е важен, важен е квантитетот.", 20, "Лесно", "Десерт", 2);
            listRecepies.Items.Add(r);


        }

        private void listRecepies_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listRecepies.SelectedIndex != -1;
            if (listRecepies.SelectedIndex != -1)
            {
                selectedRecepie = listRecepies.SelectedItem as Recepie;
                lbName.Text = selectedRecepie.Name;
                textBoxContent.Text= selectedRecepie.Context;
                lbTimeForPreparing.Text = selectedRecepie.totalTime.ToString();
                lbCategory.Text = selectedRecepie.Category;
                lbTaste.Text = selectedRecepie.Taste;
                lbTotalPersons.Text = selectedRecepie.totalPersons.ToString();
                lbName.Visible = true;
                textBoxContent.Visible = true;
                lbTimeForPreparing.Visible = true;
                lbCategory.Visible = true;
                lbTaste.Visible = true;
                lbTotalPersons.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label5.Visible = true;
                label10.Visible = true;

            }
            else
            {
                selectedRecepie = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                AddRecepie form = new AddRecepie();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listRecepies.Items.Add(form.Recepie);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
           if (listRecepies.SelectedIndex != -1)
            {
                listTastes.ClearSelected();
                if (MessageBox.Show("Дали сте сигурни?", "Избриши рецепт?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    listRecepies.Items.RemoveAt(listRecepies.SelectedIndex);

                    lbName.ResetText();
                    textBoxContent.ResetText();
                    lbTimeForPreparing.ResetText();
                    lbCategory.ResetText();
                    textBoxContent.Visible = false;
                    lbTotalPersons.ResetText();
                    lbTaste.ResetText();
                    label4.Visible = false;
                    label6.Visible = false;
                    label8.Visible = false;
                    label7.Visible = false;
                    label9.Visible = false;
                    label5.Visible = false;
                    label10.Visible = false;
                }

            }
            if(listTastes.SelectedIndex!=-1)
            {
                listRecepies.ClearSelected();
                if (MessageBox.Show("Дали сте сигурни?", "Избриши рецепт?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    listTastes.Items.RemoveAt(listTastes.SelectedIndex);

                    lbName.ResetText();
                    textBoxContent.ResetText();
                    textBoxContent.Visible = false;
                    lbTimeForPreparing.ResetText();
                    lbCategory.ResetText();
                    lbTaste.ResetText();
                    lbTotalPersons.ResetText();
                    label4.Visible = false;
                    label6.Visible = false;
                    label8.Visible = false;
                    label7.Visible = false;
                    label9.Visible = false;
                    label5.Visible = false;
                    label10.Visible = false;
                }

            }
            

          
           
        }

        private void clbTaste_SelectedValueChanged(object sender, EventArgs e)
        {

            List<String> checkedValues = clbTaste.CheckedItems.Cast<String>().ToList();

            List<Recepie> allRecipes = listRecepies.Items.Cast<Recepie>().ToList();

            List<Recepie> filteredRecepies = allRecipes.Where(x => checkedValues.Contains(x.Taste)).ToList();

            listTastes.DataSource = filteredRecepies;

           
        }

        private void listTastes_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listTastes.SelectedIndex != -1;
            if (listTastes.SelectedIndex != -1)
            {
                selectedRecepie = listTastes.SelectedItem as Recepie;
                lbName.Text = selectedRecepie.Name;
                textBoxContent.Text = selectedRecepie.Context;
                lbTimeForPreparing.Text = selectedRecepie.totalTime.ToString();
                lbCategory.Text = selectedRecepie.Category;
                lbTaste.Text = selectedRecepie.Taste;
                lbTotalPersons.Text = selectedRecepie.totalPersons.ToString();
                lbName.Visible = true;
                textBoxContent.Visible = true;
                lbTimeForPreparing.Visible = true;
                lbCategory.Visible = true;
                lbTaste.Visible = true;
                lbTotalPersons.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label5.Visible = true;
                label10.Visible = true;

            }
            else
            {
                selectedRecepie = null;
            }
        }
    }
}
