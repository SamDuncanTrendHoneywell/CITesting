
using System;
using NUnit.Framework;
using CITestMobileApp;

namespace iOSTests
{
	[TestFixture]
	public class exampleTests
	{
		Book book;

		[SetUp]
		public void BookCreation ()
		{
			book = new Book ("War and Peace", "a name");
		}

		[Test]
		public void Pass ()
		{
			Assert.True (true);
		}

		[Test ()]
		public void TestCreateBookGetTitle ()
		{
			Assert.AreEqual ("War and Peace", book.title);
		}

		[Test ()]
		public void TestCreateBookGetAuthor ()
		{
			Assert.AreEqual ("a different name", book.author);
		}

		[Test]
		public void Fail ()
		{
			Assert.False (true);
		}

		[Test]
		[Ignore ("another time")]
		public void Ignore ()
		{
			Assert.True (false);
		}
	}
}
