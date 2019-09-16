using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodo : MonoBehaviour
{
    
    private Color colorComienzo;
    public Color haveMoneyColor;
    public Color haveNotMoneyColor;

    public Vector3 posicion;

    private Renderer rend;

    public GameObject torreta;

    private BuildManager buildManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        colorComienzo = rend.material.color;
        buildManager = BuildManager.getInstance();
    }

    
    public Vector3 GetPositionToBuild()
    {
        return transform.position + posicion;

    }
    

    //Si se dan las condiciones (tenes plata y no hay nada) podes poner una torreta
    private void OnMouseDown()
    {
        if (!buildManager.CanBuild)
            return;
       

        if(torreta != null)
        {
            Debug.Log(" Ya hay algo aca");
            return;
        }

        //Crear la torreta en el propio nodo.

        buildManager.BuildTurret(this);
                             
    }
     
    //Cuando pasas por arriba del nodo cambia de color al correspondiente.
    private void OnMouseEnter()
    {
        if (!buildManager.CanBuild)
            return;

        if(buildManager.HasMoney)
        {
            rend.material.color = haveMoneyColor;
        }
        else
        {
            rend.material.color = haveNotMoneyColor;
        }
    }
    //Cuando salis del nodo vuelve a su color original.
    private void OnMouseExit()
    {
        rend.material.color = colorComienzo;
    }
}
