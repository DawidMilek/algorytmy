namespace algorytmy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.D_wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.D_czas_algorytmow = new System.Windows.Forms.ListBox();
            this.D_liczby_wygenerowane = new System.Windows.Forms.ListBox();
            this.D_generuj = new System.Windows.Forms.Button();
            this.D_sortuj = new System.Windows.Forms.Button();
            this.D_algorytmy_sortowania_grupbox = new System.Windows.Forms.GroupBox();
            this.D_Przez_scalenie = new System.Windows.Forms.CheckBox();
            this.D_szybkie = new System.Windows.Forms.CheckBox();
            this.D_Przez_wstawienie = new System.Windows.Forms.CheckBox();
            this.D_Przez_wybor = new System.Windows.Forms.CheckBox();
            this.D_babelkowe = new System.Windows.Forms.CheckBox();
            this.D_Typy_Ciagow_Box = new System.Windows.Forms.ComboBox();
            this.D_Liczby_GroupBox = new System.Windows.Forms.GroupBox();
            this.D_Rozmiar_Ciagu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.D_wykres)).BeginInit();
            this.D_algorytmy_sortowania_grupbox.SuspendLayout();
            this.D_Liczby_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_Rozmiar_Ciagu)).BeginInit();
            this.SuspendLayout();
            // 
            // D_wykres
            // 
            chartArea3.Name = "ChartArea1";
            this.D_wykres.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.D_wykres.Legends.Add(legend3);
            this.D_wykres.Location = new System.Drawing.Point(411, 34);
            this.D_wykres.Name = "D_wykres";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Czas";
            this.D_wykres.Series.Add(series3);
            this.D_wykres.Size = new System.Drawing.Size(356, 304);
            this.D_wykres.TabIndex = 0;
            this.D_wykres.Text = "chart1";
            // 
            // D_czas_algorytmow
            // 
            this.D_czas_algorytmow.FormattingEnabled = true;
            this.D_czas_algorytmow.Location = new System.Drawing.Point(241, 34);
            this.D_czas_algorytmow.Name = "D_czas_algorytmow";
            this.D_czas_algorytmow.Size = new System.Drawing.Size(150, 303);
            this.D_czas_algorytmow.TabIndex = 2;
            // 
            // D_liczby_wygenerowane
            // 
            this.D_liczby_wygenerowane.FormattingEnabled = true;
            this.D_liczby_wygenerowane.Location = new System.Drawing.Point(138, 34);
            this.D_liczby_wygenerowane.Name = "D_liczby_wygenerowane";
            this.D_liczby_wygenerowane.Size = new System.Drawing.Size(80, 303);
            this.D_liczby_wygenerowane.TabIndex = 3;
            // 
            // D_generuj
            // 
            this.D_generuj.Location = new System.Drawing.Point(6, 71);
            this.D_generuj.Name = "D_generuj";
            this.D_generuj.Size = new System.Drawing.Size(75, 21);
            this.D_generuj.TabIndex = 4;
            this.D_generuj.Text = "Generuj";
            this.D_generuj.UseVisualStyleBackColor = true;
            this.D_generuj.Click += new System.EventHandler(this.D_generuj_Click);
            // 
            // D_sortuj
            // 
            this.D_sortuj.Location = new System.Drawing.Point(23, 294);
            this.D_sortuj.Name = "D_sortuj";
            this.D_sortuj.Size = new System.Drawing.Size(95, 43);
            this.D_sortuj.TabIndex = 5;
            this.D_sortuj.Text = "Sortuj";
            this.D_sortuj.UseVisualStyleBackColor = true;
            this.D_sortuj.Click += new System.EventHandler(this.D_sortuj_Click);
            // 
            // D_algorytmy_sortowania_grupbox
            // 
            this.D_algorytmy_sortowania_grupbox.Controls.Add(this.D_Przez_scalenie);
            this.D_algorytmy_sortowania_grupbox.Controls.Add(this.D_szybkie);
            this.D_algorytmy_sortowania_grupbox.Controls.Add(this.D_Przez_wstawienie);
            this.D_algorytmy_sortowania_grupbox.Controls.Add(this.D_Przez_wybor);
            this.D_algorytmy_sortowania_grupbox.Controls.Add(this.D_babelkowe);
            this.D_algorytmy_sortowania_grupbox.Location = new System.Drawing.Point(9, 145);
            this.D_algorytmy_sortowania_grupbox.Name = "D_algorytmy_sortowania_grupbox";
            this.D_algorytmy_sortowania_grupbox.Size = new System.Drawing.Size(123, 143);
            this.D_algorytmy_sortowania_grupbox.TabIndex = 6;
            this.D_algorytmy_sortowania_grupbox.TabStop = false;
            this.D_algorytmy_sortowania_grupbox.Text = "Algorytmy Sortowania";
            // 
            // D_Przez_scalenie
            // 
            this.D_Przez_scalenie.AutoSize = true;
            this.D_Przez_scalenie.Location = new System.Drawing.Point(7, 116);
            this.D_Przez_scalenie.Name = "D_Przez_scalenie";
            this.D_Przez_scalenie.Size = new System.Drawing.Size(94, 17);
            this.D_Przez_scalenie.TabIndex = 4;
            this.D_Przez_scalenie.Text = "Przez scalenie";
            this.D_Przez_scalenie.UseVisualStyleBackColor = true;
            // 
            // D_szybkie
            // 
            this.D_szybkie.AutoSize = true;
            this.D_szybkie.Location = new System.Drawing.Point(7, 92);
            this.D_szybkie.Name = "D_szybkie";
            this.D_szybkie.Size = new System.Drawing.Size(63, 17);
            this.D_szybkie.TabIndex = 3;
            this.D_szybkie.Text = "Szybkie";
            this.D_szybkie.UseVisualStyleBackColor = true;
            // 
            // D_Przez_wstawienie
            // 
            this.D_Przez_wstawienie.AutoSize = true;
            this.D_Przez_wstawienie.Location = new System.Drawing.Point(7, 68);
            this.D_Przez_wstawienie.Name = "D_Przez_wstawienie";
            this.D_Przez_wstawienie.Size = new System.Drawing.Size(107, 17);
            this.D_Przez_wstawienie.TabIndex = 2;
            this.D_Przez_wstawienie.Text = "Przez wstawienie";
            this.D_Przez_wstawienie.UseVisualStyleBackColor = true;
            // 
            // D_Przez_wybor
            // 
            this.D_Przez_wybor.AutoSize = true;
            this.D_Przez_wybor.Location = new System.Drawing.Point(7, 44);
            this.D_Przez_wybor.Name = "D_Przez_wybor";
            this.D_Przez_wybor.Size = new System.Drawing.Size(83, 17);
            this.D_Przez_wybor.TabIndex = 1;
            this.D_Przez_wybor.Text = "Przez wybór";
            this.D_Przez_wybor.UseVisualStyleBackColor = true;
            // 
            // D_babelkowe
            // 
            this.D_babelkowe.AutoSize = true;
            this.D_babelkowe.Location = new System.Drawing.Point(7, 20);
            this.D_babelkowe.Name = "D_babelkowe";
            this.D_babelkowe.Size = new System.Drawing.Size(79, 17);
            this.D_babelkowe.TabIndex = 0;
            this.D_babelkowe.Text = "Bąbelkowe";
            this.D_babelkowe.UseVisualStyleBackColor = true;
            // 
            // D_Typy_Ciagow_Box
            // 
            this.D_Typy_Ciagow_Box.FormattingEnabled = true;
            this.D_Typy_Ciagow_Box.Items.AddRange(new object[] {
            "Rosnący",
            "Malejący",
            "Losowy"});
            this.D_Typy_Ciagow_Box.Location = new System.Drawing.Point(6, 19);
            this.D_Typy_Ciagow_Box.Name = "D_Typy_Ciagow_Box";
            this.D_Typy_Ciagow_Box.Size = new System.Drawing.Size(75, 21);
            this.D_Typy_Ciagow_Box.TabIndex = 7;
            this.D_Typy_Ciagow_Box.SelectedIndexChanged += new System.EventHandler(this.D_Typy_Ciagow_Box_SelectedIndexChanged);
            // 
            // D_Liczby_GroupBox
            // 
            this.D_Liczby_GroupBox.Controls.Add(this.D_Rozmiar_Ciagu);
            this.D_Liczby_GroupBox.Controls.Add(this.D_Typy_Ciagow_Box);
            this.D_Liczby_GroupBox.Controls.Add(this.D_generuj);
            this.D_Liczby_GroupBox.Location = new System.Drawing.Point(27, 34);
            this.D_Liczby_GroupBox.Name = "D_Liczby_GroupBox";
            this.D_Liczby_GroupBox.Size = new System.Drawing.Size(88, 98);
            this.D_Liczby_GroupBox.TabIndex = 11;
            this.D_Liczby_GroupBox.TabStop = false;
            this.D_Liczby_GroupBox.Text = "Ciąg liczbowy";
            // 
            // D_Rozmiar_Ciagu
            // 
            this.D_Rozmiar_Ciagu.Location = new System.Drawing.Point(6, 46);
            this.D_Rozmiar_Ciagu.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.D_Rozmiar_Ciagu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.D_Rozmiar_Ciagu.Name = "D_Rozmiar_Ciagu";
            this.D_Rozmiar_Ciagu.Size = new System.Drawing.Size(75, 20);
            this.D_Rozmiar_Ciagu.TabIndex = 8;
            this.D_Rozmiar_Ciagu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(774, 344);
            this.Controls.Add(this.D_Liczby_GroupBox);
            this.Controls.Add(this.D_algorytmy_sortowania_grupbox);
            this.Controls.Add(this.D_sortuj);
            this.Controls.Add(this.D_liczby_wygenerowane);
            this.Controls.Add(this.D_czas_algorytmow);
            this.Controls.Add(this.D_wykres);
            this.Name = "Form1";
            this.Text = "Projekt";
            ((System.ComponentModel.ISupportInitialize)(this.D_wykres)).EndInit();
            this.D_algorytmy_sortowania_grupbox.ResumeLayout(false);
            this.D_algorytmy_sortowania_grupbox.PerformLayout();
            this.D_Liczby_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.D_Rozmiar_Ciagu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart D_wykres;
        private System.Windows.Forms.ListBox D_czas_algorytmow;
        private System.Windows.Forms.ListBox D_liczby_wygenerowane;
        private System.Windows.Forms.Button D_generuj;
        private System.Windows.Forms.Button D_sortuj;
        private System.Windows.Forms.GroupBox D_algorytmy_sortowania_grupbox;
        private System.Windows.Forms.CheckBox D_Przez_scalenie;
        private System.Windows.Forms.CheckBox D_szybkie;
        private System.Windows.Forms.CheckBox D_Przez_wstawienie;
        private System.Windows.Forms.CheckBox D_Przez_wybor;
        private System.Windows.Forms.CheckBox D_babelkowe;
        private System.Windows.Forms.ComboBox D_Typy_Ciagow_Box;
        private System.Windows.Forms.GroupBox D_Liczby_GroupBox;
        private System.Windows.Forms.NumericUpDown D_Rozmiar_Ciagu;
    }
}