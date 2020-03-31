using System;
namespace DataStructure
{ 
        public class LinkedList : IDataStructure
        {
            private Node first;
            private Node last;
         

            public int Length { get; private set; }

            public LinkedList()
            {
                first = null;
                last = null;
                Length = 0;
            }

            public LinkedList(int a)
            {
                first = new Node(a);
                last = first;
                Length = 1;
            }

            public void Add(int a)
            {
                if (first == null)
                {
                    first = new Node(a);
                    last = first;
                    Length = 1;
                }
                else
                {
                    last.Next = new Node(a);
                    last = last.Next; 
                    Length++;
                }
                
            }

            public int[] ReturnMassive()
            {
                int[] array = new int[Length];
                if (Length != 0)
                {
                    int i = 0;
                    Node tmp = first;
                    do
                    {
                        array[i] = tmp.Value;
                        i++;
                        tmp = tmp.Next;
                    } while (tmp != null);
                }
                return array;
            }

            public void AddToStart(int a)
            {
                if (first != null)
                {
                    Node tmp = new Node(a);
                    tmp.Next = first;
                    first = tmp;
                    Length++;
                }
                else
                {
                    first = new Node(a);
                    last = first;
                    Length = 1;
                }
            }

            public void AddToStart(int[] item)
            {
                for (int i = item.Length - 1; i >=0; i--)
                {
                this.AddToStart(item[i]);
                }
            }


            public void Add(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    this.Add(a[i]);
                }
            }


            public void Remove()
            {
                if (first == last)
                {
                    first = null;
                    last = null;
                    Length = 0;
                }
                else if (first == null)
                {

                }
                else
                {
                    Node current = first;
                    while (current.Next != last)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    last = current;
                    Length--;
                }
            }

            public void Remove(int quantity)
            {
                for (int i = 0; i < quantity; i++)
                {
                this.Remove();
                }
            }

            public void RemoveFromStart()
            {
                if (first == last)
                {
                    first = null;
                    last = null;
                    Length = 0;
                }
                else if (first == null)
                {

                }
                else
                {
                    first = first.Next;
                    Length--;
                }
            }

            public void RemoveFromStart(int quantity)
            {
                for (int i = 0; i < quantity; i++)
                {
                    this.RemoveFromStart();
                }
        }

        void IDataStructure.Insert(int item, int index)
            {
                throw new NotImplementedException();
            }

            void IDataStructure.Insert(int[] addmassive, int index)
            {
                throw new NotImplementedException();
            }

         

            

            void IDataStructure.RemoveOfIndex(int index)
            {
                throw new NotImplementedException();
            }

            void IDataStructure.RemoveOfIndex(int index, int quantity)
            {
                throw new NotImplementedException();
            }

            

            int IDataStructure.IndexOfItem(int item)
            {
                throw new NotImplementedException();
            }

            void IDataStructure.Reverse()
            {
                throw new NotImplementedException();
            }

            int IDataStructure.MinItem()
            {
                throw new NotImplementedException();
            }

            int IDataStructure.MaxItem()
            {
                throw new NotImplementedException();
            }

            void IDataStructure.SortUp()
            {
                throw new NotImplementedException();
            }

            void IDataStructure.SortDown()
            {
                throw new NotImplementedException();
            }

            void IDataStructure.RemoveItem(int item)
            {
                throw new NotImplementedException();
            }

            int IDataStructure.MinItemIndex()
            {
                throw new NotImplementedException();
            }

            int IDataStructure.MaxItemIndex()
            {
                throw new NotImplementedException();
            }
        }
    
}
