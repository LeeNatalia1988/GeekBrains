namespace ClinicDesktop
{
    partial class Consultations
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
            ConsultationUpdateId = new MaskedTextBox();
            ConsultationCreateDate = new MaskedTextBox();
            ConsultationCreateDescription = new MaskedTextBox();
            ConsultationCreatePetId = new MaskedTextBox();
            ConsultationCreateClientId = new MaskedTextBox();
            ConsultationGetById = new Button();
            ConsultationGetId = new TextBox();
            ConsultationGetAll = new Button();
            ConsultationGet = new ListView();
            Id = new ColumnHeader();
            ClientId = new ColumnHeader();
            PetId = new ColumnHeader();
            ConsultationDate = new ColumnHeader();
            Description = new ColumnHeader();
            ConsultationDelete = new Button();
            ConsultationDeleteId = new TextBox();
            ConsultationUpdate = new Button();
            ConsultationCreate = new Button();
            ConsultationUpdateDate = new MaskedTextBox();
            ConsultationUpdateDescription = new MaskedTextBox();
            ConsultationUpdatePetId = new MaskedTextBox();
            ConsultationUpdateClientId = new MaskedTextBox();
            SuspendLayout();
            // 
            // ConsultationUpdateId
            // 
            ConsultationUpdateId.Font = new Font("Segoe UI", 9F);
            ConsultationUpdateId.ForeColor = Color.Silver;
            ConsultationUpdateId.Location = new Point(12, 104);
            ConsultationUpdateId.Name = "ConsultationUpdateId";
            ConsultationUpdateId.Size = new Size(125, 27);
            ConsultationUpdateId.TabIndex = 39;
            ConsultationUpdateId.Text = "#";
            // 
            // ConsultationCreateDate
            // 
            ConsultationCreateDate.BackColor = SystemColors.Window;
            ConsultationCreateDate.Location = new Point(274, 10);
            ConsultationCreateDate.Mask = "00/00/0000";
            ConsultationCreateDate.Name = "ConsultationCreateDate";
            ConsultationCreateDate.Size = new Size(125, 27);
            ConsultationCreateDate.TabIndex = 33;
            ConsultationCreateDate.ValidatingType = typeof(DateTime);
            
            // 
            // ConsultationCreateDescription
            // 
            ConsultationCreateDescription.BackColor = Color.White;
            ConsultationCreateDescription.ForeColor = Color.Silver;
            ConsultationCreateDescription.Location = new Point(405, 10);
            ConsultationCreateDescription.Name = "ConsultationCreateDescription";
            ConsultationCreateDescription.Size = new Size(125, 27);
            ConsultationCreateDescription.TabIndex = 32;
            ConsultationCreateDescription.Text = "Описание";
            // 
            // ConsultationCreatePetId
            // 
            ConsultationCreatePetId.BackColor = Color.White;
            ConsultationCreatePetId.ForeColor = Color.Silver;
            ConsultationCreatePetId.Location = new Point(143, 10);
            ConsultationCreatePetId.Name = "ConsultationCreatePetId";
            ConsultationCreatePetId.Size = new Size(125, 27);
            ConsultationCreatePetId.TabIndex = 30;
            ConsultationCreatePetId.Text = "Питомец";
            // 
            // ConsultationCreateClientId
            // 
            ConsultationCreateClientId.Font = new Font("Segoe UI", 9F);
            ConsultationCreateClientId.ForeColor = Color.Silver;
            ConsultationCreateClientId.Location = new Point(12, 10);
            ConsultationCreateClientId.Name = "ConsultationCreateClientId";
            ConsultationCreateClientId.Size = new Size(125, 27);
            ConsultationCreateClientId.TabIndex = 29;
            ConsultationCreateClientId.Text = "Клиент";
            // 
            // ConsultationGetById
            // 
            ConsultationGetById.Location = new Point(501, 411);
            ConsultationGetById.Name = "ConsultationGetById";
            ConsultationGetById.Size = new Size(150, 29);
            ConsultationGetById.TabIndex = 28;
            ConsultationGetById.Text = "Отобразить по ID";
            ConsultationGetById.UseVisualStyleBackColor = true;
            ConsultationGetById.Click += ConsultationGetById_Click;
            // 
            // ConsultationGetId
            // 
            ConsultationGetId.Location = new Point(657, 413);
            ConsultationGetId.Name = "ConsultationGetId";
            ConsultationGetId.Size = new Size(125, 27);
            ConsultationGetId.TabIndex = 27;
            // 
            // ConsultationGetAll
            // 
            ConsultationGetAll.Location = new Point(9, 411);
            ConsultationGetAll.Name = "ConsultationGetAll";
            ConsultationGetAll.Size = new Size(150, 29);
            ConsultationGetAll.TabIndex = 26;
            ConsultationGetAll.Text = "Отобразить всех";
            ConsultationGetAll.UseVisualStyleBackColor = true;
            ConsultationGetAll.Click += ConsultationGetAll_Click;
            // 
            // ConsultationGet
            // 
            ConsultationGet.Columns.AddRange(new ColumnHeader[] { Id, ClientId, PetId, ConsultationDate, Description });
            ConsultationGet.FullRowSelect = true;
            ConsultationGet.GridLines = true;
            ConsultationGet.Location = new Point(9, 262);
            ConsultationGet.MultiSelect = false;
            ConsultationGet.Name = "ConsultationGet";
            ConsultationGet.Size = new Size(776, 126);
            ConsultationGet.TabIndex = 25;
            ConsultationGet.UseCompatibleStateImageBehavior = false;
            ConsultationGet.View = View.Details;
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
            // PetId
            // 
            PetId.Text = "Питомец";
            PetId.Width = 100;
            // 
            // ConsultationDate
            // 
            ConsultationDate.DisplayIndex = 4;
            ConsultationDate.Text = "Дата консультации";
            ConsultationDate.Width = 150;
            // 
            // Description
            // 
            Description.DisplayIndex = 3;
            Description.Text = "Описание";
            Description.Width = 100;
            // 
            // ConsultationDelete
            // 
            ConsultationDelete.Location = new Point(12, 206);
            ConsultationDelete.Name = "ConsultationDelete";
            ConsultationDelete.Size = new Size(94, 29);
            ConsultationDelete.TabIndex = 24;
            ConsultationDelete.Text = "Удалить";
            ConsultationDelete.UseVisualStyleBackColor = true;
            ConsultationDelete.Click += ConsultationDelete_Click;
            // 
            // ConsultationDeleteId
            // 
            ConsultationDeleteId.Location = new Point(143, 208);
            ConsultationDeleteId.Name = "ConsultationDeleteId";
            ConsultationDeleteId.Size = new Size(125, 27);
            ConsultationDeleteId.TabIndex = 23;
            // 
            // ConsultationUpdate
            // 
            ConsultationUpdate.Location = new Point(12, 154);
            ConsultationUpdate.Name = "ConsultationUpdate";
            ConsultationUpdate.Size = new Size(94, 29);
            ConsultationUpdate.TabIndex = 22;
            ConsultationUpdate.Text = "Обновить";
            ConsultationUpdate.UseVisualStyleBackColor = true;
            ConsultationUpdate.Click += ConsultationUpdate_Click;
            // 
            // ConsultationCreate
            // 
            ConsultationCreate.Location = new Point(12, 58);
            ConsultationCreate.Name = "ConsultationCreate";
            ConsultationCreate.Size = new Size(94, 29);
            ConsultationCreate.TabIndex = 21;
            ConsultationCreate.Text = "Добавить";
            ConsultationCreate.UseVisualStyleBackColor = true;
            ConsultationCreate.Click += ConsultationCreate_Click;
            // 
            // ConsultationUpdateDate
            // 
            ConsultationUpdateDate.BackColor = SystemColors.Window;
            ConsultationUpdateDate.Location = new Point(405, 104);
            ConsultationUpdateDate.Mask = "00/00/0000";
            ConsultationUpdateDate.Name = "ConsultationUpdateDate";
            ConsultationUpdateDate.Size = new Size(125, 27);
            ConsultationUpdateDate.TabIndex = 43;
            ConsultationUpdateDate.ValidatingType = typeof(DateTime);
            // 
            // ConsultationUpdateDescription
            // 
            ConsultationUpdateDescription.BackColor = Color.White;
            ConsultationUpdateDescription.ForeColor = Color.Silver;
            ConsultationUpdateDescription.Location = new Point(536, 104);
            ConsultationUpdateDescription.Name = "ConsultationUpdateDescription";
            ConsultationUpdateDescription.Size = new Size(125, 27);
            ConsultationUpdateDescription.TabIndex = 42;
            ConsultationUpdateDescription.Text = "Описание";
            // 
            // ConsultationUpdatePetId
            // 
            ConsultationUpdatePetId.BackColor = Color.White;
            ConsultationUpdatePetId.ForeColor = Color.Silver;
            ConsultationUpdatePetId.Location = new Point(274, 104);
            ConsultationUpdatePetId.Name = "ConsultationUpdatePetId";
            ConsultationUpdatePetId.Size = new Size(125, 27);
            ConsultationUpdatePetId.TabIndex = 41;
            ConsultationUpdatePetId.Text = "Питомец";
            // 
            // ConsultationUpdateClientId
            // 
            ConsultationUpdateClientId.Font = new Font("Segoe UI", 9F);
            ConsultationUpdateClientId.ForeColor = Color.Silver;
            ConsultationUpdateClientId.Location = new Point(143, 104);
            ConsultationUpdateClientId.Name = "ConsultationUpdateClientId";
            ConsultationUpdateClientId.Size = new Size(125, 27);
            ConsultationUpdateClientId.TabIndex = 40;
            ConsultationUpdateClientId.Text = "Клиент";
            // 
            // Consultations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConsultationUpdateDate);
            Controls.Add(ConsultationUpdateDescription);
            Controls.Add(ConsultationUpdatePetId);
            Controls.Add(ConsultationUpdateClientId);
            Controls.Add(ConsultationUpdateId);
            Controls.Add(ConsultationCreateDate);
            Controls.Add(ConsultationCreateDescription);
            Controls.Add(ConsultationCreatePetId);
            Controls.Add(ConsultationCreateClientId);
            Controls.Add(ConsultationGetById);
            Controls.Add(ConsultationGetId);
            Controls.Add(ConsultationGetAll);
            Controls.Add(ConsultationGet);
            Controls.Add(ConsultationDelete);
            Controls.Add(ConsultationDeleteId);
            Controls.Add(ConsultationUpdate);
            Controls.Add(ConsultationCreate);
            Name = "Consultations";
            Text = "Consultations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox ConsultationUpdateId;
        private MaskedTextBox ConsultationCreateDate;
        private MaskedTextBox ConsultationCreateDescription;
        private MaskedTextBox ConsultationCreatePetId;
        private MaskedTextBox ConsultationCreateClientId;
        private Button ConsultationGetById;
        private TextBox ConsultationGetId;
        private Button ConsultationGetAll;
        private ListView ConsultationGet;
        private ColumnHeader Id;
        private ColumnHeader ClientId;
        private ColumnHeader PetId;
        private ColumnHeader Description;
        private ColumnHeader ConsultationDate;
        private Button ConsultationDelete;
        private TextBox ConsultationDeleteId;
        private Button ConsultationUpdate;
        private Button ConsultationCreate;
        private MaskedTextBox ConsultationUpdateDate;
        private MaskedTextBox ConsultationUpdateDescription;
        private MaskedTextBox ConsultationUpdatePetId;
        private MaskedTextBox ConsultationUpdateClientId;
    }
}