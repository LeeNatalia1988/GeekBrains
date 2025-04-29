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
    public partial class Pets : Form
    {
        private static readonly ClinicClient clinicClient = new ClinicClient("http://localhost:5434/", new HttpClient());
        public Pets()
        {
            InitializeComponent();
        }

        private void PetCreate_Click(object sender, EventArgs e)
        {
            CreatePetRequest pet = new CreatePetRequest();
            pet.ClientId = Convert.ToInt32(PetCreateClientId.Text);
            pet.BirthDay = Convert.ToDateTime(PetCreateBirthDay.Text);
            pet.Name = PetCreateName.Text;
            clinicClient.PetCreateAsync(pet);
        }

        private void PetUpdate_Click(object sender, EventArgs e)
        {
            ICollection<Pet> pets = clinicClient.PetGetAllAsync().Result;

            foreach (Pet pet in pets)
            {
                if (pet.PetId == Convert.ToInt32(PetUpdateId.Text))
                {
                    UpdatePetRequest petToUpdate = new UpdatePetRequest();
                    petToUpdate.PetId = Convert.ToInt32(PetUpdateId.Text);
                    petToUpdate.ClientId = Convert.ToInt32(PetUpdateClientId.Text);
                    petToUpdate.Name = PetUpdateName.Text;
                    petToUpdate.BirthDay = Convert.ToDateTime(PetUpdateBirthDay.Text);
                    clinicClient.PetUpdateAsync(petToUpdate);
                }
            }

        }

        private void PetDelete_Click(object sender, EventArgs e)
        {
            ICollection<Pet> pets = clinicClient.PetGetAllAsync().Result;
            PetGet.Items.Clear();
            foreach (Pet pet in pets)
            {
                ListViewItem item = new ListViewItem();
                if (pet.PetId.ToString() == PetDeleteId.Text)
                {
                    clinicClient.PetDeleteAsync(pet.PetId);
                }
            }
            PetDeleteId.Clear();

        }

        private void PetGetAll_Click(object sender, EventArgs e)
        {
            ICollection<Pet> pets = clinicClient.PetGetAllAsync().Result;
            PetGet.Items.Clear();
            foreach (Pet pet in pets)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pet.PetId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.ClientId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Name.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.BirthDay.ToString()
                });

                PetGet.Items.Add(item);
            }

        }

        private void PetGetById_Click(object sender, EventArgs e)
        {
            ICollection<Pet> pets = clinicClient.PetGetAllAsync().Result;
            PetGet.Items.Clear();
            foreach (Pet pet in pets)
            {
                ListViewItem item = new ListViewItem();
                if (pet.PetId.ToString() == PetGetId.Text)
                {
                    item.Text = pet.PetId.ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = pet.ClientId.ToString()
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = pet.Name.ToString()
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = pet.BirthDay.ToString()
                    });

                    PetGet.Items.Add(item);
                }
            }
            PetGetId.Clear();

        }
    }
}
