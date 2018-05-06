namespace ThaiSomAdminApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_home = new MetroFramework.Controls.MetroTabPage();
            this.btn_SetDefault = new MetroFramework.Controls.MetroButton();
            this.btn_refresh = new MetroFramework.Controls.MetroButton();
            this.lbl_drinkCount = new MetroFramework.Controls.MetroLabel();
            this.lbl_foodCount = new MetroFramework.Controls.MetroLabel();
            this.lbl_status = new MetroFramework.Controls.MetroLabel();
            this.tab_foods = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addFood = new MetroFramework.Controls.MetroButton();
            this.txt_newFoodName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_newFoodPrice = new MetroFramework.Controls.MetroTextBox();
            this.grp_food = new System.Windows.Forms.GroupBox();
            this.btn_deleteFood = new MetroFramework.Controls.MetroButton();
            this.btn_updateFood = new MetroFramework.Controls.MetroButton();
            this.txt_foodName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_foodPrice = new MetroFramework.Controls.MetroTextBox();
            this.lst_foods = new MetroFramework.Controls.MetroListView();
            this.tab_drinks = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addDrink = new MetroFramework.Controls.MetroButton();
            this.txt_newDrinkName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_newDrinkPrice = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_deleteDrink = new MetroFramework.Controls.MetroButton();
            this.btn_updateDrink = new MetroFramework.Controls.MetroButton();
            this.txt_drinkName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_drinkPrice = new MetroFramework.Controls.MetroTextBox();
            this.lst_drinks = new MetroFramework.Controls.MetroListView();
            this.tab_kitchen = new MetroFramework.Controls.MetroTabPage();
            this.switch_kitchen = new MetroFramework.Controls.MetroToggle();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.num_kitchen = new System.Windows.Forms.NumericUpDown();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tab_service = new MetroFramework.Controls.MetroTabPage();
            this.lbl_response = new System.Windows.Forms.Label();
            this.timer_order = new System.Windows.Forms.Timer(this.components);
            this.timer_service = new System.Windows.Forms.Timer(this.components);
            this.lst_kitchen = new MetroFramework.Controls.MetroListView();
            this.lst_foodsOrdered = new MetroFramework.Controls.MetroListView();
            this.lst_service = new MetroFramework.Controls.MetroListView();
            this.switch_service = new MetroFramework.Controls.MetroToggle();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.num_service = new System.Windows.Forms.NumericUpDown();
            this.switch_sound = new MetroFramework.Controls.MetroToggle();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.tab_home.SuspendLayout();
            this.tab_foods.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_food.SuspendLayout();
            this.tab_drinks.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tab_kitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_kitchen)).BeginInit();
            this.tab_service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_service)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.tab_home);
            this.metroTabControl1.Controls.Add(this.tab_foods);
            this.metroTabControl1.Controls.Add(this.tab_drinks);
            this.metroTabControl1.Controls.Add(this.tab_kitchen);
            this.metroTabControl1.Controls.Add(this.tab_service);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(780, 492);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_home
            // 
            this.tab_home.Controls.Add(this.switch_sound);
            this.tab_home.Controls.Add(this.metroLabel14);
            this.tab_home.Controls.Add(this.btn_SetDefault);
            this.tab_home.Controls.Add(this.btn_refresh);
            this.tab_home.Controls.Add(this.lbl_drinkCount);
            this.tab_home.Controls.Add(this.lbl_foodCount);
            this.tab_home.Controls.Add(this.lbl_status);
            this.tab_home.HorizontalScrollbarBarColor = true;
            this.tab_home.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_home.HorizontalScrollbarSize = 10;
            this.tab_home.Location = new System.Drawing.Point(4, 38);
            this.tab_home.Name = "tab_home";
            this.tab_home.Size = new System.Drawing.Size(772, 450);
            this.tab_home.TabIndex = 3;
            this.tab_home.Text = "   Main   ";
            this.tab_home.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tab_home.VerticalScrollbarBarColor = true;
            this.tab_home.VerticalScrollbarHighlightOnWheel = false;
            this.tab_home.VerticalScrollbarSize = 10;
            // 
            // btn_SetDefault
            // 
            this.btn_SetDefault.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_SetDefault.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_SetDefault.Location = new System.Drawing.Point(3, 184);
            this.btn_SetDefault.Name = "btn_SetDefault";
            this.btn_SetDefault.Size = new System.Drawing.Size(189, 40);
            this.btn_SetDefault.TabIndex = 6;
            this.btn_SetDefault.Text = "Set Menu To Default";
            this.btn_SetDefault.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_SetDefault.UseSelectable = true;
            this.btn_SetDefault.Click += new System.EventHandler(this.btn_SetDefault_Click_1);
            // 
            // btn_refresh
            // 
            this.btn_refresh.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_refresh.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_refresh.Location = new System.Drawing.Point(3, 138);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(189, 40);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_refresh.UseSelectable = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_drinkCount
            // 
            this.lbl_drinkCount.AutoSize = true;
            this.lbl_drinkCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_drinkCount.Location = new System.Drawing.Point(3, 71);
            this.lbl_drinkCount.Name = "lbl_drinkCount";
            this.lbl_drinkCount.Size = new System.Drawing.Size(163, 25);
            this.lbl_drinkCount.Style = MetroFramework.MetroColorStyle.Red;
            this.lbl_drinkCount.TabIndex = 4;
            this.lbl_drinkCount.Text = "Drinks Menu Count:";
            this.lbl_drinkCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_foodCount
            // 
            this.lbl_foodCount.AutoSize = true;
            this.lbl_foodCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_foodCount.Location = new System.Drawing.Point(3, 46);
            this.lbl_foodCount.Name = "lbl_foodCount";
            this.lbl_foodCount.Size = new System.Drawing.Size(154, 25);
            this.lbl_foodCount.Style = MetroFramework.MetroColorStyle.Red;
            this.lbl_foodCount.TabIndex = 3;
            this.lbl_foodCount.Text = "Food Menu Count:";
            this.lbl_foodCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_status.Location = new System.Drawing.Point(3, 21);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(210, 25);
            this.lbl_status.Style = MetroFramework.MetroColorStyle.Red;
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Server Connection Status: ";
            this.lbl_status.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tab_foods
            // 
            this.tab_foods.Controls.Add(this.groupBox1);
            this.tab_foods.Controls.Add(this.grp_food);
            this.tab_foods.Controls.Add(this.lst_foods);
            this.tab_foods.HorizontalScrollbarBarColor = true;
            this.tab_foods.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_foods.HorizontalScrollbarSize = 10;
            this.tab_foods.Location = new System.Drawing.Point(4, 38);
            this.tab_foods.Name = "tab_foods";
            this.tab_foods.Size = new System.Drawing.Size(772, 450);
            this.tab_foods.TabIndex = 0;
            this.tab_foods.Text = "    Food Menu    ";
            this.tab_foods.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tab_foods.VerticalScrollbarBarColor = true;
            this.tab_foods.VerticalScrollbarHighlightOnWheel = false;
            this.tab_foods.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox1.Controls.Add(this.btn_addFood);
            this.groupBox1.Controls.Add(this.txt_newFoodName);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txt_newFoodPrice);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(206, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Food";
            // 
            // btn_addFood
            // 
            this.btn_addFood.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_addFood.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_addFood.Location = new System.Drawing.Point(15, 77);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(230, 40);
            this.btn_addFood.TabIndex = 7;
            this.btn_addFood.Text = "Add To Menu";
            this.btn_addFood.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_addFood.UseSelectable = true;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // txt_newFoodName
            // 
            // 
            // 
            // 
            this.txt_newFoodName.CustomButton.Image = null;
            this.txt_newFoodName.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_newFoodName.CustomButton.Name = "";
            this.txt_newFoodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_newFoodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_newFoodName.CustomButton.TabIndex = 1;
            this.txt_newFoodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_newFoodName.CustomButton.UseSelectable = true;
            this.txt_newFoodName.CustomButton.Visible = false;
            this.txt_newFoodName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_newFoodName.Lines = new string[0];
            this.txt_newFoodName.Location = new System.Drawing.Point(108, 19);
            this.txt_newFoodName.MaxLength = 32767;
            this.txt_newFoodName.Name = "txt_newFoodName";
            this.txt_newFoodName.PasswordChar = '\0';
            this.txt_newFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_newFoodName.SelectedText = "";
            this.txt_newFoodName.SelectionLength = 0;
            this.txt_newFoodName.SelectionStart = 0;
            this.txt_newFoodName.ShortcutsEnabled = true;
            this.txt_newFoodName.Size = new System.Drawing.Size(137, 23);
            this.txt_newFoodName.TabIndex = 3;
            this.txt_newFoodName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_newFoodName.UseSelectable = true;
            this.txt_newFoodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_newFoodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 48);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Food Price: ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Food Name: ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_newFoodPrice
            // 
            // 
            // 
            // 
            this.txt_newFoodPrice.CustomButton.Image = null;
            this.txt_newFoodPrice.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_newFoodPrice.CustomButton.Name = "";
            this.txt_newFoodPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_newFoodPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_newFoodPrice.CustomButton.TabIndex = 1;
            this.txt_newFoodPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_newFoodPrice.CustomButton.UseSelectable = true;
            this.txt_newFoodPrice.CustomButton.Visible = false;
            this.txt_newFoodPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_newFoodPrice.Lines = new string[0];
            this.txt_newFoodPrice.Location = new System.Drawing.Point(108, 48);
            this.txt_newFoodPrice.MaxLength = 32767;
            this.txt_newFoodPrice.Name = "txt_newFoodPrice";
            this.txt_newFoodPrice.PasswordChar = '\0';
            this.txt_newFoodPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_newFoodPrice.SelectedText = "";
            this.txt_newFoodPrice.SelectionLength = 0;
            this.txt_newFoodPrice.SelectionStart = 0;
            this.txt_newFoodPrice.ShortcutsEnabled = true;
            this.txt_newFoodPrice.Size = new System.Drawing.Size(137, 23);
            this.txt_newFoodPrice.TabIndex = 5;
            this.txt_newFoodPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_newFoodPrice.UseSelectable = true;
            this.txt_newFoodPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_newFoodPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grp_food
            // 
            this.grp_food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.grp_food.Controls.Add(this.btn_deleteFood);
            this.grp_food.Controls.Add(this.btn_updateFood);
            this.grp_food.Controls.Add(this.txt_foodName);
            this.grp_food.Controls.Add(this.metroLabel2);
            this.grp_food.Controls.Add(this.metroLabel1);
            this.grp_food.Controls.Add(this.txt_foodPrice);
            this.grp_food.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grp_food.Location = new System.Drawing.Point(206, 8);
            this.grp_food.Name = "grp_food";
            this.grp_food.Size = new System.Drawing.Size(260, 175);
            this.grp_food.TabIndex = 8;
            this.grp_food.TabStop = false;
            this.grp_food.Text = "Selected Item: ";
            // 
            // btn_deleteFood
            // 
            this.btn_deleteFood.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_deleteFood.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_deleteFood.Location = new System.Drawing.Point(15, 123);
            this.btn_deleteFood.Name = "btn_deleteFood";
            this.btn_deleteFood.Size = new System.Drawing.Size(230, 40);
            this.btn_deleteFood.TabIndex = 8;
            this.btn_deleteFood.Text = "Delete";
            this.btn_deleteFood.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_deleteFood.UseSelectable = true;
            this.btn_deleteFood.Click += new System.EventHandler(this.btn_deleteFood_Click);
            // 
            // btn_updateFood
            // 
            this.btn_updateFood.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_updateFood.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_updateFood.Location = new System.Drawing.Point(15, 77);
            this.btn_updateFood.Name = "btn_updateFood";
            this.btn_updateFood.Size = new System.Drawing.Size(230, 40);
            this.btn_updateFood.TabIndex = 7;
            this.btn_updateFood.Text = "Update";
            this.btn_updateFood.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_updateFood.UseSelectable = true;
            this.btn_updateFood.Click += new System.EventHandler(this.btn_updateFood_Click);
            // 
            // txt_foodName
            // 
            // 
            // 
            // 
            this.txt_foodName.CustomButton.Image = null;
            this.txt_foodName.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_foodName.CustomButton.Name = "";
            this.txt_foodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_foodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_foodName.CustomButton.TabIndex = 1;
            this.txt_foodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_foodName.CustomButton.UseSelectable = true;
            this.txt_foodName.CustomButton.Visible = false;
            this.txt_foodName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_foodName.Lines = new string[0];
            this.txt_foodName.Location = new System.Drawing.Point(108, 19);
            this.txt_foodName.MaxLength = 32767;
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.PasswordChar = '\0';
            this.txt_foodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_foodName.SelectedText = "";
            this.txt_foodName.SelectionLength = 0;
            this.txt_foodName.SelectionStart = 0;
            this.txt_foodName.ShortcutsEnabled = true;
            this.txt_foodName.Size = new System.Drawing.Size(137, 23);
            this.txt_foodName.TabIndex = 3;
            this.txt_foodName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_foodName.UseSelectable = true;
            this.txt_foodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_foodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Food Price: ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Food Name: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_foodPrice
            // 
            // 
            // 
            // 
            this.txt_foodPrice.CustomButton.Image = null;
            this.txt_foodPrice.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_foodPrice.CustomButton.Name = "";
            this.txt_foodPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_foodPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_foodPrice.CustomButton.TabIndex = 1;
            this.txt_foodPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_foodPrice.CustomButton.UseSelectable = true;
            this.txt_foodPrice.CustomButton.Visible = false;
            this.txt_foodPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_foodPrice.Lines = new string[0];
            this.txt_foodPrice.Location = new System.Drawing.Point(108, 48);
            this.txt_foodPrice.MaxLength = 32767;
            this.txt_foodPrice.Name = "txt_foodPrice";
            this.txt_foodPrice.PasswordChar = '\0';
            this.txt_foodPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_foodPrice.SelectedText = "";
            this.txt_foodPrice.SelectionLength = 0;
            this.txt_foodPrice.SelectionStart = 0;
            this.txt_foodPrice.ShortcutsEnabled = true;
            this.txt_foodPrice.Size = new System.Drawing.Size(137, 23);
            this.txt_foodPrice.TabIndex = 5;
            this.txt_foodPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_foodPrice.UseSelectable = true;
            this.txt_foodPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_foodPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lst_foods
            // 
            this.lst_foods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_foods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.lst_foods.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lst_foods.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lst_foods.FullRowSelect = true;
            this.lst_foods.Location = new System.Drawing.Point(3, 8);
            this.lst_foods.Name = "lst_foods";
            this.lst_foods.OwnerDraw = true;
            this.lst_foods.Size = new System.Drawing.Size(197, 427);
            this.lst_foods.TabIndex = 2;
            this.lst_foods.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lst_foods.UseCompatibleStateImageBehavior = false;
            this.lst_foods.UseSelectable = true;
            this.lst_foods.View = System.Windows.Forms.View.List;
            this.lst_foods.SelectedIndexChanged += new System.EventHandler(this.lst_foods_SelectedIndexChanged);
            // 
            // tab_drinks
            // 
            this.tab_drinks.Controls.Add(this.groupBox2);
            this.tab_drinks.Controls.Add(this.groupBox3);
            this.tab_drinks.Controls.Add(this.lst_drinks);
            this.tab_drinks.HorizontalScrollbarBarColor = true;
            this.tab_drinks.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_drinks.HorizontalScrollbarSize = 10;
            this.tab_drinks.Location = new System.Drawing.Point(4, 38);
            this.tab_drinks.Name = "tab_drinks";
            this.tab_drinks.Size = new System.Drawing.Size(772, 450);
            this.tab_drinks.TabIndex = 4;
            this.tab_drinks.Text = "    Drinks Menu    ";
            this.tab_drinks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tab_drinks.VerticalScrollbarBarColor = true;
            this.tab_drinks.VerticalScrollbarHighlightOnWheel = false;
            this.tab_drinks.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox2.Controls.Add(this.btn_addDrink);
            this.groupBox2.Controls.Add(this.txt_newDrinkName);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txt_newDrinkPrice);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(206, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 127);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Food";
            // 
            // btn_addDrink
            // 
            this.btn_addDrink.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_addDrink.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_addDrink.Location = new System.Drawing.Point(15, 77);
            this.btn_addDrink.Name = "btn_addDrink";
            this.btn_addDrink.Size = new System.Drawing.Size(230, 40);
            this.btn_addDrink.TabIndex = 7;
            this.btn_addDrink.Text = "Add To Menu";
            this.btn_addDrink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_addDrink.UseSelectable = true;
            this.btn_addDrink.Click += new System.EventHandler(this.btn_addDrink_Click);
            // 
            // txt_newDrinkName
            // 
            // 
            // 
            // 
            this.txt_newDrinkName.CustomButton.Image = null;
            this.txt_newDrinkName.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_newDrinkName.CustomButton.Name = "";
            this.txt_newDrinkName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_newDrinkName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_newDrinkName.CustomButton.TabIndex = 1;
            this.txt_newDrinkName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_newDrinkName.CustomButton.UseSelectable = true;
            this.txt_newDrinkName.CustomButton.Visible = false;
            this.txt_newDrinkName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_newDrinkName.Lines = new string[0];
            this.txt_newDrinkName.Location = new System.Drawing.Point(108, 19);
            this.txt_newDrinkName.MaxLength = 32767;
            this.txt_newDrinkName.Name = "txt_newDrinkName";
            this.txt_newDrinkName.PasswordChar = '\0';
            this.txt_newDrinkName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_newDrinkName.SelectedText = "";
            this.txt_newDrinkName.SelectionLength = 0;
            this.txt_newDrinkName.SelectionStart = 0;
            this.txt_newDrinkName.ShortcutsEnabled = true;
            this.txt_newDrinkName.Size = new System.Drawing.Size(137, 23);
            this.txt_newDrinkName.TabIndex = 3;
            this.txt_newDrinkName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_newDrinkName.UseSelectable = true;
            this.txt_newDrinkName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_newDrinkName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 48);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Drink Price:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 19);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Drink Name:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_newDrinkPrice
            // 
            // 
            // 
            // 
            this.txt_newDrinkPrice.CustomButton.Image = null;
            this.txt_newDrinkPrice.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_newDrinkPrice.CustomButton.Name = "";
            this.txt_newDrinkPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_newDrinkPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_newDrinkPrice.CustomButton.TabIndex = 1;
            this.txt_newDrinkPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_newDrinkPrice.CustomButton.UseSelectable = true;
            this.txt_newDrinkPrice.CustomButton.Visible = false;
            this.txt_newDrinkPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_newDrinkPrice.Lines = new string[0];
            this.txt_newDrinkPrice.Location = new System.Drawing.Point(108, 48);
            this.txt_newDrinkPrice.MaxLength = 32767;
            this.txt_newDrinkPrice.Name = "txt_newDrinkPrice";
            this.txt_newDrinkPrice.PasswordChar = '\0';
            this.txt_newDrinkPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_newDrinkPrice.SelectedText = "";
            this.txt_newDrinkPrice.SelectionLength = 0;
            this.txt_newDrinkPrice.SelectionStart = 0;
            this.txt_newDrinkPrice.ShortcutsEnabled = true;
            this.txt_newDrinkPrice.Size = new System.Drawing.Size(137, 23);
            this.txt_newDrinkPrice.TabIndex = 5;
            this.txt_newDrinkPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_newDrinkPrice.UseSelectable = true;
            this.txt_newDrinkPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_newDrinkPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox3.Controls.Add(this.btn_deleteDrink);
            this.groupBox3.Controls.Add(this.btn_updateDrink);
            this.groupBox3.Controls.Add(this.txt_drinkName);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.txt_drinkPrice);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Location = new System.Drawing.Point(206, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 175);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Item: ";
            // 
            // btn_deleteDrink
            // 
            this.btn_deleteDrink.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_deleteDrink.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_deleteDrink.Location = new System.Drawing.Point(15, 123);
            this.btn_deleteDrink.Name = "btn_deleteDrink";
            this.btn_deleteDrink.Size = new System.Drawing.Size(230, 40);
            this.btn_deleteDrink.TabIndex = 8;
            this.btn_deleteDrink.Text = "Delete";
            this.btn_deleteDrink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_deleteDrink.UseSelectable = true;
            this.btn_deleteDrink.Click += new System.EventHandler(this.btn_deleteDrink_Click);
            // 
            // btn_updateDrink
            // 
            this.btn_updateDrink.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_updateDrink.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_updateDrink.Location = new System.Drawing.Point(15, 77);
            this.btn_updateDrink.Name = "btn_updateDrink";
            this.btn_updateDrink.Size = new System.Drawing.Size(230, 40);
            this.btn_updateDrink.TabIndex = 7;
            this.btn_updateDrink.Text = "Update";
            this.btn_updateDrink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_updateDrink.UseSelectable = true;
            this.btn_updateDrink.Click += new System.EventHandler(this.btn_updateDrink_Click);
            // 
            // txt_drinkName
            // 
            // 
            // 
            // 
            this.txt_drinkName.CustomButton.Image = null;
            this.txt_drinkName.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_drinkName.CustomButton.Name = "";
            this.txt_drinkName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_drinkName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_drinkName.CustomButton.TabIndex = 1;
            this.txt_drinkName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_drinkName.CustomButton.UseSelectable = true;
            this.txt_drinkName.CustomButton.Visible = false;
            this.txt_drinkName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_drinkName.Lines = new string[0];
            this.txt_drinkName.Location = new System.Drawing.Point(108, 19);
            this.txt_drinkName.MaxLength = 32767;
            this.txt_drinkName.Name = "txt_drinkName";
            this.txt_drinkName.PasswordChar = '\0';
            this.txt_drinkName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_drinkName.SelectedText = "";
            this.txt_drinkName.SelectionLength = 0;
            this.txt_drinkName.SelectionStart = 0;
            this.txt_drinkName.ShortcutsEnabled = true;
            this.txt_drinkName.Size = new System.Drawing.Size(137, 23);
            this.txt_drinkName.TabIndex = 3;
            this.txt_drinkName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_drinkName.UseSelectable = true;
            this.txt_drinkName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_drinkName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 48);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Drink Price:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(15, 19);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(82, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Drink Name:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_drinkPrice
            // 
            // 
            // 
            // 
            this.txt_drinkPrice.CustomButton.Image = null;
            this.txt_drinkPrice.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_drinkPrice.CustomButton.Name = "";
            this.txt_drinkPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_drinkPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_drinkPrice.CustomButton.TabIndex = 1;
            this.txt_drinkPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_drinkPrice.CustomButton.UseSelectable = true;
            this.txt_drinkPrice.CustomButton.Visible = false;
            this.txt_drinkPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_drinkPrice.Lines = new string[0];
            this.txt_drinkPrice.Location = new System.Drawing.Point(108, 48);
            this.txt_drinkPrice.MaxLength = 32767;
            this.txt_drinkPrice.Name = "txt_drinkPrice";
            this.txt_drinkPrice.PasswordChar = '\0';
            this.txt_drinkPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_drinkPrice.SelectedText = "";
            this.txt_drinkPrice.SelectionLength = 0;
            this.txt_drinkPrice.SelectionStart = 0;
            this.txt_drinkPrice.ShortcutsEnabled = true;
            this.txt_drinkPrice.Size = new System.Drawing.Size(137, 23);
            this.txt_drinkPrice.TabIndex = 5;
            this.txt_drinkPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_drinkPrice.UseSelectable = true;
            this.txt_drinkPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_drinkPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lst_drinks
            // 
            this.lst_drinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_drinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.lst_drinks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lst_drinks.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lst_drinks.FullRowSelect = true;
            this.lst_drinks.Location = new System.Drawing.Point(3, 8);
            this.lst_drinks.Name = "lst_drinks";
            this.lst_drinks.OwnerDraw = true;
            this.lst_drinks.Size = new System.Drawing.Size(197, 427);
            this.lst_drinks.TabIndex = 10;
            this.lst_drinks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lst_drinks.UseCompatibleStateImageBehavior = false;
            this.lst_drinks.UseSelectable = true;
            this.lst_drinks.View = System.Windows.Forms.View.List;
            this.lst_drinks.SelectedIndexChanged += new System.EventHandler(this.lst_drinks_SelectedIndexChanged);
            // 
            // tab_kitchen
            // 
            this.tab_kitchen.Controls.Add(this.lst_foodsOrdered);
            this.tab_kitchen.Controls.Add(this.lst_kitchen);
            this.tab_kitchen.Controls.Add(this.switch_kitchen);
            this.tab_kitchen.Controls.Add(this.metroLabel11);
            this.tab_kitchen.Controls.Add(this.metroLabel10);
            this.tab_kitchen.Controls.Add(this.num_kitchen);
            this.tab_kitchen.Controls.Add(this.metroLabel9);
            this.tab_kitchen.HorizontalScrollbarBarColor = true;
            this.tab_kitchen.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_kitchen.HorizontalScrollbarSize = 10;
            this.tab_kitchen.Location = new System.Drawing.Point(4, 38);
            this.tab_kitchen.Name = "tab_kitchen";
            this.tab_kitchen.Size = new System.Drawing.Size(772, 450);
            this.tab_kitchen.TabIndex = 1;
            this.tab_kitchen.Text = "    Kitchen page    ";
            this.tab_kitchen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tab_kitchen.VerticalScrollbarBarColor = true;
            this.tab_kitchen.VerticalScrollbarHighlightOnWheel = false;
            this.tab_kitchen.VerticalScrollbarSize = 10;
            // 
            // switch_kitchen
            // 
            this.switch_kitchen.AutoSize = true;
            this.switch_kitchen.Location = new System.Drawing.Point(625, 19);
            this.switch_kitchen.Name = "switch_kitchen";
            this.switch_kitchen.Size = new System.Drawing.Size(80, 17);
            this.switch_kitchen.TabIndex = 8;
            this.switch_kitchen.Text = "Off";
            this.switch_kitchen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.switch_kitchen.UseSelectable = true;
            this.switch_kitchen.CheckedChanged += new System.EventHandler(this.switch_kitchen_CheckedChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(559, 17);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(60, 19);
            this.metroLabel11.TabIndex = 7;
            this.metroLabel11.Text = "Seconds.";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(407, 17);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(87, 19);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "Update Every";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // num_kitchen
            // 
            this.num_kitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.num_kitchen.DecimalPlaces = 2;
            this.num_kitchen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_kitchen.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.num_kitchen.Location = new System.Drawing.Point(500, 17);
            this.num_kitchen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_kitchen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_kitchen.Name = "num_kitchen";
            this.num_kitchen.Size = new System.Drawing.Size(53, 25);
            this.num_kitchen.TabIndex = 5;
            this.num_kitchen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(407, 53);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(90, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Ordered Item";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tab_service
            // 
            this.tab_service.Controls.Add(this.lst_service);
            this.tab_service.Controls.Add(this.switch_service);
            this.tab_service.Controls.Add(this.metroLabel12);
            this.tab_service.Controls.Add(this.metroLabel13);
            this.tab_service.Controls.Add(this.num_service);
            this.tab_service.HorizontalScrollbarBarColor = true;
            this.tab_service.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_service.HorizontalScrollbarSize = 10;
            this.tab_service.Location = new System.Drawing.Point(4, 38);
            this.tab_service.Name = "tab_service";
            this.tab_service.Size = new System.Drawing.Size(772, 450);
            this.tab_service.TabIndex = 2;
            this.tab_service.Text = "     Service page    ";
            this.tab_service.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tab_service.VerticalScrollbarBarColor = true;
            this.tab_service.VerticalScrollbarHighlightOnWheel = false;
            this.tab_service.VerticalScrollbarSize = 10;
            // 
            // lbl_response
            // 
            this.lbl_response.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_response.AutoSize = true;
            this.lbl_response.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_response.Location = new System.Drawing.Point(27, 558);
            this.lbl_response.Name = "lbl_response";
            this.lbl_response.Size = new System.Drawing.Size(89, 13);
            this.lbl_response.TabIndex = 2;
            this.lbl_response.Text = "Server Response";
            // 
            // timer_order
            // 
            this.timer_order.Tick += new System.EventHandler(this.timer_order_Tick);
            // 
            // timer_service
            // 
            this.timer_service.Tick += new System.EventHandler(this.timer_service_Tick);
            // 
            // lst_kitchen
            // 
            this.lst_kitchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_kitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.lst_kitchen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lst_kitchen.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lst_kitchen.FullRowSelect = true;
            this.lst_kitchen.Location = new System.Drawing.Point(3, 8);
            this.lst_kitchen.Name = "lst_kitchen";
            this.lst_kitchen.OwnerDraw = true;
            this.lst_kitchen.Size = new System.Drawing.Size(398, 439);
            this.lst_kitchen.TabIndex = 11;
            this.lst_kitchen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lst_kitchen.UseCompatibleStateImageBehavior = false;
            this.lst_kitchen.UseSelectable = true;
            this.lst_kitchen.View = System.Windows.Forms.View.List;
            this.lst_kitchen.ItemAdded += new System.Action<MetroFramework.Controls.MetroListView>(this.lst_kitchen_ItemAdded);
            this.lst_kitchen.SelectedIndexChanged += new System.EventHandler(this.lst_kitchen_SelectedIndexChanged);
            // 
            // lst_foodsOrdered
            // 
            this.lst_foodsOrdered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.lst_foodsOrdered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lst_foodsOrdered.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lst_foodsOrdered.FullRowSelect = true;
            this.lst_foodsOrdered.Location = new System.Drawing.Point(407, 75);
            this.lst_foodsOrdered.Name = "lst_foodsOrdered";
            this.lst_foodsOrdered.OwnerDraw = true;
            this.lst_foodsOrdered.Size = new System.Drawing.Size(362, 372);
            this.lst_foodsOrdered.TabIndex = 12;
            this.lst_foodsOrdered.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lst_foodsOrdered.UseCompatibleStateImageBehavior = false;
            this.lst_foodsOrdered.UseSelectable = true;
            this.lst_foodsOrdered.View = System.Windows.Forms.View.List;
            // 
            // lst_service
            // 
            this.lst_service.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lst_service.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.lst_service.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lst_service.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lst_service.FullRowSelect = true;
            this.lst_service.Location = new System.Drawing.Point(3, 9);
            this.lst_service.Name = "lst_service";
            this.lst_service.OwnerDraw = true;
            this.lst_service.Size = new System.Drawing.Size(398, 439);
            this.lst_service.TabIndex = 16;
            this.lst_service.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lst_service.UseCompatibleStateImageBehavior = false;
            this.lst_service.UseSelectable = true;
            this.lst_service.View = System.Windows.Forms.View.List;
            // 
            // switch_service
            // 
            this.switch_service.AutoSize = true;
            this.switch_service.Location = new System.Drawing.Point(625, 20);
            this.switch_service.Name = "switch_service";
            this.switch_service.Size = new System.Drawing.Size(80, 17);
            this.switch_service.TabIndex = 15;
            this.switch_service.Text = "Off";
            this.switch_service.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.switch_service.UseSelectable = true;
            this.switch_service.CheckedChanged += new System.EventHandler(this.switch_service_CheckedChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(559, 18);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(60, 19);
            this.metroLabel12.TabIndex = 14;
            this.metroLabel12.Text = "Seconds.";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(407, 18);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(87, 19);
            this.metroLabel13.TabIndex = 13;
            this.metroLabel13.Text = "Update Every";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // num_service
            // 
            this.num_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.num_service.DecimalPlaces = 2;
            this.num_service.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_service.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.num_service.Location = new System.Drawing.Point(500, 18);
            this.num_service.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_service.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_service.Name = "num_service";
            this.num_service.Size = new System.Drawing.Size(53, 25);
            this.num_service.TabIndex = 12;
            this.num_service.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // switch_sound
            // 
            this.switch_sound.AutoSize = true;
            this.switch_sound.Location = new System.Drawing.Point(254, 104);
            this.switch_sound.Name = "switch_sound";
            this.switch_sound.Size = new System.Drawing.Size(80, 17);
            this.switch_sound.TabIndex = 10;
            this.switch_sound.Text = "Off";
            this.switch_sound.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.switch_sound.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(3, 96);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(245, 25);
            this.metroLabel14.TabIndex = 9;
            this.metroLabel14.Text = "Play Sound On Order/Service: ";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 578);
            this.Controls.Add(this.lbl_response);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Thai Som Tam Seafood App";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.tab_home.ResumeLayout(false);
            this.tab_home.PerformLayout();
            this.tab_foods.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_food.ResumeLayout(false);
            this.grp_food.PerformLayout();
            this.tab_drinks.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tab_kitchen.ResumeLayout(false);
            this.tab_kitchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_kitchen)).EndInit();
            this.tab_service.ResumeLayout(false);
            this.tab_service.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_foods;
        private MetroFramework.Controls.MetroTabPage tab_kitchen;
        private MetroFramework.Controls.MetroTabPage tab_service;
        private MetroFramework.Controls.MetroTabPage tab_home;
        private MetroFramework.Controls.MetroLabel lbl_drinkCount;
        private MetroFramework.Controls.MetroLabel lbl_foodCount;
        private MetroFramework.Controls.MetroLabel lbl_status;
        private System.Windows.Forms.Label lbl_response;
        private MetroFramework.Controls.MetroButton btn_refresh;
        private MetroFramework.Controls.MetroButton btn_SetDefault;
        private MetroFramework.Controls.MetroListView lst_foods;
        private MetroFramework.Controls.MetroTabPage tab_drinks;
        private MetroFramework.Controls.MetroTextBox txt_foodName;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btn_addFood;
        private MetroFramework.Controls.MetroTextBox txt_newFoodName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_newFoodPrice;
        private System.Windows.Forms.GroupBox grp_food;
        private MetroFramework.Controls.MetroButton btn_deleteFood;
        private MetroFramework.Controls.MetroButton btn_updateFood;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_foodPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btn_addDrink;
        private MetroFramework.Controls.MetroTextBox txt_newDrinkName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_newDrinkPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btn_deleteDrink;
        private MetroFramework.Controls.MetroButton btn_updateDrink;
        private MetroFramework.Controls.MetroTextBox txt_drinkName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_drinkPrice;
        private MetroFramework.Controls.MetroListView lst_drinks;
        private MetroFramework.Controls.MetroToggle switch_kitchen;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.NumericUpDown num_kitchen;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.Timer timer_order;
        private System.Windows.Forms.Timer timer_service;
        private MetroFramework.Controls.MetroListView lst_kitchen;
        private MetroFramework.Controls.MetroListView lst_foodsOrdered;
        private MetroFramework.Controls.MetroListView lst_service;
        private MetroFramework.Controls.MetroToggle switch_service;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.NumericUpDown num_service;
        private MetroFramework.Controls.MetroToggle switch_sound;
        private MetroFramework.Controls.MetroLabel metroLabel14;
    }
}

