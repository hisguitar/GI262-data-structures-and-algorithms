using System;
using System.Collections.Generic;

public enum HeroType { Assassin, Mage, Support, Tank }

public class Hero
{
    public string Name { get; set; }
    public enum HeroType { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }
    public List<Item> ItemBag { get; set; }

    public void Walk()
    {
        Console.WriteLine($"{Name} is walking.");
    }

    public void Attack()
    {
        Console.WriteLine($"{Name} is attacking.");
    }
}

public enum HeroType
{
    Assassin,
    Mage,
    Support,
    Tank
}

public class Item
{
    public string Name { get; set; }
    public int Value { get; set; }

    public void Effect()
    {
        Console.WriteLine($"{Name} has healing!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero()
        {
            Name = "John",
            HeroType = HeroType.Assassin,
            Level = 10,
            HP = 100,
            ItemBag = new List<Item>()
        };

        Item item1 = new Item()
        {
            Name = "Health Potion",
            Value = 50
        };

        Item item2 = new Item()
        {
            Name = "Mana Potion",
            Value = 30
        };

        Item item3 = new Item()
        {
            Name = "Sword",
            Value = 100
        };

        hero.ItemBag.Add(item1);
        hero.ItemBag.Add(item2);
        hero.ItemBag.Add(item3);
    }
}