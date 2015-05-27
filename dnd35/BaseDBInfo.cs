using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace dnd35
{
    class BaseDBInfo
    {
        protected int _id;
        protected string _name;
        protected string _description;
        protected string _source_id;

        protected Dictionary<string, string> _keys = new Dictionary<string, string>();

        public int ID
        {
            get { return this._id; }
        }
        public string Name
        {
            get { return this._name; }
        }
        public string Description
        {
            get { return this._description; }
        }

        public BaseDBInfo()
        { }

        protected void fromDataRow(DataRow dr, string id, string name, string description)
        {
            this._id = int.Parse(dr[id].ToString());
            this._name = dr[name].ToString();
            this._description = dr[description].ToString();
        }

    }

    class BaseDBCollection
    {
        protected List<BaseDBInfo> _list = new List<BaseDBInfo>();

        public BaseDBCollection()
        {}
    }
}
