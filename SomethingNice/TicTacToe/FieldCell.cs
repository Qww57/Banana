namespace SomethingNice.TicTacToe
{
	using System;

    public struct FieldCell
    {
		public int Row { get; }

		public int Column { get; }

		public CellValue Value { get; set; }
        
		public FieldCell(int row, int column, CellValue value)
        {
			this.Row = row;
			this.Column = column;
			this.Value = value;
        }

		public override string ToString()
		{
			return FieldCell.CellValueToString(this.Value);
		}

		public static string CellValueToString(CellValue value)
		{
			switch (value)
			{
				case CellValue.Empty:
					return " ";
				case CellValue.Cross:
					return "X";
				case CellValue.Circle:
					return "O";
				default:
					throw new Exception("Unexpected cell value");
			}
		}
	}
}
