using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject WarpPoint;
    private void Update() {
        if(GetComponent<PlayerIn>().FlgPlayerStay){
            GetComponent<PlayerIn>().OtherObj.transform.position = WarpPoint.transform.position;
            GetComponent<PlayerIn>().OtherObj.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
    
}
