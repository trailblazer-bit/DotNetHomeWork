using System;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> nodeList = new GenericList<int>();
            //初始化链表
            for(int i=1;i<=10;i++)
            {
                nodeList.Add(i);
            }
            //遍历链表
            nodeList.Foreach((Node<int> node) => Console.Write(node.Data+" "));
            Console.WriteLine();
            //求出链表中元素之和
            int sum = 0;
            nodeList.Foreach((node) => sum += node.Data);
            Console.WriteLine("sum={0}",sum);

            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            //求出链表中元素的最大值
            nodeList.Foreach((node) => 
            {
                if (max < node.Data)
                    max = node.Data;
            });
            Console.WriteLine("maxValue={0}",max);

            //求出链表中元素的最小值
            nodeList.Foreach((node) =>
            {
                if (min > node.Data)
                    min = node.Data;
            });
            Console.WriteLine("minValue={0}", min);
        }
    }


    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //链表泛型类
    public class GenericList<T>
    {
        //定义头结点和尾结点
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            this.head = this.tail = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if(tail==null)
            {
                this.head = this.tail = node;
            }
            else
            {
                this.tail.Next = node;
                this.tail = node;
            }
        }

        //自定义泛型链表的Foreach方法
        //通过Action这个内置委托对象，实现对链表中的每个元素实行一定的操作
        public  void Foreach(Action<Node<T>> action)
        {
            Node<T> p = this.head;
            while(p!=null)
            {
                action(p);
                p = p.Next;
            }
        }
    }
}
