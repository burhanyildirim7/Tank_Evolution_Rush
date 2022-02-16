using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapiScript : MonoBehaviour
{
    public static KapiScript instance;

    public int _kapiDegeri;

    private void Awake()
    {
        if (instance == null) instance = this;
        //else Destroy(this);
    }

}
