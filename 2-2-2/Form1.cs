using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _2_2_2
{
    public partial class Form1 : Form
    {

        List<Flight> flights = new List<Flight>();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;
            try
            {
                //Создание нового или открытие существующего файла
                fs = new FileStream("C:\\Users\\fokin\\source\\repos\\2-2-2\\2-2-2\\" + fileName.Text, FileMode.OpenOrCreate);
            }
            catch
            {
                MessageBox.Show("Ошибка открытия файла");
                return;
            }
                for (int i = 1; i <= 10; i++)
                {
                Flight flight;
                    //Заполнение разными значениями
                     if (i % 2 == 0)
                {
                    flight = new Flight("UK" + Convert.ToString(231 + i * i + i), "Страна " + i, new DateTime(2020, (9 * i) % 11 + 1, (7 * i) % 27 + 1, (8 * i) % 24, (15 * i) % 60, 0), i, (15*i)%60, 30-i);
                }
                     else
                {
                    flight = new Flight("RB" + Convert.ToString(127 + i * i + i), "Страна " + i * i, new DateTime(2020, (9 * i) % 11 + 1, (7 * i) % 27 + 1, (8 * i) % 24, (15 * i) % 60, 0), i+2, (20*i)%60, 20-i);
                }
                     //Сериализация данных в файл
                    bf.Serialize(fs, flight);
                }

                fs.Position = 0;

                for (int i = 0; i < 10; i++)
                {
                    Flight flight = (Flight)bf.Deserialize(fs);
                    flights.Add(flight);
                    listBox.Items.Add(flight.name);
                }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox.SelectedIndex;

            name.Text = "Рейс: " + flights[i].name;
            destination.Text = "Направление: " + flights[i].destination;
            dateFly.Text = "Время вылета: " + flights[i].flying;
            durationFly.Text = "Длительность полета составит: " + flights[i].hrs + " часов " + flights[i].min + " минут";
            freePlaces.Text = "Свободных мест осталось: " + flights[i].freePlace;
        } 
    }
}
