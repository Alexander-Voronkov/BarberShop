using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Configuration;
namespace CodeFirstFinal
{
    public partial class Form1 : Form
    {
        BarberShopContext data;
        Action[] actions;
        public Form1()
        {
            data = new BarberShopContext();
            Task q = Task.Run(CreateBarberTrigger);
            InitializeComponent();
            actions = new Action[7] { First, Second, Third, Fourth, Fifth, Sixth, Seventh };
            ArchiveGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FeedbacksGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchedulesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ServicesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BarbersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ArchiveGrid.DataSource = data.Archives.ToList();
            ServicesGrid.DataSource = data.Services.ToList();
            BarbersGrid.DataSource = data.Barbers.ToList();
            ClientsGrid.DataSource = data.Clients.ToList();
            FeedbacksGrid.DataSource = data.Feedbacks.ToList();
            SchedulesGrid.DataSource = data.Schedules.ToList();
            Parameter.Visible = false;
            QueryCombo.Items.AddRange(new[] { "Show all barbers' names", "Show all senior barbers", "Show all barbers that can do traditional beard cut", "Show all barbers that can do this service", "Show all barbers that work more than this count of years", "Show count of senior barbers and count of junior barbers", "Show info about clients that were in barbershop more than this count of times" });
            QueryCombo.SelectedIndex = 0;
            QueryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        

        private void CreateBarberTrigger()
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["DbContext"].ConnectionString);
            sql.Open();
            if (new SqlCommand("select * from sys.triggers where name='BarberInsert'", sql).ExecuteReader().HasRows)
                new SqlCommand("create trigger BarberInsert" +
                    " on Barbers instead of insert" +
                    " as" +
                    " if(DATEDIFF(YEAR,(select BirthDate from inserted),(select DateOfAcception from inserted))>20) " +
                    "insert into Barbers" +
                    " select FullName,Gender,Phone,Email,BirthDate,DateOfAcception,Position from inserted", sql)
                .ExecuteNonQuery(); sql.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            switch (BarberShopDb.SelectedTab.Text)
            {
                case "Barbers":
                    if (CheckBarbersAdd())
                    {
                        Barbers c = new Barbers()
                        {
                            FullName = BarberName.Text,
                            BirthDate = BarberBirth.Value,
                            DateOfAcception = BarberAcceptiondate.Value,
                            Email = BarberEmail.Text,
                            Phone = BarberPhone.Text,
                            Gender = BarberGender.Text,
                            Position = BarberPosition.Text,
                        };
                        data.Barbers.Add(c);
                        try
                        {
                            data.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Wrong parameter!");
                        }
                        BarbersGrid.DataSource = null;
                        BarbersGrid.DataSource = data.Barbers.ToList();
                    }
                    break;
                case "Clients":
                    if (CheckClientsAdd())
                    {
                        Clients c = new Clients()
                        {
                            FullName = ClientFullName.Text,
                            Email = ClientEmail.Text,
                            Phone = ClientPhone.Text,
                        };
                        data.Clients.Add(c);
                        try
                        {
                            data.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Wrong parameter!");
                        }
                        ClientsGrid.DataSource = null;
                        ClientsGrid.DataSource = data.Clients.ToList();
                    }
                    break;
                case "Services":
                    if (CheckServicesAdd())
                    {
                        Services c = new Services()
                        {
                            Barber = data.Barbers.Find(ServiceBarberId.Value),
                            Duration = TimeSpan.FromMinutes((double)ServiceDuration.Value),
                            Price = ServicePrice.Value,
                            ServiceName = ServiceName.Text,
                        };
                        data.Services.Add(c);
                        try
                        {
                            data.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Wrong parameter!");
                        }
                        ServicesGrid.DataSource = null;
                        ServicesGrid.DataSource = data.Services.ToList();
                    }
                    break;
                case "Schedule":
                    if (CheckScheduleAdd())
                    {
                        Schedule c = new Schedule()
                        {
                            Client = data.Clients.Find(ScheduleClientId.Value),
                            Date = ScheduleDate.Value,
                            Service = data.Services.Find(ScheduleServiceId.Value),
                        };
                        data.Schedules.Add(c);
                        try
                        {
                            data.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Wrong parameter!");
                        }
                        SchedulesGrid.DataSource = null;
                        SchedulesGrid.DataSource = data.Schedules.ToList();
                    }
                    break;
                case "Archive":
                    if (CheckArchiveAdd())
                    {
                        Archives c = new Archives()
                        {
                            Date = ArchiveDate.Value,
                            Record = data.Schedules.Find(ArchiveScheduleId.Value)
                        };
                        data.Archives.Add(c);
                        try
                        {
                            data.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Wrong parameter!");
                        }
                        ArchiveGrid.DataSource = null;
                        ArchiveGrid.DataSource = data.Archives.ToList();
                    }
                    break;
                case "Feedbacks":
                    if (CheckFeedbackAdd())
                    {
                        Feedbacks c = new Feedbacks()
                        {
                            Barber = data.Barbers.Find(FeedbackBarberId.Value),
                            Client = data.Clients.Find(FeedbackClientId.Value),
                            Feedback = FeedbackText.Text,
                            HowGood = FeedbackServiceRating.Text,
                        };
                        data.Feedbacks.Add(c);
                        try
                        {
                            data.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Wrong parameter!");
                        }
                        FeedbacksGrid.DataSource = null;
                        FeedbacksGrid.DataSource = data.Feedbacks.ToList();
                    }
                    break;
            }
        }

