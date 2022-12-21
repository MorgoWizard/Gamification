using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPreviewLerping : MonoBehaviour
{
    [SerializeField] private Transform[] previewPositions;
    [SerializeField] private Transform defaultPosition;

    private int positionsAmount;
    private int currentPosition = 0, nextPosition;
    private float timer = 0;
    float LerpTimer;
    [SerializeField] float Speed = 1;

    private void Awake()
    {
        positionsAmount = previewPositions.Length;
    }

    public void moveOnForwardPosition()
    {
        nextPosition = (currentPosition + 1) % positionsAmount;
        LerpTimer = 0;
    }

    public void moveOnPreviousPosition()
    {
        nextPosition = (currentPosition - 1) % positionsAmount;
        LerpTimer = 0;

        if(nextPosition < 0)
            nextPosition = positionsAmount - 1;
    }

    private void moveToPosition()
    {
        transform.position = Vector3.Lerp(this.transform.position,
            previewPositions[nextPosition].position, LerpTimer*Speed);
        transform.rotation = Quaternion.Lerp(this.transform.rotation,
            previewPositions[nextPosition].rotation, LerpTimer*Speed);
        
        currentPosition = nextPosition;
    }

    private void Update()
    {
        if(transform.position != previewPositions[nextPosition].position)
            moveToPosition();
            LerpTimer += Time.deltaTime;
    }

    public void setPositionToDefault()
    {
        transform.position = defaultPosition.position;
        transform.rotation = defaultPosition.rotation;
        GetComponent<CameraPreviewLerping>().enabled = false;
    }
}
