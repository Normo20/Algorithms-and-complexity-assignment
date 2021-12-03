using System;
using System.Collections.Generic;
using System.Text;

namespace Cab301_assignment
{
    public class Menu
    {
       
        //handles all of the main menu stuff
        #region MainMenu Logic
        public static void MainMenu()
        {
            MainMenuText();
            bool CorrectInput = false;
            string Input = "";

            
            while (!CorrectInput)
            {
                Input = Console.ReadLine();
                CorrectInput = HandleIntInput(Input, MainMenuText, 2);
            }
            //switch statements to save code
            switch (int.Parse(Input))
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Menu.StaffLogin();
                    break;
                case 2:
                    Menu.MemberLogin();
                    break;
            }
        }

        private static void MainMenuText() 
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("============Main Menu==========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("================================");
            Console.WriteLine("Please make a selection (1-2, or 0 to exit):");
        }
        #endregion

        #region Staff Logic
        
        //handles all staff menu 
        private static void StaffLogin()
        {
            Console.WriteLine("============Staff Login============");
            Console.WriteLine("Enter 0 in any of the fields to return to main menu.");
            Console.WriteLine("Please enter username");

            string UserName = Console.ReadLine();
            if (UserName == "0") { MainMenu(); } //returns user if they hit 0 in username

            Console.WriteLine("Please enter Password");
            string Password = Console.ReadLine();

            if (Password == "0") { MainMenu(); }//returns user if they hit 0 in password

            if (UserName == "staff" && Password == "today123")
            {
                StaffMenu(); //checks user and password are correct and the launches staff menu 
            }
            else
            {
                Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Authentication Failed.");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!\n");
                StaffLogin(); //if incorrect takes them back to login
            }
        }

        //staff menu input handler
        public static void StaffMenu()
        {
            //initializing some class methods
            ToolLibrarySystem Toolz = new ToolLibrarySystem();
            MemberCollection Memcol = new MemberCollection();

            StaffMenuText();
            bool CorrectInput = false;
            string Input = "";

            //Validate input
            while (!CorrectInput)
            {
                Input = Console.ReadLine();
                CorrectInput = HandleIntInput(Input, MainMenuText, 5);
            }
            
            switch (int.Parse(Input))
            {



                case 0:
                    MainMenu();
                    break;
                case 1:
                    // Tool is set in the Toolz.add func in library system so params not used!
                    Tool Tool12 = new Tool("i", 1, 1, 1);
                    Toolz.add(Tool12);
                    StaffMenu();

                    break;
                case 2:
                   
                    //Quantity and Tool are set in the Toolz.add func in library system so params not used!
                    Tool Tool123 = new Tool("i", 1, 1, 1);
                    Toolz.add(Tool123,1);
                    StaffMenu();

                    break;
                case 3:
                    
                    Tool Tool1234 = new Tool("i", 1, 1, 1);
                    //Quantity and Tool are set in the Toolz.delete func in library system so params not used!
                    Toolz.delete(Tool1234,1);
                    StaffMenu();
                    break;
                case 4:
                    //Member is set in the Toolz.add func in library system so params not used!
                    Member meber12 = new Member("i", "i", "i", "i");
                   Toolz.add(meber12);
                    
                    
                    StaffMenu();

                    break;
                case 5:
                    //Member is set in the Toolz.delete func in library system so params not used!
                    Member meber13 = new Member("i", "i", "i", "i");
                    
                    Toolz.delete(meber13);

                    StaffMenu();
                    break;
                    
            }
        }

        //text for staff menu
        private static void StaffMenuText()
        {
            Console.WriteLine("============Staff Menu==========");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add New pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of a Tool");
            Console.WriteLine("4. Register New Member");
            Console.WriteLine("5. Remove a Member");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("================================");
            Console.WriteLine("Please make a selection (1-6, or 0 to return to main menu):");
        }

        #endregion

        #region Member Logic

        //member menu stuff
        private static void MemberLogin()
        {
            Console.WriteLine("============Member Login============");
            Console.WriteLine("Enter 0 in any of the fields to return to main menu.");
            Console.WriteLine("Please enter username");

            string UserName = Console.ReadLine();
            if (UserName == "0") { MainMenu(); } //returns user if they hit 0 in username

            Console.WriteLine("Please enter Password"); //returns user if they hit 0 in password
            string Password = Console.ReadLine();

            if (Password == "0") { MainMenu(); }

            // no password or user name check is in place so even if this message pops up it still brings you to the member menu screen
            //if username != Valid username{
            //
            //
            //}
            Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Authentication Failed");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!\n");
            //else 
            MemberMenu();
        }

        //handle input for member menu
        public static void MemberMenu()
        {
            //initializing class methods
            ToolLibrarySystem Toolz = new ToolLibrarySystem();
            MemberMenuText();
            bool CorrectInput = false;
            string Input = "";

            //Validate input
            while (!CorrectInput)
            {
                Input = Console.ReadLine();
                CorrectInput = HandleIntInput(Input, MemberMenuText, 5);
            }
            
            switch (int.Parse(Input))
            {
                case 0:
                    MainMenu();
                    break;
                    
                case 1:
                    Console.WriteLine("not implemented yet silly XD");
                    
                    //Toolz.displayTools();
                    MemberMenu();


                    break;
                case 2:
                    //Member and tool are set in the Toolz.BorrowTool func in library system so params not used!
                    Tool Tool14 = new Tool("i", 1, 1, 1);
                    Member meber14 = new Member("i", "i", "i", "i");
                    Toolz.borrowTool(meber14,Tool14 );
                    MemberMenu();

                    break;
                case 3:
                    //Member and tool are set in the Toolz.returnTool func in library system so params not used!
                    Tool Tool15 = new Tool("i", 1, 1, 1);
                    Member meber15 = new Member("i", "i", "i", "i");
                     Toolz.returnTool(meber15,Tool15);
                    MemberMenu();
                    break;
                case 4:
                    //member set in toolz.displayborrowing tools func so param not used
                    Member meber16 = new Member("i", "i", "i", "i");
                    Toolz.displayBorrowingTools(meber16);
                    MemberMenu();
                    break;
                case 5:
                    Console.WriteLine("not implemented yet silly XD");
                    // Toolz.displayTopTHree();
                    MemberMenu();
                    break;
                    
            }
        }

        //text for member menu
        private static void MemberMenuText()
        {
            Console.WriteLine("============Member Menu==========");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all tools that I am currently renting");
            Console.WriteLine("5. Display top 3 (three) most frequently rented tools");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("================================");
            Console.WriteLine("Please make a selection (1-5, or 0 to return to main menu):");
        }
        #endregion

        //function for handling the inputs throughout the menu
        public static bool HandleIntInput(string Input, Action TextMethod, int MaxInput, int MinInput = 0)
        {
            if (!int.TryParse(Input, out int IntInput))
            {
                //makes sure the string entered is within the bounds of the options
                Console.WriteLine($"Invalid Response please enter an integer between 0 and {MaxInput}");
                TextMethod(); 
                return false;
            }
            else if (IntInput < MinInput || IntInput > MaxInput)
            {
                //makes sure the number entered is within the bounds of the options
                Console.WriteLine($"Invalid integer please enter an integer between 0 and {MaxInput}");
                TextMethod(); 
                return false;
            }
            return true;
        }
    }
}
