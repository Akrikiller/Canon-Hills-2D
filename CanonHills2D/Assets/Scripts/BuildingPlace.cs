using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
                Debug.Log("clicked o buildingPlace");
        
        GameObject tower1 = this.transform.Find("Tower1").gameObject;
        if(tower1.active)
        tower1.SetActive(false);
        else
        tower1.SetActive(true);
        Debug.Log("clicked o buildingPlace");
    }
}
