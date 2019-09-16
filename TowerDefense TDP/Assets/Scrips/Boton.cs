
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    BuildManager buildManager;

    //Prefabs de las torretas
    public BuildTurrets shortTurret;
    public BuildTurrets longTurret;

    public Text MoneyTurretShort;
    public Text MoneyTurretLong;

    // Start is called before the first frame update
    void Start()
    {
        buildManager = BuildManager.getInstance();
        MoneyTurretShort.text = "$" + shortTurret.cost.ToString();
        MoneyTurretLong.text = "$" + longTurret.cost.ToString();
    }

    public void BuyTurret1()
    {
        buildManager.SetTurret(shortTurret);
    }

    public void BuyTurret2()
    {
        buildManager.SetTurret(longTurret);
       
    }


}
