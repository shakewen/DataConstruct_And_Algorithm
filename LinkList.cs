using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConstruct_And_Algorithm
{
    //直接继承IList接口，实现其所有方法
    internal class LinkList<T>
    {
        private Node<T> head;//存储一个头节点

        //进行构造函数的初始化
        public LinkList()
        {
            head = null;
        }
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            //如果头节点为空，则直接将新节点作为头节点
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                //如果头节点不为空，将新来的节点放入链表的尾节点
                //访问到链表的尾节点
                Node<T> temp = head;
                while (true)
                {
                    //如果链表的当前节点不为空，则继续访问下一个节点
                    if(temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                temp.Next = newNode;//把新来的节点放入链表的尾部
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        //插入节点
        public void Insert(int index, T item)
        {
            Node<T> newNode = new Node<T>(item);
            //如果插入到头节点的话
            if(index == 0)
            {
                //将新节点的next指向头节点
                newNode.Next = head;
                //将头节点指向新节点，现在新节点就成为了头节点
                head = newNode;
            }
            else
            {
                //从头节点开始遍历，找到要插入的位置
               Node<T> temp = head;
                for(int i = 0; i <= index-1; i++)
                {
                    //让temp向后移一个位置,直到找到要插入的位置
                    temp = temp.Next;
                }
               Node<T> preNode = temp;
               //当前要插入的节点
               Node<T> currentNode =temp.Next;

                preNode.Next = newNode;
                newNode.Next = currentNode;
            }
        }

        public T Delete(int index)
        {

        }

       
    }
}
