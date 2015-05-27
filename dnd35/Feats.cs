using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace dnd35
{
    class Feat : BaseDBInfo
    {
        private List<FeatType> _types = new List<FeatType>();

        private string table_name = "feat_to_types";
        private string sql_select = "select * from feat_to_types";

        public List<FeatType> Types
        {
            get { return this._types; }
        }

        private void _initalizekeys()
        {
            this._keys.Add("id", "feat_id");
            this._keys.Add("name", "feat_name");
            this._keys.Add("description", "feat_description");
            this._keys.Add("source", "source_id");
        }

        private void _filldata(DataRow dr) 
        {
            this._id = int.Parse(dr[this._keys["id"]].ToString());
            this._name = dr[this._keys["name"]].ToString();
            this._source_id = dr[this._keys["source"]].ToString();
        }

        private void _getfeattypes(SQLiteConnection DB)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(this.sql_select, DB);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet mydataset = new DataSet();
            adapter.Fill(mydataset, this.table_name);

            FeatType type;

            foreach (DataRow myrow in mydataset.Tables[0].Rows)
            {
            }
        }

        public Feat()
        {
            _initalizekeys();
        }
        public Feat(DataRow dr)
        {
            _initalizekeys();
            _filldata(dr);
        }
        public Feat(DataRow dr, SQLiteConnection DB)
        {
            _initalizekeys();
            _filldata(dr);


        }
    }

    class Feats
    {
        private List<Feat> _feats = new List<Feat>();

        private string sql_select = "select * from feats;";
        private string table_name = "feats";

        public List<Feat> feats
        {
            get { return this._feats; }
        }

        public Feats()
        {        }
        
        public void LoadAll(SQLiteConnection DB)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(this.sql_select, DB);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet mydataset = new DataSet();
            adapter.Fill(mydataset, this.table_name);

            Feat feat;

            foreach (DataRow myrow in mydataset.Tables[0].Rows)
            {
                feat = new Feat(myrow);
                this._feats.Add(feat);
                Console.WriteLine(String.Format("ID: {0}\tName: {1}", feat.ID, feat.Name));
            }

            string sql = "select * from feat_to_type ftt left join feat_types ft on ft.feat_type_id = ftt.feat_type_id where ftt.feat_id in (";

            SQLiteCommand myFTTCommand = new SQLiteCommand();
            myFTTCommand.Connection = DB;

            if (this._feats.Count > 1) {
                sql += ":1";
                myFTTCommand.Parameters.AddWithValue("1", this._feats[0].ID);
            }
            for (int i = 2; i < this._feats.Count; i++) {
                sql += ", :" + i;
                myFTTCommand.Parameters.AddWithValue((i - 1).ToString(), this._feats[i - 1].ID);
            }
            sql += ")";

            myFTTCommand.CommandText = sql;

            Console.WriteLine(sql);

            adapter = new SQLiteDataAdapter(myFTTCommand);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(mydataset);

            FeatType feattype;

            foreach (DataRow myrow in mydataset.Tables[0].Rows)
            {
                feattype = new FeatType(myrow);
                var result = this._feats.Where(item => item.ID == (int)myrow["feat_id"]);
                foreach (Feat myfeat in result)
                {
                    myfeat.Types.Add(feattype);
                }
            }

        }

        public void Load(int id)
        { }
    }

    class FeatType : BaseDBInfo
    {

        private void _initalizekeys()
        {
            this._keys.Add("id", "feat_type_id");
            this._keys.Add("name", "feat_type_name");
            //this._keys.Add("description", "feat_description");
            this._keys.Add("source", "source_id");
        }

        private void _filldata(DataRow dr)
        {
            if (dr.Table.Columns.Contains(this._keys["id"]))
            {
                this._id = int.Parse(dr[this._keys["id"]].ToString());
                this._name = dr[this._keys["name"]].ToString();
                this._source_id = dr[this._keys["source"]].ToString();
            }
        }

        public FeatType()
        {
            this._initalizekeys();
        }

        public FeatType(DataRow dr)
        {
            this._initalizekeys();
            this._filldata(dr);
        }
    }

    class FeatTypes : BaseDBCollection
    {
        private List<FeatType> _feattypes = new List<FeatType>();

        public List<FeatType> feattypes
        {
            get { return this._feattypes; }
        }

        public FeatTypes()
        { }
    }
}
