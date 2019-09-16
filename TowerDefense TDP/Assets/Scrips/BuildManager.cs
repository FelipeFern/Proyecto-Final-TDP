
using UnityEngine;
using UnityEngine.EventSystems;

//Clase encargada de la creacion de las torretas.
public class BuildManager : MonoBehaviour
{

    //Singleton para crear las torretas.
    public static BuildManager instance;
    //TorretaCorta
    public GameObject turretPrefab1;
    //TorretaLarga
    public GameObject turretPrefab2; 

    private BuildTurrets turretToBuild;

   
    public bool CanBuild
    {
        get { return turretToBuild != null; }
    }

    public bool HasMoney
    {
        get { return Player.money >= turretToBuild.cost; }
    }

    public void SetTurret(BuildTurrets turret)
    {
        turretToBuild = turret;
    }


    public void BuildTurret(Nodo nodoP)
    {
        if(Player.money < turretToBuild.cost)
        {
            Debug.Log("No hay suficiente dinero.");
            return;
        }

        Player.money -= turretToBuild.cost;
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, nodoP.GetPositionToBuild(), Quaternion.identity);
        nodoP.torreta = turret;  


    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.Log(" Hay mas de una instancia del BuildManager");
    }
    
    
    public  static BuildManager getInstance()
    {              
        return instance;
    }

}
