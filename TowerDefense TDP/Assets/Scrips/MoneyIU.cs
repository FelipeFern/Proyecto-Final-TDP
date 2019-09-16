using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyIU : MonoBehaviour
{

    public Text moneyText;
 
    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + Player.money.ToString();
       
    }
}
