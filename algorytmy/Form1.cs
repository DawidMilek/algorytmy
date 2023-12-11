using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorytmy
{
    public partial class Form1 : Form
    {
        CiagLiczb ciag;
        bool wybranyTypCiagu = false;

        public Form1()
        {
            InitializeComponent();
            ciag = new CiagLiczb();
        }

        private void D_generuj_Click(object sender, EventArgs e)
        {
            if (!wybranyTypCiagu)
            {
                MessageBox.Show("Wybierz typ ciągu!");
                return;
            }

            if (D_Typy_Ciagow_Box.Text == "Rosnący")
            {
                ciag.generuj_rosnacy_ciag(Convert.ToInt32(D_Rozmiar_Ciagu.Value));
            }

            if (D_Typy_Ciagow_Box.Text == "Malejący")
            {
                ciag.generuj_malejacy_ciag(Convert.ToInt32(D_Rozmiar_Ciagu.Value));
            }

            if (D_Typy_Ciagow_Box.Text == "Losowy")
            {
                ciag.generuj_losowy_ciag(Convert.ToInt32(D_Rozmiar_Ciagu.Value));
            }

            D_liczby_wygenerowane.Items.Clear();
            ciag.wstaw_ciag_do_listy(D_liczby_wygenerowane);
        }

        private void D_sortuj_Click(object sender, EventArgs e)
        {
            if (
                !D_babelkowe.Checked
             && !D_Przez_wstawienie.Checked
             && !D_Przez_wybor.Checked
             && !D_szybkie.Checked
             && !D_Przez_scalenie.Checked
              )
            {
                MessageBox.Show("Wybierz algorytm!");
                return;
            }

            if (!ciag.wygenerowane)
            {
                MessageBox.Show("Wygeneruj ciąg!");
                return;
            }

            AlgorytmySortowania algorytm = new AlgorytmySortowania();
            Stopwatch stoper = new Stopwatch();
            int[] arr;

            if (D_babelkowe.Checked)
            {
                arr = ciag.Arr;
                stoper.Start();
                algorytm.bubble_sort(arr);
                stoper.Stop();
                dodaj_do_wykresu("bąbelkowe", stoper.ElapsedMilliseconds);
                dodaj_do_listy(arr, D_liczby_posortowane);
                stoper.Restart();
            }

            if (D_Przez_wstawienie.Checked)
            {
                arr = ciag.Arr;
                stoper.Start();
                algorytm.insertion_sort(arr);
                stoper.Stop();
                dodaj_do_wykresu("przez wstawienie", stoper.ElapsedMilliseconds);
                dodaj_do_listy(arr, D_liczby_posortowane);
                stoper.Restart();
            }

            if (D_Przez_wybor.Checked)
            {
                arr = ciag.Arr;
                stoper.Start();
                algorytm.selection_sort(arr);
                stoper.Stop();
                dodaj_do_wykresu("przez wybór", stoper.ElapsedMilliseconds);
                dodaj_do_listy(arr, D_liczby_posortowane);
                stoper.Restart();
            }

            if (D_szybkie.Checked)
            {
                arr = ciag.Arr;
                stoper.Start();
                algorytm.quick_sort(arr, 0, arr.Length - 1);
                stoper.Stop();
                dodaj_do_wykresu("szybkie", stoper.ElapsedMilliseconds);
                dodaj_do_listy(arr, D_liczby_posortowane);
                stoper.Restart();
            }

            if (D_Przez_scalenie.Checked)
            {
                arr = ciag.Arr;
                stoper.Start();
                algorytm.merge_sort(arr);
                stoper.Stop();
                dodaj_do_wykresu("przez scalenie", stoper.ElapsedMilliseconds);
                dodaj_do_listy(arr, D_liczby_posortowane);
                stoper.Restart();
            }
        }

        private void dodaj_do_wykresu(string tekst, double wynik)
        {
            D_wykres.Series["Czas"].Points.AddXY(tekst, wynik);
        }

        private void dodaj_do_listy(int[] arr, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (int i in arr)
            {
                listbox.Items.Add(i);
            }
        }

        private void D_Typy_Ciagow_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            wybranyTypCiagu = true;
        }

        private void D_wykres_Click(object sender, EventArgs e)
        {

        }
    }
}
