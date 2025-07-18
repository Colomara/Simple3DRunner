
using UnityEngine;

public class ArmSwing : MonoBehaviour
{
    public Transform leftArm;
    public Transform rightArm;

    public float swingSpeed = 5f;
    public float swingAmount = 30f;




    void Update()
    {
        bool isMoving = Input.GetKey("a") || Input.GetKey("d") || Input.GetKey("w") || Input.GetKey("s");

        if (isMoving)
        {
            float angle = Mathf.Sin(Time.time * swingSpeed) * swingAmount;

            leftArm.localRotation = Quaternion.Euler(angle, 0, 0);
            rightArm.localRotation = Quaternion.Euler(-angle, 0, 0);
        }
        else
        {

            leftArm.localRotation = Quaternion.Lerp(leftArm.localRotation, Quaternion.identity, Time.deltaTime * 5f);
            rightArm.localRotation = Quaternion.Lerp(rightArm.localRotation, Quaternion.identity, Time.deltaTime * 5f);
        }
    }
}
