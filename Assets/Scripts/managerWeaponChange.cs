using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerWeaponChange : MonoBehaviour
{

    private managerWeapon mngrWeapon;
    public Transform pivotR;
    private int indexPreviousWeapon;
    // Start is called before the first frame update
    void Start()
    {
        mngrWeapon = GameObject.Find("managerWeapon").GetComponent<managerWeapon>();

        GameObject tempDefaultweapon = mngrWeapon.weapons[0];
        Instantiate(tempDefaultweapon, pivotR);
        indexPreviousWeapon = 0;
    }

    public void ChangeWeapon(int weaponIndex)
    {
 
        //Destroy(pivotR.GetChild(0).gameObject);
        if(weaponIndex != indexPreviousWeapon)
        {
            Destroy(pivotR.GetChild(0).gameObject);
            GameObject tempWeapon = mngrWeapon.weapons[weaponIndex];
            Instantiate(tempWeapon, pivotR);

            indexPreviousWeapon = weaponIndex;
        }

       
    }
 
}
