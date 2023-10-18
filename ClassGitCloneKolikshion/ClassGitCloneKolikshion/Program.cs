using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGitCloneKolikshion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolikshion<int> c = new Kolikshion<int>();
            c.AddAL("Hi");
            c.AddAL(1);
            c.AddL(2);
            c.AddL(3);
            c.AddS(4);
            c.AddS(5);
            c.AddQ(6);
            c.AddQ(7);

            Console.WriteLine("Размер ArrayList: " + c.LengthAL());
            Console.WriteLine("Размер List: " + c.LengthL());
            Console.WriteLine("Размер Stack: " + c.LengthS());
            Console.WriteLine("Размер Queue: " + c.LengthQ());
            
            object ar = c.PAAL(0);
            Console.WriteLine("Элемент из ArrayList: " + ar);
            int a = c.PAL(0);
            Console.WriteLine("Элемент из List: " + a);
            a = c.PAS(0);
            Console.WriteLine("Элемент из Stack: " + a);
            a = c.PAQ(0);
            Console.WriteLine("Элемент из Queue: " + a);

            
            
            c.RemoveAL(1);
            c.RemoveL(1);
            c.RemoveS();
            c.RemoveQ();
            

            Console.WriteLine("Размер ArrayList после удаления: " + c.LengthAL());
            Console.WriteLine("Размер List после удаления: " + c.LengthL());
            Console.WriteLine("Размер Stack после удаления: " + c.LengthS());
            Console.WriteLine("Размер Queue после удаления: " + c.LengthQ());
        }

        public class Kolikshion<T>
        {
            public ArrayList arrayList = new ArrayList();
            public List<T> list = new List<T>();
            public Stack<T> stack = new Stack<T>();
            public Queue<T> queue = new Queue<T>();

            /////ADD/////
            public void AddAL(object a)
            {
                arrayList.Add(a);
            }
            public void AddL(T a)
            {
                list.Add(a);
            }

            public void AddS(T a)
            {
                stack.Push(a);
            }

            public void AddQ(T a)
            {
                queue.Enqueue(a);
            }
            /////Remove/////
            public void RemoveAL(object a)
            {
                arrayList.Remove(a);
            }

            public void RemoveL(T a)
            {
                list.Remove(a);
            }

            public void RemoveS()
            {
                stack.Pop();
            }

            public void RemoveQ()
            {
                queue.Dequeue();
            }
            /////Get/////
            public object PAAL(int i)
            {
                return arrayList[i];
            }
            public T PAL(int i)
            {
                return list[i];
            }

            public T PAS(int i)
            {
                return stack.Peek();
            }

            public T PAQ(int i)
            {
                return queue.Peek();
            }
            /////Lenght/////
            public int LengthAL()
            {
                return arrayList.Count;
            }
            public int LengthL()
            {
                return list.Count;
            }

            public int LengthS()
            {
                return stack.Count;
            }

            public int LengthQ()
            {
                return queue.Count;
            }
        }
    }
}
