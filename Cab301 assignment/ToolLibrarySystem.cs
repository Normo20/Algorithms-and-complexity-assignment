using System;
using System.Collections.Generic;
using System.Text;

namespace Cab301_assignment
{
    public class ToolLibrarySystem : iToolLibrarySystem
    {
        //initialises tool collection objects for each tool catagory and a member collection
        MemberCollection MemberCollectionz = new MemberCollection();
        ToolCollection[] gardening = new ToolCollection[4];
        ToolCollection[] fencing = new ToolCollection[5];
        ToolCollection[] flooring = new ToolCollection[5];
        ToolCollection[] Measuring = new ToolCollection[5];
        ToolCollection[] Cleaning = new ToolCollection[5];
        ToolCollection[] Painting = new ToolCollection[5];
       ToolCollection[] Electronic = new ToolCollection[4];
        ToolCollection[] Electricity = new ToolCollection[4];
        ToolCollection[] Automotive = new ToolCollection[5];

        //recurring theme of a lot of these functions not working due to me not being able to search for specific members or tools and instead just creating new ones.
        //logic should be fairly all right though 
        //but yeah 1 problem has made some of these functions unusable
        
        
        public void initial()
        {
            //initalizes each tool collection with a tool colledction for each type of tool
            for (int i = 0; i < gardening.Length; i++)
            {
                gardening[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }

            for (int i = 0; i < fencing.Length; i++)
            {
                fencing[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }

            for (int i = 0; i < flooring.Length; i++)
            {
                flooring[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }

            for (int i = 0; i < Measuring.Length; i++)
            {
                Measuring[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }

            for (int i = 0; i < Cleaning.Length; i++)
            {
                Cleaning[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }
            for (int i = 0; i < Painting.Length; i++)
            {
                Painting[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }
            for (int i = 0; i < Electronic.Length; i++)
            {
                Electronic[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }
            for (int i = 0; i < Electricity.Length; i++)
            {
                Electricity[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }
            for (int i = 0; i < Automotive.Length; i++)
            {
                Automotive[i] = new ToolCollection(); //my ToolCollection constructor takes a parameter to set the size of the ToolCollection more specifically the size of the Tool[]
            }

        }
        public void add(Tool aTool)
        {
            //starts initial which it shouldn't but oh well
            initial();
            //menu stuff
            Console.WriteLine("please choose what catagory to add a tool too");
            Console.WriteLine("1. Gardening tools");
            Console.WriteLine("2. Flooring Tools");
            Console.WriteLine("3. Fencing tools");
            Console.WriteLine("4. Measuring tools");
            Console.WriteLine("5. Cleaning tools");
            Console.WriteLine("6. Painting tools");
            Console.WriteLine("7. Electronic tools");
            Console.WriteLine("8. Electricity tools");
            Console.WriteLine("9. Automotive tools");
            string v = Console.ReadLine();
            int V = (int.Parse(v)); //parsing the int

            if (V < 10)
            {

                if (V == 1)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Line Trimmers");
                    Console.WriteLine("2. Lawn Mowers");
                    Console.WriteLine("3. Hand Tools");
                    Console.WriteLine("4. Wheel Barrows");
                    Console.WriteLine("5. Garden Power Tools");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {

                        
                        //adds the tool using the add function in toolcollection
                            Console.WriteLine("Please enter the name of the Tool");
                            string ToolName = Console.ReadLine();
                            gardening[V1-1].add(new Tool(ToolName, 3, 3, 0));
                            Console.WriteLine(ToolName + " has been added to the system");
                        

                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }


                    // does this same thing 9 times for each tool catagory

                }

                if (V == 2)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Scrapers");
                    Console.WriteLine("2. Floor Lasers");
                    Console.WriteLine("3. Floor Levelling Tools");
                    Console.WriteLine("4. Floor Levelling Materials");
                    Console.WriteLine("5. Floor Hand Tools");
                    Console.WriteLine("6. Tiling Tools");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        flooring[V1 - 1].add(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been added to the system");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }
                if (V == 3)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Hand Tools");
                    Console.WriteLine("2. Electric Fencing");
                    Console.WriteLine("3. Steel Fencing Tools");
                    Console.WriteLine("4. Power Tools");
                    Console.WriteLine("5. Fencing Accessories");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        fencing[V1 - 1].add(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been added to the system");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 4)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Distance Tools");
                    Console.WriteLine("2. Laser Measurer");
                    Console.WriteLine("3. Measuring Jugs");
                    Console.WriteLine("4. Temperature & Humidity Tools");
                    Console.WriteLine("5. Levelling Tools");
                    Console.WriteLine("6. Markers");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Measuring[V1 - 1].add(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been added to the system");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 5)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Draining");
                    Console.WriteLine("2. Car Cleaning");
                    Console.WriteLine("3. Vacuum");
                    Console.WriteLine("4. Pressure Cleaners");
                    Console.WriteLine("5. Pool Cleaning");
                    Console.WriteLine("6. Floor Cleaning");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Cleaning[V1 - 1].add(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been added to the system");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 6)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Sanding Tools");
                    Console.WriteLine("2. Brushes");
                    Console.WriteLine("3. Rollers");
                    Console.WriteLine("4. Paint Removal Tools");
                    Console.WriteLine("5. Paint Scrapers");
                    Console.WriteLine("6. Sprayers");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Painting[V1 - 1].add(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been added to the system");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 7)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Voltage Tester");
                    Console.WriteLine("2. Oscilloscopes");
                    Console.WriteLine("3. Thermal Imaging");
                    Console.WriteLine("4. Data Test Tool");
                    Console.WriteLine("5. Insulation Testers");
                    
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Electronic[V1 - 1].add(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been added to the system");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 8)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Test Equipment");
                    Console.WriteLine("2. Safety Equipment");
                    Console.WriteLine("3. Basic Hand tools");
                    Console.WriteLine("4. Circuit Protection");
                    Console.WriteLine("5. Cable Tools");

                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Electricity[V1 - 1].add(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been added to the system");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 9)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Jacks");
                    Console.WriteLine("2. Air Compressors");
                    Console.WriteLine("3. Battery Chargers");
                    Console.WriteLine("4. Socket Tools");
                    Console.WriteLine("5. Braking");
                    Console.WriteLine("6. Drivetrain");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Automotive[V1 - 1].add(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been added to the system");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

            }
            else
            {
                Console.WriteLine("please enter a valid option");
            }


           // lawnmowers = gardening[1];
       // Tool[] LineTrimmers = gardening[0].toArray();
        //Tool[] Lawnmowers = gardening[1].toArray();
        //Tool[] HandTools = gardening[2].toArray();
        //Tool[] WheelBarrows = gardening[3].toArray();
        //Tool[] GardenPowerTools = gardening[4].toArray();

        // Tool[] FHandTools = fencing[0].toArray();

        //foreach(Tool t in gardening[0].toArray())
        // {
        //   int count = t.avaliableQuantity;
        //}

        //add tool to a tool type (which is a ToolCollection object) --  gardening[0] is a ToolCollection object - remember that a ToolCollection object is just an array of tool objects
        }

        public void add(Tool aTool, int quantity)
        {
            //does not work
            //more menu stuff
            initial(); // doesn't work without this but i know it shouldn't be here as it resets the tool array

            Console.WriteLine("please choose what catagory to add pieces of a tool to");
            Console.WriteLine("1. Gardening tools");
            Console.WriteLine("2. Flooring Tools");
            Console.WriteLine("3. Fencing tools");
            Console.WriteLine("4. Measuring tools");
            Console.WriteLine("5. Cleaning tools");
            Console.WriteLine("6. Painting tools");
            Console.WriteLine("7. Electronic tools");
            Console.WriteLine("8. Electricity tools");
            Console.WriteLine("9. Automotive tools");
            string v = Console.ReadLine();
            int V = (int.Parse(v));

            if (V < 10)
            {

                if (V == 1)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Line Trimmers");
                    Console.WriteLine("2. Lawn Mowers");
                    Console.WriteLine("3. Hand Tools");
                    Console.WriteLine("4. Wheel Barrows");
                    Console.WriteLine("5. Garden Power Tools");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            //adds the pieces of the desired tool using add pieces doesn't work because I don't know how to search for the tool so it creates a new tool instead
                            gardening[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }

                    //Does this 8 more times for each catagory of tool


                }

                if (V == 2)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Scrapers");
                    Console.WriteLine("2. Floor Lasers");
                    Console.WriteLine("3. Floor Levelling Tools");
                    Console.WriteLine("4. Floor Levelling Materials");
                    Console.WriteLine("5. Floor Hand Tools");
                    Console.WriteLine("6. Tiling Tools");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            flooring[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }
                if (V == 3)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Hand Tools");
                    Console.WriteLine("2. Electric Fencing");
                    Console.WriteLine("3. Steel Fencing Tools");
                    Console.WriteLine("4. Power Tools");
                    Console.WriteLine("5. Fencing Accessories");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            fencing[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 4)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Distance Tools");
                    Console.WriteLine("2. Laser Measurer");
                    Console.WriteLine("3. Measuring Jugs");
                    Console.WriteLine("4. Temperature & Humidity Tools");
                    Console.WriteLine("5. Levelling Tools");
                    Console.WriteLine("6. Markers");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Measuring[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 5)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Draining");
                    Console.WriteLine("2. Car Cleaning");
                    Console.WriteLine("3. Vacuum");
                    Console.WriteLine("4. Pressure Cleaners");
                    Console.WriteLine("5. Pool Cleaning");
                    Console.WriteLine("6. Floor Cleaning");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Cleaning[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 6)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Sanding Tools");
                    Console.WriteLine("2. Brushes");
                    Console.WriteLine("3. Rollers");
                    Console.WriteLine("4. Paint Removal Tools");
                    Console.WriteLine("5. Paint Scrapers");
                    Console.WriteLine("6. Sprayers");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Painting[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 7)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Voltage Tester");
                    Console.WriteLine("2. Oscilloscopes");
                    Console.WriteLine("3. Thermal Imaging");
                    Console.WriteLine("4. Data Test Tool");
                    Console.WriteLine("5. Insulation Testers");

                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Electronic[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 8)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Test Equipment");
                    Console.WriteLine("2. Safety Equipment");
                    Console.WriteLine("3. Basic Hand tools");
                    Console.WriteLine("4. Circuit Protection");
                    Console.WriteLine("5. Cable Tools");

                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Electricity[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 9)
                {
                    Console.WriteLine("Please choose the tool type to add");
                    Console.WriteLine("1. Jacks");
                    Console.WriteLine("2. Air Compressors");
                    Console.WriteLine("3. Battery Chargers");
                    Console.WriteLine("4. Socket Tools");
                    Console.WriteLine("5. Braking");
                    Console.WriteLine("6. Drivetrain");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to add too?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Automotive[V1 - 1].addPieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

            }
            else
            {
                Console.WriteLine("please enter a valid option");
            }
        }

        public void add(Member aMember)
        {
            
            
             //menu stuff

            Console.WriteLine("Please enter members last name");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("Please enter members first name");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Please enter members contact number");
            string contactNumber1 = Console.ReadLine();
            Console.WriteLine("Please enter members PIN");
            string PIN1 = Console.ReadLine();
            Member po = new Member(lastName1, firstName1, contactNumber1, PIN1);
            MemberCollectionz.add(po); //adds member using the details provided
            MemberCollectionz.search(po); //use search to check if it exists
            Console.WriteLine("new member successfully added");
            
        }

        public void borrowTool(Member aMember, Tool aTool)
        { 
            //menu stuff
            Console.WriteLine("Please re enter your user details before borrowing");
            Console.WriteLine("last name");
            string Last = Console.ReadLine();
            Console.WriteLine("first Name");
            string first = Console.ReadLine();
            Console.WriteLine("contact number");
            string contact = Console.ReadLine();
            Console.WriteLine("PIN");
            string pin = Console.ReadLine();
            Member Mem = new Member(Last,first,contact,pin); //is supposed to search and match a member but instead creates new member because I don't know how to search and match
 
            Console.WriteLine("Please enter the name of the Tool");
            string ToolName = Console.ReadLine();
            Mem.addTool(new Tool(ToolName, 3, 3, 1)); //adds a new tool using the add tool function in member

            //check if tool exists when you have the array of tools

           Console.WriteLine(ToolName + " has been borrowed");

            
                    
                   

              
            
        }

        public void delete(Tool aTool)
        {
            // menu stuff
            Console.WriteLine("please choose what catagory to delete a from");
            Console.WriteLine("1. Gardening tools");
            Console.WriteLine("2. Flooring Tools");
            Console.WriteLine("3. Fencing tools");
            Console.WriteLine("4. Measuring tools");
            Console.WriteLine("5. Cleaning tools");
            Console.WriteLine("6. Painting tools");
            Console.WriteLine("7. Electronic tools");
            Console.WriteLine("8. Electricity tools");
            Console.WriteLine("9. Automotive tools");
            string v = Console.ReadLine();
            int V = (int.Parse(v));

            if (V < 10)
            {

                if (V == 1)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Line Trimmers");
                    Console.WriteLine("2. Lawn Mowers");
                    Console.WriteLine("3. Hand Tools");
                    Console.WriteLine("4. Wheel Barrows");
                    Console.WriteLine("5. Garden Power Tools");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        gardening[V1 - 1].delete(new Tool(ToolName, 3, 3, 0)); //deletes specified tool using the delete method in
                                                                               //toolcollection once again doesn't work because I don't know how to search instead creates a new tool
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }

                    //does this 8 more times for each catagory of tool


                }

                if (V == 2)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Scrapers");
                    Console.WriteLine("2. Floor Lasers");
                    Console.WriteLine("3. Floor Levelling Tools");
                    Console.WriteLine("4. Floor Levelling Materials");
                    Console.WriteLine("5. Floor Hand Tools");
                    Console.WriteLine("6. Tiling Tools");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        flooring[V1 - 1].delete(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }
                if (V == 3)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Hand Tools");
                    Console.WriteLine("2. Electric Fencing");
                    Console.WriteLine("3. Steel Fencing Tools");
                    Console.WriteLine("4. Power Tools");
                    Console.WriteLine("5. Fencing Accessories");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        fencing[V1 - 1].delete(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 4)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Distance Tools");
                    Console.WriteLine("2. Laser Measurer");
                    Console.WriteLine("3. Measuring Jugs");
                    Console.WriteLine("4. Temperature & Humidity Tools");
                    Console.WriteLine("5. Levelling Tools");
                    Console.WriteLine("6. Markers");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Measuring[V1 - 1].delete(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 5)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Draining");
                    Console.WriteLine("2. Car Cleaning");
                    Console.WriteLine("3. Vacuum");
                    Console.WriteLine("4. Pressure Cleaners");
                    Console.WriteLine("5. Pool Cleaning");
                    Console.WriteLine("6. Floor Cleaning");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Cleaning[V1 - 1].delete(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 6)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Sanding Tools");
                    Console.WriteLine("2. Brushes");
                    Console.WriteLine("3. Rollers");
                    Console.WriteLine("4. Paint Removal Tools");
                    Console.WriteLine("5. Paint Scrapers");
                    Console.WriteLine("6. Sprayers");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Painting[V1 - 1].delete(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 7)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Voltage Tester");
                    Console.WriteLine("2. Oscilloscopes");
                    Console.WriteLine("3. Thermal Imaging");
                    Console.WriteLine("4. Data Test Tool");
                    Console.WriteLine("5. Insulation Testers");

                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Electronic[V1 - 1].delete(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 8)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Test Equipment");
                    Console.WriteLine("2. Safety Equipment");
                    Console.WriteLine("3. Basic Hand tools");
                    Console.WriteLine("4. Circuit Protection");
                    Console.WriteLine("5. Cable Tools");

                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Electricity[V1 - 1].delete(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 9)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Jacks");
                    Console.WriteLine("2. Air Compressors");
                    Console.WriteLine("3. Battery Chargers");
                    Console.WriteLine("4. Socket Tools");
                    Console.WriteLine("5. Braking");
                    Console.WriteLine("6. Drivetrain");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Automotive[V1 - 1].delete(new Tool(ToolName, 3, 3, 0));
                        Console.WriteLine(ToolName + " has been deleted");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

            }
            else
            {
                Console.WriteLine("please enter a valid option");
            }
        }

        public void delete(Tool aTool, int quantity)
        {
            initial();
            Console.WriteLine("please choose what catagory to delete a from");
            Console.WriteLine("1. Gardening tools");
            Console.WriteLine("2. Flooring Tools");
            Console.WriteLine("3. Fencing tools");
            Console.WriteLine("4. Measuring tools");
            Console.WriteLine("5. Cleaning tools");
            Console.WriteLine("6. Painting tools");
            Console.WriteLine("7. Electronic tools");
            Console.WriteLine("8. Electricity tools");
            Console.WriteLine("9. Automotive tools");
            string v = Console.ReadLine();
            int V = (int.Parse(v));

            if (V < 10)
            {

                if (V == 1)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Line Trimmers");
                    Console.WriteLine("2. Lawn Mowers");
                    Console.WriteLine("3. Hand Tools");
                    Console.WriteLine("4. Wheel Barrows");
                    Console.WriteLine("5. Garden Power Tools");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++) 
                        {
                            gardening[V1 - 1].deletePieces(new Tool(ToolName, 0, 0, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 2)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Scrapers");
                    Console.WriteLine("2. Floor Lasers");
                    Console.WriteLine("3. Floor Levelling Tools");
                    Console.WriteLine("4. Floor Levelling Materials");
                    Console.WriteLine("5. Floor Hand Tools");
                    Console.WriteLine("6. Tiling Tools");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            flooring[V1 - 1].deletePieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }
                if (V == 3)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Hand Tools");
                    Console.WriteLine("2. Electric Fencing");
                    Console.WriteLine("3. Steel Fencing Tools");
                    Console.WriteLine("4. Power Tools");
                    Console.WriteLine("5. Fencing Accessories");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            fencing[V1 - 1].deletePieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 4)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Distance Tools");
                    Console.WriteLine("2. Laser Measurer");
                    Console.WriteLine("3. Measuring Jugs");
                    Console.WriteLine("4. Temperature & Humidity Tools");
                    Console.WriteLine("5. Levelling Tools");
                    Console.WriteLine("6. Markers");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Measuring[V1 - 1].deletePieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 5)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Draining");
                    Console.WriteLine("2. Car Cleaning");
                    Console.WriteLine("3. Vacuum");
                    Console.WriteLine("4. Pressure Cleaners");
                    Console.WriteLine("5. Pool Cleaning");
                    Console.WriteLine("6. Floor Cleaning");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++) 
                        {
                            Cleaning[V1 - 1].deletePieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 6)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Sanding Tools");
                    Console.WriteLine("2. Brushes");
                    Console.WriteLine("3. Rollers");
                    Console.WriteLine("4. Paint Removal Tools");
                    Console.WriteLine("5. Paint Scrapers");
                    Console.WriteLine("6. Sprayers");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Painting[V1 - 1].deletePieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 7)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Voltage Tester");
                    Console.WriteLine("2. Oscilloscopes");
                    Console.WriteLine("3. Thermal Imaging");
                    Console.WriteLine("4. Data Test Tool");
                    Console.WriteLine("5. Insulation Testers");

                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Electronic[V1 - 1].deletePieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 8)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Test Equipment");
                    Console.WriteLine("2. Safety Equipment");
                    Console.WriteLine("3. Basic Hand tools");
                    Console.WriteLine("4. Circuit Protection");
                    Console.WriteLine("5. Cable Tools");

                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 6)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Electricity[V1 - 1].deletePieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }




                }

                if (V == 9)
                {
                    Console.WriteLine("Please choose the tool type to delete a from");
                    Console.WriteLine("1. Jacks");
                    Console.WriteLine("2. Air Compressors");
                    Console.WriteLine("3. Battery Chargers");
                    Console.WriteLine("4. Socket Tools");
                    Console.WriteLine("5. Braking");
                    Console.WriteLine("6. Drivetrain");
                    string v1 = Console.ReadLine();
                    int V1 = (int.Parse(v1));

                    if (V1 < 7)
                    {



                        Console.WriteLine("Please enter the name of the Tool");
                        string ToolName = Console.ReadLine();
                        Console.WriteLine("What Quantity do you wish to delete?");
                        string v12 = Console.ReadLine();
                        int V12 = (int.Parse(v12));
                        for (int i = 0; i < V12; i++)
                        {
                            Automotive[V1 - 1].deletePieces(new Tool(ToolName, 3, 3, 0));
                        }
                        Console.WriteLine(ToolName + " has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid option");
                    }


                }

                }
            else {
                Console.WriteLine("please enter a valid option");
            }
                }

