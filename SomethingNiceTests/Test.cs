//-----------------------------------------------------------------------------
// File = Test.cs
//-----------------------------------------------------------------------------

namespace SomethingNiceTests
{
	using NUnit.Framework;
	using SomethingNice.TicTacToe;

	[TestFixture]
	public class Test
	{
		[Test]
		public void Test_Initialize_TicTacToeField_Standard()
		{
			var field = new Field(3, 3);

			Assert.AreEqual(9, field.Cells.Length);

			foreach (FieldCell cell in field.Cells)
			{
				Assert.IsNotNull(cell);
				Assert.AreEqual(CellValue.Empty, cell.Value);
			}
		}

		[Test]
        public void Test_Initialize_TicTacToeField_NotStandard()
        {
            var field = new Field(5, 6);

            Assert.AreEqual(30, field.Cells.Length);

            foreach (FieldCell cell in field.Cells)
            {
                Assert.IsNotNull(cell);
                Assert.AreEqual(CellValue.Empty, cell.Value);
            }
        }
	}
}
