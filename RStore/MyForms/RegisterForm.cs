using RStore.DAL;
using RStore.Enums;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RStore.MyForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        MyDatabase myDatabase = new MyDatabase();
        private void btn_RegisterInRegisterForm_Click(object sender, EventArgs e)
        {
            string _email = txb_EmailInRegisterForm.Text;
            
            if (!string.IsNullOrEmpty(this.txb_Name.Text) &&
                !string.IsNullOrEmpty(this.txb_Surname.Text) &&
                !string.IsNullOrEmpty(this.txb_PhoneNumber.Text) &&
                !string.IsNullOrEmpty(this.txb_EmailInRegisterForm.Text) &&
                !string.IsNullOrEmpty(this.txb_PasswordInRegisterForm.Text) &&
                !string.IsNullOrEmpty(this.txb_PasswordAgain.Text) &&
                txb_PasswordInRegisterForm.Text == txb_PasswordAgain.Text &&
                myDatabase.EmailChecking(_email))
            {


                User user = new User()
                {
                    Name = txb_Name.Text,
                    Surname = txb_Surname.Text,
                    Email = txb_EmailInRegisterForm.Text,
                    PhoneNumber = txb_PhoneNumber.Text,
                    Password = txb_PasswordInRegisterForm.Text,
                    Status = Role.User.ToString()
                    };
                Validate(user);
                    myDatabase.UserAdd(user);
                    MessageBox.Show("Completed");



                Hide();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
       static void Validate(User user)
        {
            ValidationContext context = new ValidationContext(user);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(user, context, errors, true))
            {
                foreach (ValidationResult item in errors)
                {
                    MessageBox.Show(item.ErrorMessage);
                    break;
                }
            }
            else
            {
                MessageBox.Show("Validation operations Succeded");
            }
        }
    }
}
