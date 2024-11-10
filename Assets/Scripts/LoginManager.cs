using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Data;

public class LoginManager : MonoBehaviour
{
    public InputField usernameInput;
    public Dropdown roleDropdown;
    public Button loginButton;

    public GameObject loginUI;
    public GameObject studentUI;
    public GameObject teacherUI;

    private void Start()
    {
        // Hide both UI panels initially
        loginUI.SetActive(true);
        studentUI.SetActive(false);
        teacherUI.SetActive(false);

        // Add listener to the Login button
        loginButton.onClick.AddListener(OnLoginButtonClicked);
    }

    public void OnLoginButtonClicked()
    {
        string username = usernameInput.text;
        string role = roleDropdown.options[roleDropdown.value].text;

        Debug.Log("Username: " + username + ", Role: " + role);

        if (role == "Teacher")
        {
            teacherUI.SetActive(true);
            studentUI.SetActive(false);
            loginUI.SetActive(false);
        }
        else if (role == "Student")
        {
            studentUI.SetActive(true);
            teacherUI.SetActive(false);
            loginUI.SetActive(false);
        }

        // Load the main classroom scene or proceed with the simulation
        // SceneManager.LoadScene("ClassroomScene");
    }
}