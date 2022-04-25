using System;
using System.Collections.Generic;
using System.Text;

namespace TaskIStack
{
    class ArrayStack : IStack
    {
        //длина по умолчанию массива, используемая для реализации стека
        public static readonly int CAPACITY = 1000;

        //длина массива
        int capacity;

        Object[] s;
        int top = -1;

        public ArrayStack()
        {
            s = new Object[CAPACITY];
            capacity = CAPACITY;
        }


        public ArrayStack(int capacity)
        {
            if (capacity <= 0 || capacity > CAPACITY)
            {
                capacity = CAPACITY;
            }

            this.capacity = capacity;
            s = new Object[capacity];
        }



        public bool IsEmpty()
        {
            return top == -1;
        }

        public object Pop()
        {
            if (top == -1)
            {
                throw new IndexOutOfRangeException("Stack is Empty!");
            }

            Object temp = s[top];
            s[top] = null;
            top--;

            return temp;
        }

        public void Push(object element)
        {
            if(top + 1  >= this.capacity)
            {
                throw new IndexOutOfRangeException("Stack is Full!");
            }

            top++;
            s[top] = element;
        }

        public int Size()
        {
            return top + 1;
        }

        public object Top()
        {
            if(top == -1)
            {
                throw new IndexOutOfRangeException("Stack is Empty!");
            }

            return s[top];
        }

    }
}
