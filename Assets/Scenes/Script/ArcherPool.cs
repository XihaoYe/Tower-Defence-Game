using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherPool : MonoBehaviour
{
    public static ArcherPool SharedInstance;
    public List<GameObject> appearedArcher;
    public GameObject archerPool;
    public int amountToArcher;
    public static int remainArc;
    public static int totalArc;

    private void Awake()
    {
        SharedInstance = this;
        remainArc = amountToArcher;
        totalArc = amountToArcher;
    }

    // Start is called before the first frame update
    void Start()
    {
        appearedArcher = new List<GameObject>();
        for (int i = 0; i < amountToArcher; i++)
        {
            GameObject obj = (GameObject)Instantiate(archerPool);
            obj.SetActive(false);
            appearedArcher.Add(obj);
        }
    }

    public GameObject GetAppearedArcher()
    {
        for (int i = 0; i < appearedArcher.Count; i++)
            if (!appearedArcher[i].activeInHierarchy)
                return appearedArcher[i];
        return null;
    }
}
