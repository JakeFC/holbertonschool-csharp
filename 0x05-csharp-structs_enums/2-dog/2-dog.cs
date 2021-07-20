using System;

// A newly defined enum Rating with the values Good, Great, Excellent.
public enum Rating
{
    Good,
    Great,
    Excellent
}
// A struct Dog with 4 members of various types, a constructor, and public
// getter methods for each member.
struct Dog
{
    public Dog(string Name, float Age, string Owner, Rating Rating)
    {
    name = Name;
    age = Age;
    owner = Owner;
    rating = Rating;
    }
    public string name { get; }
    public float age { get; }
    public string owner { get; }
    public Rating rating { get; }
}