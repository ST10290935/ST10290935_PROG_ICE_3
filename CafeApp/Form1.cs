namespace CafeApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> menu = new Dictionary<string, decimal>
        {
            {"Coffee", 10.99m},
            {"Tea", 13.00m},
            {"Sandwich", 25.00m},
            {"Cake", 15.00m},
            {"Juice",20.00m },
            {"Cupcake", 10.00m }

        };

        List<Tuple<string, int>> order = new List<Tuple<string, int>>();
        public Form1()
        {
            InitializeComponent();
            PopulateMenu();
        }
        private void PopulateMenu()
        {
            foreach (var item in menu.Keys)
            {
                comboBoxItems.Items.Add(item);
            }
        }
        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBoxItems.SelectedItem as string;
            if (selectedItem != null)
            {
                int quantity = (int)numericUpDownQuantity.Value;
                order.Add(new Tuple<string, int>(selectedItem, quantity));
                MessageBox.Show("Item added to order: " + selectedItem + " x" + quantity);
            }
            else
            {
                MessageBox.Show("Please select an item from the menu.");
            }
        }

        private void buttonShowReceipt_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            string receipt = "Receipt:\n";

            foreach (var item in order)
            {
                string itemName = item.Item1;
                int quantity = item.Item2;
                decimal price = menu[itemName];
                decimal subtotal = price * quantity;

                receipt += $"{itemName} x{quantity}: R{price} each, Subtotal: R{subtotal}\n";
                total += subtotal;
            }

            receipt += $"\nTotal: R{total}";

            MessageBox.Show(receipt, "Order Receipt");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
