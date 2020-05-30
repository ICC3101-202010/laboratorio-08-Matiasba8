namespace Lab8_MatíasBustos
{
    partial class AppForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowLocalsPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ListBoxLocals = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartMenuPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewCine_Panel_View = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Salas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.horario = new System.Windows.Forms.TextBox();
            this.ownername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LocalOptionsView = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NewStorePanel = new System.Windows.Forms.Panel();
            this.MessageCreationMovie = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CategoriasStore = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.horariostore = new System.Windows.Forms.TextBox();
            this.ownernamestore = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NewRestaurantPanel = new System.Windows.Forms.Panel();
            this.CreateRestaurant = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.MesaExc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.HorarioRestaurante = new System.Windows.Forms.TextBox();
            this.ownerRestaurant = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ShowLocalsPanel.SuspendLayout();
            this.StartMenuPanel.SuspendLayout();
            this.NewCine_Panel_View.SuspendLayout();
            this.LocalOptionsView.SuspendLayout();
            this.NewStorePanel.SuspendLayout();
            this.NewRestaurantPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowLocalsPanel
            // 
            this.ShowLocalsPanel.Controls.Add(this.BackButton);
            this.ShowLocalsPanel.Controls.Add(this.ListBoxLocals);
            this.ShowLocalsPanel.Controls.Add(this.label3);
            this.ShowLocalsPanel.Location = new System.Drawing.Point(9, 60);
            this.ShowLocalsPanel.Name = "ShowLocalsPanel";
            this.ShowLocalsPanel.Size = new System.Drawing.Size(405, 259);
            this.ShowLocalsPanel.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(25, 216);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(108, 31);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Volver";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Back_button_click);
            // 
            // ListBoxLocals
            // 
            this.ListBoxLocals.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ListBoxLocals.FormattingEnabled = true;
            this.ListBoxLocals.Location = new System.Drawing.Point(6, 53);
            this.ListBoxLocals.Name = "ListBoxLocals";
            this.ListBoxLocals.Size = new System.Drawing.Size(331, 121);
            this.ListBoxLocals.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Locales:";
            // 
            // StartMenuPanel
            // 
            this.StartMenuPanel.Controls.Add(this.label2);
            this.StartMenuPanel.Controls.Add(this.button3);
            this.StartMenuPanel.Controls.Add(this.button1);
            this.StartMenuPanel.Controls.Add(this.label1);
            this.StartMenuPanel.Location = new System.Drawing.Point(90, 27);
            this.StartMenuPanel.Name = "StartMenuPanel";
            this.StartMenuPanel.Size = new System.Drawing.Size(211, 264);
            this.StartMenuPanel.TabIndex = 0;
            this.StartMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StartMenuPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "[ADMIN]";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Mostrar Locales";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowLocals_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nuevo Local";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewLocal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Centro Comercial";
            // 
            // NewCine_Panel_View
            // 
            this.NewCine_Panel_View.Controls.Add(this.button7);
            this.NewCine_Panel_View.Controls.Add(this.label9);
            this.NewCine_Panel_View.Controls.Add(this.Salas);
            this.NewCine_Panel_View.Controls.Add(this.label8);
            this.NewCine_Panel_View.Controls.Add(this.label7);
            this.NewCine_Panel_View.Controls.Add(this.horario);
            this.NewCine_Panel_View.Controls.Add(this.ownername);
            this.NewCine_Panel_View.Controls.Add(this.label6);
            this.NewCine_Panel_View.Location = new System.Drawing.Point(109, 111);
            this.NewCine_Panel_View.Name = "NewCine_Panel_View";
            this.NewCine_Panel_View.Size = new System.Drawing.Size(257, 152);
            this.NewCine_Panel_View.TabIndex = 2;
            this.NewCine_Panel_View.Paint += new System.Windows.Forms.PaintEventHandler(this.NewCine_Panel_View_Paint);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(117, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Crear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.CheckMovie_button_click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad de Salas";
            // 
            // Salas
            // 
            this.Salas.Location = new System.Drawing.Point(99, 89);
            this.Salas.Name = "Salas";
            this.Salas.Size = new System.Drawing.Size(124, 20);
            this.Salas.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Horario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre Dueño";
            // 
            // horario
            // 
            this.horario.Location = new System.Drawing.Point(99, 60);
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(124, 20);
            this.horario.TabIndex = 2;
            this.horario.TextChanged += new System.EventHandler(this.horario_TextChanged);
            // 
            // ownername
            // 
            this.ownername.Location = new System.Drawing.Point(99, 34);
            this.ownername.Name = "ownername";
            this.ownername.Size = new System.Drawing.Size(124, 20);
            this.ownername.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nuevo Cine";
            // 
            // LocalOptionsView
            // 
            this.LocalOptionsView.Controls.Add(this.label5);
            this.LocalOptionsView.Controls.Add(this.button6);
            this.LocalOptionsView.Controls.Add(this.button5);
            this.LocalOptionsView.Controls.Add(this.button4);
            this.LocalOptionsView.Controls.Add(this.label4);
            this.LocalOptionsView.Location = new System.Drawing.Point(46, 47);
            this.LocalOptionsView.Name = "LocalOptionsView";
            this.LocalOptionsView.Size = new System.Drawing.Size(300, 301);
            this.LocalOptionsView.TabIndex = 2;
            this.LocalOptionsView.Paint += new System.Windows.Forms.PaintEventHandler(this.LocalOptionsView_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Elija de que tipo va ser el nuevo local";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(95, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 29);
            this.button6.TabIndex = 3;
            this.button6.Text = "Tienda";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Store_button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(95, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 29);
            this.button5.TabIndex = 2;
            this.button5.Text = "Cine";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MovieTheaterbutton5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(95, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "Restaurante";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Restaurant_button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "NuevoLocal";
            // 
            // NewStorePanel
            // 
            this.NewStorePanel.Controls.Add(this.MessageCreationMovie);
            this.NewStorePanel.Controls.Add(this.button8);
            this.NewStorePanel.Controls.Add(this.label10);
            this.NewStorePanel.Controls.Add(this.CategoriasStore);
            this.NewStorePanel.Controls.Add(this.label11);
            this.NewStorePanel.Controls.Add(this.label12);
            this.NewStorePanel.Controls.Add(this.horariostore);
            this.NewStorePanel.Controls.Add(this.ownernamestore);
            this.NewStorePanel.Controls.Add(this.label13);
            this.NewStorePanel.Location = new System.Drawing.Point(109, 95);
            this.NewStorePanel.Name = "NewStorePanel";
            this.NewStorePanel.Size = new System.Drawing.Size(230, 159);
            this.NewStorePanel.TabIndex = 3;
            // 
            // MessageCreationMovie
            // 
            this.MessageCreationMovie.AutoSize = true;
            this.MessageCreationMovie.Location = new System.Drawing.Point(66, 234);
            this.MessageCreationMovie.Name = "MessageCreationMovie";
            this.MessageCreationMovie.Size = new System.Drawing.Size(0, 13);
            this.MessageCreationMovie.TabIndex = 19;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Crear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.CreateStore_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Categoria";
            // 
            // CategoriasStore
            // 
            this.CategoriasStore.Location = new System.Drawing.Point(88, 98);
            this.CategoriasStore.Name = "CategoriasStore";
            this.CategoriasStore.Size = new System.Drawing.Size(124, 20);
            this.CategoriasStore.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Horario";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nombre Dueño";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // horariostore
            // 
            this.horariostore.Location = new System.Drawing.Point(88, 69);
            this.horariostore.Name = "horariostore";
            this.horariostore.Size = new System.Drawing.Size(124, 20);
            this.horariostore.TabIndex = 13;
            // 
            // ownernamestore
            // 
            this.ownernamestore.Location = new System.Drawing.Point(88, 42);
            this.ownernamestore.Name = "ownernamestore";
            this.ownernamestore.Size = new System.Drawing.Size(124, 20);
            this.ownernamestore.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(65, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Nueva Tienda";
            // 
            // NewRestaurantPanel
            // 
            this.NewRestaurantPanel.Controls.Add(this.label18);
            this.NewRestaurantPanel.Controls.Add(this.CreateRestaurant);
            this.NewRestaurantPanel.Controls.Add(this.label14);
            this.NewRestaurantPanel.Controls.Add(this.MesaExc);
            this.NewRestaurantPanel.Controls.Add(this.label15);
            this.NewRestaurantPanel.Controls.Add(this.label16);
            this.NewRestaurantPanel.Controls.Add(this.HorarioRestaurante);
            this.NewRestaurantPanel.Controls.Add(this.ownerRestaurant);
            this.NewRestaurantPanel.Controls.Add(this.label17);
            this.NewRestaurantPanel.Location = new System.Drawing.Point(96, 114);
            this.NewRestaurantPanel.Name = "NewRestaurantPanel";
            this.NewRestaurantPanel.Size = new System.Drawing.Size(295, 152);
            this.NewRestaurantPanel.TabIndex = 4;
            // 
            // CreateRestaurant
            // 
            this.CreateRestaurant.Location = new System.Drawing.Point(117, 115);
            this.CreateRestaurant.Name = "CreateRestaurant";
            this.CreateRestaurant.Size = new System.Drawing.Size(75, 23);
            this.CreateRestaurant.TabIndex = 9;
            this.CreateRestaurant.Text = "Crear";
            this.CreateRestaurant.UseVisualStyleBackColor = true;
            this.CreateRestaurant.Click += new System.EventHandler(this.CreateRestaurant_click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Mesa Exclusiva";
            // 
            // MesaExc
            // 
            this.MesaExc.Location = new System.Drawing.Point(99, 89);
            this.MesaExc.Name = "MesaExc";
            this.MesaExc.Size = new System.Drawing.Size(124, 20);
            this.MesaExc.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Horario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nombre Dueño";
            // 
            // HorarioRestaurante
            // 
            this.HorarioRestaurante.Location = new System.Drawing.Point(99, 60);
            this.HorarioRestaurante.Name = "HorarioRestaurante";
            this.HorarioRestaurante.Size = new System.Drawing.Size(124, 20);
            this.HorarioRestaurante.TabIndex = 2;
            // 
            // ownerRestaurant
            // 
            this.ownerRestaurant.Location = new System.Drawing.Point(99, 34);
            this.ownerRestaurant.Name = "ownerRestaurant";
            this.ownerRestaurant.Size = new System.Drawing.Size(124, 20);
            this.ownerRestaurant.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(72, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nuevo Restaurante";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "(Si o No)";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 415);
            this.Controls.Add(this.StartMenuPanel);
            this.Controls.Add(this.NewRestaurantPanel);
            this.Controls.Add(this.NewCine_Panel_View);
            this.Controls.Add(this.NewStorePanel);
            this.Controls.Add(this.LocalOptionsView);
            this.Controls.Add(this.ShowLocalsPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Center";
            this.ShowLocalsPanel.ResumeLayout(false);
            this.ShowLocalsPanel.PerformLayout();
            this.StartMenuPanel.ResumeLayout(false);
            this.StartMenuPanel.PerformLayout();
            this.NewCine_Panel_View.ResumeLayout(false);
            this.NewCine_Panel_View.PerformLayout();
            this.LocalOptionsView.ResumeLayout(false);
            this.LocalOptionsView.PerformLayout();
            this.NewStorePanel.ResumeLayout(false);
            this.NewStorePanel.PerformLayout();
            this.NewRestaurantPanel.ResumeLayout(false);
            this.NewRestaurantPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartMenuPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListBoxLocals;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel LocalOptionsView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel NewCine_Panel_View;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Salas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox horario;
        private System.Windows.Forms.TextBox ownername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel ShowLocalsPanel;
        private System.Windows.Forms.Panel NewStorePanel;
        private System.Windows.Forms.Label MessageCreationMovie;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CategoriasStore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox horariostore;
        private System.Windows.Forms.TextBox ownernamestore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel NewRestaurantPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button CreateRestaurant;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MesaExc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox HorarioRestaurante;
        private System.Windows.Forms.TextBox ownerRestaurant;
        private System.Windows.Forms.Label label17;
    }
}

