namespace StoreApp
{
    partial class ShopingCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemsCount = new System.Windows.Forms.Label();
            this.lstB_items = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.RichTextBox();
            this.txt_secondName = new System.Windows.Forms.RichTextBox();
            this.txt_cardNum = new System.Windows.Forms.RichTextBox();
            this.txt_cvv = new System.Windows.Forms.RichTextBox();
            this.txt_adres = new System.Windows.Forms.RichTextBox();
            this.bnt_purchase = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR SHOPPING CART";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total $:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.price.Location = new System.Drawing.Point(99, 108);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(29, 31);
            this.price.TabIndex = 2;
            this.price.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of items:";
            // 
            // itemsCount
            // 
            this.itemsCount.AutoSize = true;
            this.itemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.itemsCount.Location = new System.Drawing.Point(221, 77);
            this.itemsCount.Name = "itemsCount";
            this.itemsCount.Size = new System.Drawing.Size(29, 31);
            this.itemsCount.TabIndex = 4;
            this.itemsCount.Text = "0";
            // 
            // lstB_items
            // 
            this.lstB_items.BackColor = System.Drawing.Color.Khaki;
            this.lstB_items.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstB_items.FormattingEnabled = true;
            this.lstB_items.HorizontalScrollbar = true;
            this.lstB_items.ItemHeight = 23;
            this.lstB_items.Location = new System.Drawing.Point(307, 77);
            this.lstB_items.Name = "lstB_items";
            this.lstB_items.Size = new System.Drawing.Size(738, 119);
            this.lstB_items.TabIndex = 5;
            this.lstB_items.SelectedIndexChanged += new System.EventHandler(this.lstB_items_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(16, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "First name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(336, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Second name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label6.Location = new System.Drawing.Point(16, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Debit/Credit card:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(16, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "CVV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label8.Location = new System.Drawing.Point(16, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Adres:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.BackColor = System.Drawing.Color.Gold;
            this.txt_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_firstName.Location = new System.Drawing.Point(172, 226);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_firstName.Size = new System.Drawing.Size(158, 28);
            this.txt_firstName.TabIndex = 17;
            this.txt_firstName.Text = "";
            // 
            // txt_secondName
            // 
            this.txt_secondName.BackColor = System.Drawing.Color.Gold;
            this.txt_secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_secondName.Location = new System.Drawing.Point(530, 223);
            this.txt_secondName.Name = "txt_secondName";
            this.txt_secondName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_secondName.Size = new System.Drawing.Size(158, 28);
            this.txt_secondName.TabIndex = 18;
            this.txt_secondName.Text = "";
            // 
            // txt_cardNum
            // 
            this.txt_cardNum.BackColor = System.Drawing.Color.Gold;
            this.txt_cardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_cardNum.Location = new System.Drawing.Point(249, 274);
            this.txt_cardNum.Name = "txt_cardNum";
            this.txt_cardNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_cardNum.Size = new System.Drawing.Size(327, 28);
            this.txt_cardNum.TabIndex = 19;
            this.txt_cardNum.Text = "";
            // 
            // txt_cvv
            // 
            this.txt_cvv.BackColor = System.Drawing.Color.Gold;
            this.txt_cvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_cvv.Location = new System.Drawing.Point(100, 323);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_cvv.Size = new System.Drawing.Size(74, 28);
            this.txt_cvv.TabIndex = 20;
            this.txt_cvv.Text = "";
            // 
            // txt_adres
            // 
            this.txt_adres.BackColor = System.Drawing.Color.Gold;
            this.txt_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_adres.Location = new System.Drawing.Point(115, 364);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_adres.Size = new System.Drawing.Size(304, 28);
            this.txt_adres.TabIndex = 21;
            this.txt_adres.Text = "";
            // 
            // bnt_purchase
            // 
            this.bnt_purchase.BackColor = System.Drawing.Color.Khaki;
            this.bnt_purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bnt_purchase.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.bnt_purchase.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.bnt_purchase.Location = new System.Drawing.Point(825, 300);
            this.bnt_purchase.Name = "bnt_purchase";
            this.bnt_purchase.Size = new System.Drawing.Size(220, 51);
            this.bnt_purchase.TabIndex = 22;
            this.bnt_purchase.Text = "Purchase";
            this.bnt_purchase.UseVisualStyleBackColor = false;
            this.bnt_purchase.Click += new System.EventHandler(this.bnt_purchase_Click);
            // 
            // ShopingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.bnt_purchase);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.txt_cardNum);
            this.Controls.Add(this.txt_secondName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstB_items);
            this.Controls.Add(this.itemsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ShopingCard";
            this.Size = new System.Drawing.Size(1080, 444);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itemsCount;
        private System.Windows.Forms.ListBox lstB_items;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txt_firstName;
        private System.Windows.Forms.RichTextBox txt_secondName;
        private System.Windows.Forms.RichTextBox txt_cardNum;
        private System.Windows.Forms.RichTextBox txt_cvv;
        private System.Windows.Forms.RichTextBox txt_adres;
        private System.Windows.Forms.Button bnt_purchase;
    }
}
