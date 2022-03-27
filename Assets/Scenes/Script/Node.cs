using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject tileHighlightPrefab;
    public GameObject arc;
    public GameObject mag;
    public GameObject upgrade;
    public static GameObject built;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go.tag == "Build")
                {
                    arc.SetActive(true);
                    arc.transform.position = new Vector3(go.transform.position.x - 0.7f, 1.2f, go.transform.position.z - 0.7f);
                    mag.SetActive(true);
                    mag.transform.position = new Vector3(go.transform.position.x + 0.9f, 1.2f, go.transform.position.z - 0.7f);
                    tileHighlightPrefab.transform.position = go.transform.position;
                    built = go;
                }
                else if (go.tag == "Turret")
                {
                    upgrade.SetActive(true);
                    upgrade.transform.position = new Vector3(go.transform.position.x, 1.2f, go.transform.position.z);
                    tileHighlightPrefab.transform.position = go.transform.position;
                }
                else
                {
                    tileHighlightPrefab.transform.position = new Vector3(go.transform.position.x, -10.2f, go.transform.position.z);
                    arc.transform.position = new Vector3(go.transform.position.x, -10.2f, go.transform.position.z);
                    mag.transform.position = new Vector3(go.transform.position.x, -10.2f, go.transform.position.z);
                    upgrade.transform.position = new Vector3(go.transform.position.x, -10.2f, go.transform.position.z);
                }
            }
        }
    }
}
