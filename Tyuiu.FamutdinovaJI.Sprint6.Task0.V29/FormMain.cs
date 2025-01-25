using Tyuiu.FamutdinovaJI.Sprint6.Task0.V29.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint6.Task0.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResultOutput.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarInput.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxResult_Enter(object sender, EventArgs e)
        {

        }


        private void textBoxVarInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != ',') && (e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxResultOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tаск 0 выполнила студентка группы ИИПб-24-2 Фамутдинова Юлия Ильфатовна","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