        public void delete(Member aMember)
        {
            //not working atm 
            
            


            Console.WriteLine("Please enter members last name");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("Please enter members first name");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Please enter members contact number");
            string contactNumber1 = Console.ReadLine();
            Console.WriteLine("Please enter members PIN");
            string PIN1 = Console.ReadLine();
            Member po1 = new Member(lastName1, firstName1, contactNumber1, PIN1);
            //  if (MemberCollectionz.search(po1) == true)
            //
            //{ 
            MemberCollectionz.search(po1); //searches for the member to check if they exist  they never do cause code is broken
                MemberCollectionz.delete(po1); // deletes the member using the delete function
                Console.WriteLine("member successfully deleted");
            //}
           
        }

        public void displayBorrowingTools(Member aMember)
        {
            Console.WriteLine("Please enter members last name");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("Please enter members first name");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Please enter members contact number");
            string contactNumber1 = Console.ReadLine();
            Console.WriteLine("Please enter members PIN");
            string PIN1 = Console.ReadLine();

            Member Memberz = new Member(firstName1,lastName1,contactNumber1,PIN1);
            Memberz.toarray(); //runs the toarray function in member class which returns an array of tools for member 
            //once again doesn't work because it's doing it for a new member and not the searched member which obv returns nothing
        }

        public void displayTools(string aToolType)
        {
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            throw new NotImplementedException();
        }

        public string[] listTools(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            //menu stuff
            Console.WriteLine("Please re enter your user details before returning");
            Console.WriteLine("last name");
            string Last = Console.ReadLine();
            Console.WriteLine("first Name");
            string first = Console.ReadLine();
            Console.WriteLine("contact number");
            string contact = Console.ReadLine();
            Console.WriteLine("PIN");
            string pin = Console.ReadLine();
            Member Mem = new Member(Last, first, contact, pin);

            Console.WriteLine("Please enter the name of the Tool");
            string ToolName = Console.ReadLine();
            Mem.deleteTool(new Tool(ToolName, 3, 3, 1)); //how to know the number of borrowings?? also this just delets all tools the member has and doesn't use this unput yet

            //check if tool exists when you have the array of tools

            Console.WriteLine(ToolName + " has been returned");
        }
    }
}
