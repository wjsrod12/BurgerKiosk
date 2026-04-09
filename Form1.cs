using System.Diagnostics.Eventing.Reader;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoCheeseBurger.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 주문 금액: 0원";

            btnReset.Focus();
            

        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기 버거 4,000원");
            }
            else if (rdoCheeseBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치즈 버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }

            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            lblTotalCost.ForeColor = Color.MediumBlue;
            lblTotalCost.Text= "총 주문 금액:" + totalCost.ToString("N0")+"원";

            if (totalCost == 0)
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "메뉴를 선택해주세요";
            }

        }
                }
}
