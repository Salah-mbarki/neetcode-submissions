public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int , HashSet<int>> row = new Dictionary<int , HashSet<int>>();
        Dictionary<int , HashSet<int>> col = new Dictionary<int , HashSet<int>>();
        Dictionary<string , HashSet<int>> square = new Dictionary<string , HashSet<int>>();
        for (int r = 0 ; r < 9 ; r++)
        {
            for (int c =0 ; c< 9; c++)
            {
                if(board[r][c] == '.')
                {
                    continue ;
                }
                string squareKey = (r/3) + "," + (c/3);

                if(row.ContainsKey(r) && row[r].Contains(board[r][c]) || col.ContainsKey(c) && col[c].Contains(board[r][c]) || square.ContainsKey(squareKey) && square[squareKey].Contains(board[r][c]))
                {
                    return false ;
                }
                if(!row.ContainsKey(r)){ row[r] = new HashSet<int>(); }
                if(!col.ContainsKey(c)){ col[c] = new HashSet<int>(); }
                if(!square.ContainsKey(squareKey)){ square[squareKey] = new HashSet<int>(); }

                row[r].Add(board[r][c]);
                col[c].Add(board[r][c]);
                square[squareKey].Add(board[r][c]);
            }
        }
        return true ;
    }
}
