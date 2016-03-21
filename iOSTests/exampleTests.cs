﻿
using System;
using NUnit.Framework;

namespace iOSTests
{
	[TestFixture]
	public class exampleTests
	{
		[Test]
		public void Pass ()
		{
			Assert.True (true);
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