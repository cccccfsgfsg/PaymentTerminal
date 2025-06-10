using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaymentTerminal
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(string receiptText)
        {
            InitializeComponent();
            // Подписка на событие Load
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            // Установка текста чека
            txtReceipt.Text = receiptText;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            // Настройка формы при загрузке
            txtReceipt.Font = new Font("Consolas", 10); // Моноширинный шрифт для читаемости чека
            txtReceipt.BackColor = Color.White;
            this.Text = "Чек платежа";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Закрытие формы
            this.Close();
        }
    }
}