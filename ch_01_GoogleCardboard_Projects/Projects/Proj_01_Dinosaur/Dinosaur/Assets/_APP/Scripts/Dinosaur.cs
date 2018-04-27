using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour {

    public GameObject din;

    public void ZoomIn()
    {
        din.transform.localScale += new Vector3(1F, 1F, 1F);
    }
}
