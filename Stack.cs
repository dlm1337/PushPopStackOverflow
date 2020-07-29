using System.Collections;
namespace PushPopStackOverflow
{
        public class Stack
        {
        
            private int index;
            readonly private ArrayList pushPopList;
            public Stack()
            {
                pushPopList = new ArrayList();
                index = -1;
            }
        public void Push(object item)
        {
            pushPopList.Add(item);
            index++;
        }
        public object Pop()
        {
           
            
                object obj = pushPopList[index];
                pushPopList.RemoveAt(index);
                index--;
                return obj;
            
          

           
        }

        public void Clear()
        {
            pushPopList.Clear();
            index = -1;
        }

        public ArrayList PushPopList()
        {
           return pushPopList;
         
        }
        }







}
