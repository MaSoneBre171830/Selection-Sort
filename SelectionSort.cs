using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class SelectionSort
    {
        public static int[] Sort(int[] arr)
        {
            int CurrentMin;
            int index = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                CurrentMin = arr[i];
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (CurrentMin > arr[j])
                    {
                        index = j;
                        CurrentMin = arr[j];
                    }

                }
                
                if(CurrentMin != arr[i])
                {
                    int temp = arr[i];
                    arr[i] = CurrentMin;
                    arr[index] = temp;

                }
            }

            return arr;
        }

        
    }
}
