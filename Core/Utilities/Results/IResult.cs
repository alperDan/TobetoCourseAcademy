﻿using System;
namespace Core.Utilities.Results
{
	//Temel void ler için başlangıç
	public interface IResult
	{
		bool Success { get; }
		string Message { get; }
	}
}

