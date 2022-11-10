using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHit : MonoBehaviour
{
    private string hit1 = "Hit";
    private string hit2 = "Hit2";

    public string GetRandomHit()
    {
        var random = Random.Range(1, 3);
        if (random == 1)
        {
            return hit1;
        }
        if (random == 2)
        {
            return hit2;
        }
        
        return null;
        
    }
    // Start is called before the first frame update

}
