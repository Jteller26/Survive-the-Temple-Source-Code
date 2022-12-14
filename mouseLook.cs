using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{

    public Transform AimTransform;


    private void Update()
    {
        AimHandling();
    }

    private void AimHandling()
    {
        Vector3 MousePos = GetMouseWorldPosition();
        Vector3 AimDir = (MousePos - transform.position).normalized;
        float Angle = Mathf.Atan2(AimDir.y, AimDir.x) * Mathf.Rad2Deg;
        AimTransform.eulerAngles = new Vector3(0, 0, Angle);

        Vector3 localScale = Vector3.one;
        if (Angle > 90 || Angle < -90)
        {
            localScale.y = -1f;
        }
        else
        {
            localScale.y = +1f;
        }
        AimTransform.localScale = localScale;

    }

    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }
    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }

    public static Vector3 GetDirToMouse(Vector3 fromPosition)
    {
        Vector3 mouseWorldPosition = GetMouseWorldPosition();
        return (mouseWorldPosition - fromPosition).normalized;
    }

}

