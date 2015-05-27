using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SQLite;

namespace dnd35
{
    public partial class Form1 : Form
    {
        Feats feats;
        Abilities abilities;
        SQLiteConnection threefivedb;

        public Form1()
        {
            InitializeComponent();

            threefivedb = new SQLiteConnection("Data Source=data.s3db");
            threefivedb.Open();

            feats = new Feats();
            abilities = new Abilities();

            feats.LoadAll(threefivedb);
            abilities.LoadAll(threefivedb);
        }

        private void buttonGetAbilities(object sender, EventArgs e)
        {

            string sql = "select * from abilities;";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, threefivedb);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet mydataset = new DataSet();
            adapter.Fill(mydataset, "abilities");

            foreach (Ability ability in abilities.abilities)
            {
                Console.WriteLine(String.Format("ID: {0}\tName: {1}", ability.ID, ability.Name));
            }
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            Dice TwoDSix = new Dice();
            int[] numbers;

            int cycles = 10000;

            TwoDSix.Number = 3;
            TwoDSix.Sides = 6;

            numbers = new int[cycles];

            chart1.Series.Clear();

            Series series = chart1.Series.Add("2D6");

            for (int i = 0; i < cycles; i++)
            {
                numbers[i] = TwoDSix.RollNormal();
            }

            //numbers.Sort();

            var someCount = 0;

            for (int i = TwoDSix.Number; i <= (TwoDSix.Sides * TwoDSix.Number); i++)
            {
                someCount = numbers.Count(y => y == i);
                series.Points.AddXY(i, someCount);
            }
            
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            buttonGetAbilities(sender, e);
        }

        
    }
}
