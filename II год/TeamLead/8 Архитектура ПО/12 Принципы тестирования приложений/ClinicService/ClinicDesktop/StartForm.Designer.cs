namespace ClinicDesktop
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Client = new Button();
            Consultation = new Button();
            Pet = new Button();
            SuspendLayout();
            // 
            // Client
            // 
            Client.BackColor = SystemColors.ActiveCaption;
            Client.Location = new Point(44, 124);
            Client.Name = "Client";
            Client.Size = new Size(171, 88);
            Client.TabIndex = 0;
            Client.Text = "Клиент";
            Client.UseVisualStyleBackColor = false;
            Client.Click += Client_Click;
            // 
            // Consultation
            // 
            Consultation.BackColor = Color.IndianRed;
            Consultation.Location = new Point(317, 124);
            Consultation.Name = "Consultation";
            Consultation.Size = new Size(171, 88);
            Consultation.TabIndex = 1;
            Consultation.Text = "Консультация";
            Consultation.UseVisualStyleBackColor = false;
            Consultation.Click += Consultation_Click;
            // 
            // Pet
            // 
            Pet.BackColor = Color.DarkSeaGreen;
            Pet.Location = new Point(589, 124);
            Pet.Name = "Pet";
            Pet.Size = new Size(171, 88);
            Pet.TabIndex = 2;
            Pet.Text = "Питомец";
            Pet.UseVisualStyleBackColor = false;
            Pet.Click += Pet_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 343);
            Controls.Add(Pet);
            Controls.Add(Consultation);
            Controls.Add(Client);
            Name = "StartForm";
            Text = "Выберите категорию";
            Load += StartForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Client;
        private Button Consultation;
        private Button Pet;
    }
}
