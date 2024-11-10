using UnityEngine;

public class TeacherController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Speak()
    {
        Debug.Log("Speak Event Start");
        animator.SetTrigger("Speak");
        Debug.Log("Speak Event End");
        // Optionally, play an audio clip here
        // AudioSource.PlayClipAtPoint(teacherAudioClip, transform.position);
    }

    public void Idle()
    {
        Debug.Log("Idle Event Start");
        animator.SetTrigger("Idle");
        Debug.Log("Idle Event End");
        // Optionally, play an audio clip here
        // AudioSource.PlayClipAtPoint(teacherAudioClip, transform.position);
    }
}