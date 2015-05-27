using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace dnd35
{
    class Ability : BaseDBInfo
    {
        public Ability()
        { }
        public Ability(DataRow dr)
        {
            this.fromDataRow(dr, "ability_id", "ability_name", "ability_description");
        }
    }

    class Abilities
    {
        private List<Ability> _list = new List<Ability>();

        private string sql_select = "select * from abilities;";
        private string table_name = "abilities";

        public List<Ability> abilities
        {
            get { return this._list; }
        }

        public Abilities()
        {        }
        
        public void LoadAll(SQLiteConnection DB)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(this.sql_select, DB);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet mydataset = new DataSet();
            adapter.Fill(mydataset, this.table_name);

            Ability item;

            foreach (DataRow myrow in mydataset.Tables[0].Rows)
            {
                item = new Ability(myrow);
                this._list.Add(item);
                Console.WriteLine(String.Format("ID: {0}\tName: {1}", item.ID, item.Name));
            }
        }
    }
}
