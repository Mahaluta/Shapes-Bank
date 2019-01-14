using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComonTypeSystemHomework3
{
    public class BitArray64
    {
        // fields
        private int[] arr = new int[10];
        public int Length = 0;

        // methods

        public override bool Equals(object obj)
        {
            BitArray64 array = obj as BitArray64;

            if (array == null)
                return false;
            if (this.Length != array.Length)
                return false;

            int index = 0;
            while (index < 10)
            {
                if (this.arr[index] != array[index])
                    return false;
                index++;
            }

            return true;

        }

        public static bool operator ==(BitArray64 arr1, BitArray64 arr2)
        {
            return BitArray64.Equals(arr1, arr2);
        }
        public static bool operator !=(BitArray64 arr1, BitArray64 arr2)
        {
            return !BitArray64.Equals(arr1, arr2);
        }

        public override int GetHashCode()
        {
            return 1323;

        }

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }




    }
}
