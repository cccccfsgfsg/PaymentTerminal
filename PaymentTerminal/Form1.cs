using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PaymentTerminal
{
    public partial class PaymentTerminalForm : Form
    {
        public PaymentTerminalForm()
        {
            InitializeComponent();
            // Подписка на событие Load
            this.Load += new System.EventHandler(this.PaymentTerminalForm_Load);
            // Подписка на событие SelectedIndexChanged
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
        }

        // Обработчик загрузки формы
        private void PaymentTerminalForm_Load(object sender, EventArgs e)
        {
            // Инициализация ComboBox списком услуг
            cmbService.Items.Clear();
            cmbService.Items.Add("Пополнение мобильного телефона");
            cmbService.Items.Add("Оплата интернета");
            cmbService.Items.Add("Другое");
            cmbService.Items.Add("Steam");
            // Установка значения по умолчанию
            cmbService.SelectedIndex = 0;
            // Очистка статуса
            lblStatus.Text = "Готов к работе.";
            lblStatus.ForeColor = System.Drawing.Color.Black;
        }

        // Обработчик события Click для label1
        private void label1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Метка нажата.";
            lblStatus.ForeColor = System.Drawing.Color.Black;
        }

        // Обработчик события Enter для grpService
        private void grpService_Enter(object sender, EventArgs e)
        {
            lblStatus.Text = "Выберите услугу в группе.";
            lblStatus.ForeColor = System.Drawing.Color.Black;
        }

        // Обработчик события SelectedIndexChanged для cmbService
        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex != -1)
            {
                lblStatus.Text = $"Выбрана услуга: {cmbService.SelectedItem}";
                lblStatus.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Проверка выбора услуги
            if (cmbService.SelectedIndex == -1)
            {
                lblStatus.Text = "Выберите услугу!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Валидация номера телефона
            string phoneNumber = txtPhoneNumber.Text;
            if (!IsValidPhoneNumber(phoneNumber))
            {
                lblStatus.Text = "Неверный формат номера телефона (+7 и 10 цифр)!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Валидация суммы
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount < 100 || amount > 10000)
            {
                lblStatus.Text = "Сумма должна быть от 100 до 10000 руб!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Подтверждение платежа
            DialogResult result = MessageBox.Show(
                $"Пополнить номер {phoneNumber} на {amount} руб.?\nУслуга: {cmbService.SelectedItem}",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                lblStatus.Text = "Платеж отменен.";
                lblStatus.ForeColor = System.Drawing.Color.Orange;
                return;
            }

            // Эмуляция обработки платежа
            lblStatus.Text = "Обработка платежа...";
            lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.Refresh();
            Thread.Sleep(2000); // Задержка для имитации

            // Генерация чека
            string transactionId = Guid.NewGuid().ToString();
            GenerateReceipt(transactionId, phoneNumber, amount, cmbService.SelectedItem.ToString());

            lblStatus.Text = $"Платеж успешен! ID: {transactionId}\nЧек отображен.";
            lblStatus.ForeColor = System.Drawing.Color.Green;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = "";
            txtAmount.Text = "";
            cmbService.SelectedIndex = -1;
            lblStatus.Text = "Операция отменена.";
            lblStatus.ForeColor = System.Drawing.Color.Orange;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 12 || !phoneNumber.StartsWith("+7"))
                return false;
            for (int i = 2; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                    return false;
            }
            return true;
        }

        private void GenerateReceipt(string transactionId, string phoneNumber, decimal amount, string service)
        {
            string receipt = $@"=== Чек платежного терминала ===
Дата: {DateTime.Now:dd.MM.yyyy HH:mm:ss}
ID транзакции: {transactionId}
Услуга: {service}
Номер телефона: {phoneNumber}
Сумма: {amount} руб.
Статус: Успешно
================================";

            try
            {
                // Сохранение чека в файл
                File.WriteAllText("receipt.txt", receipt);

                // Отображение чека в новой форме
                ReceiptForm receiptForm = new ReceiptForm(receipt);
                receiptForm.ShowDialog(); // Модальное окно
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Ошибка: {ex.Message}";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}