using System;

namespace ACM
{
    public class Customer
    {
        private string _lastName;
        public string FirstName { get; set; }

        public Customer()
        {
            var colors = new string[4];
            colors[0] = "Red";
            colors[1] = "Esperesso";
            colors[2] = "White";
            colors[3] = "Navy";
            Console.WriteLine(colors);

            // Collection inititalizers
            var colors2 = new string[4] {"Red", "Esperesso", "White", "Navy"};
            foreach(string item in colors){
                Console.WriteLine(item);
            }

            // Array methods
            Array.Sort(colors2);
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}
