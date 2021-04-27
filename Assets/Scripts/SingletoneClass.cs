using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletoneClass : MonoBehaviour
{
    private static int _rootInt;

    public static int SINGLETONINT { get { return _rootInt; } set { _rootInt = value; } }
}
