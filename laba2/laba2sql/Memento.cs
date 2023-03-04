using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace laba2sql
{
    // Originator
    public class Orginator
    {   
        private DB dbase = new DB();
        public DataTable dt = new DataTable();

        // сохранение состояния 
        public Memento SaveState()
        {
            dt.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `products`", dbase.GetConnection());
            adapter.Fill(dt);
            return new Memento(dt);
        }

        // восстановление состояния
        public void RestoreState(Memento memento)
        {
            dt = memento.Dt;
        }
    }
    // Memento
    public class Memento
    {
        public DataTable Dt { get; private set; }
        public Memento(DataTable dt)
        {
            Dt = dt;
        }
    }

    // Caretaker
    public class Caretaker
    {
        public Stack<Memento> History { get; private set; }
        public Caretaker()
        {
            History = new Stack<Memento>();
        }
    }
}
