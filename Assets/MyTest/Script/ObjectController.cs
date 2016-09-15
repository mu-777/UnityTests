using UnityEngine;
using System.Collections;

public class ObjectController : MonoBehaviour {

    public GameObject _target;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (_target != null) {
            _target.transform.Rotate(Vector3.up, 30f * Time.deltaTime);
            print(_target.transform.rotation);
        }
    }
}
