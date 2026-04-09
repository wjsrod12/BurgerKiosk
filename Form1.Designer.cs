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
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            grbTopping = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            grbOrderList = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnDelete = new Button();
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
            grbBurger.Controls.Add(radioButton3);
            grbBurger.Controls.Add(radioButton2);
            grbBurger.Controls.Add(radioButton1);
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
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("맑은 고딕", 9.75F);
            radioButton3.ForeColor = Color.Purple;
            radioButton3.Location = new Point(11, 244);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 21);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("맑은 고딕", 9.75F);
            radioButton2.ForeColor = Color.Purple;
            radioButton2.Location = new Point(11, 146);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("맑은 고딕", 9.75F);
            radioButton1.ForeColor = Color.Purple;
            radioButton1.Location = new Point(11, 56);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // grbTopping
            // 
            grbTopping.Controls.Add(checkBox4);
            grbTopping.Controls.Add(checkBox3);
            grbTopping.Controls.Add(checkBox2);
            grbTopping.Controls.Add(checkBox1);
            grbTopping.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbTopping.ForeColor = Color.OrangeRed;
            grbTopping.Location = new Point(301, 106);
            grbTopping.Name = "grbTopping";
            grbTopping.Size = new Size(165, 223);
            grbTopping.TabIndex = 2;
            grbTopping.TabStop = false;
            grbTopping.Text = "추가 옵션";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = Color.Indigo;
            checkBox4.Location = new Point(11, 175);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(99, 25);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "소스 추가";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.Indigo;
            checkBox3.Location = new Point(11, 128);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(99, 25);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "치즈 추가";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = Color.Indigo;
            checkBox2.Location = new Point(11, 82);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(61, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "콜라";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Indigo;
            checkBox1.Location = new Point(11, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "감자튀김";
            checkBox1.UseVisualStyleBackColor = true;
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
            lblTotalCost.Size = new Size(105, 21);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(17, 35);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(229, 151);
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
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btnDelete.Location = new Point(652, 373);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 41);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "초기화";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnOrder);
            Controls.Add(grbOrderList);
            Controls.Add(grbTopping);
            Controls.Add(grbBurger);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
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
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox grbTopping;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox grbOrderList;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnDelete;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
