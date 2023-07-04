﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            List<string> Book = new List<string>();
            Console.WriteLine(" Добавьте книгу для прочтения ");
            Book.Add(Console.ReadLine());
            Console.WriteLine("Удалить Книгу из списка  ");
            Book.BinarySearch("Пехов");//найти книгу получить ей индекс для последующего удаоения 
            Book.RemoveAt(index);
        }
            ///void Add(T item): добавление нового элемента в список

//            void AddRange(IEnumerable<T> collection): добавление в список коллекции или массива

//int BinarySearch(T item): бинарный поиск элемента в списке.Если элемент найден, то метод возвращает индекс этого элемента в коллекции. При этом список должен быть отсортирован.

//void CopyTo(T[] array): копирует список в массив array

//void CopyTo(int index, T[] array, int arrayIndex, int count): копирует из списка начиная с индекса index элементы, количество которых равно count, и вставляет их в массив array начиная с индекса arrayIndex

//bool Contains(T item): возвращает true, если элемент item есть в списке

//void Clear(): удаляет из списка все элементы

//bool Exists(Predicate<T> match): возвращает true, если в списке есть элемент, который соответствует делегату match

//T? Find(Predicate<T> match): возвращает первый элемент, который соответствует делегату match. Если элемент не найден, возвращается null

//T? FindLast(Predicate<T> match): возвращает последний элемент, который соответствует делегату match. Если элемент не найден, возвращается null

//List<T> FindAll(Predicate<T> match): возвращает список элементов, которые соответствуют делегату match

//int IndexOf(T item): возвращает индекс первого вхождения элемента в списке

//int LastIndexOf(T item): возвращает индекс последнего вхождения элемента в списке

//List<T> GetRange(int index, int count): возвращает список элементов, количество которых равно count, начиная с индекса index.

//void Insert(int index, T item): вставляет элемент item в список по индексу index. Если такого индекса в списке нет, то генерируется исключение

//void InsertRange(int index, collection): вставляет коллекцию элементов collection в текущий список начиная с индекса index.Если такого индекса в списке нет, то генерируется исключение

//bool Remove(T item): удаляет элемент item из списка, и если удаление прошло успешно, то возвращает true.Если в списке несколько одинаковых элементов, то удаляется только первый из них

//void RemoveAt(int index): удаление элемента по указанному индексу index. Если такого индекса в списке нет, то генерируется исключение

//void RemoveRange(int index, int count): параметр index задает индекс, с которого надо удалить элементы, а параметр count задает количество удаляемых элементов.

//int RemoveAll((Predicate<T> match)): удаляет все элементы, которые соответствуют делегату match. Возвращает количество удаленных элементов

//void Reverse(): изменяет порядок элементов

//void Reverse(int index, int count): изменяет порядок на обратный для элементов, количество которых равно count, начиная с индекса index

//void Sort(): сортировка списка

//void Sort(IComparer<T>? comparer): сортировка списка с помощью объекта comparer, который передается в качестве параметра
//        }
    
}
