using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_StorageManager.Classes
{
    class Common
    { 
        // public static bool runGetTotals = false;
        public static MenuForm menuForm;

        public static bool CheckOpenForms(string formName)
        {
            // check whether the form is already open
            bool formIsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == formName)
                {
                    formIsOpen = true;
                }
            }
            return formIsOpen;
        }

        public static bool UserAnswer(string question, string caption)
        {
            bool answer = false;
            DialogResult result_MessageBox = MessageBox.Show(question, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result_MessageBox == DialogResult.Yes) answer = true;
            
            return answer;
        }

        public void Test(Label label)
        {
            label.Text = "kutya";
        }
    }
}
