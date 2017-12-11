using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDoor : MonoBehaviour, IActivatable
{
    [SerializeField]
    string nameText;

    [Tooltip("If you set a key, the door will be locked.")]
    [SerializeField]
    InventoryObject[] key;
    private LockMechanism lockMechanism;

    private Animator animator;
    private bool isLocked, isOpen;
    private List<InventoryObject> playerInventory;

    public string NameText
    {
        get
        {
            string toReturn = nameText;

            if (isOpen)
                toReturn = ""; // So it doesn't look like you can open the door anymore.
            else if (isLocked && !HasKey1 && !HasKey2 && !HasKey3 && !HasKey4 && !HasKey5)
                toReturn += " (LOCKED)";
            else if (isLocked && HasKey1 && HasKey2 && HasKey3 && HasKey4 && HasKey5)
            {
                toReturn += string.Format(" (use) All Keys" );
                
            }
                

            return toReturn;
        }
    }

    private bool HasKey1
    {
        get
        {
            return playerInventory.Contains(key[0]);
            
        }
    }
    private bool HasKey2
    {
        get
        {
            return playerInventory.Contains(key[1]);

        }
    }

    private bool HasKey3
    {
        get
        {
            return playerInventory.Contains(key[2]);

        }
    }

    private bool HasKey4
    {
        get
        {
            return playerInventory.Contains(key[3]);

        }
    }
    private bool HasKey5
    {
        get
        {
            return playerInventory.Contains(key[4]);

        }
    }

    public void DoActivate()
    {
        if (!isOpen)
        {
            if (!isLocked || HasKey1 && HasKey2 && HasKey3 && HasKey4 && HasKey5)
            {
                animator.SetBool("isOpened", true);
                isOpen = true;
                playerInventory.Remove(key[0]);
                playerInventory.Remove(key[1]);
                playerInventory.Remove(key[2]);
                playerInventory.Remove(key[3]);
                playerInventory.Remove(key[4]);
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
        isLocked = key != null;
        
    }
}