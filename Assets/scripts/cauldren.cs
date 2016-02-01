using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cauldren : MonoBehaviour {
    public int captured_slimes;
    public int needed_slimes_to_win;
    public GameObject count_object;
	// Use this for initialization
	void Start () {
	captured_slimes = 0;
	Physics2D.IgnoreCollision(count_object.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
	
	// Update is called once per frame
	void Update ()
	{
	if (hasWon())
	{
	    SceneManager.LoadScene("YouWinScene");
	    SceneManager.UnloadScene("EmptyGameplayTesting");
	    //SceneManager.SetActiveScene(BensScene);
	}
	}
	void OnTriggerEnter2D(Collider2D coll)
    {
	if(coll.gameObject.tag == count_object.tag)
        {
	    Destroy(coll.gameObject);
	    captured_slimes++;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
	if (col.gameObject.tag == count_object.tag)
	{
	    Destroy(col.gameObject);
	    captured_slimes++;
	}
    }
    bool hasWon()
    {
	if (captured_slimes>= needed_slimes_to_win)
	{
	    return true;
        }
	else
	{
	    return false;
		
	}
    }
}
