using System;
using System.Collections.Generic;
using System.Text;

namespace TaskIStack
{
    interface IStack
    {

        int Size(); // - возвращает количество элементов в стеке;
        bool IsEmpty(); //возвращает true, если стек пуст, в противном случае – false;
        void Push(Object element); //добавляет элемент в стек; параметр – добавляемый элемент;
        Object Top(); //возвращает последний элемент стека;
        Object Pop(); // удаляет последний элемент стека;
    }
}
