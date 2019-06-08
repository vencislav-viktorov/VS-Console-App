﻿public class CreateCommand : Command
{
    private readonly IWeaponFactory weaponFactory;
    private readonly IRepository repository;

    public CreateCommand(string[] data)
        : base(data)
    {
    }

    public override void Execute()
    {
        var tokens = this.Data[0].Split();

        string rarity = tokens[0];
        string type = tokens[1];
        string name = this.Data[1];

        IWeapon weapon = this.weaponFactory.CreateWeapon(rarity, type, name);

        this.repository.AddWeapon(weapon);
    }
}