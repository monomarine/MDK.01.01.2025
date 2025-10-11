using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class Book
	{
		private string title;
		private string author;
		private bool isIssued;

		public string Title { get => title; set => title = value; }
		public string Author { get => author; set => author = value; }
		public bool IsIssued { get => isIssued; set => isIssued = value; }

		public Book(string title, string author, bool isIssued)
		{
			this.title = title;
			this.author = author;
			this.isIssued = isIssued;
		}
	}
}
