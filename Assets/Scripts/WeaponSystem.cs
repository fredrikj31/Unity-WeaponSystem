using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
	[SerializeField] GameObject hand;
	[SerializeField] GameObject Sword;
	[SerializeField] Animator animator;

	private bool canSwing = true;

    // Start is called before the first frame update
    void Start()
    {
        this.Sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (this.canSwing == true)
			{
				StartCoroutine(PerformSwing());
			}
		}

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
			this.Sword.SetActive(false);
		} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			this.Sword.SetActive(true);
		}
    }

	private IEnumerator PerformSwing() {
		animator.SetBool("Attacking", true);
		this.canSwing = false;

		yield return new WaitForSeconds(0.5f);

		this.canSwing = true;
		animator.SetBool("Attacking", false);
	}
}
