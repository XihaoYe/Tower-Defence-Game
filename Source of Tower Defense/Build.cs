using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    public GameObject notEnough;
    private static string[] tags = new string[] { "Turret" };


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit1;
            if (Physics.Raycast(ray1, out hit1))
            {
                GameObject C = hit1.collider.gameObject;
                if (C.name == "Archer Warrior" && Player.Money >= 100)
                {
                    GameObject archer = ArcherPool.SharedInstance.GetAppearedArcher();
                    archer.transform.position = new Vector3(C.transform.position.x + 0.7f, .4f, C.transform.position.z + 0.7f);
                    archer.SetActive(true);
                    Player.Money -= 100;
                    ArcherPool.remainArc -= 1;
                    Node.built.transform.gameObject.tag = "Turret";
                }
                else if (C.name == "Archer Warrior" && Player.Money < 100)
                {
                    notEnough.SetActive(true);
                    Invoke("fade", 2f);
                }

                if (C.name == "Mage Warrior" && Player.Money >= 150)
                {
                    GameObject mage = MagePool.SharedInstance.GetAppearedMage();
                    mage.transform.position = new Vector3(C.transform.position.x - 0.7f, .4f, C.transform.position.z + 0.7f);
                    mage.SetActive(true);
                    Player.Money -= 150;
                    MagePool.remainMag -= 1;
                    Node.built.transform.gameObject.tag = "Turret";
                }
                else if (C.name == "Mage Warrior" && Player.Money < 150)
                {
                    notEnough.SetActive(true);
                    Invoke("fade", 2f);
                }
            }
        }
    }

    void fade()
    {
        notEnough.SetActive(false);
    }
}
