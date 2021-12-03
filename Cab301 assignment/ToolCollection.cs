using System;
using System.Collections.Generic;
using System.Text;


namespace Cab301_assignment
{
    public class ToolCollection : iToolCollection
    {
        // please look in Tool library system for how I've constructed my tool object arrays !!! and also in the top add function
        private int number;

        private Tool[] tools;
       
        //initializes tool colection object
        public ToolCollection()
        {
            tools = new Tool[30];
        }
      

        
        public int Number
        {
            get { return number; }
           
        }

        public void add(Tool tool)
        {
            //adds tool to the desired collection which is handeles in library system and then increments the collection array counter
            tools[number] =  tool;
           Console.WriteLine(tool);
            number++;
        }
        public void delete(Tool tool)
        {
            //removes tool of the desired collection which is handeles in library system and then decrements the collection array counter
            tools[number] = null;
            number--;
            
        }

        public void deletePieces(Tool tool)
        {
            //delets pieces of the desired tool of the collection which is handeles in library system and then decrements the quantity counter
            tools[number] = tool;
            tool.Quantity--;
            Console.WriteLine(tool);
            
            
        }

        public void addPieces(Tool tool)
        {
            //adds pieces of the desired tool of the collection which is handeles in library system and then increments the quantity counter
            tools[number] = tool;
            tool.Quantity++;
            Console.WriteLine(tool);
        }

        public bool search(Tool tool)
        {
           
            throw new NotImplementedException();
        }
        
        public Tool[] toArray()
        {
           //returns the tools array 
          
            return tools;
        }
    }
}
