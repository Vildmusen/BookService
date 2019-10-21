namespace BookService
{
    partial class BookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.books_lstbox = new System.Windows.Forms.ListBox();
            this.authors_lstbox = new System.Windows.Forms.ListBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.property_value_input = new System.Windows.Forms.TextBox();
            this.property_lbl = new System.Windows.Forms.Label();
            this.lessthan_radio_btn = new System.Windows.Forms.RadioButton();
            this.greaterthan_radio_btn = new System.Windows.Forms.RadioButton();
            this.equals_radio_btn = new System.Windows.Forms.RadioButton();
            this.notEquals_radio_btn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.property_combo_box = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.author_name_lbl = new System.Windows.Forms.Label();
            this.author_name_input = new System.Windows.Forms.TextBox();
            this.publication_year_lbl = new System.Windows.Forms.Label();
            this.publication_year_input = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.between_years_dash_lbl = new System.Windows.Forms.Label();
            this.between_years_high_input = new System.Windows.Forms.TextBox();
            this.between_years_lbl = new System.Windows.Forms.Label();
            this.between_years_low_input = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rating_threshold_dash_lbl = new System.Windows.Forms.Label();
            this.rating_threshold_high_input = new System.Windows.Forms.TextBox();
            this.rating_threshold_lbl = new System.Windows.Forms.Label();
            this.rating_threshold_low_input = new System.Windows.Forms.TextBox();
            this.filter_btn = new System.Windows.Forms.Button();
            this.save_query_chk = new System.Windows.Forms.CheckBox();
            this.search_result_lbl = new System.Windows.Forms.Label();
            this.search_tab_ctrl = new System.Windows.Forms.TabControl();
            this.search_basic_tab = new System.Windows.Forms.TabPage();
            this.search_advanced_tab = new System.Windows.Forms.TabPage();
            this.book_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.search_tab_ctrl.SuspendLayout();
            this.search_basic_tab.SuspendLayout();
            this.search_advanced_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current result:";
            // 
            // books_lstbox
            // 
            this.books_lstbox.FormattingEnabled = true;
            this.books_lstbox.IntegralHeight = false;
            this.books_lstbox.Location = new System.Drawing.Point(237, 34);
            this.books_lstbox.Name = "books_lstbox";
            this.books_lstbox.Size = new System.Drawing.Size(213, 338);
            this.books_lstbox.TabIndex = 1;
            this.books_lstbox.SelectedIndexChanged += new System.EventHandler(this.books_lstbox_SelectedIndexChanged);
            // 
            // authors_lstbox
            // 
            this.authors_lstbox.FormattingEnabled = true;
            this.authors_lstbox.Location = new System.Drawing.Point(459, 34);
            this.authors_lstbox.Name = "authors_lstbox";
            this.authors_lstbox.Size = new System.Drawing.Size(193, 225);
            this.authors_lstbox.TabIndex = 2;
            this.authors_lstbox.SelectedIndexChanged += new System.EventHandler(this.authors_lstbox_SelectedIndexChanged);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reset_btn.Location = new System.Drawing.Point(145, 335);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(76, 35);
            this.reset_btn.TabIndex = 13;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // property_value_input
            // 
            this.property_value_input.Location = new System.Drawing.Point(16, 158);
            this.property_value_input.Name = "property_value_input";
            this.property_value_input.Size = new System.Drawing.Size(161, 20);
            this.property_value_input.TabIndex = 21;
            // 
            // property_lbl
            // 
            this.property_lbl.AutoSize = true;
            this.property_lbl.Location = new System.Drawing.Point(13, 10);
            this.property_lbl.Name = "property_lbl";
            this.property_lbl.Size = new System.Drawing.Size(49, 13);
            this.property_lbl.TabIndex = 22;
            this.property_lbl.Text = "Property:";
            // 
            // lessthan_radio_btn
            // 
            this.lessthan_radio_btn.AutoSize = true;
            this.lessthan_radio_btn.Checked = true;
            this.lessthan_radio_btn.Location = new System.Drawing.Point(16, 52);
            this.lessthan_radio_btn.Name = "lessthan_radio_btn";
            this.lessthan_radio_btn.Size = new System.Drawing.Size(80, 17);
            this.lessthan_radio_btn.TabIndex = 23;
            this.lessthan_radio_btn.TabStop = true;
            this.lessthan_radio_btn.Text = "< Less than";
            this.lessthan_radio_btn.UseVisualStyleBackColor = true;
            // 
            // greaterthan_radio_btn
            // 
            this.greaterthan_radio_btn.AutoSize = true;
            this.greaterthan_radio_btn.Location = new System.Drawing.Point(16, 75);
            this.greaterthan_radio_btn.Name = "greaterthan_radio_btn";
            this.greaterthan_radio_btn.Size = new System.Drawing.Size(93, 17);
            this.greaterthan_radio_btn.TabIndex = 24;
            this.greaterthan_radio_btn.Text = "> Greater than";
            this.greaterthan_radio_btn.UseVisualStyleBackColor = true;
            // 
            // equals_radio_btn
            // 
            this.equals_radio_btn.AutoSize = true;
            this.equals_radio_btn.Location = new System.Drawing.Point(15, 97);
            this.equals_radio_btn.Name = "equals_radio_btn";
            this.equals_radio_btn.Size = new System.Drawing.Size(72, 17);
            this.equals_radio_btn.TabIndex = 25;
            this.equals_radio_btn.Text = "== Equals";
            this.equals_radio_btn.UseVisualStyleBackColor = true;
            // 
            // notEquals_radio_btn
            // 
            this.notEquals_radio_btn.AutoSize = true;
            this.notEquals_radio_btn.Location = new System.Drawing.Point(15, 122);
            this.notEquals_radio_btn.Name = "notEquals_radio_btn";
            this.notEquals_radio_btn.Size = new System.Drawing.Size(89, 17);
            this.notEquals_radio_btn.TabIndex = 26;
            this.notEquals_radio_btn.Text = "!= Not Equals";
            this.notEquals_radio_btn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Value:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.property_combo_box);
            this.panel1.Controls.Add(this.property_lbl);
            this.panel1.Controls.Add(this.property_value_input);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lessthan_radio_btn);
            this.panel1.Controls.Add(this.notEquals_radio_btn);
            this.panel1.Controls.Add(this.greaterthan_radio_btn);
            this.panel1.Controls.Add(this.equals_radio_btn);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 234);
            this.panel1.TabIndex = 30;
            this.panel1.Tag = "Expression";
            // 
            // property_combo_box
            // 
            this.property_combo_box.FormattingEnabled = true;
            this.property_combo_box.Location = new System.Drawing.Point(16, 25);
            this.property_combo_box.Name = "property_combo_box";
            this.property_combo_box.Size = new System.Drawing.Size(161, 21);
            this.property_combo_box.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.author_name_lbl);
            this.panel3.Controls.Add(this.author_name_input);
            this.panel3.Controls.Add(this.publication_year_lbl);
            this.panel3.Controls.Add(this.publication_year_input);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 98);
            this.panel3.TabIndex = 32;
            this.panel3.Tag = "Expression";
            // 
            // author_name_lbl
            // 
            this.author_name_lbl.AutoSize = true;
            this.author_name_lbl.Location = new System.Drawing.Point(12, 10);
            this.author_name_lbl.Name = "author_name_lbl";
            this.author_name_lbl.Size = new System.Drawing.Size(69, 13);
            this.author_name_lbl.TabIndex = 28;
            this.author_name_lbl.Text = "Author Name";
            // 
            // author_name_input
            // 
            this.author_name_input.Location = new System.Drawing.Point(14, 26);
            this.author_name_input.Name = "author_name_input";
            this.author_name_input.Size = new System.Drawing.Size(173, 20);
            this.author_name_input.TabIndex = 16;
            // 
            // publication_year_lbl
            // 
            this.publication_year_lbl.AutoSize = true;
            this.publication_year_lbl.Location = new System.Drawing.Point(12, 49);
            this.publication_year_lbl.Name = "publication_year_lbl";
            this.publication_year_lbl.Size = new System.Drawing.Size(96, 13);
            this.publication_year_lbl.TabIndex = 29;
            this.publication_year_lbl.Text = "Year of Publication";
            // 
            // publication_year_input
            // 
            this.publication_year_input.Location = new System.Drawing.Point(14, 67);
            this.publication_year_input.Name = "publication_year_input";
            this.publication_year_input.Size = new System.Drawing.Size(173, 20);
            this.publication_year_input.TabIndex = 17;
            this.publication_year_input.TextChanged += new System.EventHandler(this.publication_year_input_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Controls.Add(this.between_years_dash_lbl);
            this.panel4.Controls.Add(this.between_years_high_input);
            this.panel4.Controls.Add(this.between_years_lbl);
            this.panel4.Controls.Add(this.between_years_low_input);
            this.panel4.Location = new System.Drawing.Point(6, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 60);
            this.panel4.TabIndex = 33;
            this.panel4.Tag = "Expression";
            // 
            // between_years_dash_lbl
            // 
            this.between_years_dash_lbl.AutoSize = true;
            this.between_years_dash_lbl.Location = new System.Drawing.Point(98, 28);
            this.between_years_dash_lbl.Name = "between_years_dash_lbl";
            this.between_years_dash_lbl.Size = new System.Drawing.Size(10, 13);
            this.between_years_dash_lbl.TabIndex = 31;
            this.between_years_dash_lbl.Text = "-";
            // 
            // between_years_high_input
            // 
            this.between_years_high_input.Location = new System.Drawing.Point(114, 25);
            this.between_years_high_input.Name = "between_years_high_input";
            this.between_years_high_input.Size = new System.Drawing.Size(73, 20);
            this.between_years_high_input.TabIndex = 30;
            this.between_years_high_input.TextChanged += new System.EventHandler(this.between_years_high_input_TextChanged);
            // 
            // between_years_lbl
            // 
            this.between_years_lbl.AutoSize = true;
            this.between_years_lbl.Location = new System.Drawing.Point(12, 9);
            this.between_years_lbl.Name = "between_years_lbl";
            this.between_years_lbl.Size = new System.Drawing.Size(79, 13);
            this.between_years_lbl.TabIndex = 28;
            this.between_years_lbl.Text = "Between Years";
            // 
            // between_years_low_input
            // 
            this.between_years_low_input.Location = new System.Drawing.Point(14, 25);
            this.between_years_low_input.Name = "between_years_low_input";
            this.between_years_low_input.Size = new System.Drawing.Size(77, 20);
            this.between_years_low_input.TabIndex = 16;
            this.between_years_low_input.TextChanged += new System.EventHandler(this.between_years_low_input_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.rating_threshold_dash_lbl);
            this.panel2.Controls.Add(this.rating_threshold_high_input);
            this.panel2.Controls.Add(this.rating_threshold_lbl);
            this.panel2.Controls.Add(this.rating_threshold_low_input);
            this.panel2.Location = new System.Drawing.Point(6, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 64);
            this.panel2.TabIndex = 34;
            this.panel2.Tag = "Expression";
            // 
            // rating_threshold_dash_lbl
            // 
            this.rating_threshold_dash_lbl.AutoSize = true;
            this.rating_threshold_dash_lbl.Location = new System.Drawing.Point(98, 29);
            this.rating_threshold_dash_lbl.Name = "rating_threshold_dash_lbl";
            this.rating_threshold_dash_lbl.Size = new System.Drawing.Size(10, 13);
            this.rating_threshold_dash_lbl.TabIndex = 31;
            this.rating_threshold_dash_lbl.Text = "-";
            // 
            // rating_threshold_high_input
            // 
            this.rating_threshold_high_input.Location = new System.Drawing.Point(114, 26);
            this.rating_threshold_high_input.Name = "rating_threshold_high_input";
            this.rating_threshold_high_input.Size = new System.Drawing.Size(73, 20);
            this.rating_threshold_high_input.TabIndex = 30;
            // 
            // rating_threshold_lbl
            // 
            this.rating_threshold_lbl.AutoSize = true;
            this.rating_threshold_lbl.Location = new System.Drawing.Point(12, 10);
            this.rating_threshold_lbl.Name = "rating_threshold_lbl";
            this.rating_threshold_lbl.Size = new System.Drawing.Size(132, 13);
            this.rating_threshold_lbl.TabIndex = 28;
            this.rating_threshold_lbl.Text = "Rating threshold (0,0 - 5,0)";
            // 
            // rating_threshold_low_input
            // 
            this.rating_threshold_low_input.Location = new System.Drawing.Point(14, 26);
            this.rating_threshold_low_input.Name = "rating_threshold_low_input";
            this.rating_threshold_low_input.Size = new System.Drawing.Size(78, 20);
            this.rating_threshold_low_input.TabIndex = 16;
            // 
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.filter_btn.Location = new System.Drawing.Point(8, 286);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(216, 43);
            this.filter_btn.TabIndex = 35;
            this.filter_btn.Text = "APPLY FILTER";
            this.filter_btn.UseVisualStyleBackColor = false;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // save_query_chk
            // 
            this.save_query_chk.AutoSize = true;
            this.save_query_chk.Location = new System.Drawing.Point(11, 335);
            this.save_query_chk.Name = "save_query_chk";
            this.save_query_chk.Size = new System.Drawing.Size(90, 17);
            this.save_query_chk.TabIndex = 36;
            this.save_query_chk.Text = "Save results?";
            this.save_query_chk.UseVisualStyleBackColor = true;
            // 
            // search_result_lbl
            // 
            this.search_result_lbl.AutoSize = true;
            this.search_result_lbl.Location = new System.Drawing.Point(312, 12);
            this.search_result_lbl.Name = "search_result_lbl";
            this.search_result_lbl.Size = new System.Drawing.Size(0, 13);
            this.search_result_lbl.TabIndex = 37;
            // 
            // search_tab_ctrl
            // 
            this.search_tab_ctrl.Controls.Add(this.search_basic_tab);
            this.search_tab_ctrl.Controls.Add(this.search_advanced_tab);
            this.search_tab_ctrl.Location = new System.Drawing.Point(4, 12);
            this.search_tab_ctrl.Name = "search_tab_ctrl";
            this.search_tab_ctrl.SelectedIndex = 0;
            this.search_tab_ctrl.Size = new System.Drawing.Size(224, 272);
            this.search_tab_ctrl.TabIndex = 38;
            // 
            // search_basic_tab
            // 
            this.search_basic_tab.Controls.Add(this.panel3);
            this.search_basic_tab.Controls.Add(this.panel2);
            this.search_basic_tab.Controls.Add(this.panel4);
            this.search_basic_tab.Location = new System.Drawing.Point(4, 22);
            this.search_basic_tab.Name = "search_basic_tab";
            this.search_basic_tab.Padding = new System.Windows.Forms.Padding(3);
            this.search_basic_tab.Size = new System.Drawing.Size(216, 246);
            this.search_basic_tab.TabIndex = 0;
            this.search_basic_tab.Text = "Basic Search";
            this.search_basic_tab.UseVisualStyleBackColor = true;
            // 
            // search_advanced_tab
            // 
            this.search_advanced_tab.Controls.Add(this.panel1);
            this.search_advanced_tab.Location = new System.Drawing.Point(4, 22);
            this.search_advanced_tab.Name = "search_advanced_tab";
            this.search_advanced_tab.Padding = new System.Windows.Forms.Padding(3);
            this.search_advanced_tab.Size = new System.Drawing.Size(216, 246);
            this.search_advanced_tab.TabIndex = 1;
            this.search_advanced_tab.Text = "Advanced Search";
            this.search_advanced_tab.UseVisualStyleBackColor = true;
            // 
            // book_listbox
            // 
            this.book_listbox.FormattingEnabled = true;
            this.book_listbox.Location = new System.Drawing.Point(459, 278);
            this.book_listbox.Name = "book_listbox";
            this.book_listbox.Size = new System.Drawing.Size(190, 95);
            this.book_listbox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Selected Book:";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.book_listbox);
            this.Controls.Add(this.search_tab_ctrl);
            this.Controls.Add(this.search_result_lbl);
            this.Controls.Add(this.save_query_chk);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.authors_lstbox);
            this.Controls.Add(this.books_lstbox);
            this.Controls.Add(this.label1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.search_tab_ctrl.ResumeLayout(false);
            this.search_basic_tab.ResumeLayout(false);
            this.search_advanced_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox books_lstbox;
        private System.Windows.Forms.ListBox authors_lstbox;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.TextBox property_value_input;
        private System.Windows.Forms.Label property_lbl;
        private System.Windows.Forms.RadioButton lessthan_radio_btn;
        private System.Windows.Forms.RadioButton greaterthan_radio_btn;
        private System.Windows.Forms.RadioButton equals_radio_btn;
        private System.Windows.Forms.RadioButton notEquals_radio_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label author_name_lbl;
        private System.Windows.Forms.TextBox author_name_input;
        private System.Windows.Forms.Label publication_year_lbl;
        private System.Windows.Forms.TextBox publication_year_input;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label between_years_dash_lbl;
        private System.Windows.Forms.TextBox between_years_high_input;
        private System.Windows.Forms.Label between_years_lbl;
        private System.Windows.Forms.TextBox between_years_low_input;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label rating_threshold_dash_lbl;
        private System.Windows.Forms.TextBox rating_threshold_high_input;
        private System.Windows.Forms.Label rating_threshold_lbl;
        private System.Windows.Forms.TextBox rating_threshold_low_input;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.ComboBox property_combo_box;
        private System.Windows.Forms.CheckBox save_query_chk;
        private System.Windows.Forms.Label search_result_lbl;
        private System.Windows.Forms.TabControl search_tab_ctrl;
        private System.Windows.Forms.TabPage search_basic_tab;
        private System.Windows.Forms.TabPage search_advanced_tab;
        private System.Windows.Forms.ListBox book_listbox;
        private System.Windows.Forms.Label label2;
    }
}

