using Microsoft.VisualBasic.ApplicationServices;

namespace Pr_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SubsystemPartnersContext db = new SubsystemPartnersContext())
            {
                var partner = db.Partners.ToList();
                TableName.Text = "Список партнеров:";

                foreach (Partner u in partner)
                {
                    TableValue.Text += $"{u.Id, -5}|    |{u.IdTypePartner, -5}|   |{u.NamePartner, -20}|    |" +
                        $"{u.LegalAddress, -80}|     |{u.DirectorFullName, -25}|      |{u.Phone, -15}\n";
                }
            }
        }
    }
}
