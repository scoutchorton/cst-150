using System.Runtime.CompilerServices;

namespace Milestone3 {
    class Driver {
        /// <summary>
        /// Show the information about an InventoryItem in an organized fashion
        /// </summary>
        /// <param name="item">Item to display</param>
        private static void printItem(InventoryItem item) {
            Console.WriteLine(String.Format("{0} ({1}, {2})", item.name, item.brand, item.model));
            Console.WriteLine(String.Format("{0} {1} @ {2} {3}", item.type, item.size, item.length, item.lengthUnit));
            Console.WriteLine(String.Format("     Used: {0}", item.inStorage));
            Console.WriteLine(String.Format("Available: {0}", item.totalStorage - item.inStorage));
            Console.WriteLine(String.Format("    Total: {0} {1}%", item.totalStorage, ((float)item.inStorage / (float)item.totalStorage) * 100));
        }

        /// <summary>
        /// Command line execution of tests
        /// </summary>
        /// <param name="args">CLI arguments</param>
        /// <returns>CLI exit status</returns>
        public static int Main(String[] args) {
            // Show details about item being tested
            var item = new InventoryItem(
                "Audio Cable",
                "Standard",
                "XLR",
                10.0f,
                "feet",
                "unknown",
                "unknown",
                10,
                20
            );
            printItem(item);
            Console.WriteLine();

            // Prepare test suite
            var inventoryItemTest = new MiniTest.Test<InventoryItem>("Inventory Item");

            // Have consistent item to check
            Func<InventoryItem> initItem = () => {
                return new InventoryItem(
                    "Audio Cable",
                    "Standard",
                    "XLR",
                    5.0f,
                    "feet",
                    "unknown",
                    "unknown",
                    10,
                    20
                );
            };

            // Initialize tests
            inventoryItemTest
                .it("initializes", initItem)
                .it("has correct properties", initItem)
                .it("can take 3 items", initItem)
                .it("can't take 13 items", initItem)
                .it("can return 3 items", initItem)
                .it("can't return 13 items", initItem)
                .it("can discard 3 items", initItem)
                .it("can't discard 13 items", initItem)
                .it("can stock 3 items", initItem)
                .it("can't take negative items", initItem)
                ;
            
            // Add test requirements
            inventoryItemTest
                .should("initializes", (item) => {
                    return item != null;
                })
                .should("has correct properties", (item) => {
                    if(item!.name != "Audio Cable") return false;
                    else if(item!.size != "Standard") return false;
                    else if(item!.type != "XLR") return false;
                    else if(item!.length != 5.0f) return false;
                    else if(item!.lengthUnit != "feet") return false;
                    else if(item!.brand != "unknown") return false;
                    else if(item!.model != "unknown") return false;
                    else if(item!.inStorage != 10) return false;
                    else if(item!.totalStorage != 20) return false;

                    return true;
                })

                
                .should("can take 3 items", (item) => {
                    try {
                        item!.take(3);
                    } catch {
                        return false;
                    }

                    return item!.inStorage == 7;
                })
                .should("can't take 13 items", (item) => {
                    try {
                        item!.take(13);
                    } catch {
                        return true;
                    }

                    return false;
                })
                
                .should("can return 3 items", (item) => {
                    try {
                        item!.restore(3);
                    } catch {
                        return false;
                    }

                    return item!.inStorage == 13;
                })
                .should("can't return 13 items", (item) => {
                    try {
                        item!.restore(13);
                    } catch {
                        return true;
                    }

                    return false;
                })

                .should("can discard 3 items", (item) => {
                    try {
                        item!.discard(3);
                    } catch {
                        return false;
                    }

                    return item!.totalStorage == 17;
                })
                .should("can't discard 13 items", (item) => {
                    try {
                        item!.discard(13);
                    } catch {
                        return true;
                    }

                    return false;
                })

                .should("can stock 3 items", (item) => {
                    try {
                        item!.stock(3);
                    } catch {
                        return false;
                    }

                    return item!.totalStorage == 23;
                })


                .should("can't take negative items", (item) => {
                    try {
                        item!.take(-2);
                    } catch {
                        return true;
                    }

                    return false;
                })
                ;

            // Execute test suite and print results
            return inventoryItemTest.runTests() ? 0 : 1;
        }
    }
}