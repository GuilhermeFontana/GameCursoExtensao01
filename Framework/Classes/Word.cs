using System.Data;

namespace Framework.Classes {
    internal class Word {

        #region Atributes
        private int RowsNumber { get; set; }
        private int ColumnsNumber { get; set; }
        private char[,] Map { get; set; }


        public Word(int rowsNumber, int columnsNumber) {
            this.RowsNumber = rowsNumber;
            this.ColumnsNumber = columnsNumber;
            this.Map = new char[rowsNumber, columnsNumber];

            Fill();
        }
        #endregion Atributes

        #region Private Methods

        private void Fill() {
            if(RowsNumber < 2 || ColumnsNumber < 2)
                throw new Exception($@"Dimensões ({RowsNumber}x{ColumnsNumber}) inválidas");

            for(int i = 0; i < RowsNumber; i++) {
                if(i == 0)
                    Map[0, 0] = '╔';
                else if(i < RowsNumber - 1)
                    Map[i, 0] = '║';
                else
                    Map[i, 0] = '╚';

                if(i == 0 || i == RowsNumber - 1)
                    for(int j = 1; j < ColumnsNumber - 1; j++)
                        Map[i, j] = '═';

                if(i == 0)
                    Map[i, ColumnsNumber - 1] = '╗';
                else if(i < RowsNumber - 1)
                    Map[i, ColumnsNumber - 1] = '║';
                else
                    Map[i, ColumnsNumber - 1] = '╝';
            }

        }
        #endregion Private Methods

        #region Public Methods
        public void Draw(int row, int col, char symbol) {
            Map[row, col] = symbol;
        }

        public void Draw(int rowStart, int columnStart, string text) {

            List<string> parts = new List<string>(text.Replace("\r", "").Trim().Split('\n'));

            int size = rowStart + parts.Count();
            if(size > RowsNumber)
                throw new Exception($"Out of bounds. Size: {size}. Limit: {RowsNumber}");

            int rowIndex = rowStart;
            int _columnStart = columnStart;
            foreach(string part in parts) {
                size = _columnStart + part.Length;
                if(size > ColumnsNumber)
                    throw new Exception($"Out of bounds. Size: {size}. Limit: {ColumnsNumber}");

                for(int columnIndex = _columnStart, index = 0; index < part.Length; columnIndex++, index++)
                    Map[rowIndex, columnIndex] = part[index];

                rowIndex++;
                _columnStart = 0;
            }
        }
        #endregion Public Methods

        #region Override
        public override string ToString() {
            string word = string.Empty;

            for(int i = 0; i < RowsNumber; i++) {
                for(int j = 0; j < ColumnsNumber; j++) {
                    word += Map[i, j] == 0 ? ' ' : Map[i, j];
                }
                word += "\n";
            }

            return word;
        }
        #endregion Override
    }
}
