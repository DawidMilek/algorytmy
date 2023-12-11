using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorytmy
{
    internal class CiagLiczb
    {
        private int[] arr = null;
        public bool wygenerowane = false;

        public int[] Arr
        {
            get => (int[])arr.Clone();
        }

        public void generuj_rosnacy_ciag(int x)
        {
            arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = i;
            }

            wygenerowane = true;
        }

        public void generuj_malejacy_ciag(int x)
        {
            arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = x - i;
            }

            wygenerowane = true;
        }

        public void generuj_losowy_ciag(int x)
        {
            arr = new int[x];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                arr[i] = r.Next(0, 9999);
            }

            wygenerowane = true;
        }

        public void wstaw_ciag_do_listy(ListBox listbox)
        {
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++)
            {
                listbox.Items.Add(arr[i]);
            }
        }
    }
}
