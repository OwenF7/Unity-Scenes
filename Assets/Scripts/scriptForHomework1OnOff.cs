using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptForHomework1OnOff : MonoBehaviour
{

    public bool onOff;
    public Renderer render;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool onOff = Mathf.FloorToInt(Time.time) % 2 == 0;

        render.enabled = onOff;
    }
}
