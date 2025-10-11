using Microsoft.AspNetCore.Components;
using System.Text;

namespace Blazor.Components.MathF
{
	public partial class Fibonacci : ComponentBase
	{
		private int _count;
		private readonly List<long> sequence = new();
		private int Count
		{
			get => _count;
			set
			{
				_count = value < 0 ? 0 : value; 
				Generate();
			}
		}
		private void Generate()
		{
			sequence.Clear();
			long a = 0, b = 1;
			for (int i = 0; i < _count; i++)
			{
				sequence.Add(a);
				(a, b) = (b, a + b);
			}
		}
	}
	
}