using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Alert : MonoBehaviour {

    void Start() {
        transform.DOPunchScale(new Vector3(1.5f, 1.5f, 1.5f), 1f);
    }

    void Update() {

    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
