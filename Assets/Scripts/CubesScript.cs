using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubesScript : MonoBehaviour, IActivatiable {
   
    //[SerializeField]
    //public Renderer rend2;
    
    [SerializeField]
    private Material[] materials;
    [SerializeField]
    private Renderer rend;
    private LockMechanism cubes;
    private int white = 0;
    private int red = 1;
    [SerializeField]
    private Light cubeLight;
    


    public void Do()
    {
        
        //if (this.transform.name == "Cube#1")
        //{
        //    cubes.Cube1Collected = true;
        //    cubeLight.enabled = false;

        //}
        //if (this.transform.name == "Cube#2")
        //{
        //    cubes.Cube2Collected = true;
        //    cubeLight.enabled = false;
        //}
        //if(this.transform.name == "Cube#3")
        //{
        //    cubes.Cube3Collected = true;
        //    cubeLight.enabled = false;
        //}
        //if(this.transform.name == "BigAssSphere")
        //{
        //    cubes.Sphere1Collected = true;
        //}
        //rend.sharedMaterial = materials[red];
        
      

    }

 


    // Use this for initialization
    void Start()
    {
       
        
        cubes = GameObject.Find("Lvl1Manager").GetComponent<LockMechanism>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[white];
    }

    // Update is called once per frame
    void Update()
    {

    }

}
