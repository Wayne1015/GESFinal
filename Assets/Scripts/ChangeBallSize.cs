using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBallSize : MonoBehaviour {
    [SerializeField]
    private GameObject bigSphere;
    [SerializeField]
    private GameObject smallSphere;
    // Use this for initialization


    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "FPSController")
        {
            Destroy(bigSphere);
            smallSphere.SetActive(true);
        }
    }

}
