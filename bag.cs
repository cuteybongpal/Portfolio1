using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bag : MonoBehaviour
{
    public GameObject[] blockStack = new GameObject[7];
    // Start is called before the first frame update
    void Start()
    {
        baag();
    }
    public void baag(){
        Instantiate(blockStack[Random.Range(0,blockStack.Length)], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
