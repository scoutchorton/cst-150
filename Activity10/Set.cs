using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lydia's code - find the errors!

namespace Activity10 {
    class Set {
        private List<int> elements;
        
        public Set() {
            elements = new List<int>();
        }

        public bool addElement(int val) {
            if(containsElement(val)) {
                return false;
            } else {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val) {
            for(int i = 0; i < elements.Count; i++) {
                if(val == elements[i]) return true;
                /*
                 * **Removed**
                 * This would trip on the first element and wouldn't finish
                 * looking at the other elements
                 */
                //else return false;
            }
            return false;
        }
        
        public override string ToString() {
            string str = "";
            
            foreach(int i in elements) {
                str += i + " ";
            }
            
            return str;
        }
        
        public void clearSet() {
            elements.Clear();
        }
        
        public Set union(Set rhs) {
            /*
             * **Added**
             * Union is supposed to not modify the left hand side (lhs/this)
             * or the right hand side (rhs), so a new Set must be created and
             * be returned
             */
            Set unionedSet = new Set();

            /*
             * **Added**
             * Since no longer adding to the lhs, all the elements must be
             * copied over to the new Set
             */
            foreach(int element in this.elements)
                unionedSet.addElement(element);

            for(int i = 0; i < rhs.elements.Count; i++) {
                /*
                 * **Refactored**
                 * Switch to use unionedSet instead of editing rhs
                 */
                //this.addElement(rhs.elements[i]);
                unionedSet.addElement(rhs.elements[i]);
            }
            
            /*
             * **Refactored**
             * Switch to use unionedSet
             */
            //return rhs;
            return unionedSet;
        }
    }
}