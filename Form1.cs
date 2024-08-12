namespace CSharp_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void childFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clild Form Object
            ChildForm1 cf1 = new ChildForm1();
            //Define MDi parent form
            cf1.MdiParent = this;
            cf1.Show();
        }
    }
}
