using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
#pragma warning disable
    internal class SLinkedList: IEnumerable<string>
    {
        private Node _head;
        private Node _tail;
        private int _count;

        public int Count => _count;
        public bool IsEmpty => _head == null;

        public SLinkedList()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
        /*
         * функционал:
         * 
         * получить первый элемент
         * получить последний элемент
         * 
         * вставить элемент в начало списка
         * добавить элемент в конец списка!
         * добавить элемент после другого
         * 
         * удалить первый элемент!
         * удалить последний элемент!
         * удалить элемент по его данным!
         * 
         * проверить наличие элемента!
         * очистить список!
         * реализовать перебор элементов
         * перевернуть!
         * 
         */

        public string GetFirst()
        {
            return _head == null ? null : _head.Data;
        }

        public string GetLast()
        {
            return _tail == null ? null : _tail.Data;
        }

        public void AddFirst(string text)
        {
            if (text == null)
                throw new ArgumentException("данные пустые");

            Node node = new(text);

            if (IsEmpty)
                _tail = node;
            node.Next = _head;
            _head = node;

            _count++;
        }

        public void InsertAfter(string existingText, string text)
        {
            if (existingText == null || text == null)
                throw new ArgumentException("данные пустые");
            if (IsEmpty)
            {
                AddFirst(text);
                return;
            }

            Node node = new(text);
            Node current = _head;

            while (current.Next != null)
            {
                if (current.Data == existingText)
                {
					node.Next = current.Next;
					current.Next = node;
                    _count++;
                    break;
                }
                current = current.Next;
            }

        }

        public void AddLast(string text)
        {
            throw new NotImplementedException();
        }

		public IEnumerator<string> GetEnumerator()
		{
            Node current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
		    return GetEnumerator();
		}
	}
}
