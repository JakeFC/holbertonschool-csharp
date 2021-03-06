using System;

///<summary>Custom generic class of Queue with type T.</summary>
public class Queue<T>
{
	///<summary>Returns the Queue's type.</summary>
	public Type CheckType()
	{
		return this.GetType().GetGenericArguments()[0];
	}

	///<summary>Element class of a Queue.</summary>
	public class Node
	{
		///<summary>Data value of the node.</summary>
		public T value = default(T);
		///<summary>Next node in the queue.</summary>
		public Node next = null;

		///<summary>Constructor for creating a new node with given value.</summary>
		///<param name="val">Value to insert in new node.</param>
		public Node(T val)
		{
			value = val;
		}
	}

	///<summary>First node in the queue.</summary>
	public Node head = null;
	///<summary>Last node in the queue.</summary>
	public Node tail = null;
	///<summary>Number of nodes in the queue.</summary>
	public int count = 0;

	///<summary>Creates a node of given value and places it at the end of the queue.</summary>
	///<param name="val">Value to place inside new node.</param>
	public void Enqueue(T val)
	{
		Node newNode = new Node(val);
		if (head == null)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			tail.next = newNode;
			tail = newNode;
		}
		count++;
	}

	///<summary>Returns the number of nodes in the queue.</summary>
	public int Count()
	{
		return count;
	}
}
