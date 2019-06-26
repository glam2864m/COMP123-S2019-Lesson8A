using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8A
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        public Lab08Form()
        {
            InitializeComponent();
        }

        private void InfoGroupbox_Enter(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }
        /// <summary>
        /// this is the event handler for the submitbutton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTexBox.Text;

            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTexBox.Text + " " + AgeTextBox.Text;
            ClearForm();
        }

        private void ClearForm()
        {
            NameTexBox.Clear();
            AgeTextBox.Clear();
        }

        /// <summary>
        /// this is the event handler for the agetextbox textchange event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }

        private void NameTexBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTexBox.Text.Length >= 2) ? true : false;
        }
    }
}
