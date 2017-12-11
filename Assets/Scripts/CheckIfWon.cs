using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class CheckIfWon : MonoBehaviour {
    [SerializeField]
    private GameObject winCanvas;
    [SerializeField]
    private FirstPersonController fps;
    
	public bool WinObjectNumber1Got = false;
    public bool WinObjectNumber2Got = false;
    public bool OnLvl2 = false;

    private void Start()
    {
        
    }
    // Update is called once per frame

    void Update () {
		if(WinObjectNumber1Got == true && WinObjectNumber2Got == true)//If you have both objects then
        {
            //Display a new canvas to tell you that you won
            winCanvas.SetActive(true);
            fps.enabled = false;
            if(Input.GetButton("Cancel"))//If you hit escape when you win you will quit the game.
            {
                Application.Quit();
            }
            if(Input.GetKey(KeyCode.M))
            {
                SceneManager.LoadScene("Menu");
            }
        }
	}
}
