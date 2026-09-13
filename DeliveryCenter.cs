using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment2.Net.OOP
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }
        private Shipment[] shipments;
        private int count;

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
            count = 0;
        }

        public Shipment this[int index]
        {
            get
            {
                if (shipments != null && index >= 0 && index < count)
                {
                    return shipments[index];
                }
                return default;
            }
            set
            {
                if (shipments != null && index >= 0 && index < count)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                    {
                        return shipments[i];
                    }
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (count < 20)
            {
                shipments[count] = shipment;
                count++;
                Console.WriteLine("Shipment Added Successfully");
                return true;
            }
            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            Shipment[] tempArray = new Shipment[20];
            int newCount = 0;
            bool isFound = false;

            for (int i = 0; i < count; i++)
            {
                if (shipments[i] != null && !shipments[i].TrackingCode.Equals(trackingCode))
                {
                    tempArray[newCount] = shipments[i];
                    newCount++;
                }
                else
                {
                    isFound = true;
                }
            }

            if (isFound)
            {
                shipments = tempArray;
                count = newCount;
            }

            return isFound;
        }
        public void PrintAllShipments()
        {
            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipment();
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }

}