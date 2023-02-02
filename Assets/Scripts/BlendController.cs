using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private float spd;
 
    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        
        if (input > 0)
        {
            spd += Time.deltaTime;
        }
        else
        {
            spd += (1f - Time.deltaTime);

        }
        spd = Mathf.Min(1f, spd);
    }
}
