using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    //use this for initialization
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "��";
        tom.sound = "�Ŀ�!";

        tom.Playsound();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
