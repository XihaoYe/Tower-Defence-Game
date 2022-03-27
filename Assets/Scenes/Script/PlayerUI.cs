using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text MoneyAmount;
    public Text ArcherAmount;
    public Text MageAmount;

    // Update is called once per frame
    void Update()
    {
        MoneyAmount.text = "$" + Player.Money.ToString();
        ArcherAmount.text = "Archer($100): " + ArcherPool.remainArc.ToString() + "/" + ArcherPool.totalArc.ToString();
        MageAmount.text = "Mage($150): " + MagePool.remainMag.ToString() + "/" + MagePool.totalMag.ToString();
    }
}
