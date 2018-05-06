using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ThaiSomAdminApp
{

    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public const string Host = "http://kadirapp.azurewebsites.net/api/food/";
        public List<Item> Foods = new List<Item>();
        public List<Item> Drinks = new List<Item>();
        public List<Order> Orders = new List<Order>();
        public List<string> Services = new List<string>();
        Item _selectedFood = null;
        Item _selectedDrink = null;

        public Menu()
        {
            InitializeComponent();
            DownloadContent();
        }

        public void DownloadContent()
        {
            lbl_status.Text = $@"Server Connection Status: {Request.Get(Host + "Status")}";
            lbl_foodCount.Text = $@"Food Menu Count: {GetFoods().Count}";
            lbl_drinkCount.Text = $@"Drink Menu Count:{GetDrinks().Count}";

        }

        private void btn_SetDefault_Click_1(object sender, EventArgs e)
        {
            List<Item> Foods = new List<Item>();
            Foods.Add(new Item("Burger", 1.20));
            Foods.Add(new Item("Fries", 2.20));
            Foods.Add(new Item("Hot Dog", 3.20));
            Foods.Add(new Item("Salmon", 4.20));
            Foods.Add(new Item("Loli", 5.20));
            lbl_response.Text = Request.Put(Host + "UpdateFoods", WebUtility.HtmlEncode(JsonConvert.SerializeObject(Foods)));

            List<Item> Drinks = new List<Item>();
            Drinks.Add(new Item("LMAO ais", 1.20));
            Drinks.Add(new Item("teh ais", 2.20));
            Drinks.Add(new Item("Ais Kosong", 2.20));
            Drinks.Add(new Item("strawberry", 3.20));
            lbl_response.Text = Request.Put(Host + "UpdateDrinks", WebUtility.HtmlEncode(JsonConvert.SerializeObject(Drinks)));

            DownloadContent();
        }

        public List<Item> GetFoods()
        {
            Foods = JsonConvert.DeserializeObject<List<Item>>(Request.Get("http://kadirapp.azurewebsites.net/api/Food/AllFoods"));
            UpdateFoodList();
            return Foods;
        }
        public List<Item> GetDrinks()
        {
           Drinks = JsonConvert.DeserializeObject<List<Item>>(Request.Get("http://kadirapp.azurewebsites.net/api/Food/AllDrinks"));
            UpdateDrinkList();
            return Drinks;
        }

        private void UpdateFoodList()
        {
            lst_foods.Clear();
            foreach (var food in Foods)
            {
                lst_foods.Items.Add(new ListViewItem(food.Name) { Tag = food });
            }
        }

        private void UpdateDrinkList()
        {
            lst_drinks.Clear();
            foreach (var drink in Drinks)
            {
                lst_drinks.Items.Add(new ListViewItem(drink.Name) { Tag = drink });
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DownloadContent();
        }

        private void lst_foods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = (Item)lst_foods.SelectedItems[0].Tag;
            _selectedFood = Foods.Find(o => o.Name.Contains(i.Name));
            txt_foodName.Text = _selectedFood.Name;
            txt_foodPrice.Text = _selectedFood.Price.ToString();
        }

        private void btn_updateFood_Click(object sender, EventArgs e)
        {
            if (_selectedFood == null) return;
            _selectedFood.Name = txt_foodName.Text;
            if(double.TryParse(txt_foodPrice.Text,out var price))
            {
                _selectedFood.Price = price;
            }
            else
            {
                MessageBox.Show("Please enter valid number");
            }
            UpdateFoodList();
            lbl_response.Text =  Request.Put(Host + "UpdateFoods", WebUtility.HtmlEncode(JsonConvert.SerializeObject(Foods)));
        }
        private void btn_addFood_Click(object sender, EventArgs e)
        {
            var foodName = txt_newFoodName.Text;
            if (double.TryParse(txt_newFoodPrice.Text, out var foodPrice))
            {
                Foods.Add(new Item(foodName,foodPrice));
                UpdateFoodList();
                lbl_response.Text = Request.Put(Host + "UpdateFoods", WebUtility.HtmlEncode(JsonConvert.SerializeObject(Foods)));
            }
            else
            {
                MessageBox.Show("Please enter valid number");
            }
        }

        private void btn_deleteFood_Click(object sender, EventArgs e)
        {
            if (_selectedFood == null) return;
            Foods.Remove(_selectedFood);
            UpdateFoodList();
            txt_foodName.Text = "";
            txt_foodPrice.Text = "";
            lbl_response.Text = Request.Put(Host + "UpdateFoods", WebUtility.HtmlEncode(JsonConvert.SerializeObject(Foods)));
        }

        private void lst_drinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = (Item)lst_drinks.SelectedItems[0].Tag;
            _selectedDrink = Drinks.Find(o => o.Name.Contains(i.Name));
            txt_drinkName.Text = _selectedDrink.Name;
            txt_drinkPrice.Text = _selectedDrink.Price.ToString();
        }

        private void btn_updateDrink_Click(object sender, EventArgs e)
        {
            if (_selectedDrink == null) return;
            _selectedDrink.Name = txt_drinkName.Text;
            if (double.TryParse(txt_drinkPrice.Text, out var price))
            {
                _selectedDrink.Price = price;
            }
            else
            {
                MessageBox.Show("Please enter valid number");
            }
            UpdateDrinkList();
            lbl_response.Text = Request.Put(Host + "UpdateDrinks", WebUtility.HtmlEncode(JsonConvert.SerializeObject(Drinks)));
        }

        private void btn_deleteDrink_Click(object sender, EventArgs e)
        {
            if (_selectedDrink == null) return;
            Drinks.Remove(_selectedDrink);
            UpdateDrinkList();
            txt_drinkName.Text = "";
            txt_drinkPrice.Text = "";
            lbl_response.Text = Request.Put(Host + "UpdateDrinks", WebUtility.HtmlEncode(JsonConvert.SerializeObject(Drinks)));
        }

        private void btn_addDrink_Click(object sender, EventArgs e)
        {
            var drinkName = txt_newDrinkName.Text;
            if (double.TryParse(txt_newDrinkPrice.Text, out var drinkPrice))
            {
                Drinks.Add(new Item(drinkName, drinkPrice));
                UpdateDrinkList();
                lbl_response.Text = Request.Put(Host + "UpdateDrinks", WebUtility.HtmlEncode(JsonConvert.SerializeObject(Drinks)));
            }
            else
            {
                MessageBox.Show("Please enter valid number");
            }
        }

        private void switch_kitchen_CheckedChanged(object sender, EventArgs e)
        {
            timer_order.Interval = (int) (num_kitchen.Value * 1000);
            timer_order.Enabled = switch_kitchen.Checked;
        }

        private void timer_order_Tick(object sender, EventArgs e)
        {
            var orders = JsonConvert.DeserializeObject<List<Order>>(Request.Get("http://kadirapp.azurewebsites.net/api/Food/AllOrders"));
            if (Orders.Count != 0 && Orders.Count != 0 && orders.Last().date.Equals(Orders.Last().date)) return;

            if (switch_sound.Checked) new SpeechSynthesizer().SpeakAsync("You have a new Order");
            lst_kitchen.Clear();
            Orders = orders;
            var tmp = new List<Order>(orders);
            tmp.Reverse();
            foreach (var order in tmp)
            {
                lst_kitchen.Items.Add(new ListViewItem($"Table [{order.TableName}] - {order.date:G}") { Tag = order });
            }
            
        }

        private void timer_service_Tick(object sender, EventArgs e)
        {
            var services = JsonConvert.DeserializeObject<List<string>>(Request.Get("http://kadirapp.azurewebsites.net/api/Food/AllServices"));
            lbl_response.Text = services.Count.ToString();
            if (Services.Count != 0 && services.Count != 0 && Services.Last().Equals(services.Last())) return;

            if (switch_sound.Checked) new SpeechSynthesizer().SpeakAsync("You have a new request");
            lst_service.Clear();
            Services = services;
            var tmp = new List<string>(services);
            tmp.Reverse();
            foreach (var service in tmp)
            {
                lst_service.Items.Add(new ListViewItem(service));
            }
        }

        private void lst_kitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_foodsOrdered.Clear();
            Order o = (Order)lst_kitchen.SelectedItems[0].Tag;
            foreach (var item in o.OrderItem)
            {
                lst_foodsOrdered.Items.Add(new ListViewItem(item.Name));
            }
        }

        private void switch_service_CheckedChanged(object sender, EventArgs e)
        {
            timer_service.Interval = (int)(num_service.Value * 1000);
            timer_service.Enabled = switch_service.Checked;
        }

        private void lst_kitchen_ItemAdded(MetroFramework.Controls.MetroListView obj)
        {
            
        }
    }
    public class Item
    {
        public string Name;
        public double Price;

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetRm()
        {
            return $"RM{Price:##.00}";
        }
    }

    public class Order
    {
        public string TableName;
        public List<Item> OrderItem;
        public DateTime date;

        public Order(string tbName, List<Item> items,DateTime dt)
        {
            TableName = tbName;
            OrderItem = items;
            date =dt;
        }
    }

    public class Request
    {
        public static string Post(string address, string data)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(address);
            httpWebRequest.ContentType = "application /json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

        public static string Get(string address)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(address);
            httpWebRequest.Method = "Get";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var response = streamReader.ReadToEnd();
                response = WebUtility.HtmlDecode(response);
                if (response.StartsWith("\"")) response = response.Remove(0, 1);
                if (response.EndsWith("\"")) response = response.Remove(response.Length - 1);
                return response;
            }
        }

        public static string Put(string address, string data)
        {
            data = $"\"{data}\"";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(address);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


    }
}
