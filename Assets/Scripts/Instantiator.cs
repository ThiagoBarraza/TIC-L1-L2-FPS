using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField] GameObject[] Objects;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instance(Objects[Random.Range(0, Objects.Length)]);
        }
    }

    void Instance(GameObject Objeto)
    {
        Instantiate(Objeto, transform.position, transform.rotation);
    }
}
