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

    private void Awake()
    {
        positionsAmount = previewPositions.Length;
    }

    public void moveOnForwardPosition()
    {
        nextPosition = (currentPosition + 1) % positionsAmount;
    }

    public void moveOnPreviousPosition()
    {
        nextPosition = Mathf.Abs((currentPosition - 1) % positionsAmount);
    }

    private void moveToPosition()
    {
        transform.position = Vector3.MoveTowards(previewPositions[currentPosition].position,
            previewPositions[nextPosition].position, Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(previewPositions[currentPosition].rotation,
            previewPositions[nextPosition].rotation, Time.deltaTime);
        
        currentPosition = nextPosition;
    }

    private void Update()
    {
        if(transform.position != previewPositions[nextPosition].position)
            moveToPosition();
    }

    public void setPositionToDefault()
    {
        transform.position = defaultPosition.position;
    }
}
