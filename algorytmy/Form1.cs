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
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
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

            for(int i = 0; i < n-1; i++)
            {
                int index_min = i;
                for(int j = i+1; j < n; j++)
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

        public void Przez_Wstawianie(int []array)
        {
            for(int i =0; i < array.Length;i++)
            {
                int obecny = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > obecny)
                {
                    array[j+1] = array[j];
                    j = j - 1;
                }

                array[j+1] = obecny;
            }
        }

        private void D_generuj_Click(object sender, EventArgs e)
        {
            array = new int[10];
            Random rnd = new Random();

            for(int i = 0; i < 10; i++)
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
            if(D_bombelkowe.Checked)
            {
                BubbleSort(this.array);
            }
            else if(D_Przez_wstawienie.Checked)
            {
                Przez_Wstawianie(this.array);
            }
            else if(D_Przez_wybor.Checked)
            {
                Przez_Wybor(this.array);
            }
            

            for(int i = 0; i < this.array.Length; i++)
            {
                D_liczby_posortowane.Items.Add(this.array[i]);
            }
        }

    }
}
