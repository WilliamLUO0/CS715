using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material[] material;
    public int x;
    Renderer read;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        read = GetComponent<Renderer>();
        read.enabled = true;

        read.sharedMaterial = material[x];
        
        
        

    }

    // Update is called once per frame
    void Update()
    {
        // read.sharedMaterial = material[x];
        
    }

    public void ChangeToClassA(){
        
        read.sharedMaterial = material[2];
       
    }

    public void ChangeToClassB(){
        
        read.sharedMaterial = material[1];
       
    }
    public void ChangeToClassC(){
        
        read.sharedMaterial = material[0];
       
    }

    public void updateGlove(char itemLevel)
    {
        if (itemLevel == 'C') {
            ChangeToClassC();
        } else if (itemLevel == 'B') {
            ChangeToClassB();
        } else {
            ChangeToClassA();
        }
    }
}
