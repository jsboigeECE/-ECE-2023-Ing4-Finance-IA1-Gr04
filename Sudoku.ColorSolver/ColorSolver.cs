using System.Drawing;
using Sudoku.Shared;


namespace Sudoku.ColorSolver
{
    public class ColorSolver : ISudokuSolver
    {
        private int V;
        private int[,] graph;

        public ColorSolver(int V) // Constructeur de la classe
        {
         
            this.V = V;
            this.graph = new int[V, V];
        }

        public ColorSolver(): this(9)
        {

        }
        
        
        private bool is_safe(int v, int c, int[] color) // Fonction pour vérifier si la couleur est valide
        {
            for (int i = 0; i < this.V; i++)
            {
                if (this.graph[v, i] == 1 && color[i] == c)
                {
                    return false;
                }
            }
            return true;
        }

        private bool graph_coloring(int m, int[] color, int v) // Fonction de coloriage du graphe
        {
            
            if (v == this.V)
            {
                return true;
            }

            for (int c = 1; c <= m; c++)
            {
                if (is_safe(v, c, color))
                {
                    color[v] = c;
                    if (graph_coloring(m, color, v + 1))
                    {
                        return true;
                    }
                    color[v] = 0;
                }
            }
            
            return false;
        }

        public int[,] solve_sudoku(int[,] sudoku) // Fonction pour résoudre le Sudoku
        {
            int[] color = new int[this.V];

            for (int i = 0; i < this.V; i++)
            {
                for (int j = 0; j < this.V; j++)
                {
                    if (sudoku[i, j] != 0)
                    {
                        int c = sudoku[i, j];
                        this.graph[i, j] = 1;
                        color[i * this.V + j] = c;
                    }
                }
            }

            int m = this.V;
            graph_coloring(m, color, 0);

            for (int i = 0; i < this.V; i++)
            {
                for (int j = 0; j < this.V; j++)
                {
                    sudoku[i, j] = color[i * this.V + j];
                }
            }

            return sudoku;
        }

        SudokuGrid ISudokuSolver.Solve(SudokuGrid s) // Fonction pour résoudre le Sudoku dans la grille donnée
        {
            int[,] sudoku = new int[9, 9]; // Création d'une nouvelle matrice pour stocker les valeurs de la grille

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = s.Cells[i][j]; // Copie des valeurs de la grille dans la nouvelle matrice
                }
            }
            
            sudoku = solve_sudoku(sudoku); // Appel de la fonction solve_sudoku pour résoudre le Sudoku

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    s.Cells[i][j] = sudoku[i, j]; // Copie des valeurs de la nouvelle matrice dans la grille originale
                }
            }
            return s;
        }
    }
}


/*
using System.Drawing;
using Sudoku.Shared;

namespace Sudoku.ColorSolver
{
    public class ColorSolver : ISudokuSolver
    {

        SudokuGrid ISudokuSolver.Solve(SudokuGrid s)
        {

            int[,] sudoku;

            //Méthode pour utiliser un tableau format int[,] au lieu de [][] imposé
            //par le format de base
            //On créer donc un tableau int[,] qui prend toutes les valeurs de la
            //grille de sudoku en paramètre
            sudoku = Convertion(s);

            //Appel de la méthode de résolution
            SolverColor(sudoku, 0, 0);

            //Boucle pour mettre à jour le tableau du suduko à retourner à partir du
            //tableau sur lequel on a fait les modifications
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    s.Cells[i][j] = sudoku[i, j];

            return s;
        }

        public int[,] Convertion(SudokuGrid s)
        {

            int[,] sudok = new int[10, 10];

            //On remplace chaque case du nouveau tableau par la grille passée en
            //paramètre
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    sudok[i, j] = s.Cells[i][j];

            return sudok;
        }
   
        // La fonction pour vérifier si un nombre peut être placé dans une case
        static bool CanPlace(int row, int col,int[,] grid, int num)
        {
            int size = 9;
            // Vérifie si une case a deja la meme couleur dans la rangée
            for (int i = 0; i < size; i++)
            {
                if (grid[row, i] == num)
                {
                    return false;
                }
            }

            // Vérifie si une case a deja la meme couleur dans la colonne
            for (int i = 0; i < size; i++)
            {
                if (grid[i, col] == num)
                {
                    return false;
                }
            }
            // Vérifie si une case a deja la meme couleur dans la sous-grille 3x3
            int subgridSize = (int)Math.Sqrt(size);
            int subgridRow = row / subgridSize * subgridSize;
            int subgridCol = col / subgridSize * subgridSize;
            for (int i = subgridRow; i < subgridRow + subgridSize; i++)
            {
                for (int j = subgridCol; j < subgridCol + subgridSize; j++)
                {
                    if (grid[i, j] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }





        static bool SolverColor(int[,] grid, int row, int col)
        {

            // Cherche la première case vide
            int size = 9;
            bool isEmpty = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        isEmpty = true;
                        break;
                    }
                }
                if (isEmpty)
                {
                    break;
                }
            }
            // Si toutes les cases sont remplies, le Sudoku est résolu
            if (!isEmpty)
            {
                return true;
            }
            // Cherche le premier nombre qui peut être placé dans la case
            for (int num = 1; num <= size; num++)
            {
                if (CanPlace(row, col,grid, num))
                {
                    grid[row, col] = num;

                    // Si le Sudoku est résolu avec ce nombre, retourne vrai
                    if (SolverColor(grid,row,col))
                    {
                        return true;
                    }

                    // Sinon, essaie avec un autre nombre
                    grid[row, col] = 0;
                }
            }
            // Si aucun nombre ne fonctionne, retourne faux
            return false;
        }




    }
}

*/
