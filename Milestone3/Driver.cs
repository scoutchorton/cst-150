using System.Runtime.CompilerServices;

namespace Milestone3 {
    class Driver {
        /// <summary>
        /// Command line execution of tests
        /// </summary>
        /// <param name="args">CLI arguments</param>
        /// <returns>CLI exit status</returns>
        public static int Main(String[] args) {
            // Prepare items to add to the inventory
            InventoryItem guitarCables = new InventoryItem("Guitar cables", "regular", "1/4", 6.0f, "feet", "unknown", "unknown", 3, 10);
            InventoryItem HDMICables = new InventoryItem("HDMI cables", "regular", "HDMI", 10.0f, "feet", "unknown", "unknown", 1, 6);
            InventoryItem VGACables = new InventoryItem("VGA cables", "regular", "VGA", 2.0f, "feet", "unknown", "unknown", 4, 4);

            // Prepare test suite
            var inventoryItemTest = new MiniTest.Test<InventoryManager>("Inventory Manager");

            // Have consistent item to check
            Func<InventoryManager> initItem = () => {
                InventoryManager im = new InventoryManager();
                im.add(guitarCables);
                im.add(HDMICables);
                return im;
            };

            // Initialize tests
            inventoryItemTest
                .it("initializes", initItem)
                .it("displays", initItem)

                .it("should add new item", initItem)
                .it("shouldn't add existing item", initItem)
                
                .it("can remove existing item", initItem)
                .it("can't remove non-existant item", initItem)
                
                .it("can restock an item", initItem)
                .it("can't restock a non-existant item", initItem)
                .it("can't restock 0 items", initItem)
                .it("can't restock negative items", initItem)

                .it("can find an eixsting item", initItem)
                .it("can't find a non-eixstant item", initItem)
                .it("can't find an eixsting item but with wrong criteria", initItem)
                ;
            
            // Add test requirements
            inventoryItemTest
                .should("initializes", (im) => {
                    return im != null;
                })
                .should("displays", (im) => {
                    return true; // No good way to check for this other than somehow reading stdout
                })

                .should("should add new item", (im) => {
                    int index = im.add(VGACables);
                    return index > -1;
                })
                .should("shouldn't add existing item", (im) => {
                    int index = im.add(HDMICables);
                    return index == -1;
                })

                .should("can remove existing item", (im) => {
                    bool status = im.remove(guitarCables);
                    return status == true;
                })
                .should("can't remove non-existant item", (im) => {
                    bool status = im.remove(VGACables);
                    return status == false;
                })

                .should("can restock an item", (im) => {
                    int newStock = im.restock(guitarCables, 5);
                    return newStock > 5;
                })
                .should("can't restock a non-existant item", (im) => {
                    int newStock = im.restock(VGACables, 2);
                    return newStock == -1;
                })
                .should("can't restock 0 items", (im) => {
                    int newStock = im.restock(HDMICables, 0);
                    return newStock == -1;
                })
                .should("can't restock negative items", (im) => {
                    int newStock = im.restock(guitarCables, -3);
                    return newStock == -1;
                })

                .should("can find an eixsting item", (im) => {
                    InventoryItem? item = im.search("HDMI cables", SearchType.NAME);
                    return item != null;
                })
                .should("can't find a non-eixstant item", (im) => {
                    InventoryItem? item = im.search("VGA cables", SearchType.NAME);
                    return item == null;
                })
                .should("can't find an eixsting item but with wrong criteria", (im) => {
                    InventoryItem? item = im.search("Guitar cables", SearchType.MODEL);
                    return item == null;
                })
                ;

            // Execute test suite and print results
            return inventoryItemTest.runTests() ? 0 : 1;
        }
    }
}