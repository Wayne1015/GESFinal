using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowItemName : MonoBehaviour, IActivatable
{
    [SerializeField]
    private string nameText;

    
    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
