using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Hawaii : MonoBehaviour {

    public GameObject missile;

    void Start ()
    {
	}

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                var spawned = Missile.SpawnMissile(missile, hit.point);
                spawned.targetObj = this;
            }
        }
        /*
                for (int i = 0; i < Input.touchCount; ++i)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Began)
                    {
                        // Construct a ray from the current touch coordinates
                        ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                        // Create a particle if hit
                        if (Physics.Raycast(ray))
                            Instantiate(particle, transform.position, transform.rotation);
                    }
                }
        */
    }

    public void Shake()
    {
        transform.DOShakePosition(0.5f, 0.5f, 25).OnComplete(ShakeComplete);
    }

    public void ShakeComplete()
    {
        transform.DOMove(Vector3.zero, 0.1f).SetEase(Ease.Linear);
    }
}
