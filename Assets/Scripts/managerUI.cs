using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class managerUI : MonoBehaviour
{

    private managerWeaponChange mngrWeaponChange;
    // Start is called before the first frame update
    void Start()
    {
        mngrWeaponChange = GameObject.FindGameObjectWithTag("Player").GetComponent<managerWeaponChange>();
    }

    public void ButtonWeaponChange()
    {
        GameObject tempBtn = EventSystem.current.currentSelectedGameObject;
        int tempBtnindex = tempBtn.transform.GetSiblingIndex();

        mngrWeaponChange.ChangeWeapon(tempBtnindex);

        //Debug.Log(tempBtn + ":" + tempBtnindex);
    }
}
