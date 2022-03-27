using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tip : MonoBehaviour
{
    public GameObject tip;

    // Update is called once per frame
    void Update()
    {
        Destroy(tip,2f);
    }
}
