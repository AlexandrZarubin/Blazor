using Microsoft.AspNetCore.Components;
using System;

namespace Blazor.Components.Converters;

public partial class Converter : ComponentBase
{
	// ---- Dec  Bin ----
	private int _decValue;
	private string BinResult = "0";

	private int DecValue
	{
		get => _decValue;
		set
		{
			_decValue = value;
			int abs = Math.Abs(_decValue);
			string s = Convert.ToString(abs, 2);
			string sign = _decValue < 0 ? "-" : "";
			BinResult = sign + s;
		}
	}

	// ---- Hex  Dec ----
	private string _hexText = string.Empty;
	private string HexResult = string.Empty;

	private string HexText
	{
		get => _hexText;
		set
		{
			_hexText = (value ?? string.Empty).Trim().Replace(" ", "");
			if (_hexText.Length == 0) { HexResult = ""; return; }

			try
			{
				long dec = Convert.ToInt64(_hexText, 16);
				HexResult = dec.ToString();
			}
			catch
			{
				HexResult = "Invalid";
			}
		}
	}

	// ---- Bin  Dec ----
	private string _binText = string.Empty;
	private string DecResult = string.Empty;

	private string BinText
	{
		get => _binText;
		set
		{
			_binText = (value ?? string.Empty).Trim().Replace(" ", "");
			if (_binText.Length == 0)
			{
				DecResult = string.Empty;
				return;
			}

			try
			{
				int dec = Convert.ToInt32(_binText, 2); // <<< вот он, простой bin2dec
				DecResult = dec.ToString();
			}
			catch
			{
				DecResult = "Invalid";
			}
		}
	}

	// ---- Dec  Hex ----
	private int _decHexValue;
	private string DecHexResult = "0";

	private int DecHexValue
	{
		get => _decHexValue;
		set
		{
			_decHexValue = value;

			int abs = Math.Abs(_decHexValue);
			string sign = _decHexValue < 0 ? "-" : "";

			DecHexResult = sign + Convert.ToString(abs, 16).ToUpperInvariant();
			DecHexResult = sign + "0x" + Convert.ToString(abs, 16).ToUpperInvariant();
		}
	}


}
