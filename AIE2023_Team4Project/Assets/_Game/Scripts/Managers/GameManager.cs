using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //create a static instance that can be accessed by all scripts as long as a gamemanger script is in the same scene
    //simply use GameManager._instance to reference this script
    public GameManager _instance;

    // Start is called before the first frame update
    void Start()
    {
        //assign this object to the static instance
        _instance = this;
    }
}
