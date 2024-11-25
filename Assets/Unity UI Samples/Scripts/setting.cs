using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel; 
    private bool isclick = false;
    void playRenwu(bool isnotclick)
    {
        panel.gameObject.SetActive(isnotclick);
    }
    public void Onclickbutton() {
        if (isclick == false)
        { isclick = true;
            playRenwu(true);
        }
        else 
        { 
            isclick = false; 
            playRenwu(false); 
        }
    }
}
