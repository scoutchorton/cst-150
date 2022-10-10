namespace Milestone2 {
    class SizeException : Exception {
        public SizeException() : base("Invalid size.") {}
    }

    class InventoryItem {
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

        public void takeItem() {
            takeItem(1);
        }
        public void takeItem(int count) {
            // Check for amount in storage
            if(count > inStorage)
                throw new SizeException();

            // Remove from storage
            inStorage -= count;
        }

        public void returnItem() {
            returnItem(1);
        }
        public void returnItem(int count) {
            // Check if storage is full
            if(inStorage + count > totalStorage)
                throw new SizeException();

            // Add back to storage
            inStorage += count;
        }
    }
}
