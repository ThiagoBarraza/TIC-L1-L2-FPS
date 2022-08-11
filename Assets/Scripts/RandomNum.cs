using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNum : MonoBehaviour
{
    [SerializeField] int RandomNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GenerateRandomNum();
            Debug.Log("Randomized" + RandomNumber);
        }
    }

    void GenerateRandomNum()
    {
        RandomNumber = Random.Range(0, 16);
    }
}
