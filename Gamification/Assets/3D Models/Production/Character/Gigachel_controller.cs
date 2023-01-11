using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gigachel_controller : MonoBehaviour
{
    [SerializeField] private GameObject gigachelTarget;
    [SerializeField] private float gigachelSpeed;
    private bool gigachelNeSpit = false;
    private Vector3 initPosition;
    private Vector3 initRotation;
    private Vector3 initScale;
    [SerializeField] private Texture2D initTexture;
    [SerializeField] private Texture2D Olga;

    private void Start()
    {
        initPosition = this.transform.position;
        initRotation = this.transform.eulerAngles;
        initScale = this.transform.localScale;
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
                if(Input.GetKeyDown(KeyCode.J))
                    if(gigachelNeSpit == false)
                        gigachelNeSpit = true;
                    else
                        gigachelNeSpit = false;
    }

    private void FixedUpdate()
    {
        if(gigachelNeSpit == true)
        {
            this.transform.LookAt(gigachelTarget.transform);
            this.transform.position = Vector3.MoveTowards(this.transform.position, gigachelTarget.transform.position, gigachelSpeed);
            this.transform.localScale = new Vector3(3.22F,1.224575F,1.224575F);
            this.gameObject.GetComponent<Renderer>().materials[3].SetTexture("_BaseMap", Olga);
        }
        else
        {
            this.transform.position = initPosition;
            this.transform.rotation = Quaternion.Euler(initRotation);
            this.transform.localScale = initScale;
            this.gameObject.GetComponent<Renderer>().materials[3].SetTexture("_BaseMap", initTexture);
        }
    }
}
