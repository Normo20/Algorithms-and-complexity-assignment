using System;
using System.Collections.Generic;
using System.Text;

namespace Cab301_assignment
{
    class MemberCollection : BSTree, iMemberCollection
    {
        //uses the BSTree class given in the tutorial
        BSTree bSTree;
        private Member[] members;
        private int count;
        private int number;
        
        //initialises membercollection object
        public MemberCollection()
        {
            count = 0;
            bSTree = new BSTree();
            members = new Member[count];

        }



        public int Number
        {
            get { return number; }

        }

        public void add(Member aMember)
        {
            //adds a member into the bstree using the insert method in the tree class 
            bSTree.Insert(aMember);
            count++;
        }

        public void delete(Member aMember)
        {
            //deletes a member into the bstree using the delete method in the tree class 
            bSTree.Delete(aMember);
            count--;
        }

        public bool search(Member aMember)
        {
            //searches a member into the bstree using the search method in the tree class 
            bool o = bSTree.Search(aMember);
            //prints out the bool value to see if search was sucessful 
            Console.WriteLine(o);
            return o;
        }

        public Member[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
