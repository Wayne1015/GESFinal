using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedColorSwitch : MonoBehaviour, IActivatiable {
    [SerializeField]
    private Text itemName;

    public void Do()
    {
        StartCoroutine(Wait());
        
        
       
    }

    IEnumerator Wait()
    {
        itemName.text = "Hmmm locked. Must be some way to open it.";
        yield return new WaitForSeconds(3);
    }

    
}
