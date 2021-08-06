using System;

///<summary>Player class.</summary>
public class Player
{
	// Player's name.
	private string name;
	// Player's max health.
	private float maxHp;
	// Players current health.
	private float hp;

	///<summary>Instantiates a player with optional name and maxHP or defaults.</summary>
	///<param name="name">Name of the player, default "Player".</param>
	///<param name="maxHp">Max health of the player, default 100. Must be > 0.</param>
	public Player(string name = "Player", float maxHp = 100f)
	{
		this.name = name;
		this.maxHp = maxHp;
		if (maxHp < 0)
		{
			this.maxHp = 100f;
			System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		this.hp = this.maxHp;
	}

	///<summary>Prints the current health out of max health of the player.</summary>
	public void PrintHealth()
	{
		System.Console.WriteLine(String.Format("{0} has {1} / {2} health", this.name, this.hp, this.maxHp));
	}
}
