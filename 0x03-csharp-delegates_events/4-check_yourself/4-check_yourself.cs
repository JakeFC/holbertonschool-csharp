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
	private string status;

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
		this.status = String.Format("{0} is ready to go", this.name);
		HPCheck += CheckStatus; // adds CheckStatus method to event handler's list of actions
	}

	///<summary>Prints the current health out of max health of the player.</summary>
	public void PrintHealth()
	{
		System.Console.WriteLine(String.Format("{0} has {1} / {2} health", this.name, this.hp, this.maxHp));
	}

	///<summary>Delegate for math calculations.</summary>
	///<param name="f">Float input.</param>
	public delegate void CalculateMath(float f);

	///<summary>Prints a formatted string for Player taking damage.</summary>
	///<param name="damage">Damage taken. If less than 0, set to 0.</param>
	public void TakeDamage(float damage)
	{
		if (damage <  0)
			damage = 0f;
		System.Console.WriteLine(String.Format("{0} takes {1} damage!", this.name, damage));
		ValidateHP(this.hp - damage);
	}

	///<summary>Prints a formatted string for Player healing HP.</summary>
	///<param name="heal">Health given. If less than 0, set to 0.</param>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0f;
		System.Console.WriteLine(String.Format("{0} heals {1} HP!", this.name, heal));
		ValidateHP(this.hp + heal);
	}

	///<summary>Changes Player hp to new amount, not going under 0 or over maxHp.</summary>
	///<param name="newHp">The new hp to try to set Player to.</param>
	public void ValidateHP(float newHp)
	{
		this.hp = newHp;
		if (newHp < 0)
			this.hp = 0;
		if (newHp > this.maxHp)
			this.hp = this.maxHp;
		HPCheck(this, new CurrentHPArgs(this.hp));
	}

	///<summary>Adjusts a value, based on its modifier.</summary>
	///<param name="baseValue">Value to be modified.</param>
	///<param name="modifier">Modifier to apply to value.</param>
	///<returns>The modified value.</returns>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak) // or 0
			return baseValue / 2;
		else if (modifier == Modifier.Strong) // or 2
			return baseValue * 1.5f;
		else
			return baseValue;
	}

	///<summary>Handles HP Checking events with CurrentHPArgs as argument.</summary>
	public event EventHandler<CurrentHPArgs> HPCheck;

	///<summary>Sets and prints the current status of the object, based on their current hp.</summary>
	///<param name="sender">The object being checked.</param>
	///<param name="e">CurentHPArgs, containg the currentHp of the player.</param>
	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == this.maxHp)
			this.status = String.Format("{0} is in perfect health!", this.name);
		else if (e.currentHp >= this.maxHp / 2)
			this.status = String.Format("{0} is doing well!", this.name);
		else if (e.currentHp >= this.maxHp / 4)
			this.status = String.Format("{0} isn't doing too great...", this.name);
		else if (e.currentHp > 0)
			this.status = String.Format("{0} needs help!", this.name);
		else
			this.status = String.Format("{0} is knocked out!", this.name);
		System.Console.WriteLine(this.status);
	}
}

///<summary>Enumerated collection of modifiers.</summary>
public enum Modifier {
	///<summary>Weak modifier, value 0.</summary>
	Weak,
	///<summary>Base modifier, value 1.</summary>
	Base,
	///<summary>Strong modifier, value 2.</summary>
	Strong
}

///<summary>Delegate for modifier calculations.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>EventArgs containing current hp information.</summary>
public class CurrentHPArgs : EventArgs
{
	///<summary>Readonly current hp value of the object.</summary>
	public float currentHp { get; }

	///<summary>Instantiates the CurrentHPArgs with given currentHp value.</summary>
	///<param name="newHp">Value to set as currentHp.</param>
	public CurrentHPArgs(float newHp)
	{
		currentHp = newHp;
	}
}