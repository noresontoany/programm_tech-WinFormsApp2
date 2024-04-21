using static WinFormsApp2.Form1;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            txtcop.Text = Properties.Settings.Default.cop.ToString();
        }


        private void result_click(object sender, EventArgs e)
        {
            int cop;
            try
            {
                cop = int.Parse(this.txtcop.Text);
            }
            catch (FormatException)
            {
                return;
            }

            Properties.Settings.Default.cop = cop;
            Properties.Settings.Default.Save();

            MessageBox.Show(logic.answer(cop)); // выведем содержимое поля txtPetrovSum
        }

        public class logic
        {
            static String checkC(int num)
            {
                if (num == 1)
                {
                    return "копейка";
                }
                else if ((num % 100) > 1 && (num % 100) < 5)
                {
                    return "копейки";
                }
                else if ((num % 100) > 4 && (num % 100) < 21)
                {
                    return "копеек";
                }
                else if ((num % 100 % 10) == 1)
                {
                    return "копейка";
                }
                else if (((num % 100 % 10) > 1) && ((num % 100 % 10) < 5))
                {
                    return "копейки";
                }
                else
                {
                    return "копеек";
                }


            }
            static String checkR(int num)
            {
                if ((num / 100) == 1)
                {
                    return "ь";
                }
                else if ((num / 100) > 1 && (num / 100) < 5)
                {
                    return "я";
                }
                else if ((num / 100) > 4 && (num / 100) < 21)
                {
                    return "ей";
                }
                else if ((num / 100 % 10) == 1)
                {
                    return "ь";
                }
                else if (((num / 100 % 10) > 1) && ((num / 100 % 10) < 5))
                {
                    return "я";
                }
                else
                {
                    return "ей";
                }
            }

            public static String answer(int cop)
            {



                if (cop % 100 != 0 && cop / 100 != 0)
                {
                    return $"{cop / 100} рубл{checkR(cop)}  {cop % 100} {checkC(cop)}";
                }
                else if (cop / 100 != 0)
                {
                    return $"{cop / 100} рубл{checkR(cop)}";
                }
                else
                {
                    return $"только {cop % 100} {checkC(cop)}";
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtcop.Text = string.Empty;
        }
    }
}