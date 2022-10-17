namespace CodeFirstFinal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarberShopDb = new System.Windows.Forms.TabControl();
            this.BarberPage = new System.Windows.Forms.TabPage();
            this.ClientsPage = new System.Windows.Forms.TabPage();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.ServicesPage = new System.Windows.Forms.TabPage();
            this.SchedulePage = new System.Windows.Forms.TabPage();
            this.ArchivePage = new System.Windows.Forms.TabPage();
            this.FeedbacksPage = new System.Windows.Forms.TabPage();
            this.ServicesGrid = new System.Windows.Forms.DataGridView();
            this.SchedulesGrid = new System.Windows.Forms.DataGridView();
            this.ArchiveGrid = new System.Windows.Forms.DataGridView();
            this.FeedbacksGrid = new System.Windows.Forms.DataGridView();
            this.BarbersGrid = new System.Windows.Forms.DataGridView();
            this.BarberName = new System.Windows.Forms.TextBox();
            this.BarberBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarberGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BarberPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BarberAcceptiondate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BarberPosition = new System.Windows.Forms.TextBox();
            this.BarberEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ClientFullName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ClientEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ClientPhone = new System.Windows.Forms.TextBox();
            this.ServiceName = new System.Windows.Forms.TextBox();
            this.ServiceBarberId = new System.Windows.Forms.NumericUpDown();
            this.ServicePrice = new System.Windows.Forms.NumericUpDown();
            this.ServiceDuration = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ScheduleClientId = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.ScheduleServiceId = new System.Windows.Forms.NumericUpDown();
            this.ScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.ArchiveDate = new System.Windows.Forms.DateTimePicker();
            this.ArchiveScheduleId = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.FeedbackText = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.FeedbackBarberId = new System.Windows.Forms.NumericUpDown();
            this.FeedbackServiceRating = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.FeedbackClientId = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.QueryCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Parameter = new System.Windows.Forms.TextBox();
            this.SeparateGrid = new System.Windows.Forms.DataGridView();
            this.BarberShopDb.SuspendLayout();
            this.BarberPage.SuspendLayout();
            this.ClientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.ServicesPage.SuspendLayout();
            this.SchedulePage.SuspendLayout();
            this.ArchivePage.SuspendLayout();
            this.FeedbacksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbacksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarbersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBarberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleClientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleServiceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveScheduleId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackBarberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackClientId)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BarberShopDb
            // 
            this.BarberShopDb.Controls.Add(this.BarberPage);
            this.BarberShopDb.Controls.Add(this.ClientsPage);
            this.BarberShopDb.Controls.Add(this.ServicesPage);
            this.BarberShopDb.Controls.Add(this.SchedulePage);
            this.BarberShopDb.Controls.Add(this.ArchivePage);
            this.BarberShopDb.Controls.Add(this.FeedbacksPage);
            this.BarberShopDb.Controls.Add(this.tabPage1);
            this.BarberShopDb.Location = new System.Drawing.Point(12, 12);
            this.BarberShopDb.Name = "BarberShopDb";
            this.BarberShopDb.SelectedIndex = 0;
            this.BarberShopDb.Size = new System.Drawing.Size(776, 353);
            this.BarberShopDb.TabIndex = 0;
            // 
            // BarberPage
            // 
            this.BarberPage.Controls.Add(this.label7);
            this.BarberPage.Controls.Add(this.BarberEmail);
            this.BarberPage.Controls.Add(this.label6);
            this.BarberPage.Controls.Add(this.BarberPosition);
            this.BarberPage.Controls.Add(this.label5);
            this.BarberPage.Controls.Add(this.BarberAcceptiondate);
            this.BarberPage.Controls.Add(this.label4);
            this.BarberPage.Controls.Add(this.label3);
            this.BarberPage.Controls.Add(this.BarberPhone);
            this.BarberPage.Controls.Add(this.label2);
            this.BarberPage.Controls.Add(this.BarberGender);
            this.BarberPage.Controls.Add(this.label1);
            this.BarberPage.Controls.Add(this.BarberBirth);
            this.BarberPage.Controls.Add(this.BarberName);
            this.BarberPage.Controls.Add(this.BarbersGrid);
            this.BarberPage.Location = new System.Drawing.Point(4, 22);
            this.BarberPage.Name = "BarberPage";
            this.BarberPage.Padding = new System.Windows.Forms.Padding(3);
            this.BarberPage.Size = new System.Drawing.Size(768, 327);
            this.BarberPage.TabIndex = 0;
            this.BarberPage.Text = "Barbers";
            this.BarberPage.UseVisualStyleBackColor = true;
            // 
            // ClientsPage
            // 
            this.ClientsPage.Controls.Add(this.label10);
            this.ClientsPage.Controls.Add(this.ClientPhone);
            this.ClientsPage.Controls.Add(this.label9);
            this.ClientsPage.Controls.Add(this.ClientEmail);
            this.ClientsPage.Controls.Add(this.label8);
            this.ClientsPage.Controls.Add(this.ClientFullName);
            this.ClientsPage.Controls.Add(this.ClientsGrid);
            this.ClientsPage.Location = new System.Drawing.Point(4, 22);
            this.ClientsPage.Name = "ClientsPage";
            this.ClientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsPage.Size = new System.Drawing.Size(768, 327);
            this.ClientsPage.TabIndex = 1;
            this.ClientsPage.Text = "Clients";
            this.ClientsPage.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(36, 386);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 52);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(135, 386);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 52);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(235, 386);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 52);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Location = new System.Drawing.Point(3, 3);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.Size = new System.Drawing.Size(762, 253);
            this.ClientsGrid.TabIndex = 1;
            // 
            // ServicesPage
            // 
            this.ServicesPage.Controls.Add(this.label14);
            this.ServicesPage.Controls.Add(this.label13);
            this.ServicesPage.Controls.Add(this.label12);
            this.ServicesPage.Controls.Add(this.label11);
            this.ServicesPage.Controls.Add(this.ServiceDuration);
            this.ServicesPage.Controls.Add(this.ServicePrice);
            this.ServicesPage.Controls.Add(this.ServiceBarberId);
            this.ServicesPage.Controls.Add(this.ServiceName);
            this.ServicesPage.Controls.Add(this.ServicesGrid);
            this.ServicesPage.Location = new System.Drawing.Point(4, 22);
            this.ServicesPage.Name = "ServicesPage";
            this.ServicesPage.Size = new System.Drawing.Size(768, 327);
            this.ServicesPage.TabIndex = 2;
            this.ServicesPage.Text = "Services";
            this.ServicesPage.UseVisualStyleBackColor = true;
            // 
            // SchedulePage
            // 
            this.SchedulePage.Controls.Add(this.label17);
            this.SchedulePage.Controls.Add(this.ScheduleDate);
            this.SchedulePage.Controls.Add(this.label16);
            this.SchedulePage.Controls.Add(this.ScheduleServiceId);
            this.SchedulePage.Controls.Add(this.label15);
            this.SchedulePage.Controls.Add(this.ScheduleClientId);
            this.SchedulePage.Controls.Add(this.SchedulesGrid);
            this.SchedulePage.Location = new System.Drawing.Point(4, 22);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Size = new System.Drawing.Size(768, 327);
            this.SchedulePage.TabIndex = 3;
            this.SchedulePage.Text = "Schedule";
            this.SchedulePage.UseVisualStyleBackColor = true;
            // 
            // ArchivePage
            // 
            this.ArchivePage.Controls.Add(this.label19);
            this.ArchivePage.Controls.Add(this.label18);
            this.ArchivePage.Controls.Add(this.ArchiveScheduleId);
            this.ArchivePage.Controls.Add(this.ArchiveDate);
            this.ArchivePage.Controls.Add(this.ArchiveGrid);
            this.ArchivePage.Location = new System.Drawing.Point(4, 22);
            this.ArchivePage.Name = "ArchivePage";
            this.ArchivePage.Size = new System.Drawing.Size(768, 327);
            this.ArchivePage.TabIndex = 4;
            this.ArchivePage.Text = "Archive";
            this.ArchivePage.UseVisualStyleBackColor = true;
            // 
            // FeedbacksPage
            // 
            this.FeedbacksPage.Controls.Add(this.FeedbackClientId);
            this.FeedbacksPage.Controls.Add(this.label23);
            this.FeedbacksPage.Controls.Add(this.label22);
            this.FeedbacksPage.Controls.Add(this.label21);
            this.FeedbacksPage.Controls.Add(this.FeedbackServiceRating);
            this.FeedbacksPage.Controls.Add(this.FeedbackBarberId);
            this.FeedbacksPage.Controls.Add(this.label20);
            this.FeedbacksPage.Controls.Add(this.FeedbackText);
            this.FeedbacksPage.Controls.Add(this.FeedbacksGrid);
            this.FeedbacksPage.Location = new System.Drawing.Point(4, 22);
            this.FeedbacksPage.Name = "FeedbacksPage";
            this.FeedbacksPage.Size = new System.Drawing.Size(768, 327);
            this.FeedbacksPage.TabIndex = 5;
            this.FeedbacksPage.Text = "Feedbacks";
            this.FeedbacksPage.UseVisualStyleBackColor = true;
            // 
            // ServicesGrid
            // 
            this.ServicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesGrid.Location = new System.Drawing.Point(3, 3);
            this.ServicesGrid.Name = "ServicesGrid";
            this.ServicesGrid.Size = new System.Drawing.Size(762, 250);
            this.ServicesGrid.TabIndex = 2;
            // 
            // SchedulesGrid
            // 
            this.SchedulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchedulesGrid.Location = new System.Drawing.Point(3, 3);
            this.SchedulesGrid.Name = "SchedulesGrid";
            this.SchedulesGrid.Size = new System.Drawing.Size(762, 252);
            this.SchedulesGrid.TabIndex = 2;
            // 
            // ArchiveGrid
            // 
            this.ArchiveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchiveGrid.Location = new System.Drawing.Point(3, 3);
            this.ArchiveGrid.Name = "ArchiveGrid";
            this.ArchiveGrid.Size = new System.Drawing.Size(762, 252);
            this.ArchiveGrid.TabIndex = 3;
            // 
            // FeedbacksGrid
            // 
            this.FeedbacksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbacksGrid.Location = new System.Drawing.Point(3, 3);
            this.FeedbacksGrid.Name = "FeedbacksGrid";
            this.FeedbacksGrid.Size = new System.Drawing.Size(762, 223);
            this.FeedbacksGrid.TabIndex = 3;
            // 
            // BarbersGrid
            // 
            this.BarbersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BarbersGrid.Location = new System.Drawing.Point(4, 4);
            this.BarbersGrid.Name = "BarbersGrid";
            this.BarbersGrid.Size = new System.Drawing.Size(762, 252);
            this.BarbersGrid.TabIndex = 3;
            // 
            // BarberName
            // 
            this.BarberName.Location = new System.Drawing.Point(6, 264);
            this.BarberName.Name = "BarberName";
            this.BarberName.Size = new System.Drawing.Size(100, 20);
            this.BarberName.TabIndex = 4;
            // 
            // BarberBirth
            // 
            this.BarberBirth.Location = new System.Drawing.Point(339, 261);
            this.BarberBirth.Name = "BarberBirth";
            this.BarberBirth.Size = new System.Drawing.Size(141, 20);
            this.BarberBirth.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gender";
            // 
            // BarberGender
            // 
            this.BarberGender.Location = new System.Drawing.Point(6, 297);
            this.BarberGender.Name = "BarberGender";
            this.BarberGender.Size = new System.Drawing.Size(100, 20);
            this.BarberGender.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone";
            // 
            // BarberPhone
            // 
            this.BarberPhone.Location = new System.Drawing.Point(174, 264);
            this.BarberPhone.Name = "BarberPhone";
            this.BarberPhone.Size = new System.Drawing.Size(100, 20);
            this.BarberPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date of acception";
            // 
            // BarberAcceptiondate
            // 
            this.BarberAcceptiondate.Location = new System.Drawing.Point(339, 287);
            this.BarberAcceptiondate.Name = "BarberAcceptiondate";
            this.BarberAcceptiondate.Size = new System.Drawing.Size(141, 20);
            this.BarberAcceptiondate.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Position";
            // 
            // BarberPosition
            // 
            this.BarberPosition.Location = new System.Drawing.Point(174, 297);
            this.BarberPosition.Name = "BarberPosition";
            this.BarberPosition.Size = new System.Drawing.Size(100, 20);
            this.BarberPosition.TabIndex = 14;
            // 
            // BarberEmail
            // 
            this.BarberEmail.Location = new System.Drawing.Point(598, 276);
            this.BarberEmail.Name = "BarberEmail";
            this.BarberEmail.Size = new System.Drawing.Size(100, 20);
            this.BarberEmail.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(704, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // ClientFullName
            // 
            this.ClientFullName.Location = new System.Drawing.Point(112, 272);
            this.ClientFullName.Name = "ClientFullName";
            this.ClientFullName.Size = new System.Drawing.Size(100, 20);
            this.ClientFullName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Full name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(597, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Email";
            // 
            // ClientEmail
            // 
            this.ClientEmail.Location = new System.Drawing.Point(478, 272);
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.Size = new System.Drawing.Size(100, 20);
            this.ClientEmail.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Phone";
            // 
            // ClientPhone
            // 
            this.ClientPhone.Location = new System.Drawing.Point(307, 272);
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(100, 20);
            this.ClientPhone.TabIndex = 6;
            // 
            // ServiceName
            // 
            this.ServiceName.Location = new System.Drawing.Point(46, 271);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(135, 20);
            this.ServiceName.TabIndex = 3;
            // 
            // ServiceBarberId
            // 
            this.ServiceBarberId.Location = new System.Drawing.Point(225, 271);
            this.ServiceBarberId.Name = "ServiceBarberId";
            this.ServiceBarberId.Size = new System.Drawing.Size(120, 20);
            this.ServiceBarberId.TabIndex = 4;
            // 
            // ServicePrice
            // 
            this.ServicePrice.DecimalPlaces = 2;
            this.ServicePrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ServicePrice.Location = new System.Drawing.Point(412, 271);
            this.ServicePrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.Size = new System.Drawing.Size(120, 20);
            this.ServicePrice.TabIndex = 5;
            // 
            // ServiceDuration
            // 
            this.ServiceDuration.Location = new System.Drawing.Point(604, 270);
            this.ServiceDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ServiceDuration.Name = "ServiceDuration";
            this.ServiceDuration.Size = new System.Drawing.Size(120, 20);
            this.ServiceDuration.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(621, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Duration (in minutes)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(459, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "BarberId";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Service name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Client id";
            // 
            // ScheduleClientId
            // 
            this.ScheduleClientId.Location = new System.Drawing.Point(135, 271);
            this.ScheduleClientId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ScheduleClientId.Name = "ScheduleClientId";
            this.ScheduleClientId.Size = new System.Drawing.Size(120, 20);
            this.ScheduleClientId.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Service id";
            // 
            // ScheduleServiceId
            // 
            this.ScheduleServiceId.Location = new System.Drawing.Point(285, 271);
            this.ScheduleServiceId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ScheduleServiceId.Name = "ScheduleServiceId";
            this.ScheduleServiceId.Size = new System.Drawing.Size(120, 20);
            this.ScheduleServiceId.TabIndex = 10;
            // 
            // ScheduleDate
            // 
            this.ScheduleDate.Location = new System.Drawing.Point(441, 271);
            this.ScheduleDate.Name = "ScheduleDate";
            this.ScheduleDate.Size = new System.Drawing.Size(200, 20);
            this.ScheduleDate.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(522, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Date";
            // 
            // ArchiveDate
            // 
            this.ArchiveDate.Location = new System.Drawing.Point(199, 272);
            this.ArchiveDate.Name = "ArchiveDate";
            this.ArchiveDate.Size = new System.Drawing.Size(200, 20);
            this.ArchiveDate.TabIndex = 4;
            // 
            // ArchiveScheduleId
            // 
            this.ArchiveScheduleId.Location = new System.Drawing.Point(452, 272);
            this.ArchiveScheduleId.Name = "ArchiveScheduleId";
            this.ArchiveScheduleId.Size = new System.Drawing.Size(120, 20);
            this.ArchiveScheduleId.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(480, 295);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Schedule id";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(282, 295);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Date";
            // 
            // FeedbackText
            // 
            this.FeedbackText.Location = new System.Drawing.Point(20, 241);
            this.FeedbackText.Name = "FeedbackText";
            this.FeedbackText.Size = new System.Drawing.Size(329, 49);
            this.FeedbackText.TabIndex = 4;
            this.FeedbackText.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(159, 304);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Feedback";
            // 
            // FeedbackBarberId
            // 
            this.FeedbackBarberId.Location = new System.Drawing.Point(544, 261);
            this.FeedbackBarberId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FeedbackBarberId.Name = "FeedbackBarberId";
            this.FeedbackBarberId.Size = new System.Drawing.Size(46, 20);
            this.FeedbackBarberId.TabIndex = 6;
            // 
            // FeedbackServiceRating
            // 
            this.FeedbackServiceRating.Location = new System.Drawing.Point(366, 260);
            this.FeedbackServiceRating.Name = "FeedbackServiceRating";
            this.FeedbackServiceRating.Size = new System.Drawing.Size(133, 20);
            this.FeedbackServiceRating.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(378, 304);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "How good was service?";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(541, 304);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Barber id";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(650, 304);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Client id";
            // 
            // FeedbackClientId
            // 
            this.FeedbackClientId.Location = new System.Drawing.Point(653, 260);
            this.FeedbackClientId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FeedbackClientId.Name = "FeedbackClientId";
            this.FeedbackClientId.Size = new System.Drawing.Size(41, 20);
            this.FeedbackClientId.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SeparateGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(768, 327);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Separate Queries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // QueryCombo
            // 
            this.QueryCombo.FormattingEnabled = true;
            this.QueryCombo.Location = new System.Drawing.Point(411, 386);
            this.QueryCombo.Name = "QueryCombo";
            this.QueryCombo.Size = new System.Drawing.Size(355, 21);
            this.QueryCombo.TabIndex = 4;
            this.QueryCombo.SelectedIndexChanged += new System.EventHandler(this.QueryCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Parameter
            // 
            this.Parameter.Location = new System.Drawing.Point(517, 417);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(100, 20);
            this.Parameter.TabIndex = 6;
            // 
            // SeparateGrid
            // 
            this.SeparateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeparateGrid.Location = new System.Drawing.Point(3, 3);
            this.SeparateGrid.Name = "SeparateGrid";
            this.SeparateGrid.Size = new System.Drawing.Size(762, 321);
            this.SeparateGrid.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Parameter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QueryCombo);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.BarberShopDb);
            this.Name = "Form1";
            this.Text = "BarberShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.BarberShopDb.ResumeLayout(false);
            this.BarberPage.ResumeLayout(false);
            this.BarberPage.PerformLayout();
            this.ClientsPage.ResumeLayout(false);
            this.ClientsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.ServicesPage.ResumeLayout(false);
            this.ServicesPage.PerformLayout();
            this.SchedulePage.ResumeLayout(false);
            this.SchedulePage.PerformLayout();
            this.ArchivePage.ResumeLayout(false);
            this.ArchivePage.PerformLayout();
            this.FeedbacksPage.ResumeLayout(false);
            this.FeedbacksPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbacksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarbersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBarberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleClientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleServiceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveScheduleId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackBarberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackClientId)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeparateGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl BarberShopDb;
        private System.Windows.Forms.TabPage BarberPage;
        private System.Windows.Forms.TabPage ClientsPage;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.DataGridView BarbersGrid;
        private System.Windows.Forms.TabPage ServicesPage;
        private System.Windows.Forms.DataGridView ServicesGrid;
        private System.Windows.Forms.TabPage SchedulePage;
        private System.Windows.Forms.DataGridView SchedulesGrid;
        private System.Windows.Forms.TabPage ArchivePage;
        private System.Windows.Forms.DataGridView ArchiveGrid;
        private System.Windows.Forms.TabPage FeedbacksPage;
        private System.Windows.Forms.DataGridView FeedbacksGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BarberPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BarberAcceptiondate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BarberPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BarberGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BarberBirth;
        private System.Windows.Forms.TextBox BarberName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BarberEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ClientFullName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ClientPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ClientEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ServiceDuration;
        private System.Windows.Forms.NumericUpDown ServicePrice;
        private System.Windows.Forms.NumericUpDown ServiceBarberId;
        private System.Windows.Forms.TextBox ServiceName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown ScheduleServiceId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown ScheduleClientId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker ScheduleDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown ArchiveScheduleId;
        private System.Windows.Forms.DateTimePicker ArchiveDate;
        private System.Windows.Forms.NumericUpDown FeedbackClientId;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox FeedbackServiceRating;
        private System.Windows.Forms.NumericUpDown FeedbackBarberId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RichTextBox FeedbackText;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox QueryCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Parameter;
        private System.Windows.Forms.DataGridView SeparateGrid;
    }
}

