namespace Milestone4 {
    public enum SearchType {
        NAME,
        SIZE,
        BRAND,
        MODEL,
        LENGTH
    }

    public class InventoryManager {
        private List<InventoryItem> items = new List<InventoryItem>();
        public int Count { get { return items.Count; } }
        // https://stackoverflow.com/a/1499107
        public InventoryItem this[int index] {
            get { return items[index]; }
        }

        public InventoryManager() { }

        /// <summary>
        /// Add an item to the inventory manager
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Index of item, or -1 if already in the list</returns>
        public int add(InventoryItem item) {
            if(items.Contains(item)) return -1;

            items.Add(item);
            return items.Count;
        }

        /// <summary>
        /// Remove an item from the inventory manager
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True when removed, false when not found or an issue occurred</returns>
        public bool remove(InventoryItem item) {
            return items.Remove(item);
        }
        /// <summary>
        /// Remove an item from the inventory manager
        /// </summary>
        /// <param name="index"></param>
        /// <returns>True when removed, false when not found or an issue occurred</returns>
        public bool remove(int index) {
            try {
                items.RemoveAt(index);
            } catch(ArgumentOutOfRangeException) {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Stock an amount of each item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="amount"></param>
        /// <returns>New total amount after adding stock</returns>
        public int restock(InventoryItem item, int amount) {
            int index = items.IndexOf(item);

            if(index == -1) return -1;
            else if(amount <= 0) return -1;

            items[index].stock(amount);
            return items[index].totalStorage;
        }

        /// <summary>
        /// Display all items in the inventory
        /// </summary>
        public void display() {
            for(int index = 0; index < items.Count; index++) {
                InventoryItem item = items[index];

                Console.Write(String.Format("#{0} ", index));
                Console.Write(String.Format("{0} ({1}, {2}) ", item.name, item.brand, item.model));
                Console.Write(String.Format("{0} {1} @ {2} {3} ", item.type, item.size, item.length, item.lengthUnit));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Search for an item by value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns>The item if found, null otherwise</returns>
        public InventoryItem? search(string value, SearchType type) {
            foreach(InventoryItem item in items) {
                switch(type) {
                    case SearchType.NAME:
                        if(item.name == value) return item;
                        break;
                    case SearchType.SIZE:
                        if(item.size == value) return item;
                        break;
                    case SearchType.BRAND:
                        if(item.brand == value) return item;
                        break;
                    case SearchType.MODEL:
                        if(item.model == value) return item;
                        break;
                    case SearchType.LENGTH:
                        if(item.length.ToString() == value) return item;
                        break;
                }
            }

            return null;
        }
    }
}