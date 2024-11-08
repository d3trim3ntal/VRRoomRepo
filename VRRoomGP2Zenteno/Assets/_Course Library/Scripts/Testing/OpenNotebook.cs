using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNotebook : MonoBehaviour
{
    public GameObject cover;
    public HingeJoint myHinge;

    // Start is called before the first frame update
    void Start()
    {
        var myHinge = cover.GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSesame()
    {
        myHinge.useMotor = true;
        Debug.Log("motor should be true");
    }
}
