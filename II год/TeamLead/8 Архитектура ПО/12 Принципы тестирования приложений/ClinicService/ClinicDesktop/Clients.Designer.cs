namespace ClinicDesktop
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClientCreate = new Button();
            ClientUpdate = new Button();
            ClientDeleteId = new TextBox();
            ClientDelete = new Button();
            ClientGet = new ListView();
            Id = new ColumnHeader();
            Document = new ColumnHeader();
            SurName = new ColumnHeader();
            FirstName = new ColumnHeader();
            Patronymic = new ColumnHeader();
            BirthDay = new ColumnHeader();
            ClientGetAll = new Button();
            ClientGetById = new Button();
            ClientGetId = new TextBox();
            ClientCreateDocument = new MaskedTextBox();
            ClientCreateSurName = new MaskedTextBox();
            ClientCreateFirstName = new MaskedTextBox();
            ClientCreatePatronymic = new MaskedTextBox();
            ClientCreateBirthDay = new MaskedTextBox();
            ClientUpdateBirthDay = new MaskedTextBox();
            ClientUpdatePatronymic = new MaskedTextBox();
            ClientUpdateFirstName = new MaskedTextBox();
            ClientUpdateSurName = new MaskedTextBox();
            ClientUpdateDocument = new MaskedTextBox();
            ClientUpdateId = new MaskedTextBox();
            SuspendLayout();
            // 
            // ClientCreate
            // 
            ClientCreate.Location = new Point(12, 60);
            ClientCreate.Name = "ClientCreate";
            ClientCreate.Size = new Size(94, 29);
            ClientCreate.TabIndex = 1;
            ClientCreate.Text = "Добавить";
            ClientCreate.UseVisualStyleBackColor = true;
            ClientCreate.Click += ClientCreate_Click;
            // 
            // ClientUpdate
            // 
            ClientUpdate.Location = new Point(12, 156);
            ClientUpdate.Name = "ClientUpdate";
            ClientUpdate.Size = new Size(94, 29);
            ClientUpdate.TabIndex = 3;
            ClientUpdate.Text = "Обновить";
            ClientUpdate.UseVisualStyleBackColor = true;
            ClientUpdate.Click += ClientUpdate_Click;
            // 
            // ClientDeleteId
            // 
            ClientDeleteId.Location = new Point(143, 210);
            ClientDeleteId.Name = "ClientDeleteId";
            ClientDeleteId.Size = new Size(125, 27);
            ClientDeleteId.TabIndex = 4;
            // 
            // ClientDelete
            // 
            ClientDelete.Location = new Point(12, 208);
            ClientDelete.Name = "ClientDelete";
            ClientDelete.Size = new Size(94, 29);
            ClientDelete.TabIndex = 5;
            ClientDelete.Text = "Удалить";
            ClientDelete.UseVisualStyleBackColor = true;
            ClientDelete.Click += ClientDelete_Click;
            // 
            // ClientGet
            // 
            ClientGet.Columns.AddRange(new ColumnHeader[] { Id, Document, SurName, FirstName, Patronymic, BirthDay });
            ClientGet.FullRowSelect = true;
            ClientGet.GridLines = true;
            ClientGet.Location = new Point(9, 264);
            ClientGet.MultiSelect = false;
            ClientGet.Name = "ClientGet";
            ClientGet.Size = new Size(776, 126);
            ClientGet.TabIndex = 6;
            ClientGet.UseCompatibleStateImageBehavior = false;
            ClientGet.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "#";
            Id.Width = 50;
            // 
            // Document
            // 
            Document.Text = "Документ";
            Document.Width = 100;
            // 
            // SurName
            // 
            SurName.Text = "Фамилия";
            SurName.Width = 100;
            // 
            // FirstName
            // 
            FirstName.Text = "Имя";
            FirstName.Width = 100;
            // 
            // Patronymic
            // 
            Patronymic.Text = "Отчество";
            Patronymic.Width = 100;
            // 
            // BirthDay
            // 
            BirthDay.Text = "Дата рождения";
            BirthDay.Width = 150;
            // 
            // ClientGetAll
            // 
            ClientGetAll.Location = new Point(9, 413);
            ClientGetAll.Name = "ClientGetAll";
            ClientGetAll.Size = new Size(150, 29);
            ClientGetAll.TabIndex = 7;
            ClientGetAll.Text = "Отобразить всех";
            ClientGetAll.UseVisualStyleBackColor = true;
            ClientGetAll.Click += ClientGetAll_Click;
            // 
            // ClientGetById
            // 
            ClientGetById.Location = new Point(501, 413);
            ClientGetById.Name = "ClientGetById";
            ClientGetById.Size = new Size(150, 29);
            ClientGetById.TabIndex = 9;
            ClientGetById.Text = "Отобразить по ID";
            ClientGetById.UseVisualStyleBackColor = true;
            ClientGetById.Click += ClientGetById_Click;
            // 
            // ClientGetId
            // 
            ClientGetId.Location = new Point(657, 415);
            ClientGetId.Name = "ClientGetId";
            ClientGetId.Size = new Size(125, 27);
            ClientGetId.TabIndex = 8;
            // 
            // ClientCreateDocument
            // 
            ClientCreateDocument.Font = new Font("Segoe UI", 9F);
            ClientCreateDocument.ForeColor = Color.Silver;
            ClientCreateDocument.Location = new Point(12, 12);
            ClientCreateDocument.Name = "ClientCreateDocument";
            ClientCreateDocument.Size = new Size(125, 27);
            ClientCreateDocument.TabIndex = 10;
            ClientCreateDocument.Text = "Документ";
            ClientCreateDocument.Enter += ClientCreateDocument_Enter;
            ClientCreateDocument.Leave += ClientCreateDocument_Leave;
            // 
            // ClientCreateSurName
            // 
            ClientCreateSurName.BackColor = Color.White;
            ClientCreateSurName.ForeColor = Color.Silver;
            ClientCreateSurName.Location = new Point(143, 12);
            ClientCreateSurName.Name = "ClientCreateSurName";
            ClientCreateSurName.Size = new Size(125, 27);
            ClientCreateSurName.TabIndex = 11;
            ClientCreateSurName.Text = "Фамилия";
            ClientCreateSurName.Enter += ClientCreateSurName_Enter;
            ClientCreateSurName.Leave += ClientCreateSurName_Leave;
            // 
            // ClientCreateFirstName
            // 
            ClientCreateFirstName.BackColor = Color.White;
            ClientCreateFirstName.ForeColor = Color.Silver;
            ClientCreateFirstName.Location = new Point(274, 12);
            ClientCreateFirstName.Name = "ClientCreateFirstName";
            ClientCreateFirstName.Size = new Size(125, 27);
            ClientCreateFirstName.TabIndex = 12;
            ClientCreateFirstName.Text = "Имя";
            ClientCreateFirstName.Enter += ClientCreateFirstName_Enter;
            ClientCreateFirstName.Leave += ClientCreateFirstName_Leave;
            // 
            // ClientCreatePatronymic
            // 
            ClientCreatePatronymic.BackColor = Color.White;
            ClientCreatePatronymic.ForeColor = Color.Silver;
            ClientCreatePatronymic.Location = new Point(405, 12);
            ClientCreatePatronymic.Name = "ClientCreatePatronymic";
            ClientCreatePatronymic.Size = new Size(125, 27);
            ClientCreatePatronymic.TabIndex = 13;
            ClientCreatePatronymic.Text = "Отчество";
            ClientCreatePatronymic.Enter += ClientCreatePatronymic_Enter;
            ClientCreatePatronymic.Leave += ClientCreatePatronymic_Leave;
            // 
            // ClientCreateBirthDay
            // 
            ClientCreateBirthDay.BackColor = SystemColors.Window;
            ClientCreateBirthDay.Location = new Point(536, 12);
            ClientCreateBirthDay.Mask = "00/00/0000";
            ClientCreateBirthDay.Name = "ClientCreateBirthDay";
            ClientCreateBirthDay.Size = new Size(125, 27);
            ClientCreateBirthDay.TabIndex = 14;
            ClientCreateBirthDay.ValidatingType = typeof(DateTime);
            // 
            // ClientUpdateBirthDay
            // 
            ClientUpdateBirthDay.BackColor = SystemColors.Window;
            ClientUpdateBirthDay.Location = new Point(667, 106);
            ClientUpdateBirthDay.Mask = "00/00/0000";
            ClientUpdateBirthDay.Name = "ClientUpdateBirthDay";
            ClientUpdateBirthDay.Size = new Size(125, 27);
            ClientUpdateBirthDay.TabIndex = 19;
            ClientUpdateBirthDay.ValidatingType = typeof(DateTime);
            // 
            // ClientUpdatePatronymic
            // 
            ClientUpdatePatronymic.BackColor = Color.White;
            ClientUpdatePatronymic.ForeColor = Color.Silver;
            ClientUpdatePatronymic.Location = new Point(536, 106);
            ClientUpdatePatronymic.Name = "ClientUpdatePatronymic";
            ClientUpdatePatronymic.Size = new Size(125, 27);
            ClientUpdatePatronymic.TabIndex = 18;
            ClientUpdatePatronymic.Text = "Отчество";
            ClientUpdatePatronymic.Enter += ClientUpdatePatronymic_Enter;
            ClientUpdatePatronymic.Leave += ClientUpdatePatronymic_Leave;
            // 
            // ClientUpdateFirstName
            // 
            ClientUpdateFirstName.BackColor = Color.White;
            ClientUpdateFirstName.ForeColor = Color.Silver;
            ClientUpdateFirstName.Location = new Point(405, 106);
            ClientUpdateFirstName.Name = "ClientUpdateFirstName";
            ClientUpdateFirstName.Size = new Size(125, 27);
            ClientUpdateFirstName.TabIndex = 17;
            ClientUpdateFirstName.Text = "Имя";
            ClientUpdateFirstName.Enter += ClientUpdateFirstName_Enter;
            ClientUpdateFirstName.Leave += ClientUpdateFirstName_Leave;
            // 
            // ClientUpdateSurName
            // 
            ClientUpdateSurName.BackColor = Color.White;
            ClientUpdateSurName.ForeColor = Color.Silver;
            ClientUpdateSurName.Location = new Point(274, 106);
            ClientUpdateSurName.Name = "ClientUpdateSurName";
            ClientUpdateSurName.Size = new Size(125, 27);
            ClientUpdateSurName.TabIndex = 16;
            ClientUpdateSurName.Text = "Фамилия";
            ClientUpdateSurName.Enter += ClientUpdateSurName_Enter;
            ClientUpdateSurName.Leave += ClientUpdateSurName_Leave;
            // 
            // ClientUpdateDocument
            // 
            ClientUpdateDocument.Font = new Font("Segoe UI", 9F);
            ClientUpdateDocument.ForeColor = Color.Silver;
            ClientUpdateDocument.Location = new Point(143, 106);
            ClientUpdateDocument.Name = "ClientUpdateDocument";
            ClientUpdateDocument.Size = new Size(125, 27);
            ClientUpdateDocument.TabIndex = 15;
            ClientUpdateDocument.Text = "Документ";
            ClientUpdateDocument.Enter += ClientUpdateDocument_Enter;
            ClientUpdateDocument.Leave += ClientUpdateDocument_Leave;
            // 
            // ClientUpdateId
            // 
            ClientUpdateId.Font = new Font("Segoe UI", 9F);
            ClientUpdateId.ForeColor = Color.Silver;
            ClientUpdateId.Location = new Point(12, 106);
            ClientUpdateId.Name = "ClientUpdateId";
            ClientUpdateId.Size = new Size(125, 27);
            ClientUpdateId.TabIndex = 20;
            ClientUpdateId.Text = "#";
            ClientUpdateId.Enter += ClientUpdateId_Enter;
            ClientUpdateId.Leave += ClientUpdateId_Leave;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 459);
            Controls.Add(ClientUpdateId);
            Controls.Add(ClientUpdateBirthDay);
            Controls.Add(ClientUpdatePatronymic);
            Controls.Add(ClientUpdateFirstName);
            Controls.Add(ClientUpdateSurName);
            Controls.Add(ClientUpdateDocument);
            Controls.Add(ClientCreateBirthDay);
            Controls.Add(ClientCreatePatronymic);
            Controls.Add(ClientCreateFirstName);
            Controls.Add(ClientCreateSurName);
            Controls.Add(ClientCreateDocument);
            Controls.Add(ClientGetById);
            Controls.Add(ClientGetId);
            Controls.Add(ClientGetAll);
            Controls.Add(ClientGet);
            Controls.Add(ClientDelete);
            Controls.Add(ClientDeleteId);
            Controls.Add(ClientUpdate);
            Controls.Add(ClientCreate);
            Name = "Clients";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ClientCreateDocument_Enter(object sender, EventArgs e)
        {
            if (ClientCreateDocument.Text != string.Empty)
            {
                ClientCreateDocument.Text = string.Empty;
            }
        }

        private void ClientCreateDocument_Leave(object sender, EventArgs e)
        {
            if (ClientCreateDocument.Text == "")
            {
                ClientCreateDocument.ForeColor = Color.Silver;
                ClientCreateDocument.Text = "Документ";
            }           
        }
        private void ClientCreateSurName_Enter(object sender, EventArgs e)
        {
            if (ClientCreateSurName.Text != string.Empty)
            {
                ClientCreateSurName.Text = string.Empty;
            }
        }

        private void ClientCreateSurName_Leave(object sender, EventArgs e)
        {
            if (ClientCreateSurName.Text == "")
            {
                ClientCreateSurName.ForeColor = Color.Silver;
                ClientCreateSurName.Text = "Фамилия";
            }
        }
        private void ClientCreateFirstName_Enter(object sender, EventArgs e)
        {
            if (ClientCreateFirstName.Text != string.Empty)
            {
                ClientCreateFirstName.Text = string.Empty;
            }
        }

        private void ClientCreateFirstName_Leave(object sender, EventArgs e)
        {
            if (ClientCreateFirstName.Text == "")
            {
                ClientCreateFirstName.ForeColor = Color.Silver;
                ClientCreateFirstName.Text = "Имя";
            }
        }

        private void ClientCreatePatronymic_Enter(object sender, EventArgs e)
        {
            if (ClientCreatePatronymic.Text != string.Empty)
            {
                ClientCreatePatronymic.Text = string.Empty;
            }
        }

        private void ClientCreatePatronymic_Leave(object sender, EventArgs e)
        {
            if (ClientCreatePatronymic.Text == "")
            {
                ClientCreatePatronymic.ForeColor = Color.Silver;
                ClientCreatePatronymic.Text = "Отчество";
            }
        }
        private void ClientUpdateId_Enter(object sender, EventArgs e)
        {
            if (ClientUpdateId.Text != string.Empty)
            {
                ClientUpdateId.Text = string.Empty;
            }
        }

        private void ClientUpdateId_Leave(object sender, EventArgs e)
        {
            if (ClientUpdateId.Text == "")
            {
                ClientUpdateId.ForeColor = Color.Silver;
                ClientUpdateId.Text = "#";
            }
        }
        private void ClientUpdateDocument_Enter(object sender, EventArgs e)
        {
            if (ClientUpdateDocument.Text != string.Empty)
            {
                ClientUpdateDocument.Text = string.Empty;
            }
        }

        private void ClientUpdateDocument_Leave(object sender, EventArgs e)
        {
            if (ClientUpdateDocument.Text == "")
            {
                ClientUpdateDocument.ForeColor = Color.Silver;
                ClientUpdateDocument.Text = "Документ";
            }
        }
        private void ClientUpdateSurName_Enter(object sender, EventArgs e)
        {
            if (ClientUpdateSurName.Text != string.Empty)
            {
                ClientUpdateSurName.Text = string.Empty;
            }
        }

        private void ClientUpdateSurName_Leave(object sender, EventArgs e)
        {
            if (ClientUpdateSurName.Text == "")
            {
                ClientUpdateSurName.ForeColor = Color.Silver;
                ClientUpdateSurName.Text = "Фамилия";
            }
        }
        private void ClientUpdateFirstName_Enter(object sender, EventArgs e)
        {
            if (ClientUpdateFirstName.Text != string.Empty)
            {
                ClientUpdateFirstName.Text = string.Empty;
            }
        }

        private void ClientUpdateFirstName_Leave(object sender, EventArgs e)
        {
            if (ClientUpdateFirstName.Text == "")
            {
                ClientUpdateFirstName.ForeColor = Color.Silver;
                ClientUpdateFirstName.Text = "Имя";
            }
        }

        private void ClientUpdatePatronymic_Enter(object sender, EventArgs e)
        {
            if (ClientUpdatePatronymic.Text != string.Empty)
            {
                ClientUpdatePatronymic.Text = string.Empty;
            }
        }

        private void ClientUpdatePatronymic_Leave(object sender, EventArgs e)
        {
            if (ClientUpdatePatronymic.Text == "")
            {
                ClientUpdatePatronymic.ForeColor = Color.Silver;
                ClientUpdatePatronymic.Text = "Отчество";
            }
        }

        #endregion
        private Button ClientCreate;
        private Button ClientUpdate;
        private TextBox ClientDeleteId;
        private Button ClientDelete;
        private ListView ClientGet;
        private ColumnHeader Id;
        private ColumnHeader Document;
        private ColumnHeader SurName;
        private ColumnHeader FirstName;
        private ColumnHeader Patronymic;
        private Button ClientGetAll;
        private Button ClientGetById;
        private TextBox ClientGetId;
        private MaskedTextBox ClientCreateDocument;
        private MaskedTextBox ClientCreateSurName;
        private MaskedTextBox ClientCreateFirstName;
        private MaskedTextBox ClientCreatePatronymic;
        private MaskedTextBox ClientCreateBirthDay;
        private MaskedTextBox ClientUpdateBirthDay;
        private MaskedTextBox ClientUpdatePatronymic;
        private MaskedTextBox ClientUpdateFirstName;
        private MaskedTextBox ClientUpdateSurName;
        private MaskedTextBox ClientUpdateDocument;
        private MaskedTextBox ClientUpdateId;
        private ColumnHeader BirthDay;
    }
}