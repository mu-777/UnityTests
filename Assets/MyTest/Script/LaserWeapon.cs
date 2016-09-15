using UnityEngine;
using System.Collections;

public class LaserWeapon : MonoBehaviour {

    public string _targetTag = "Enemy";
    private RaycastHit _hitted;

    // Use this for initialization
    void Start() {

    }

    void Update() {

        RaycastHit hit;
        if (Physics.Raycast(this.transform.position,
                            this.transform.position - Camera.main.transform.position,
                            out hit)) {
            _hitted = hit;
            if (_hitted.collider.tag == _targetTag) {
                _hitted.collider.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        } else {
            if (_hitted.collider.GetComponent<MeshRenderer>().material.color == Color.red) {
                _hitted.collider.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }
    }
}
