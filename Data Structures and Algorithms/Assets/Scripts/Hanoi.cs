using System;

public class Hanoi
{
	public void Main()
	{
		hanoi(5, "A", "C", "B");
	}

	void swap(string a, string b)
	{
		Console.WriteLine(a + " -> " + b);
	}

	void hanoi(int disk, string source, string dest, string spare)
	{
		if (disk == 0)
		{
			swap(source, dest);
		}
		else
		{
			hanoi(disk - 1, source, spare, dest);
			swap(source, dest);
			hanoi(disk - 1, spare, dest, source);
		}
	}
}