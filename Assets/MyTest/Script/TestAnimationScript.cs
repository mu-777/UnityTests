//http://hiyotama.hatenablog.com/entry/2015/06/27/090000


using UnityEngine;
using System.Collections;

public class TestAnimationScript : MonoBehaviour {
    private Animator anim;

    void Start() {
        anim = this.GetComponent<Animator>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            anim.SetBool("walk", true);
        } else {
            anim.SetBool("walk", false);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            //anim.SetBool("walk", true);
            this.transform.Rotate(Vector3.up, 25f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            //anim.SetBool("walk", true);
            this.transform.Rotate(Vector3.up, -25f * Time.deltaTime);
        }
    }
}