using System;
using System.Windows.Forms;
using Unity;

namespace TestApp
{
    public partial class Form1 : Form
    {
        UnityContainer unityContainer = new UnityContainer();

        public Form1()
        {
            //TN.Logic.IOC
            //Register(unityContainer);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}