using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clib : MonoBehaviour
{
    public GameObject playerHandL;
    public GameObject playerHandR;
    public GameObject Board;
    public GameObject Bag;

    public void Move()
    {
        
          
            Board.transform.parent = playerHandL.transform;
        
     
    }
    public void MoveBag()
    {


        Bag.transform.parent = playerHandR.transform;
        Bag.transform.position = new Vector3(0,0,0);    


    }

}
