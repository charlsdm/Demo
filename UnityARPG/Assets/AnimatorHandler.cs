using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorHandler : MonoBehaviour
{

    public Animator anim;
    int vertical;
    int horizontal;
    public bool canRotate;
    // Start is called before the first frame update

    public void Init()
    {
        anim = GetComponent<Animator>();
        vertical = Animator.StringToHash("Vertical");
        horizontal = Animator.StringToHash("Horizontal");

    }

    public void UpdateAnimatorValues(float verticalMovement,float horizontalMovement)
    {
        #region Vertical;
        float v = 0;
        if(verticalMovement>0&&verticalMovement<0.55f)
        {
            v = 0.5f;
        }
        else if(verticalMovement>0.55f)
        {
            v = 1.0f;
        }
        else if(verticalMovement<0&&verticalMovement>=-0.55f)
        {
            v = -0.5f;
        }
        else if(verticalMovement<-0.55f)
        {
            v = -1f;
        }
        else
        {
            v = 0;
        }
        #endregion

        #region Horizontal
        float h = 0;
        if(horizontalMovement>0&&horizontalMovement<0.55f)
        {
            h = 0.5f;
        }
        else if(horizontalMovement>0.55f)
        {
            h = 1.0f;
        }
        else if(horizontal<0&&horizontal>=-0.55f)
        {
            h = -0.5f;
        }
        else if(horizontal<-0.55f)
        {
            h = -1;
        }
        else
        {
            h = 0;
        }
        #endregion

        anim.SetFloat(vertical, v, 0.1f, Time.deltaTime);
        anim.SetFloat(horizontal, h, 0.1f, Time.deltaTime);
    }

    public void  CanRotate()
    {
        canRotate = true;
    }
    public void  StopRotation()
    {
        canRotate = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
