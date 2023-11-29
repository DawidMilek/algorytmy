using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorytmy
{
    public partial class Form1 : Form
    {
        private int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        public void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        public void Przez_Wybor(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int index_min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[index_min])
                    {
                        index_min = j;
                    }
                }

                int tmp = array[index_min];
                array[index_min] = array[i];
                array[i] = tmp;
            }
        }

        public void Przez_Wstawianie(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int obecny = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > obecny)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = obecny;
            }
        }

        public void Szybkie(int[] array, int lewy, int prawy)
        {
            var i = lewy;
            var j = prawy;
            var srodek = array[(lewy+prawy)/2];

            while (i <= j)
            {
                while (array[i] < srodek)
                { i++; }
                while (array[j] > srodek)
                { j--; }

                if (i <= j)
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (lewy < j)
            { Szybkie(array, lewy, j); }

            if (i < prawy)
            { Szybkie(array, i, prawy); }
        }
        /*nie działa
        public void scalenie(int poczatek, int koniec)
        {
            int []tmp_array = new int[this.array.Length];
            for(int i = poczatek; i <= koniec; i++)
            {
                tmp_array[i] = this.array[i]; //kopia
            }

            int p = poczatek;
            int q = (poczatek+koniec)/2+1;
            int r = poczatek;
            while(p <= (poczatek+koniec)/2 && q <= koniec)
            {
                if (tmp_array[p] < tmp_array[q])
                {
                    this.array[r] = tmp_array[p];
                    r++;
                    p++;
                }
                else
                {
                    this.array[r] = tmp_array[q];
                    r++;
                    q++;
                }
            }

            while(p <= (poczatek+koniec)/2)
            {
                this.array[r] = tmp_array[p];
                r++;
                p++;
            }
        }

        public void Przez_Scalenie(int poczatek, int koniec)
        {
            if(poczatek <  koniec)
            {
                Przez_Scalenie(poczatek, (poczatek + koniec) / 2);
                Przez_Scalenie((poczatek + koniec) / 2 + 1, koniec);
                scalenie(poczatek,koniec);
            }
        }
        */
        private void D_generuj_Click(object sender, EventArgs e)
        {
            array = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                this.array[i] = rnd.Next(100);
                D_liczby_wygenerowane.Items.Add(this.array[i]);
            }
        }

        private void D_algorytmy_sortowania_grupbox_Enter(object sender, EventArgs e)
        {

        }

        private void D_bombelkowe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void D_Przez_wybor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void D_Przez_wstawienie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void D_szybkie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void D_Przez_scalenie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void D_liczby_wygenerowane_SelectedIndexChanged(object sender, EventArgs e)
        {
            D_liczby_wygenerowane.Items.Clear();
        }

        private void D_liczby_posortowane_SelectedIndexChanged(object sender, EventArgs e)
        {
            D_liczby_posortowane.Items.Clear();
        }

        private void D_wykres_Click(object sender, EventArgs e)
        {

        }
        private void D_sortuj_Click(object sender, EventArgs e)
        {
            if (D_bombelkowe.Checked)
            {
                BubbleSort(this.array);
            }
            else if (D_Przez_wstawienie.Checked)
            {
                Przez_Wstawianie(this.array);
            }
            else if (D_Przez_wybor.Checked)
            {
                Przez_Wybor(this.array);
            }
            else if (D_szybkie.Checked)
            {
                Szybkie(this.array, 0, this.array.Length - 1);
            }
            else if(D_Przez_scalenie.Checked)
            {
                //Przez_Scalenie(0, this.array.Length);
            }

            D_liczby_posortowane.Items.Clear();


            for (int i = 0; i < this.array.Length; i++)
            {
                D_liczby_posortowane.Items.Add(this.array[i]);
            }
        }

    }
}
