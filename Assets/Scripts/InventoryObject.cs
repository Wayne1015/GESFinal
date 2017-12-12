using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable
{
    [SerializeField]
    private string nameText;

    [SerializeField]
    private string descriptionText;
    private Lvl2Manager lvl2Manager;
    private MeshRenderer meshRenderer;
    private InventoryMenu inventoryMenu;
    private Collider collider;
    private LockMechanism cubes;
    [SerializeField]
    private Light cubeLight;
    [SerializeField]
    private GameObject keyToSpawnIn;
    private CheckIfWon checkIfWon;
    [SerializeField]
    private AudioSource pickUpSound;
    [SerializeField]
    public GameObject mysteriousStairs;

    public string NameText

    {
        get
        {
            return nameText;
        }
    }
   

    public string DescriptionText { get { return descriptionText; } }

    private void Awake()
    {
        inventoryMenu = FindObjectOfType<InventoryMenu>();
        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
        cubes = GameObject.Find("Lvl1Manager").GetComponent<LockMechanism>();
        checkIfWon = GameObject.Find("WinManager").GetComponent<CheckIfWon>();


    }
    public void DoActivate()
    {
        inventoryMenu.PlayerInventory.Add(this);
        pickUpSound.Play();
        if (checkIfWon.OnLvl2 == false)
            
        {
            if (this.transform.name == "Key#1")
            {
                cubes.Key1Collected = true;
                cubeLight.enabled = false;
                mysteriousStairs.SetActive(true);
                
                
                

            }
            else if (this.transform.name == "Key#2")
            {
                cubes.Key2Collected = true;
                cubeLight.enabled = false;
            }
            else if (this.transform.name == "Key#3")
            {
                cubes.Key3Collected = true;
                cubeLight.enabled = false;
            }
             else if (this.transform.name == "BigAssSphere")
            {
                cubes.Key4Collected = true;
                cubeLight.enabled = false;
            }
            else if (this.transform.name == "BigAssSphere2")
            {
                cubes.Key5Collected = true;
                cubeLight.enabled = false;
            }
            else if(this.transform.name == "PickupableNote")
            {
                cubeLight.enabled = false;
            }
            else if (this.transform.name == "SuperKey#1")
            {
                cubeLight.enabled = false;
                checkIfWon.WinObjectNumber1Got = true;


            }
        }
        if(checkIfWon.OnLvl2 == true)
        {
            if (lvl2Manager == null)
            {
                lvl2Manager = GameObject.Find("Lvl2Manager").GetComponent<Lvl2Manager>();
            }
            if(lvl2Manager != null)
            {


                if (this.transform.name == "Key#4")
                {
                    lvl2Manager.fakeDoors[2].SetActive(false);
                    cubeLight.enabled = false;

                }
                else if (this.transform.name == "Key#5")
                {
                    lvl2Manager.fakeDoors[1].SetActive(false);
                    lvl2Manager.fakeDoors[0].SetActive(true);
                    cubeLight.enabled = false;
                }
                else if(this.transform.name == "Key#6")
                {
                    cubeLight.enabled = false;
                }
                else if (this.transform.name == "SuperKey#2")
                {
                    cubeLight.enabled = false;
                    checkIfWon.WinObjectNumber2Got = true;
                }

                else if(this.transform.name == "PickupableNote#3")
                {
                    lvl2Manager.fakeDoors[0].SetActive(false);
                    cubeLight.enabled = false;
                    lvl2Manager.door.SetBool("isDoorOpen", false);
                }
                else if (this.transform.name == "PickupableNote#4")
                {
                    lvl2Manager.fakeDoors[3].SetActive(false);
                    cubeLight.enabled = false;
                    
                }
                else if(this.transform.name == "PickupableNote#5")
                {
                    lvl2Manager.fakeDoors[4].SetActive(false);
                    lvl2Manager.fakeDoors[3].SetActive(true);
                    cubeLight.enabled = false;
                }
                else if (this.transform.name == "PickupableNote#6")
                {
                    lvl2Manager.fakeDoors[4].SetActive(true);
                    lvl2Manager.fakeDoors[5].SetActive(false);
                    keyToSpawnIn.SetActive(true);
                    cubeLight.enabled = false;
                }
                else if(this.transform.name == "PickupableNote#7")
                {
                    cubeLight.enabled = false;
                    lvl2Manager.fakeDoors[6].SetActive(false);
                }
            }
        }

        // Doing this rather than destroy because our Inventory menu still needs
        // to know about this object even though it has been collected and 
        // removed from the 3D world.
        // Also, if you wanted to add sound effects here,
        // and we destroy before the sfx are done, it will not sound correct.
        // Just like how coin worked in our 2D project!
        meshRenderer.enabled = false;
        collider.enabled = false;        
    }
}