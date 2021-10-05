using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsandGenerics
{
    class CustomArrayList
    {
        private int[] arr;
        public CustomArrayList(int[] values)
        {
            this.arr = values;
        }
        public void Add(int i)
        {
            //create new array with 1 more space for new value, copy over old values
                int[] newArr = new int[arr.Length + 1];
                arr.CopyTo(newArr, 0);
             //add new value to end of array
                newArr[newArr.Length - 1] = i;
                arr = newArr;
        }
        public void PrintValues()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        // Pop will remove the last element from the list and return it       
        // - remember to make your array smaller after removing the element
         public int Pop()
        {
            int item = arr[arr.Length - 1];

            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length -1; i++)
            {
                newArr[i] = arr[i];
            }
            //arr.CopyTo(newArr, 0);
            arr = newArr;
            return item;
           //throw new NotImplementedException();
        }



}
}
