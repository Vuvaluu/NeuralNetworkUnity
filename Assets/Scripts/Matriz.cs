using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Matriz : MonoBehaviour
{
    public void Matrix(int _rows, int _columns)
    {
        float[,] matrix1 = new float[_rows, _columns];
        float[,] matrix2 = new float[_rows, _columns];

        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _columns; j++)
            {
               
            }
        }
    }
    public void GetAt(int x, int y)
    {
        
    }

    public void SetAt(int x, int y)
    {

    }

    //public static MatrixOperator (Matriz m1, Matriz m2){
       // }

    public void Transpose()
    {
        
    }

    public void Print()
    {
        
    }
}
