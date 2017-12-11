using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockMechanism : MonoBehaviour {

    [SerializeField]
    public bool Key1Collected;//
    [SerializeField]
    public bool Key2Collected;
    [SerializeField]
    public bool Key3Collected;
    [SerializeField]
    public bool Key4Collected;
    [SerializeField]
    public bool Key5Collected;
    [SerializeField]
    private GameObject superKey;
    private bool Lighton = false;



   

    private CheckIfWon checkIfWon;

 
   
   

    [SerializeField]
    private GameObject Lvl2;

    [SerializeField]
    private GameObject lvl1;
    [SerializeField]
    private Light doorLight;

   

    private int white = 0;//In materials[] 0 is white and 1 is red

    // Use this for initialization


    //IEnumerator ChangeLevel()//Called when cube1 and 2 are pressed
    //{







    //    yield return new WaitForSeconds(DoorTimer);



    //    //////////////////////////////////////////////////////////// Wait 3 seconds then

    //    ////LeftLight.enabled = true; //Light above left cube on
    //    ////RightLight.enabled = true;//Light above right cube on


    //    //Cube1rend.sharedMaterial = materials[white];//Cube1 material changes to white
    //    //Cube2rend.sharedMaterial = materials[white];//Cube2 material changes to white
    //    //Cube1Pressed = false; //Reset door opening bools
    //    //Cube2Pressed = false;//Reset door opening bools

    //    //door2.SetBool("isOpened", false);

    //}


    // Update is called once per frame
    private void Start()
    {
        checkIfWon = GameObject.Find("WinManager").GetComponent<CheckIfWon>();
    }
    void FixedUpdate () {


        if (Lighton == false)
        {
            if (Key1Collected == true && Key2Collected == true && Key3Collected == true && Key4Collected == true && Key5Collected)//If cube1 and cube2 are activated
            {

                Lighton = true;
                doorLight.enabled = true;
                superKey.SetActive(true);
                


            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "FPSController")
        {
            Destroy(lvl1);
            checkIfWon.OnLvl2 = true;
            //lvl1.gameObject.SetActive(false);//Not Sure which is better using destory gives me an error saying to 
            Lvl2.gameObject.SetActive(true);
            
        }
    }
}
