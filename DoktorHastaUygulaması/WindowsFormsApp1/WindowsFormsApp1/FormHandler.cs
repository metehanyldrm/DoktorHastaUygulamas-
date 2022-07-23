using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class FormHandler
    {
        public static void formDegistir(Form bulunanForm, Form gecilecekOlanForm)
        {
            bulunanForm.Hide();
            gecilecekOlanForm.Show();
        }

        public static void yeniFormAc(Form yeniForm)
        {
            yeniForm.Show();
        }
    }
}
