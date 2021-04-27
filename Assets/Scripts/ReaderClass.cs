using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaderClass : MonoBehaviour
{
    public int score;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SingletoneClass.SINGLETONINT++;
            score = SingletoneClass.SINGLETONINT;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SingletoneClass.SINGLETONINT--;
            score = SingletoneClass.SINGLETONINT;
        }
    }
}
