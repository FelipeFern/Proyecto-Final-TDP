
using UnityEngine;

public class Boton : MonoBehaviour
{
    BuildManager buildManager;

    //Prefabs de las torretas
    public BuildTurrets shortTurret;
    public BuildTurrets longTurret;

   
    // Start is called before the first frame update
    void Start()
    {
        buildManager = BuildManager.getInstance(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyTurret1()
    {
        buildManager.setTurret(shortTurret);
    }

    public void BuyTurret2()
    {
        buildManager.setTurret(longTurret);

    }


}
