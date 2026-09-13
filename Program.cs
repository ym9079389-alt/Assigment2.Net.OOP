namespace Assigment2.Net.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1
            #region a
            //a) What is the difference between a class and a struct?

            //Class is reference type and Support OOP features,
            //Struct is value type and does not support OOP features.
            #endregion

            #region b
            //b) Why are classes more suitable than structs for large applications?

            //Because classes are reference types, they are more suitable for large applications as they can be easily managed in memory and support features like inheritance.
            #endregion

            #endregion


            #region Q 2

            #region a
            //a) Which class is the parent class?
            // shipment
            #endregion

            #region b  
            // b) Which class is the child class?
            // expressshipment
            #endregion

            #region C
            //c) What members are inherited by ExpressShipment?
            // Trakingcode
            #endregion

            #region d
            //d) Why is inheritance better than duplicating the same code in multiple classes?
            // Inheritance allows for code reuseability and maintenance.
            #endregion
            #endregion

            #region Q 3

            DeliveryCenter center = new DeliveryCenter("Cairo Center");

            Console.WriteLine("--- Enter Details for Standard Shipment ---");
            Console.Write("Tracking Code: "); string code1 = Console.ReadLine();
            Console.Write("Description: "); string desc1 = Console.ReadLine();
            Console.Write("Weight: "); decimal.TryParse(Console.ReadLine(), out decimal w1);
            Console.Write("Delivery Fee: "); decimal.TryParse(Console.ReadLine(), out decimal f1);
            Console.Write("City: "); string city1 = Console.ReadLine();
            Console.Write("Street: "); string street1 = Console.ReadLine();
            Console.Write("Building Number: "); int.TryParse(Console.ReadLine(), out int b1);

            DeliveryAddress addr1 = new DeliveryAddress(city1, street1, b1);
            StandardShipment standard = new StandardShipment(code1, desc1, w1, f1, addr1);
            center.AddShipment(standard);

            Console.WriteLine("\n--- Enter Details for Express Shipment ---");
            Console.Write("Tracking Code: "); string code2 = Console.ReadLine();
            Console.Write("Description: "); string desc2 = Console.ReadLine();
            Console.Write("Weight: "); decimal.TryParse(Console.ReadLine(), out decimal w2);
            Console.Write("Delivery Fee: "); decimal.TryParse(Console.ReadLine(), out decimal f2);
            Console.Write("Extra Fee: "); decimal.TryParse(Console.ReadLine(), out decimal extraFee);
            Console.Write("City: "); string city2 = Console.ReadLine();
            Console.Write("Street: "); string street2 = Console.ReadLine();
            Console.Write("Building Number: "); int.TryParse(Console.ReadLine(), out int b2);

            DeliveryAddress addr2 = new DeliveryAddress(city2, street2, b2);
            ExpressShipment express = new ExpressShipment(code2, desc2, w2, f2, addr2, extraFee);
            center.AddShipment(express);

            Console.WriteLine("\n--- Enter Details for International Shipment ---");
            Console.Write("Tracking Code: "); string code3 = Console.ReadLine();
            Console.Write("Description: "); string desc3 = Console.ReadLine();
            Console.Write("Weight: "); decimal.TryParse(Console.ReadLine(), out decimal w3);
            Console.Write("Delivery Fee: "); decimal.TryParse(Console.ReadLine(), out decimal f3);
            Console.Write("Destination Country: "); string country = Console.ReadLine();
            Console.Write("Customs Fee: "); decimal.TryParse(Console.ReadLine(), out decimal customsFee);
            Console.Write("City: "); string city3 = Console.ReadLine();
            Console.Write("Street: "); string street3 = Console.ReadLine();
            Console.Write("Building Number: "); int.TryParse(Console.ReadLine(), out int b3);

            DeliveryAddress addr3 = new DeliveryAddress(city3, street3, b3);
            InternationalShipment intern = new InternationalShipment(code3, desc3, w3, f3, addr3, country, customsFee);
            center.AddShipment(intern);

            Console.Write("Enter a Tracking Code to search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine("Shipment Found");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("\nShipment not found.");
            }


            Console.WriteLine("Enter a Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();
            center.RemoveShipment(removeCode);

            center.PrintAllShipments();
            #endregion
        }
    }
}
