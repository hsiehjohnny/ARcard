using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("眼魔")]
    public Transform behold;
    [Header("寶箱怪")]
    public Transform chest;
    [Header("搖桿")]
    public FixedJoystick Joystick;
    [Range(0.1f, 50f)]
    [Header("旋轉速度")]
    public float turnspeed = 1.5f;
    [Header("縮放倍率"), Range(0.1f, 5f)]
    public float scalesize = 2.5f;
    [Header("動畫")]
    public Animator anibehold;
    public Animator anichest;

    public float x = 0;



    private void Start()
    {
        print("123");
    }
    private void Update()
    {
        print(Joystick.Vertical);
        behold.Rotate(0, Joystick.Horizontal, 0);
        chest.Rotate(0, Joystick.Horizontal * turnspeed, 0);

     
            x = Mathf.Clamp(Joystick.Vertical, 0.2f, 1);


            behold.transform.localScale = new Vector3(1, 1, 1) * x * scalesize;
            chest.transform.localScale = new Vector3(1, 1, 1) * x * scalesize;
        
        
    }

    public void anicontroll(string anicall)
    {
        anibehold.SetTrigger(anicall);
        anichest.SetTrigger(anicall);
    }
}
