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
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current result:";
            // 
            // books_lstbox
            // 
            this.books_lstbox.FormattingEnabled = true;
            this.books_lstbox.IntegralHeight = false;
            this.books_lstbox.Location = new System.Drawing.Point(16, 30);
            this.books_lstbox.Name = "books_lstbox";
            this.books_lstbox.Size = new System.Drawing.Size(300, 345);
            this.books_lstbox.TabIndex = 1;
            // 
            // authors_lstbox
            // 
            this.authors_lstbox.FormattingEnabled = true;
            this.authors_lstbox.Location = new System.Drawing.Point(322, 30);
            this.authors_lstbox.Name = "authors_lstbox";
            this.authors_lstbox.Size = new System.Drawing.Size(193, 147);
            this.authors_lstbox.TabIndex = 2;
            this.authors_lstbox.SelectedIndexChanged += new System.EventHandler(this.authors_lstbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "All authors:";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reset_btn.Location = new System.Drawing.Point(610, 332);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(67, 43);
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
            this.panel1.Location = new System.Drawing.Point(322, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 188);
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
            this.panel3.Location = new System.Drawing.Point(521, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 113);
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
            this.author_name_input.Size = new System.Drawing.Size(126, 20);
            this.author_name_input.TabIndex = 16;
            // 
            // publication_year_lbl
            // 
            this.publication_year_lbl.AutoSize = true;
            this.publication_year_lbl.Location = new System.Drawing.Point(12, 54);
            this.publication_year_lbl.Name = "publication_year_lbl";
            this.publication_year_lbl.Size = new System.Drawing.Size(96, 13);
            this.publication_year_lbl.TabIndex = 29;
            this.publication_year_lbl.Text = "Year of Publication";
            // 
            // publication_year_input
            // 
            this.publication_year_input.Location = new System.Drawing.Point(14, 72);
            this.publication_year_input.Name = "publication_year_input";
            this.publication_year_input.Size = new System.Drawing.Size(126, 20);
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
            this.panel4.Location = new System.Drawing.Point(521, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 61);
            this.panel4.TabIndex = 33;
            this.panel4.Tag = "Expression";
            // 
            // between_years_dash_lbl
            // 
            this.between_years_dash_lbl.AutoSize = true;
            this.between_years_dash_lbl.Location = new System.Drawing.Point(73, 29);
            this.between_years_dash_lbl.Name = "between_years_dash_lbl";
            this.between_years_dash_lbl.Size = new System.Drawing.Size(10, 13);
            this.between_years_dash_lbl.TabIndex = 31;
            this.between_years_dash_lbl.Text = "-";
            // 
            // between_years_high_input
            // 
            this.between_years_high_input.Location = new System.Drawing.Point(89, 26);
            this.between_years_high_input.Name = "between_years_high_input";
            this.between_years_high_input.Size = new System.Drawing.Size(51, 20);
            this.between_years_high_input.TabIndex = 30;
            this.between_years_high_input.TextChanged += new System.EventHandler(this.between_years_high_input_TextChanged);
            // 
            // between_years_lbl
            // 
            this.between_years_lbl.AutoSize = true;
            this.between_years_lbl.Location = new System.Drawing.Point(12, 10);
            this.between_years_lbl.Name = "between_years_lbl";
            this.between_years_lbl.Size = new System.Drawing.Size(79, 13);
            this.between_years_lbl.TabIndex = 28;
            this.between_years_lbl.Text = "Between Years";
            // 
            // between_years_low_input
            // 
            this.between_years_low_input.Location = new System.Drawing.Point(14, 26);
            this.between_years_low_input.Name = "between_years_low_input";
            this.between_years_low_input.Size = new System.Drawing.Size(53, 20);
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
            this.panel2.Location = new System.Drawing.Point(521, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 58);
            this.panel2.TabIndex = 34;
            this.panel2.Tag = "Expression";
            // 
            // rating_threshold_dash_lbl
            // 
            this.rating_threshold_dash_lbl.AutoSize = true;
            this.rating_threshold_dash_lbl.Location = new System.Drawing.Point(73, 29);
            this.rating_threshold_dash_lbl.Name = "rating_threshold_dash_lbl";
            this.rating_threshold_dash_lbl.Size = new System.Drawing.Size(10, 13);
            this.rating_threshold_dash_lbl.TabIndex = 31;
            this.rating_threshold_dash_lbl.Text = "-";
            // 
            // rating_threshold_high_input
            // 
            this.rating_threshold_high_input.Location = new System.Drawing.Point(89, 26);
            this.rating_threshold_high_input.Name = "rating_threshold_high_input";
            this.rating_threshold_high_input.Size = new System.Drawing.Size(51, 20);
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
            this.rating_threshold_low_input.Size = new System.Drawing.Size(53, 20);
            this.rating_threshold_low_input.TabIndex = 16;
            // 
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.filter_btn.Location = new System.Drawing.Point(521, 280);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(156, 43);
            this.filter_btn.TabIndex = 35;
            this.filter_btn.Text = "FILTER";
            this.filter_btn.UseVisualStyleBackColor = false;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // save_query_chk
            // 
            this.save_query_chk.AutoSize = true;
            this.save_query_chk.Location = new System.Drawing.Point(521, 345);
            this.save_query_chk.Name = "save_query_chk";
            this.save_query_chk.Size = new System.Drawing.Size(90, 17);
            this.save_query_chk.TabIndex = 36;
            this.save_query_chk.Text = "Save results?";
            this.save_query_chk.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 393);
            this.Controls.Add(this.save_query_chk);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.label2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox books_lstbox;
        private System.Windows.Forms.ListBox authors_lstbox;
        private System.Windows.Forms.Label label2;
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
    }
}

