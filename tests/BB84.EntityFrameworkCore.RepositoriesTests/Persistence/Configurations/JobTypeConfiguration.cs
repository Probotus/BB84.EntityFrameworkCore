﻿using BB84.EntityFrameworkCore.Repositories.SqlServer.Configurations;
using BB84.EntityFrameworkCore.RepositoriesTests.Persistence.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BB84.EntityFrameworkCore.RepositoriesTests.Persistence.Configurations;
internal sealed class JobTypeConfiguration : CompositeConfiguration<JobType>
{
	public override void Configure(EntityTypeBuilder<JobType> builder)
	{
		base.Configure(builder);

		_ = builder.HasNoKey();
	}
}
