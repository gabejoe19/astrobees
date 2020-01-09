using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotBehaviour : MonoBehaviour
{
    public string[,] colorTraits;
    public string[,] stemTraits;
    public string[,] petalTraits;
    public string[,] thornsTraits;

    public string[,] prevColor;
    public string[,] prevStem;
    public string[,] prevPetal;
    public string[,] prevThorns;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PunnettSquare(string[,] traits, string[,] prevTraits)
    {
        string[,] square = new string[2, 2];
        string[,] results = new string[4, 2];
        
        //first set of traits
        square[0, 0] = traits[0, 0];
        square[0, 1] = traits[0, 1];
        //second set of traits
        square[1, 0] = prevTraits[0, 0];
        square[1, 1] = prevTraits[0, 1];

        //result 1
        results[0, 0] = square[0, 0];
        results[0, 1] = square[1, 0];
        //result 2
        results[1, 0] = square[0, 1];
        results[1, 1] = square[1, 0];
        //result 3
        results[2, 0] = square[0, 0];
        results[2, 1] = square[1, 1];
        //result 4
        results[3, 0] = square[0, 1];
        results[3, 1] = square[1, 1];

        int winner = Random.Range(0, 100);

        if(winner <= 25)
        {

        }
        
        else if(winner <= 50 && winner > 25)
        {

        }

        else if(winner <= 75 && winner > 50)
        {

        }

        else if(winner <= 100 && winner > 75)
        {
            
        }
    }
}
