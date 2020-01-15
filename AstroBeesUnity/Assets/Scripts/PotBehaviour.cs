using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotBehaviour : MonoBehaviour
{
    public string[,] colorTraits = new string[1, 2];
    public string[,] stemTraits = new string[1, 2];
    public string[,] petalTraits = new string[1, 2];
    public string[,] thornsTraits = new string[1, 2];

    public string[,] prevColor = new string[1, 2];
    public string[,] prevStem = new string[1, 2];
    public string[,] prevPetal = new string[1, 2];
    public string[,] prevThorns = new string[1, 2];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PunnettSquare()
    {
        string[,] square = new string[2, 2];
        string[,] squareResults = new string[4, 2];
        //string[,] finalResults = new string[4, 2];

        //COLOR

        //first set of traits
        square[0, 0] = colorTraits[0, 0];
        square[0, 1] = colorTraits[0, 1];
        //second set of traits
        square[1, 0] = prevColor[0, 0];
        square[1, 1] = prevColor[0, 1];

        //result 1
        squareResults[0, 0] = square[0, 0];
        squareResults[0, 1] = square[1, 0];
        //result 2
        squareResults[1, 0] = square[0, 1];
        squareResults[1, 1] = square[1, 0];
        //result 3
        squareResults[2, 0] = square[0, 0];
        squareResults[2, 1] = square[1, 1];
        //result 4
        squareResults[3, 0] = square[0, 1];
        squareResults[3, 1] = square[1, 1];

        int winner = Random.Range(0, 100);

        if(winner <= 25) //result 1
        {
            prevColor[0, 0] = squareResults[0, 0];
            prevColor[0, 1] = squareResults[0, 1];
        }
        
        else if(winner <= 50 && winner > 25) //result 2
        {
            prevColor[0, 0] = squareResults[1, 0];
            prevColor[0, 1] = squareResults[1, 1];
        }

        else if(winner <= 75 && winner > 50) //result 3
        {
            prevColor[0, 0] = squareResults[2, 0];
            prevColor[0, 1] = squareResults[2, 1];
        }

        else if(winner <= 100 && winner > 75) //result 4
        {
            prevColor[0, 0] = squareResults[3, 0];
            prevColor[0, 1] = squareResults[3, 1];
        }

        //STEM

        //first set of traits
        square[0, 0] = stemTraits[0, 0];
        square[0, 1] = stemTraits[0, 1];
        //second set of traits
        square[1, 0] = prevStem[0, 0];
        square[1, 1] = prevStem[0, 1];

        //result 1
        squareResults[0, 0] = square[0, 0];
        squareResults[0, 1] = square[1, 0];
        //result 2
        squareResults[1, 0] = square[0, 1];
        squareResults[1, 1] = square[1, 0];
        //result 3
        squareResults[2, 0] = square[0, 0];
        squareResults[2, 1] = square[1, 1];
        //result 4
        squareResults[3, 0] = square[0, 1];
        squareResults[3, 1] = square[1, 1];

        winner = Random.Range(0, 100);

        if (winner <= 25) //result 1
        {
            prevStem[0, 0] = squareResults[0, 0];
            prevStem[0, 1] = squareResults[0, 1];
        }

        else if (winner <= 50 && winner > 25) //result 2
        {
            prevStem[0, 0] = squareResults[1, 0];
            prevStem[0, 1] = squareResults[1, 1];
        }

        else if (winner <= 75 && winner > 50) //result 3
        {
            prevStem[0, 0] = squareResults[2, 0];
            prevStem[0, 1] = squareResults[2, 1];
        }

        else if (winner <= 100 && winner > 75) //result 4
        {
            prevStem[0, 0] = squareResults[3, 0];
            prevStem[0, 1] = squareResults[3, 1];
        }

        //PETAL

        //first set of traits
        square[0, 0] = petalTraits[0, 0];
        square[0, 1] = petalTraits[0, 1];
        //second set of traits
        square[1, 0] = prevPetal[0, 0];
        square[1, 1] = prevPetal[0, 1];

        //result 1
        squareResults[0, 0] = square[0, 0];
        squareResults[0, 1] = square[1, 0];
        //result 2
        squareResults[1, 0] = square[0, 1];
        squareResults[1, 1] = square[1, 0];
        //result 3
        squareResults[2, 0] = square[0, 0];
        squareResults[2, 1] = square[1, 1];
        //result 4
        squareResults[3, 0] = square[0, 1];
        squareResults[3, 1] = square[1, 1];

        winner = Random.Range(0, 100);

        if (winner <= 25) //result 1
        {
            prevPetal[0, 0] = squareResults[0, 0];
            prevPetal[0, 1] = squareResults[0, 1];
        }

        else if (winner <= 50 && winner > 25) //result 2
        {
            prevPetal[0, 0] = squareResults[1, 0];
            prevPetal[0, 1] = squareResults[1, 1];
        }

        else if (winner <= 75 && winner > 50) //result 3
        {
            prevPetal[0, 0] = squareResults[2, 0];
            prevPetal[0, 1] = squareResults[2, 1];
        }

        else if (winner <= 100 && winner > 75) //result 4
        {
            prevPetal[0, 0] = squareResults[3, 0];
            prevPetal[0, 1] = squareResults[3, 1];
        }

        //THORN

        //first set of traits
        square[0, 0] = thornsTraits[0, 0];
        square[0, 1] = thornsTraits[0, 1];
        //second set of traits
        square[1, 0] = prevThorns[0, 0];
        square[1, 1] = prevThorns[0, 1];

        //result 1
        squareResults[0, 0] = square[0, 0];
        squareResults[0, 1] = square[1, 0];
        //result 2
        squareResults[1, 0] = square[0, 1];
        squareResults[1, 1] = square[1, 0];
        //result 3
        squareResults[2, 0] = square[0, 0];
        squareResults[2, 1] = square[1, 1];
        //result 4
        squareResults[3, 0] = square[0, 1];
        squareResults[3, 1] = square[1, 1];

        winner = Random.Range(0, 100);

        if (winner <= 25) //result 1
        {
            prevThorns[0, 0] = squareResults[0, 0];
            prevThorns[0, 1] = squareResults[0, 1];
        }

        else if (winner <= 50 && winner > 25) //result 2
        {
            prevThorns[0, 0] = squareResults[1, 0];
            prevThorns[0, 1] = squareResults[1, 1];
        }

        else if (winner <= 75 && winner > 50) //result 3
        {
            prevThorns[0, 0] = squareResults[2, 0];
            prevThorns[0, 1] = squareResults[2, 1];
        }

        else if (winner <= 100 && winner > 75) //result 4
        {
            prevThorns[0, 0] = squareResults[3, 0];
            prevThorns[0, 1] = squareResults[3, 1];
        }

        //use prev traits to create the new flower in the next pot
    }
}
