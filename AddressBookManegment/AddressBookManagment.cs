using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManegment
{
    internal class AddressBookManagment
    {
        DataTable table = new DataTable();
        public void InsertContactToTable()
        {
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(int));
            table.Columns.Add("PhoneNumber", typeof(long));
            table.Columns.Add("Email", typeof(string));
            table.Rows.Add("Amit", "Nayak", "Jiral", "Dhenkanal", "Odisha", 890890, 8908908908, "amit@gmail.com");
            table.Rows.Add("Manit", "Nayak", "Vatika", "IMT", "Hariyana", 900908, 9090909090, "manit@gmail.com");
            table.Rows.Add("Smruti", "Ranjan", "Knowhere", "Cool", "Marse", 098098, 9438943894, "bana@gmail.com.");
        }
    }
}
