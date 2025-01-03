﻿namespace BB84.EntityFrameworkCore.Models.Abstractions.Components;

/// <summary>
/// The interface for enumerator based components.
/// </summary>
public interface IEnumerator
{
	/// <summary>
	/// The name of the enumerator.
	/// </summary>
	string Name { get; set; }

	/// <summary>
	/// The description of the enumerator.
	/// </summary>
	string? Description { get; set; }
}
