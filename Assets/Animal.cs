using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    //������ ���� ����
    public string name;
    public string sound;





    //�����Ҹ��� ����ϴ� �޼���
    public void Playsound() {

        Debug.Log(name + ":" + sound);
    
    
    }


}
