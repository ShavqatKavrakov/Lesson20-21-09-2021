using System;
using System.Collections.Generic;
namespace Lesson20._21._09._2021
{
    class MyList<T>
    {
        T [] list;
        private int i=0;
        private int Lenths=default;
        public int Count=>list.Length;
            public T this[int index]
            {
                get=> list[index];
                set=>list[index]=value;
            }
            public MyList(int Length)
            {
              list =new T[Length];
            }
            public MyList():this(1){}          
            public void  Add(T element) 
            {  
                Array.Resize(ref list,++Lenths);
                   list[i++]=element;
            }
    }
    class MyDictionary<TKey,TValue>
    {
      public  struct Pair
       {
         public int key;
         public TValue value;
         public Pair(int key,TValue value)
         {
             this.key=key;
             this.value=value;
         }
       }
       public Pair[] pairs;
       private int Length=0;
       private int i=0,e=0;
       public int Count=>pairs.Length;
       public MyDictionary():this(1){}
           public MyDictionary(int Length)
       {
           pairs=new Pair[Length];
   
       }
         public void Add(int key,TValue value)
     {
         e=key;
         Array.Resize(ref pairs, ++Length);
         pairs[i].key=key;
         pairs[i++].value=value;
     }
       public TValue this[int index]
     {
         get =>pairs[index].value;
         set =>pairs[e].value=value;
     }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
         list.Add("Muhammad");
         Console.WriteLine(list[0]);
         list.Add("Anvar");
         Console.WriteLine(list[1]);
         MyDictionary<int ,string> dictionary=new MyDictionary<int, string>();
         dictionary.Add(0,"WQ");
         dictionary.Add(1,"Mahmud");
         dictionary.Add(2,"Muhtor");
         Console.WriteLine(dictionary[2]);

         }
      }  
}

