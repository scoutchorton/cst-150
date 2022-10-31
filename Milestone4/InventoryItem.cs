namespace Milestone4 {
    class SizeException : Exception {
        public SizeException() : base("Invalid size.") {}
    }

    public class InventoryItem {
        public string name;
        public string size;
        public string type;
        public float length;
        public string lengthUnit;
        public string model;
        public string brand;
        private int __inStorage = 0;
        public int inStorage {
            get { return __inStorage; }
            set {
                if(value > totalStorage)
                    throw new SizeException();

                __inStorage = value;
            }
        }
        private int __totalStorage;
        public int totalStorage {
            get { return __totalStorage; }
            set {
                if(value < inStorage)
                    throw new SizeException();

                __totalStorage = value;
            }
        }

        public InventoryItem(string name, string size, string type, float length, string lengthUnit, string model, string brand, int inStorage, int totalStorage) {
            this.name = name;
            this.size = size;
            this.type = type;
            this.length = length;
            this.lengthUnit = lengthUnit;
            this.model = model;
            this.brand = brand;
            // Assign totalStorage first since inStorage will error out if more than total
            this.totalStorage = totalStorage;
            this.inStorage = inStorage;
        }

        /// <summary>
        /// Take a single item from storage
        /// </summary>
        public void take() {
            take(1);
        }
        /// <summary>
        /// Take an amount items from storage
        /// </summary>
        /// <param name="count"></param>
        /// <exception cref="SizeException">When attempting to take items that don't exist</exception>
        public void take(int count) {
            // Check for amount in storage
            if(count > inStorage || count < 0) throw new SizeException();

            // Remove from storage
            inStorage -= count;
        }

        /// <summary>
        /// Restore a single item to storage
        /// </summary>
        public void restore() {
            restore(1);
        }
        /// <summary>
        /// Restore an amount of items to storage
        /// </summary>
        /// <param name="count"></param>
        /// <exception cref="SizeException">When attempting to add items that there isn't room for</exception>
        public void restore(int count) {
            // Check if storage is full
            if(inStorage + count > totalStorage || count < 0) throw new SizeException();

            // Add back to storage
            inStorage += count;
        }

        /// <summary>
        /// Discard a single item
        /// </summary>
        public void discard() {
            discard(1);
        }
        /// <summary>
        /// Discard an amount of taken out items completely
        /// </summary>
        /// <param name="count"></param>
        /// <exception cref="SizeException">When attempting to take items that don't exist</exception>
        public void discard(int count) {
            // Check for amount in storage
            if(count > totalStorage || count > (totalStorage - inStorage) || count < 0) throw new SizeException();

            // Remove from storage
            totalStorage -= count;
        }

        /// <summary>
        /// Stock a single item
        /// </summary>
        public void stock() {
            stock(1);
        }
        /// <summary>
        /// Stock an amount of items, but don't put into storage yet (recieved in mail but not processed)
        /// </summary>
        /// <param name="count"></param>
        public void stock(int count) {
            if(count < 0) throw new SizeException();

            // Increment the stocked amount of items
            totalStorage += count;
        }
    }
}
