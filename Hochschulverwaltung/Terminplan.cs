using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hochschulverwaltung
{
    public partial class Terminplan : UserControl
    {
        DateTime dateNow = DateTime.Now;
        public Terminplan()
        {
            


            InitializeComponent();
            FillInputDozentSelection();

            ChangeWeek(dateNow);

            // Wochenstart ermitteln, Label erstellen ab Monatag bis Samstag, Liste mit Terminen laden, Termine nach Dataum Filter, dabei jeden Termin, der in dieser Woche stattdfindet grafisch in den jeweiligen slot schieben. Row Span nach Termindauer variieren. Im Termin den Namen des Kureses als Text des Labels nehmen.
        }



        private void ChangeWeek(DateTime currentDate)
        {
            // Calculate the start of the week (Monday)
            DateTime startOfWeek = currentDate.AddDays(DayOfWeek.Monday - currentDate.DayOfWeek - 1);
            DateTime endOfWeek = startOfWeek.AddDays(6);


            tlp_Studenplan.Controls.Clear();
            InitializeTimeSlots();
            // Populate labels with day names and dates
            for (int col = 1; col <= 6; col++)
            {
                Label dateLabel = new Label();
                DateTime currentDay = startOfWeek.AddDays(col);

                dateLabel.Text = $"{currentDay.ToString("ddd dd.MM.yyyy")}";
                dateLabel.TextAlign = ContentAlignment.TopCenter;
                tlp_Studenplan.Controls.Add(dateLabel, col, 0);
            }

            foreach (var termin in Termin.Termine.Values)
            {
                if (termin.DateTime >= startOfWeek && termin.DateTime <= endOfWeek)
                {
                    int column = (int)termin.DateTime.DayOfWeek;
                    int index = -1;

                    switch (termin.DateTime.Hour)
                    {
                        case 8:
                            index = 1;
                            break;
                        case 9:
                            index = 2;
                            break;
                        case 10:
                            index = 3;
                            break;
                        case 12:
                            index = 4;
                            break;
                        case 13:
                            index = 5;
                            break;
                        case 14:
                            index = 6;
                            break;
                        case 16:
                            index = 7;
                            break;
                        case 18:
                            index = 8;
                            break;
                        default:
                            break;
                    }

                    Button termButton = new Button();
                    termButton.Text = termin.Kurs.Name;
                    termButton.TextAlign = ContentAlignment.TopCenter;
                    termButton.Dock = DockStyle.Fill;
                    termButton.Margin = new Padding(0);
                    termButton.Padding = new Padding(0);
                    termButton.BackColor = Color.Beige;

                    tlp_Studenplan.Controls.Add(termButton, column, index);
                    tlp_Studenplan.SetRowSpan(termButton, termin.Dauer);
                }
            }
        }
        private void InitializeTimeSlots()
        {
            string[] timeSlots = { "8:00 - 9:00", "9:00 - 10:30", "10:45 - 12:15", "12:15 - 13:00", "13:00 - 14:30", "14:45 - 16:15", "16:30 - 18:00", "18:15 - 19:45" };

            for (int row = 1; row <= timeSlots.Length; row++)
            {
                Label timeSlotLabel = new Label();
                timeSlotLabel.Text = timeSlots[row - 1];
                timeSlotLabel.TextAlign = ContentAlignment.MiddleRight;
                tlp_Studenplan.Controls.Add(timeSlotLabel, 0, row);
            }
        }

        private void Bttn_WochVor_Click(object sender, EventArgs e)
        {
            dateNow = dateNow.AddDays(7);
            ChangeWeek(dateNow);
        }
        private void FillInputDozentSelection()
        {
            foreach (var Kurs in Kurs.Kurse.Values)
            {
                comboBox2.Items.Add(Kurs.KursID);
            }
        }
        private void Bttn_WocheZurueck_Click(object sender, EventArgs e)
        {
            dateNow = dateNow.AddDays(-7);
            ChangeWeek(dateNow);
        }

        private void bttn_addLesson_Click(object sender, EventArgs e)
        {

            new Termin(dtp_beginLesson.Value,Kurs.Kurse[comboBox2.Text], Convert.ToInt32( tbx_durationLesson.Text));
            ChangeWeek(dateNow);
        }
    }
}

