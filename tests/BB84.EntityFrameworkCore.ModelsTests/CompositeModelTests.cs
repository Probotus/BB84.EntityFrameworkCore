﻿using BB84.EntityFrameworkCore.Models;
using BB84.EntityFrameworkCore.Models.Abstractions;

namespace BB84.EntityFrameworkCore.ModelsTests;

[TestClass]
public sealed class CompositeModelTests
{
	[TestMethod]
	public void CompositeModelTest()
	{
		ICompositeModel model;

		model = new TestClass();

		Assert.IsNotNull(model);
		Assert.IsNull(model.Timestamp);
	}

	private sealed class TestClass : CompositeModel
	{ }
}
