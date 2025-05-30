﻿// Copyright: 2024 Robert Peter Meyer
// License: MIT
//
// This source code is licensed under the MIT license found in the
// LICENSE file in the root directory of this source tree.
using BB84.EntityFrameworkCore.Repositories.Tests.Persistence;
using BB84.EntityFrameworkCore.Repositories.Tests.Persistence.Entities;
using BB84.EntityFrameworkCore.Repositories.Tests.Persistence.Repositories;

namespace BB84.EntityFrameworkCore.Repositories.Tests;

[TestClass]
public sealed class PersonJobTests : UnitTestBase
{
	[TestMethod]
	public void CreateTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		PersonJobEntity personJob = new();

		repository.Create(personJob);
	}

	[TestMethod]
	public void CreateRangeTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		List<PersonJobEntity> personJobs = [new(), new()];

		repository.Create(personJobs);
	}

	[TestMethod]
	public async Task CreateAsyncTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		PersonJobEntity personJob = new();

		await repository.CreateAsync(personJob)
			.ConfigureAwait(false);
	}

	[TestMethod]
	public async Task CreateRangeAsyncTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		List<PersonJobEntity> personJobs = [new(), new()];

		await repository.CreateAsync(personJobs)
			.ConfigureAwait(false);
	}

	[TestMethod]
	public void CountAllTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		int count = repository.CountAll(false);

		Assert.AreEqual(0, count);
	}

	[TestMethod]
	public void CountByConditionTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		int count = repository.Count(x => x.PersonId.Equals(Guid.Empty));

		Assert.AreEqual(0, count);
	}

	[TestMethod]
	public async Task CountAllAsyncTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		int count = await repository.CountAllAsync(false)
			.ConfigureAwait(false);

		Assert.AreEqual(0, count);
	}

	[TestMethod]
	public async Task CountByConditionAsyncTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		int count = await repository.CountAsync(expression: x => x.PersonId.Equals(Guid.Empty))
			.ConfigureAwait(false);

		Assert.AreEqual(0, count);
	}

	[TestMethod]
	public void DeleteTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		PersonJobEntity personJob = new() { PersonId = Guid.NewGuid(), JobId = Guid.NewGuid() };

		repository.Delete(personJob);
	}

	[TestMethod]
	public void DeleteRangeTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		List<PersonJobEntity> personJobs = [new() { PersonId = Guid.NewGuid(), JobId = Guid.NewGuid() }];

		repository.Delete(personJobs);
	}

	[TestMethod]
	public async Task DeleteAsyncTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		PersonJobEntity personJob = new() { PersonId = Guid.NewGuid(), JobId = Guid.NewGuid() };

		await repository.DeleteAsync(personJob)
			.ConfigureAwait(false);
	}

	[TestMethod]
	public async Task DeleteRangeAsyncTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		List<PersonJobEntity> personJobs = [new() { PersonId = Guid.NewGuid(), JobId = Guid.NewGuid() }];

		await repository.DeleteAsync(personJobs)
			.ConfigureAwait(false);
	}

	[TestMethod]
	public void UpdateTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		PersonJobEntity personJob = new() { PersonId = Guid.NewGuid(), JobId = Guid.NewGuid() };

		repository.Update(personJob);
	}

	[TestMethod]
	public void UpdateRangeTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		List<PersonJobEntity> personJobs = [new() { PersonId = Guid.NewGuid(), JobId = Guid.NewGuid() }];

		repository.Update(personJobs);
	}

	[TestMethod]
	public async Task UpdateAsyncTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		PersonJobEntity personJob = new() { PersonId = Guid.NewGuid(), JobId = Guid.NewGuid() };

		await repository.UpdateAsync(personJob)
			.ConfigureAwait(false);
	}

	[TestMethod]
	public async Task UpdateRangeAsyncTest()
	{
		using TestDbContext dbContext = GetTestContext();
		PersonJobRepository repository = new(dbContext);

		List<PersonJobEntity> personJobs = [new() { PersonId = Guid.NewGuid(), JobId = Guid.NewGuid() }];

		await repository.UpdateAsync(personJobs)
			.ConfigureAwait(false);
	}
}
