using UnityEngine;
using System.Collections;
public class NewBehaviourScript : MonoBehaviour
{
    public void StartGame()
    {
        Application.LoadLevel("Drag And Drop");
    }
    public void Back()
    {
        Application.LoadLevel("menu");
    }
}
