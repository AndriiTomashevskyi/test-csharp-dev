﻿using System;

namespace TaxCalculator.Domain.Exceptions
{
	public abstract class NotFoundException : Exception
	{
		protected NotFoundException(string message) : base(message)
		{
		}
	}
}

