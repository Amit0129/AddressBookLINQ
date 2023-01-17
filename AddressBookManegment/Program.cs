namespace AddressBookManegment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Manegment Using LINQ");
            AddressBookManagment addressBookManagment = new AddressBookManagment();
            addressBookManagment.InsertContactToTable();
            addressBookManagment.DisplayContacts();
            addressBookManagment.EditExistingContact("Smruti", "Ranjan", "City", "Dhenkanal");
            addressBookManagment.DeleteContact("Smruti", "Ranjan");
        }
    }
}