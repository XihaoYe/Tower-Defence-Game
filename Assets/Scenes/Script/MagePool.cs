using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagePool : MonoBehaviour
{
    public static MagePool SharedInstance;
    public List<GameObject> appearedMage;
    public GameObject magePool;
    public int amountToMage;
    public static int remainMag;
    public static int totalMag;

    private void Awake()
    {
        SharedInstance = this;
        remainMag = amountToMage;
        totalMag = amountToMage;
    }

    // Start is called before the first frame update
    void Start()
    {
        appearedMage = new List<GameObject>();
        for (int i = 0; i < amountToMage; i++)
        {
            GameObject obj = (GameObject)Instantiate(magePool);
            obj.SetActive(false);
            appearedMage.Add(obj);
        }
    }

    public GameObject GetAppearedMage()
    {
        for (int i = 0; i < appearedMage.Count; i++)
            if (!appearedMage[i].activeInHierarchy)
                return appearedMage[i];
        return null;
    }
}
