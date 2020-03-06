using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamburg_script : MonoBehaviour
{
    public GameObject Menu_Panel_Inactive;
    public GameObject Menu_Panel_Active;
    public GameObject Hamburg_Panel;

    public bool Move_Menu_Panel;
    public bool Move_Menu_Panel_back;

    public float moveSpeed;
    public float tempMenuPos;

    // Start is called before the first frame update
    void Start()
    {
        Hamburg_Panel.transform.position = Menu_Panel_Inactive.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Move_Menu_Panel)
        {
            Hamburg_Panel.transform.position = Vector3.Lerp(Hamburg_Panel.transform.position, Menu_Panel_Active.transform.position, moveSpeed * Time.deltaTime);
            if(Hamburg_Panel.transform.localPosition.x == tempMenuPos)
            {
                Move_Menu_Panel = false;
                Hamburg_Panel.transform.position = Menu_Panel_Active.transform.position;
                tempMenuPos = -999999999.99f;
            }
        }
        if (Move_Menu_Panel_back)
        {
            Hamburg_Panel.transform.position = Vector3.Lerp(Hamburg_Panel.transform.position, Menu_Panel_Inactive.transform.position, moveSpeed * Time.deltaTime);
            if (Hamburg_Panel.transform.localPosition.x == tempMenuPos)
            {
                Move_Menu_Panel_back = false;
                Hamburg_Panel.transform.position = Menu_Panel_Inactive.transform.position;
                tempMenuPos = -999999999.99f;
            }
        }
    }
    public void MovePanel()
    {
        Move_Menu_Panel_back = false;
        Move_Menu_Panel = true;

        Debug.Log("Move_Menu_Panel = " + Move_Menu_Panel + "       " + "Move_Menu_Panel = " + Move_Menu_Panel_back);
    }
    public void MovePanelBack()
    {
        Move_Menu_Panel = false;
        Move_Menu_Panel_back = true;

        Debug.Log("Move_Menu_Panel = " + Move_Menu_Panel + "       " + "Move_Menu_Panel_Back = " + Move_Menu_Panel_back);
    }
}
