using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace DnD3._5Game
{
    class db
    {
        protected void PopulateGrid()
        {
            try
            {
                String connectionString = "Data Source=" +
                            AppDomain.CurrentDomain.BaseDirectory + (@"data.s3db") +
                            "; Version=3;";
                String getclassesdata = "SELECT * from classes";
                String getfeatsdata = "SELECT * from feats";

                SQLiteDataAdapter dataAdapter =
                            new SQLiteDataAdapter(getclassesdata, connectionString);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                //dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.Columns[0].Visible = false;

                DataSet dsgames = new DataSet();
                dataAdapter = new SQLiteDataAdapter(getfeatsdata, connectionString);
                dataAdapter.Fill(dsgames);
            }
            catch (Exception e)
            {
            }
        }
    }
}