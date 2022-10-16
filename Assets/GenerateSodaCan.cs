using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSodaCan : MonoBehaviour
{
    public GameObject sodaCan;
    public Transform parent;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddObject()
    {
        GameObject newSodaCan = Instantiate(sodaCan, parent, false);
        newSodaCan.SetActive(true);
    }
}
