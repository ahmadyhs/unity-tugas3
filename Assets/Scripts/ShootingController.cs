using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{   
    public GameObject weapon;
    public AudioSource hitSound;
    public ParticleSystem muzzleFlash;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
            hitSound.Play();
            muzzleFlash.Play();
        }
    }

    void Shoot(){
        RaycastHit hitObject;

        if(Physics.Raycast(weapon.transform.position, transform.forward, out hitObject)){
            Destroy(hitObject.transform.gameObject);
        }
    }
}
