using System.Diagnostics;
namespace QBomberG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMessage.Text) || string.IsNullOrEmpty(textBoxFrequency.Text) || string.IsNullOrEmpty(textBoxTimeout.Text))
            {
                MessageBox.Show("��������������Ϊ�գ�");
                return;
            }
            Process p = new Process();
            ProcessStartInfo psi = new()
            {
                UseShellExecute = false,
                FileName = @".\qb.exe"
            };
            string[] args = { "--message", textBoxMessage.Text, "--frequency", textBoxFrequency.Text, "--timeout", textBoxTimeout.Text };
            foreach (string item in args)
            {
                psi.ArgumentList.Add(item);
            }
            p.StartInfo = psi;
            p.Start();
        }

        private void textBoxFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            //�������Ĳ����˸�����֣�����������
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
                MessageBox.Show("������������");
            }

        }

        private void textBoxTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            //�������Ĳ����˸�����֣�����������
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
                MessageBox.Show("������������");
            }
        }
    }
}