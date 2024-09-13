using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConstruct_And_Algorithm
{
    internal class Node<T>
    {
        private T data;//存储数据
        private Node<T> next; //相当于指针 指向下一个节点

        //让数据可以进行赋值和取值操作
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        //不传递参数
        public Node()
        {
            data = default(T);
            next = null;
        }

        //传递数据
        public Node(T value)
        {
            data = value;
            next = null;
            
        }
        //有时候会进行2个参数的传递，传递数据和下一个节点的指针
        public Node(T value, Node<T> next)
        {
            this.data = value;
            this.next = next;
        }
        
        //传递一个指针，指向下一个节点
        public Node(Node<T> next)
        {
            this.next = next;
        }


    }
}
