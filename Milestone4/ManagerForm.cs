namespace Milestone4 {
    public partial class ManagerForm : Form {
        InventoryManager im = new InventoryManager();

        public ManagerForm() {
            InitializeComponent();
        }

        public void newItemHandler(object sender, EventArgs e) {
            // State validation
            if(newItemName.Text.Length == 0) {
                MessageBox.Show("Please enter a name for the new item.");
                return;
            }

            // Create and add item
            InventoryItem item = new InventoryItem(newItemName.Text, "size", "type", 1.0f, "units", "model", "brand", 1, 1);
            im.add(item);

            // 
        }
    }
}