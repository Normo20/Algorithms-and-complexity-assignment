using System;
using System.Collections.Generic;
using System.Text;

namespace Cab301_assignment
{
    public class Tool : iTool
    {
        public string name;
        public int quantity;
        public int avaliableQuantity = 0;
        public int noBorrowings;


        
        //getters and setters
        public string Name {
            get { return name; }
            set { name = Name; }
        }
        public int Quantity {
            get { return quantity; }
            set { quantity = Quantity; }
        }
        public int AvailableQuantity {
            get { return avaliableQuantity; }
            set { avaliableQuantity = AvailableQuantity; }
        }
        public int NoBorrowings {
            get { return noBorrowings; }
            set { noBorrowings = NoBorrowings; }
        }
        //object constructor 
        public Tool(string name, int quantity, int avaliablequantity, int noborrowings)
        {
            this.name = name;
            this.quantity = quantity;
            this.avaliableQuantity = avaliablequantity;
            this.noBorrowings = noborrowings;
        }
        //this was giving me an erorr so its commented out in both here and the interface
       // public MemberCollection GetBorrowers => throw new NotImplementedException();

        public void addBorrower(Member aMember)
        {
            //not properly implemented
            noBorrowings++;
            

        }

        public void deleteBorrower(Member aMember)
        {
            //not properly implemented
            noBorrowings--;
            
        }
        public override string ToString()
        {
            return (name + " " + Quantity + " " + avaliableQuantity.ToString() + "\n");
        }

    }
}
