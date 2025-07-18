using UnityEngine;

public class LegSwing : MonoBehaviour
{
    public Transform leftLeg;
    public Transform rightLeg;

    public float swingSpeed = 5f;
    public float swingAmount = 20f;

    void Update()
    {
        // ���������, ��������� �� �����
        bool isMoving = Input.GetKey("a") || Input.GetKey("d") || Input.GetKey("w") || Input.GetKey("s");

        if (isMoving)
        {
            float angle = Mathf.Sin(Time.time * swingSpeed) * swingAmount;

            leftLeg.localRotation = Quaternion.Euler(angle, 0, 0);
            rightLeg.localRotation = Quaternion.Euler(-angle, 0, 0);
        }
        else
        {
            // ���������� ���� � ����������� ���������
            leftLeg.localRotation = Quaternion.Lerp(leftLeg.localRotation, Quaternion.identity, Time.deltaTime * 5f);
            rightLeg.localRotation = Quaternion.Lerp(rightLeg.localRotation, Quaternion.identity, Time.deltaTime * 5f);
        }
    }
}