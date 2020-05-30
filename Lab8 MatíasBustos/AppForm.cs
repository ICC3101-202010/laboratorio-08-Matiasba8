using Lab8_MatíasBustos.Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_MatíasBustos
{
    public partial class AppForm : Form
    {



        List<Panel> stackPanels = new List<Panel>();
        LocalController localController = new LocalController();


        public AppForm()
        {
            InitializeComponent();

            stackPanels.Add(StartMenuPanel);


            stackPanels.Add(ShowLocalsPanel);
            stackPanels.Add(NewCine_Panel_View);
            stackPanels.Add(LocalOptionsView);
            stackPanels.Add(NewStorePanel);
            stackPanels.Add(NewRestaurantPanel);
            ShowPanel(StartMenuPanel);


        }

        private void NewLocal_Click(object sender, EventArgs e)
        {
            ShowPanel(LocalOptionsView);
            


        }

        private void SearchLocal_Click(object sender, EventArgs e)
        {

        }

        private void ShowLocals_Click(object sender, EventArgs e)
        {
            foreach (Local local in localController.ReturnLocals())
            {
                ListBoxLocals.Items.Add("Local: " + local.LocalType + " Dueño: " + local.OwnerName + " Horario: " + local.HorarioAtencion);
            }
            



            ShowPanel(ShowLocalsPanel);
            

        }

        private void Back_button_click(object sender, EventArgs e)
        {
            ShowPanel(StartMenuPanel);
            ListBoxLocals.Items.Clear();

        }

        public void ShowPanel(Panel panel)
        {
            foreach (Panel panel1 in stackPanels)
            {
                if (panel1 != panel)
                {
                    panel1.Visible = false;
                }
            }
            panel.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Restaurant_button4_Click(object sender, EventArgs e)
        {
            ShowPanel(NewRestaurantPanel);
        }

        private void MovieTheaterbutton5_Click(object sender, EventArgs e)
        {
            ShowPanel(NewCine_Panel_View);
            
        }

        private void Store_button6_Click(object sender, EventArgs e)
        {
            ShowPanel(NewStorePanel);
        }

        private void CheckMovie_button_click(object sender, EventArgs e)
        {
            int lenowner = ownername.Text.Length;
            int lenhorario = horario.Text.Length;
            int lensalas = Salas.Text.Length;

            if(lenowner==0 || lenowner == 0 || lenowner == 0 )
            {
                MessageCreationMovie.Text = "Porfavor ingrese todos los parametros necesarios!!";
            }
            else
            {
                Cine cine = new Cine(Int32.Parse(Salas.Text), ownername.Text,localController.IdAssign(), horario.Text, "CINE");
                localController.AddLocal(cine);
                MessageCreationMovie.Text = "Pelicula creada con exito!";

                
                ShowPanel(StartMenuPanel);
            }
        }

        private void StartMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LocalOptionsView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewCine_Panel_View_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateStore_button_Click(object sender, EventArgs e)
        {
            int lenowners = ownernamestore.Text.Length;
            int lenHorariost = horariostore.Text.Length;
            int lenCategorys = CategoriasStore.Text.Length;

            if (lenowners == 0 || lenHorariost == 0 || lenCategorys == 0)
            {
                MessageCreationMovie.Text = "Porfavor ingrese todos los parametros necesarios!!";
            }
            else
            {
                Tienda tienda = new Tienda(CategoriasStore.Text, ownernamestore.Text, localController.IdAssign(), horariostore.Text, "Tienda");
                localController.AddLocal(tienda);
                MessageCreationMovie.Text = "Tienda creada con exito!";


                ShowPanel(StartMenuPanel);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void horario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateRestaurant_click(object sender, EventArgs e)
        {
            int lenownerr = ownerRestaurant.Text.Length;
            int lenHorariosr = HorarioRestaurante.Text.Length;
            int lenCategoryr = MesaExc.Text.Length;

            if (lenownerr == 0 || lenHorariosr == 0 || lenCategoryr == 0)
            {
                MessageCreationMovie.Text = "Porfavor ingrese todos los parametros necesarios!!";
            }
            else
            {
                Restaurante restaurante = new Restaurante(CategoriasStore.Text, ownernamestore.Text, localController.IdAssign(), horariostore.Text, "Restaurante");
                localController.AddLocal(restaurante);
                MessageCreationMovie.Text = "Restaurante creado con exito!";
                ShowPanel(StartMenuPanel);

            }
        }
    }
}
