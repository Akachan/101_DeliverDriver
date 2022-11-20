using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

[SerializeField] GameObject barryMovil;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(barryMovil.transform.position.x, barryMovil.transform.position.y, -10) ;
    }
}