        private bool CheckBarbersAdd()
        {
            return BarberEmail.TextLength>8&&BarberPhone.TextLength>=10&&BarberEmail.Text.Contains("@") && BarberName.TextLength != 0 && BarberPosition.TextLength != 0 && BarberGender.TextLength != 0 && BarberPhone.Text.Where(x=>char.IsLetter(x)).Count()==0 && (BarberAcceptiondate.Value.Year - BarberBirth.Value.Year) > 20;
        }

        private bool CheckClientsAdd()
        {
            return ClientEmail.Text.Contains("@") && ClientFullName.TextLength != 0 && ClientPhone.Text.Where(x=>char.IsLetter(x)).Count()==0&&ClientPhone.TextLength>=10&&ClientEmail.TextLength>8;
        }

        private bool CheckServicesAdd()
        {
            return ServiceName.TextLength != 0 && ServiceDuration.Value != 0 && ServiceBarberId.Value != 0;
        }

        private bool CheckScheduleAdd()
        {
            return ScheduleClientId.Value != 0 && ScheduleServiceId.Value != 0;
        }

        private bool CheckArchiveAdd()
        {
            return ArchiveScheduleId.Value != 0;
        }

        private bool CheckFeedbackAdd()
        {
            return FeedbackText.TextLength != 0 && FeedbackClientId.Value != 0 && FeedbackBarberId.Value != 0;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            switch (BarberShopDb.SelectedTab.Text)
            {
                case "Barbers": if (data.Barbers.Count() == 1) return; if (BarbersGrid.SelectedRows.Count > 0) { BarbersGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Barbers.Remove(x.DataBoundItem as Barbers)); data.SaveChanges(); BarbersGrid.DataSource = null; BarbersGrid.DataSource = data.Barbers.ToList(); BarbersGrid.ClearSelection(); } break;
                case "Clients": if (ClientsGrid.SelectedRows.Count > 0) { ClientsGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Clients.Remove(x.DataBoundItem as Clients)); data.SaveChanges(); ClientsGrid.DataSource = null; ClientsGrid.DataSource = data.Clients.ToList(); ClientsGrid.ClearSelection(); } break;
                case "Feedbacks": if (FeedbacksGrid.SelectedRows.Count > 0) { FeedbacksGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Feedbacks.Remove(x.DataBoundItem as Feedbacks)); data.SaveChanges(); FeedbacksGrid.DataSource = null; FeedbacksGrid.DataSource = data.Feedbacks.ToList(); FeedbacksGrid.ClearSelection(); } break;
                case "Archive": if (ArchiveGrid.SelectedRows.Count > 0) { ArchiveGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Archives.Remove(x.DataBoundItem as Archives)); data.SaveChanges(); ArchiveGrid.DataSource = null; ArchiveGrid.DataSource = data.Archives.ToList(); ArchiveGrid.ClearSelection(); } break;
                case "Services": if (ServicesGrid.SelectedRows.Count > 0) { ServicesGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Services.Remove(x.DataBoundItem as Services)); data.SaveChanges(); ServicesGrid.DataSource = null; ServicesGrid.DataSource = data.Services.ToList(); ServicesGrid.ClearSelection(); } break;
                case "Schedule": if (SchedulesGrid.SelectedRows.Count > 0) { SchedulesGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Schedules.Remove(x.DataBoundItem as Schedule)); data.SaveChanges(); SchedulesGrid.DataSource = null; SchedulesGrid.DataSource = data.Schedules.ToList(); SchedulesGrid.ClearSelection(); } break;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            switch (BarberShopDb.SelectedTab.Text)
            {
                case "Barbers": BarbersGrid.SelectAll(); BarbersGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Barbers.AddOrUpdate(x.DataBoundItem as Barbers)); data.SaveChanges(); BarbersGrid.DataSource = null; BarbersGrid.DataSource = data.Barbers.ToList(); BarbersGrid.ClearSelection(); break;
                case "Clients": ClientsGrid.SelectAll(); ClientsGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Clients.AddOrUpdate(x.DataBoundItem as Clients)); data.SaveChanges(); ClientsGrid.DataSource = null; ClientsGrid.DataSource = data.Clients.ToList(); ClientsGrid.ClearSelection(); break;
                case "Feedbacks": FeedbacksGrid.SelectAll(); FeedbacksGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Feedbacks.AddOrUpdate(x.DataBoundItem as Feedbacks)); data.SaveChanges(); FeedbacksGrid.DataSource = null; FeedbacksGrid.DataSource = data.Feedbacks.ToList(); FeedbacksGrid.ClearSelection(); break;
                case "Archive": ArchiveGrid.SelectAll(); ArchiveGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Archives.AddOrUpdate(x.DataBoundItem as Archives)); data.SaveChanges(); ArchiveGrid.DataSource = null; ArchiveGrid.DataSource = data.Archives.ToList(); ArchiveGrid.ClearSelection(); break;
                case "Services": ServicesGrid.SelectAll(); ServicesGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Services.AddOrUpdate(x.DataBoundItem as Services)); data.SaveChanges(); ServicesGrid.DataSource = null; ServicesGrid.DataSource = data.Services.ToList(); ServicesGrid.ClearSelection(); break;
                case "Schedule": SchedulesGrid.SelectAll(); SchedulesGrid.SelectedRows.Cast<DataGridViewRow>().ToList().ForEach(x => data.Schedules.AddOrUpdate(x.DataBoundItem as Schedule)); data.SaveChanges(); SchedulesGrid.DataSource = null; SchedulesGrid.DataSource = data.Schedules.ToList(); SchedulesGrid.ClearSelection(); break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.Dispose();
        }

        private void QueryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QueryCombo.SelectedIndex == 3 || QueryCombo.SelectedIndex == 4 || QueryCombo.SelectedIndex == 6)
                Parameter.Visible = true;
            else
                Parameter.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Parameter.TextLength == 0 && (QueryCombo.SelectedIndex == 3 || QueryCombo.SelectedIndex == 4 || QueryCombo.SelectedIndex == 6))
            {
                return;
            }
            if (QueryCombo.SelectedIndex == 4 || QueryCombo.SelectedIndex == 6)
            {
                try
                {
                    int.Parse(Parameter.Text);
                }
                catch { return; }
            }
            actions[QueryCombo.SelectedIndex]();
            BarberShopDb.SelectedIndex = 6;
        }


        private void First()
        {
            SeparateGrid.DataSource = null;
            SeparateGrid.DataSource = data.Barbers.ToList();
        }

        private void Second()
        {
            SeparateGrid.DataSource = null;
            SeparateGrid.DataSource = (from c in data.Barbers where c.Position == "Senior" select c).ToList();
        }

        private void Third()
        {
            SeparateGrid.DataSource = null;
            SeparateGrid.DataSource = (from c in data.Barbers where (c.Services.Where(x => x.ServiceName == "Traditional beard cut")).Count() > 0 select c).ToList();
        }

        private void Fourth()
        {
            SeparateGrid.DataSource = null;
            SeparateGrid.DataSource = (from c in data.Barbers where (c.Services.Where(x => x.ServiceName == Parameter.Text)).Count() > 0 select c).ToList();
        }

        private void Fifth()
        {
            SeparateGrid.DataSource = null;
            int i = int.Parse(Parameter.Text);
            SeparateGrid.DataSource = (from c in data.Barbers where (DateTime.Now.Year - c.DateOfAcception.Year) > i select c).ToList();
        }

        private void Sixth()
        {
            SeparateGrid.DataSource = null;
            var dt = new DataTable();
            dt.Columns.Add("Senior count");
            dt.Columns.Add("Junior count");
            dt.Rows.Add((from c in data.Barbers where c.Position == "Senior" select c).Count(), (from c in data.Barbers where c.Position == "Junior" select c).Count());
            SeparateGrid.DataSource = dt;
        }

        private void Seventh()
        {
            SeparateGrid.DataSource = null;
            int i = int.Parse(Parameter.Text);
            SeparateGrid.DataSource = (from c in data.Clients where (from c1 in data.Schedules where data.Clients.Find(c1.Id)==c select c1).Count() > i select c).ToList();
        }
    }
    internal class BarberShopContext : DbContext
    {
        public BarberShopContext() : base("DbContext") { }
        public virtual DbSet<Barbers> Barbers { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Archives> Archives { get; set; }
    }

    internal class Barbers
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public DateTime DateOfAcception { get; set; }
        [Required]
        [MaxLength(50)]
        public string Position { get; set; }
        public virtual ICollection<Services> Services { get; set; }
        public virtual ICollection<Feedbacks> Feedbacks { get; set; }
    }

    internal class Services
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string ServiceName { get; set; }
        [Required]
        [Column(TypeName = "time")]
        public TimeSpan Duration { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Required]
        public virtual Barbers Barber { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }

    internal class Feedbacks
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Feedback { get; set; }
        [Required]
        [MaxLength(20)]
        public string HowGood { get; set; }
        [Required]
        public virtual Clients Client { get; set; }
        [Required]
        public virtual Barbers Barber { get; set; }
    }

    internal class Schedule
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public virtual Clients Client { get; set; }
        [Required]
        public virtual Services Service { get; set; }
        public virtual ICollection<Archives> Archives { get; set; }
    }

    internal class Clients
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public virtual ICollection<Feedbacks> Feedbacks { get; set; }
    }

    internal class Archives
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public virtual Schedule Record { get; set; }
    }
}
