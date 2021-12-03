using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Cab301_assignment
{
    public class Member : iMember, IComparable<Member>
    {
        private string lastname;
        private string firstname;
        private string contactNumber;
        private string pin;
        private Tool[] toolsBorrowed;
        private int numTools;
        string[] po;

        //various getters and setters
        public string Lastname {
            get { return lastname; }
            set { lastname = Lastname; }
        }
        public string Firstname {
            get { return firstname; }
            set { firstname = Firstname; }
        }
        public string ContactNumber {
            get { return contactNumber; }
            set { contactNumber = ContactNumber; }
        }
        public string PIN {
            get { return pin; }
            set { pin = PIN; }
        }

        
        
        //initializes the member object
        public Member(string lastName, string firstName, string ContactNumber, string PIN)
        {
            this.lastname = lastName;
            this.firstname = firstName;
            this.contactNumber = ContactNumber;
            this.pin = PIN;
            this.toolsBorrowed = new Tool[2];
            this.numTools = 0;
        }

        //tools borrowed to array 
       public void toarray()
        {
            //loops through the tools borrowed by index upto 3 and puts them into an array using toString()
            for (int i = 0; i < 3; i++)
            {
                
                po[i]= toolsBorrowed[i].ToString();
            }

        }

        string[] iMember.Tools
        {



            //gets toolsBorrowed in an array
            get { return po; }

        }
        //ask about
        public void addTool(Tool aTool)
        {
            //adds tool to a users tools borrowed in the array index 
            this.toolsBorrowed[numTools] = (Tool)aTool;
            Array.Resize<Tool>(ref toolsBorrowed, toolsBorrowed.Length + 1);
            numTools = +1;
        }

        public void deleteTool(Tool aTool) //currently just deletes all tools a member owns
        {
            
            int i = 0;
            //iterates through all the tools a member owns and sets it to null
            for (i = 0; i < toolsBorrowed.Length; i++)
            {
                        toolsBorrowed[i] = null;
            
            }
            i++;
        }
        public override string ToString()
        {
            return (firstname + " " + lastname + " " + contactNumber.ToString() + "\n");
        }
        //compare to method
        public int CompareTo(Member another)
        {
            if (this.lastname.CompareTo(another.Lastname) < 0)
                return -1;
            else
                    if (this.lastname.CompareTo(another.Lastname) == 0)
                return this.firstname.CompareTo(another.Firstname);
            else
                return 1;
        }
    }
}
