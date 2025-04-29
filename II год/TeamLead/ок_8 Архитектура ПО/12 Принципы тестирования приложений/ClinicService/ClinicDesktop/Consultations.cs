
using ClinicServiceNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDesktop
{
    public partial class Consultations : Form
    {
        private static readonly ClinicClient clinicClient = new ClinicClient("http://localhost:5434/", new HttpClient());
        public Consultations()
        {
            InitializeComponent();
        }

        private void ConsultationCreate_Click(object sender, EventArgs e)
        {
            CreateConsultationRequest consultation = new CreateConsultationRequest();
            consultation.ClientId = Convert.ToInt32(ConsultationCreateClientId.Text);
            consultation.PetId = Convert.ToInt32(ConsultationCreatePetId.Text);
            consultation.ConsultationDate = Convert.ToDateTime(ConsultationCreateDate.Text);
            consultation.Description = ConsultationCreateDescription.Text;
            clinicClient.ConsultationCreateAsync(consultation);
        }

        private void ConsultationUpdate_Click(object sender, EventArgs e)
        {
            ICollection<Consultation> consultations = clinicClient.ConsultationGetAllAsync().Result;

            foreach (Consultation consultation in consultations)
            {
                if (consultation.ConsultationId == Convert.ToInt32(ConsultationUpdateId.Text))
                {
                    UpdateConsultationRequest consultationToUpdate = new UpdateConsultationRequest();
                    consultationToUpdate.ConsultationId = Convert.ToInt32(ConsultationUpdateId.Text);
                    consultationToUpdate.ClientId = Convert.ToInt32(ConsultationUpdateClientId.Text);
                    consultationToUpdate.PetId = Convert.ToInt32(ConsultationUpdatePetId.Text);
                    consultationToUpdate.ConsultationDate = Convert.ToDateTime(ConsultationUpdateDate.Text);
                    consultationToUpdate.Description = ConsultationUpdateDescription.Text;
                    clinicClient.ConsultationUpdateAsync(consultationToUpdate);
                }
            }
        }

        private void ConsultationDelete_Click(object sender, EventArgs e)
        {
            ICollection<Consultation> consultations = clinicClient.ConsultationGetAllAsync().Result;
            ConsultationGet.Items.Clear();
            foreach (Consultation consultation in consultations)
            {
                ListViewItem item = new ListViewItem();
                if (consultation.ConsultationId.ToString() == ConsultationDeleteId.Text)
                {
                    clinicClient.ConsultationDeleteAsync(consultation.ConsultationId);
                }
            }
            ConsultationDeleteId.Clear();
        }

        private void ConsultationGetAll_Click(object sender, EventArgs e)
        {
            ICollection<Consultation> consultations = clinicClient.ConsultationGetAllAsync().Result;
            ConsultationGet.Items.Clear();
            foreach (Consultation consultation in consultations)
            {
                ListViewItem item = new ListViewItem();
                item.Text = consultation.ConsultationId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.ClientId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.PetId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.ConsultationDate.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.Description.ToString()
                });
                ConsultationGet.Items.Add(item);
            }
        }

        private void ConsultationGetById_Click(object sender, EventArgs e)
        {
            ICollection<Consultation> consultations = clinicClient.ConsultationGetAllAsync().Result;
            ConsultationGet.Items.Clear();
            foreach (Consultation consultation in consultations)
            {
                ListViewItem item = new ListViewItem();
                if (consultation.ConsultationId.ToString() == ConsultationGetId.Text)
                {
                    item.Text = consultation.ConsultationId.ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = consultation.ClientId.ToString()
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = consultation.PetId.ToString()
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = consultation.ConsultationDate.ToString()
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = consultation.Description.ToString()
                    });
                    ConsultationGet.Items.Add(item); ;
                }
            }
            ConsultationGetId.Clear();
        }

        
    }
}
