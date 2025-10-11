using Microsoft.AspNetCore.Components;
using System.Numerics; // BigInteger

namespace Blazor.Components.MathF;

public partial class Factorial : ComponentBase
{
	private int _n;
	private readonly List<string> lines = new();

	private int N
	{
		get => _n;
		set
		{
			_n = value < 0 ? 0 : value;
			BuildTable();
		}
	}

	private void BuildTable()
	{
		lines.Clear();

		if (_n == 0) return;   

		BigInteger acc = BigInteger.One;
		for (int i = 1; i <= _n; i++)
		{
			acc *= i;                          
			lines.Add($"{i}! = {acc}");        
		}
	}
}
