using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telemedicine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PatientDal _patientDal = new PatientDal();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            dgwPatients.DataSource = _patientDal.GetAll();
        }

        private void dgwPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _patientDal.Add(new Patient()
            {
                Name = tbxName.Text,
                Fin=tbxFin.Text,
                Sex=tbxSex.Text,
                Birthday=tbxBirthday.Text,
                Number=Convert.ToInt32(tbxBirthday.Text),
                Addres=tbxAddress.Text,
                Oclock=tbxOclock.Text,
                Diagnoss=tbxDiagnoss.Text
            });
            LoadPatients();
            MessageBox.Show("Added!");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _patientDal.Update(new Patient() {
            Id=Convert.ToInt32(dgwPatients.CurrentRow.Cells[0].Value),
            Name=tbxNameUpdate.Text,
            Fin=tbxFinUpdate.Text,
            Sex=tbxSexUpdate.Text,
            Birthday=tbxBirthdayUpdate.Text,
            Number=Convert.ToInt32(tbxNumberUpdate.Text),
            Addres=tbxAddressUpdate.Text,
            Oclock=tbxOclockUpdate.Text,
            Diagnoss=tbxDiagnossUpdate.Text
            });
            LoadPatients();
            MessageBox.Show("Updated!");
        }

        private void dgwPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwPatients.CurrentRow.Cells[1].Value.ToString();
            tbxFinUpdate.Text = dgwPatients.CurrentRow.Cells[2].Value.ToString();
            tbxSexUpdate.Text = dgwPatients.CurrentRow.Cells[3].Value.ToString();
            tbxBirthdayUpdate.Text = dgwPatients.CurrentRow.Cells[4].Value.ToString();
            tbxNumberUpdate.Text = dgwPatients.CurrentRow.Cells[5].Value.ToString();
            tbxAddressUpdate.Text = dgwPatients.CurrentRow.Cells[6].Value.ToString();
            tbxOclockUpdate.Text = dgwPatients.CurrentRow.Cells[7].Value.ToString();
            tbxDiagnossUpdate.Text = dgwPatients.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _patientDal.Delete(new Patient() {
            Id=Convert.ToInt32(dgwPatients.CurrentRow.Cells[0].Value)
            });
            LoadPatients();
            MessageBox.Show("Deleted!");
        }

        private void lblDiagnoss_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }
    }

}
