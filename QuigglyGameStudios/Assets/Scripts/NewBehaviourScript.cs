using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Player)
{
    if (Player.gameObject.tag == "Player")
    {
        DontDestroyOnLoad(Player.gameObject);
        Application.LoadLevel("boss fight");   
    }
}
}
