using UnityEngine;
using System.Collections.Generic;

public enum Walking
{
    Normal,
    Silly,
    Sulking
}

[CreateAssetMenu(fileName = "Ghost", menuName = "Ghost", order = 0)]
public class Ghost : ScriptableObject 
{
    public string ghostName;
    public TextAsset dialogue;
    // public List<string> success;
    // public List<string> failure;
    // public List<string> order;
    // public List<List<string>> story;
    public int numStory;  // starts at 1
    public List<Recipe> recipesOrdered;
    public Arc arc;
    public Walking walking;

}
