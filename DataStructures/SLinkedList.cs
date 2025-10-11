using System.Collections;

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

        public string GetFirst()
        {
            return _head == null ? null : _head.Data;
        }

        public string GetLast()
        {
            return _tail == null ? null : _tail.Data;
        }

        public bool Contains(string text)
        {
            if (IsEmpty)
                return false;

            Node current = _head;

            while (current != null)
            {
                if (current.Data == text)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException("список пуст");

            Node nextHead = _head.Next;
            _head.Next = null;
            _head = nextHead;

            _count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException("список пуст");

            Node current = _head;

            while (current.Next.Next != null)
                current = current.Next;
            
            current.Next.Next = null;
            current.Next = null;
            _tail = current;

            _count--;
        }

        public void Remove(string text)
        {
            if (IsEmpty)
                throw new ArgumentOutOfRangeException("список пуст");

            Node current = _head;

            while (current != null)
            {
                if (current.Next != null && current.Next.Data == text)
                {
                    if (current.Next.Next != null)
                    {
                        current.Next = current.Next.Next;
                    }                      
                    else
                    {
                        current.Next = null;
                        _tail = current;
                    }      

                    _count--;
                    break;
                }
                current = current.Next;
            }
        }

        public void Clear()
        {
            Node current = _head;

            while (current != null)
            {
                current.Next = null;
            }

            _head = null;
            _tail = null;
            _count = 0;
        }

        public void Reverse()
        {
            Node current = _head;

            Node previous = null;
            Node next = null;

            _tail = _head;

            while (current != null)
            {
                next = current.Next;  
                current.Next = previous; 
                previous = current;    
                current = next;
            }

            _head = previous;

            Node head = _head;
            _tail = head;
            _head = _tail;
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
            if (text == null)
                throw new ArgumentException("данные пустые");

            Node node = new Node(text);

            if (IsEmpty)
                _head = node;

            Node prevTail = _tail;
            prevTail.Next = node;

            _tail = node;     

            _count++;
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
