using System.ComponentModel.Design;

namespace Pro100test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        private void textbtn_Click(object sender, EventArgs e)
        {

            createUserBase(txtPath.Text);

            //isWorkinglbl.Text = "Path Didn't Find any Games";

            spitOutGames();

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {



        }

    }
}