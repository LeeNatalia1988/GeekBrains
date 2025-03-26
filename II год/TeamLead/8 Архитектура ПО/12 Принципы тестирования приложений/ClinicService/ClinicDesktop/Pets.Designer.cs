namespace ClinicDesktop
{
    partial class Pets
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
            PetUpdateBirthDay = new MaskedTextBox();
            PetUpdateName = new MaskedTextBox();
            PetUpdateClientId = new MaskedTextBox();
            PetUpdateId = new MaskedTextBox();
            PetCreateBirthDay = new MaskedTextBox();
            PetCreateName = new MaskedTextBox();
            PetCreateClientId = new MaskedTextBox();
            PetGetById = new Button();
            PetGetId = new TextBox();
            PetGetAll = new Button();
            PetGet = new ListView();
            Id = new ColumnHeader();
            ClientId = new ColumnHeader();
            Name = new ColumnHeader();
            BirthDay = new ColumnHeader();
            PetDelete = new Button();
            PetDeleteId = new TextBox();
            PetUpdate = new Button();
            PetCreate = new Button();
            SuspendLayout();
            // 
            // PetUpdateBirthDay
            // 
            PetUpdateBirthDay.BackColor = SystemColors.Window;
            PetUpdateBirthDay.Location = new Point(408, 104);
            PetUpdateBirthDay.Mask = "00/00/0000";
            PetUpdateBirthDay.Name = "PetUpdateBirthDay";
            PetUpdateBirthDay.Size = new Size(125, 27);
            PetUpdateBirthDay.TabIndex = 60;
            PetUpdateBirthDay.ValidatingType = typeof(DateTime);
            // 
            // PetUpdateName
            // 
            PetUpdateName.BackColor = Color.White;
            PetUpdateName.ForeColor = Color.Silver;
            PetUpdateName.Location = new Point(277, 104);
            PetUpdateName.Name = "PetUpdateName";
            PetUpdateName.Size = new Size(125, 27);
            PetUpdateName.TabIndex = 58;
            PetUpdateName.Text = "Имя";
            // 
            // PetUpdateClientId
            // 
            PetUpdateClientId.Font = new Font("Segoe UI", 9F);
            PetUpdateClientId.ForeColor = Color.Silver;
            PetUpdateClientId.Location = new Point(146, 104);
            PetUpdateClientId.Name = "PetUpdateClientId";
            PetUpdateClientId.Size = new Size(125, 27);
            PetUpdateClientId.TabIndex = 57;
            PetUpdateClientId.Text = "Клиент";
            // 
            // PetUpdateId
            // 
            PetUpdateId.Font = new Font("Segoe UI", 9F);
            PetUpdateId.ForeColor = Color.Silver;
            PetUpdateId.Location = new Point(15, 104);
            PetUpdateId.Name = "PetUpdateId";
            PetUpdateId.Size = new Size(125, 27);
            PetUpdateId.TabIndex = 56;
            PetUpdateId.Text = "#";
            // 
            // PetCreateBirthDay
            // 
            PetCreateBirthDay.BackColor = SystemColors.Window;
            PetCreateBirthDay.Location = new Point(277, 10);
            PetCreateBirthDay.Mask = "00/00/0000";
            PetCreateBirthDay.Name = "PetCreateBirthDay";
            PetCreateBirthDay.Size = new Size(125, 27);
            PetCreateBirthDay.TabIndex = 55;
            PetCreateBirthDay.ValidatingType = typeof(DateTime);
            // 
            // PetCreateName
            // 
            PetCreateName.BackColor = Color.White;
            PetCreateName.ForeColor = Color.Silver;
            PetCreateName.Location = new Point(146, 10);
            PetCreateName.Name = "PetCreateName";
            PetCreateName.Size = new Size(125, 27);
            PetCreateName.TabIndex = 53;
            PetCreateName.Text = "Имя";
            // 
            // PetCreateClientId
            // 
            PetCreateClientId.Font = new Font("Segoe UI", 9F);
            PetCreateClientId.ForeColor = Color.Silver;
            PetCreateClientId.Location = new Point(15, 10);
            PetCreateClientId.Name = "PetCreateClientId";
            PetCreateClientId.Size = new Size(125, 27);
            PetCreateClientId.TabIndex = 52;
            PetCreateClientId.Text = "Клиент";
            // 
            // PetGetById
            // 
            PetGetById.Location = new Point(504, 411);
            PetGetById.Name = "PetGetById";
            PetGetById.Size = new Size(150, 29);
            PetGetById.TabIndex = 51;
            PetGetById.Text = "Отобразить по ID";
            PetGetById.UseVisualStyleBackColor = true;
            PetGetById.Click += PetGetById_Click;
            // 
            // PetGetId
            // 
            PetGetId.Location = new Point(660, 413);
            PetGetId.Name = "PetGetId";
            PetGetId.Size = new Size(125, 27);
            PetGetId.TabIndex = 50;
            // 
            // PetGetAll
            // 
            PetGetAll.Location = new Point(12, 411);
            PetGetAll.Name = "PetGetAll";
            PetGetAll.Size = new Size(150, 29);
            PetGetAll.TabIndex = 49;
            PetGetAll.Text = "Отобразить всех";
            PetGetAll.UseVisualStyleBackColor = true;
            PetGetAll.Click += PetGetAll_Click;
            // 
            // PetGet
            // 
            PetGet.Columns.AddRange(new ColumnHeader[] { Id, ClientId, Name, BirthDay });
            PetGet.FullRowSelect = true;
            PetGet.GridLines = true;
            PetGet.Location = new Point(12, 262);
            PetGet.MultiSelect = false;
            PetGet.Name = "PetGet";
            PetGet.Size = new Size(776, 126);
            PetGet.TabIndex = 48;
            PetGet.UseCompatibleStateImageBehavior = false;
            PetGet.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "#";
            Id.Width = 50;
            // 
            // ClientId
            // 
            ClientId.Text = "Клиент";
            ClientId.Width = 100;
            // 
            // Name
            // 
            Name.Text = "Имя";
            Name.Width = 100;
            // 
            // BirthDay
            // 
            BirthDay.Text = "Дата рождения";
            BirthDay.Width = 150;
            // 
            // PetDelete
            // 
            PetDelete.Location = new Point(15, 206);
            PetDelete.Name = "PetDelete";
            PetDelete.Size = new Size(94, 29);
            PetDelete.TabIndex = 47;
            PetDelete.Text = "Удалить";
            PetDelete.UseVisualStyleBackColor = true;
            PetDelete.Click += PetDelete_Click;
            // 
            // PetDeleteId
            // 
            PetDeleteId.Location = new Point(146, 208);
            PetDeleteId.Name = "PetDeleteId";
            PetDeleteId.Size = new Size(125, 27);
            PetDeleteId.TabIndex = 46;
            // 
            // PetUpdate
            // 
            PetUpdate.Location = new Point(15, 154);
            PetUpdate.Name = "PetUpdate";
            PetUpdate.Size = new Size(94, 29);
            PetUpdate.TabIndex = 45;
            PetUpdate.Text = "Обновить";
            PetUpdate.UseVisualStyleBackColor = true;
            PetUpdate.Click += PetUpdate_Click;
            // 
            // PetCreate
            // 
            PetCreate.Location = new Point(15, 58);
            PetCreate.Name = "PetCreate";
            PetCreate.Size = new Size(94, 29);
            PetCreate.TabIndex = 44;
            PetCreate.Text = "Добавить";
            PetCreate.UseVisualStyleBackColor = true;
            PetCreate.Click += PetCreate_Click;
            // 
            // Pets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PetUpdateBirthDay);
            Controls.Add(PetUpdateName);
            Controls.Add(PetUpdateClientId);
            Controls.Add(PetUpdateId);
            Controls.Add(PetCreateBirthDay);
            Controls.Add(PetCreateName);
            Controls.Add(PetCreateClientId);
            Controls.Add(PetGetById);
            Controls.Add(PetGetId);
            Controls.Add(PetGetAll);
            Controls.Add(PetGet);
            Controls.Add(PetDelete);
            Controls.Add(PetDeleteId);
            Controls.Add(PetUpdate);
            Controls.Add(PetCreate);
            //Name = "Pets";
            Text = "Pets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox PetUpdateBirthDay;
        private MaskedTextBox PetUpdateName;
        private MaskedTextBox PetUpdateClientId;
        private MaskedTextBox PetUpdateId;
        private MaskedTextBox PetCreateBirthDay;
        private MaskedTextBox PetCreateName;
        private MaskedTextBox PetCreateClientId;
        private Button PetGetById;
        private TextBox PetGetId;
        private Button PetGetAll;
        private ListView PetGet;
        private ColumnHeader Id;
        private ColumnHeader ClientId;
        private ColumnHeader Name;
        private ColumnHeader BirthDay;
        private Button PetDelete;
        private TextBox PetDeleteId;
        private Button PetUpdate;
        private Button PetCreate;
    }
}