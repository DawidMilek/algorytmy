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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.D_wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.D_liczby_posortowane = new System.Windows.Forms.ListBox();
            this.D_liczby_wygenerowane = new System.Windows.Forms.ListBox();
            this.D_generuj = new System.Windows.Forms.Button();
            this.D_sortuj = new System.Windows.Forms.Button();
            this.D_algorytmy_sortowania_grupbox = new System.Windows.Forms.GroupBox();
            this.D_bombelkowe = new System.Windows.Forms.CheckBox();
            this.D_Przez_wybor = new System.Windows.Forms.CheckBox();
            this.D_Przez_wstawienie = new System.Windows.Forms.CheckBox();
            this.D_szybkie = new System.Windows.Forms.CheckBox();
            this.D_Przez_scalenie = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.D_wykres)).BeginInit();
            this.D_algorytmy_sortowania_grupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // D_wykres
            // 
            chartArea6.Name = "ChartArea1";
            this.D_wykres.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.D_wykres.Legends.Add(legend6);
            this.D_wykres.Location = new System.Drawing.Point(488, 44);
            this.D_wykres.Name = "D_wykres";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.D_wykres.Series.Add(series6);
            this.D_wykres.Size = new System.Drawing.Size(300, 300);
            this.D_wykres.TabIndex = 0;
            this.D_wykres.Text = "chart1";
            this.D_wykres.Click += new System.EventHandler(this.D_wykres_Click);
            // 
            // D_liczby_posortowane
            // 
            this.D_liczby_posortowane.FormattingEnabled = true;
            this.D_liczby_posortowane.Location = new System.Drawing.Point(343, 44);
            this.D_liczby_posortowane.Name = "D_liczby_posortowane";
            this.D_liczby_posortowane.Size = new System.Drawing.Size(120, 303);
            this.D_liczby_posortowane.TabIndex = 2;
            this.D_liczby_posortowane.SelectedIndexChanged += new System.EventHandler(this.D_liczby_posortowane_SelectedIndexChanged);
            // 
            // D_liczby_wygenerowane
            // 
            this.D_liczby_wygenerowane.FormattingEnabled = true;
            this.D_liczby_wygenerowane.Location = new System.Drawing.Point(201, 44);
            this.D_liczby_wygenerowane.Name = "D_liczby_wygenerowane";
            this.D_liczby_wygenerowane.Size = new System.Drawing.Size(120, 303);
            this.D_liczby_wygenerowane.TabIndex = 3;
            this.D_liczby_wygenerowane.SelectedIndexChanged += new System.EventHandler(this.D_liczby_wygenerowane_SelectedIndexChanged);
            // 
            // D_generuj
            // 
            this.D_generuj.Location = new System.Drawing.Point(46, 44);
            this.D_generuj.Name = "D_generuj";
            this.D_generuj.Size = new System.Drawing.Size(75, 23);
            this.D_generuj.TabIndex = 4;
            this.D_generuj.Text = "Generuj";
            this.D_generuj.UseVisualStyleBackColor = true;
            this.D_generuj.Click += new System.EventHandler(this.D_generuj_Click);
            // 
            // D_sortuj
            // 
            this.D_sortuj.Location = new System.Drawing.Point(46, 227);
            this.D_sortuj.Name = "D_sortuj";
            this.D_sortuj.Size = new System.Drawing.Size(75, 23);
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
            this.D_algorytmy_sortowania_grupbox.Controls.Add(this.D_bombelkowe);
            this.D_algorytmy_sortowania_grupbox.Location = new System.Drawing.Point(46, 74);
            this.D_algorytmy_sortowania_grupbox.Name = "D_algorytmy_sortowania_grupbox";
            this.D_algorytmy_sortowania_grupbox.Size = new System.Drawing.Size(123, 147);
            this.D_algorytmy_sortowania_grupbox.TabIndex = 6;
            this.D_algorytmy_sortowania_grupbox.TabStop = false;
            this.D_algorytmy_sortowania_grupbox.Text = "Algorytmy Sortowania";
            this.D_algorytmy_sortowania_grupbox.Enter += new System.EventHandler(this.D_algorytmy_sortowania_grupbox_Enter);
            // 
            // D_bombelkowe
            // 
            this.D_bombelkowe.AutoSize = true;
            this.D_bombelkowe.Location = new System.Drawing.Point(7, 20);
            this.D_bombelkowe.Name = "D_bombelkowe";
            this.D_bombelkowe.Size = new System.Drawing.Size(87, 17);
            this.D_bombelkowe.TabIndex = 0;
            this.D_bombelkowe.Text = "Bombelkowe";
            this.D_bombelkowe.UseVisualStyleBackColor = true;
            this.D_bombelkowe.CheckedChanged += new System.EventHandler(this.D_bombelkowe_CheckedChanged);
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
            this.D_Przez_wybor.CheckedChanged += new System.EventHandler(this.D_Przez_wybor_CheckedChanged);
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
            this.D_Przez_wstawienie.CheckedChanged += new System.EventHandler(this.D_Przez_wstawienie_CheckedChanged);
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
            this.D_szybkie.CheckedChanged += new System.EventHandler(this.D_szybkie_CheckedChanged);
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
            this.D_Przez_scalenie.CheckedChanged += new System.EventHandler(this.D_Przez_scalenie_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.D_algorytmy_sortowania_grupbox);
            this.Controls.Add(this.D_sortuj);
            this.Controls.Add(this.D_generuj);
            this.Controls.Add(this.D_liczby_wygenerowane);
            this.Controls.Add(this.D_liczby_posortowane);
            this.Controls.Add(this.D_wykres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.D_wykres)).EndInit();
            this.D_algorytmy_sortowania_grupbox.ResumeLayout(false);
            this.D_algorytmy_sortowania_grupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart D_wykres;
        private System.Windows.Forms.ListBox D_liczby_posortowane;
        private System.Windows.Forms.ListBox D_liczby_wygenerowane;
        private System.Windows.Forms.Button D_generuj;
        private System.Windows.Forms.Button D_sortuj;
        private System.Windows.Forms.GroupBox D_algorytmy_sortowania_grupbox;
        private System.Windows.Forms.CheckBox D_Przez_scalenie;
        private System.Windows.Forms.CheckBox D_szybkie;
        private System.Windows.Forms.CheckBox D_Przez_wstawienie;
        private System.Windows.Forms.CheckBox D_Przez_wybor;
        private System.Windows.Forms.CheckBox D_bombelkowe;
    }
}

