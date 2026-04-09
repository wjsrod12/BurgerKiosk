namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            grbBurger = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdoCheeseBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            grbTopping = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grbOrderList = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            grbBurger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbTopping.SuspendLayout();
            grbOrderList.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.Location = new Point(46, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(298, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // grbBurger
            // 
            grbBurger.Controls.Add(pictureBox3);
            grbBurger.Controls.Add(pictureBox2);
            grbBurger.Controls.Add(pictureBox1);
            grbBurger.Controls.Add(rdoCheeseBurger);
            grbBurger.Controls.Add(rdoBulgogiBurger);
            grbBurger.Controls.Add(rdoHamBurger);
            grbBurger.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbBurger.ForeColor = Color.OrangeRed;
            grbBurger.Location = new Point(37, 106);
            grbBurger.Name = "grbBurger";
            grbBurger.Size = new Size(218, 305);
            grbBurger.TabIndex = 1;
            grbBurger.TabStop = false;
            grbBurger.Text = "메뉴 선택";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._3B;
            pictureBox3.Location = new Point(112, 215);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2B;
            pictureBox2.Location = new Point(112, 128);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1B;
            pictureBox1.Location = new Point(112, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // rdoCheeseBurger
            // 
            rdoCheeseBurger.AutoSize = true;
            rdoCheeseBurger.Font = new Font("맑은 고딕", 9.75F);
            rdoCheeseBurger.ForeColor = Color.Purple;
            rdoCheeseBurger.Location = new Point(11, 244);
            rdoCheeseBurger.Name = "rdoCheeseBurger";
            rdoCheeseBurger.Size = new Size(78, 21);
            rdoCheeseBurger.TabIndex = 2;
            rdoCheeseBurger.TabStop = true;
            rdoCheeseBurger.Text = "치즈버거";
            rdoCheeseBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 9.75F);
            rdoBulgogiBurger.ForeColor = Color.Purple;
            rdoBulgogiBurger.Location = new Point(11, 146);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(96, 21);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기 버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 9.75F);
            rdoHamBurger.ForeColor = Color.Purple;
            rdoHamBurger.Location = new Point(11, 56);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(65, 21);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // grbTopping
            // 
            grbTopping.Controls.Add(chkSauce);
            grbTopping.Controls.Add(chkCheese);
            grbTopping.Controls.Add(chkCola);
            grbTopping.Controls.Add(chkPotato);
            grbTopping.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbTopping.ForeColor = Color.OrangeRed;
            grbTopping.Location = new Point(301, 106);
            grbTopping.Name = "grbTopping";
            grbTopping.Size = new Size(165, 223);
            grbTopping.TabIndex = 2;
            grbTopping.TabStop = false;
            grbTopping.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Indigo;
            chkSauce.Location = new Point(11, 175);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(99, 25);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.Indigo;
            chkCheese.Location = new Point(11, 128);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(99, 25);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = Color.Indigo;
            chkCola.Location = new Point(11, 82);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(61, 25);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.ForeColor = Color.Indigo;
            chkPotato.Location = new Point(11, 35);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(93, 25);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grbOrderList
            // 
            grbOrderList.Controls.Add(lblTotalCost);
            grbOrderList.Controls.Add(lstOrder);
            grbOrderList.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbOrderList.ForeColor = Color.OrangeRed;
            grbOrderList.Location = new Point(509, 106);
            grbOrderList.Name = "grbOrderList";
            grbOrderList.Size = new Size(262, 246);
            grbOrderList.TabIndex = 3;
            grbOrderList.TabStop = false;
            grbOrderList.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.MediumBlue;
            lblTotalCost.Location = new Point(17, 215);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(143, 21);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 주문 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(17, 35);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(229, 172);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(0, 192, 0);
            btnOrder.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btnOrder.ForeColor = SystemColors.ControlText;
            btnOrder.Location = new Point(518, 373);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(109, 41);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.IndianRed;
            btnReset.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btnReset.Location = new Point(652, 373);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(109, 41);
            btnReset.TabIndex = 5;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grbOrderList);
            Controls.Add(grbTopping);
            Controls.Add(grbBurger);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Burger Kiosk v.1.0";
            grbBurger.ResumeLayout(false);
            grbBurger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbTopping.ResumeLayout(false);
            grbTopping.PerformLayout();
            grbOrderList.ResumeLayout(false);
            grbOrderList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbBurger;
        private RadioButton rdoCheeseBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private GroupBox grbTopping;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
        private GroupBox grbOrderList;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
