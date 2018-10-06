namespace SomethingNice.TicTacToe
{
	using System;

	public class Field
	{
		private readonly int numberOfRows;

		private readonly int numberOfColumns;

		private int turns;

        /// <summary>
        /// Gets the cells.
		/// 
		/// 0 | 1 | 2
		/// ----------
        /// 3 | 4 | 5
		/// ----------
        /// 6 | 7 | 8
		/// 
        /// </summary>
        /// <value>The cells.</value>
		public FieldCell[] Cells { get; private set; }

		public Field(int length = 3, int width = 3)
        {
			this.numberOfRows = length;
			this.numberOfColumns = width;
               
			this.InitializeCells();

			this.turns = 0;
        }

		private void InitializeCells()
		{
			if (Cells == null)
			{
				int numberOfCells = numberOfRows * numberOfColumns;
				this.Cells = new FieldCell[numberOfCells];

				for (int rowIndex = 0; rowIndex < numberOfRows; rowIndex ++)
				{
					for (int columnIndex = 0; columnIndex < numberOfColumns; columnIndex++)
                    {
						int index = GetIndex(rowIndex, columnIndex);
						this.Cells[index] = new FieldCell(
							rowIndex, 
							columnIndex, 
							CellValue.Empty);
                    }
				}
			}
		}

		internal bool TryPlay(int row, int column, CellValue value)
		{
			// TODO add an out parameter in order to return to
            // the user the reason why we did not accept his move was invalid.
            // Do it in a dedicated const class.
			if (row < 0 || row > this.numberOfRows
			    || column < 0 || column > this.numberOfColumns)
			{
				return false;	
			}

			if (value == CellValue.Empty)
			{
				return false;
			}

			int index = this.GetIndex(row, column);
            
			// TODO move this as part of the cell logic with a Modify(value)
			// method.
			if (this.Cells[index].Value != CellValue.Empty)
			{
				return false;
			}

			this.Cells[index].Value = value;

			this.turns++;

			return true;
		}

        internal bool IsFieldFull()
		{
			return this.turns == this.Cells.Length;
		}

		private int GetIndex(int row, int column)
		{
			return row * numberOfRows + column;
		}

		internal void DisplayField()
		{
			// TODO make generic, only 3x3 now.
			Console.WriteLine(this.Cells[0] + " | " + this.Cells[1] + " | " + this.Cells[2]);
            Console.WriteLine(this.Cells[3] + " | " + this.Cells[4] + " | " + this.Cells[5]);
            Console.WriteLine(this.Cells[6] + " | " + this.Cells[7] + " | " + this.Cells[8]);
		}

		internal void ClearField()
		{
			if (Cells != null)
			{
				Cells = null;	
			}	
		}
    }
}
