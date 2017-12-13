using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour {

    public Transform character;
    public Vector3 offset;

    void Update()
    {
        ////podążanie kamery za postacią
        transform.position = character.position + offset;
    }
}
