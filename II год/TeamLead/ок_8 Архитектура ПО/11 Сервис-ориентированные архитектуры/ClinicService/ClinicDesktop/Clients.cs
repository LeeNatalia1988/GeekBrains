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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicDesktop
{
    public partial class Clients : Form
    {
        private static readonly ClinicClient clinicClient = new ClinicClient("http://localhost:5434/", new HttpClient());
        public Clients()
        {
            InitializeComponent();
        }

        private void ClientCreate_Click(object sender, EventArgs e)
        {
            CreateClientRequest client = new CreateClientRequest();
            client.Document = ClientCreateDocument.Text;
            client.SurName = ClientCreateSurName.Text;
            client.FirstName = ClientCreateFirstName.Text;
            client.Patronymic = ClientCreatePatronymic.Text;
            client.BirthDay = Convert.ToDateTime(ClientCreateBirthDay.Text);
            clinicClient.ClientCreateAsync(client);
        }

        private void ClientUpdate_Click(object sender, EventArgs e)
        {
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;

            foreach (Client client in clients)
            {
                if (client.ClientId == Convert.ToInt32(ClientUpdateId.Text))
                {
                    UpdateClientRequest clientToUpdate = new UpdateClientRequest();
                    clientToUpdate.ClientId = Convert.ToInt32(ClientUpdateId.Text);
                    clientToUpdate.Document = ClientUpdateDocument.Text;
                    clientToUpdate.SurName = ClientUpdateSurName.Text;
                    clientToUpdate.FirstName = ClientUpdateFirstName.Text;
                    clientToUpdate.Patronymic = ClientUpdatePatronymic.Text;
                    clientToUpdate.BirthDay = Convert.ToDateTime(ClientUpdateBirthDay.Text);
                    clinicClient.ClientUpdateAsync(clientToUpdate);
                }
            }
        }
        private void ClientDelete_Click(object sender, EventArgs e)
        {
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;
            ClientGet.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                if (client.ClientId.ToString() == ClientDeleteId.Text)
                {
                    clinicClient.ClientDeleteAsync(client.ClientId);
                }
            }
            ClientDeleteId.Clear();
        }

        private void ClientGetAll_Click(object sender, EventArgs e)
        {
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;
            ClientGet.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Document
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.BirthDay.ToString()
                });
                ClientGet.Items.Add(item);
            }
        }

        private void ClientGetById_Click(object sender, EventArgs e)
        {
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;
            ClientGet.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                if (client.ClientId.ToString() == ClientGetId.Text)
                {
                    item.Text = client.ClientId.ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = client.Document
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = client.FirstName
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = client.SurName
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = client.BirthDay.ToString()
                    });
                    ClientGet.Items.Add(item);
                }
            }
            ClientGetId.Clear();
        }
    }
}
