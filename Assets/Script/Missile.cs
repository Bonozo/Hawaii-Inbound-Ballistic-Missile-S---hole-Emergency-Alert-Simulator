using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Missile : MonoBehaviour {

    public GameObject particle;
    public Hawaii targetObj;
    public Vector3 target;

    void Start ()
    {
    }
	
	void Update ()
    {
	}

    public void Launch(Vector3 targetPos)
    {
        target = targetPos;

        transform.DOMove(targetPos, 2f).SetEase(Ease.Linear).OnComplete(Detonate);
        transform.DOScale(0.5f, 2f).SetEase(Ease.Linear).OnComplete(Detonate);
    }

    public void Detonate()
    {
        targetObj.Shake();
        Destroy(gameObject);
        Instantiate(particle, target, transform.rotation);
    }

    public static Missile SpawnMissile(GameObject prefab, Vector3 targetPos)
    {
        var missile = Instantiate(prefab);

        var script = missile.GetComponent<Missile>();
        script.Launch(targetPos);

        return script;
    }

}
