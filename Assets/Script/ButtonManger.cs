using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManger : MonoBehaviour
{


    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }



        public void Restart()
    {
        SceneManager.LoadScene(0);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
   
}
