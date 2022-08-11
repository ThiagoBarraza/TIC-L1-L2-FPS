using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField] GameObject[] sillas;
    private bool DeactivatedARR = false;


    // Start is called before the first frame update
    void Start()
    {
        sillas = GameObject.FindGameObjectsWithTag("Silla");
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (DeactivatedARR)
            {
                DeactivateARR(sillas, true);
                DeactivatedARR = false;
                Debug.Log("Activated");
            }
            else
            {
                DeactivateARR(sillas, false);
                DeactivatedARR = true;
                Debug.Log("Deactivated");
            }
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            AddRigidBodyToARR(sillas);
        }
    }

    void DeactivateARR(GameObject[] Array, bool ActiveorUnactive)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i].SetActive(ActiveorUnactive);
        }
    }

    void AddRigidBodyToARR(GameObject[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i].AddComponent<Rigidbody>();
        }
    }
}
