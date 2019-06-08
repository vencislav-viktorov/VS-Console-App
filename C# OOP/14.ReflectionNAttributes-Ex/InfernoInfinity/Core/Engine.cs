﻿using System;
using System.Linq;
using System.Reflection;

public class Engine : IRunnable
{
    private readonly IGemFactory gemFactory;
    private readonly IWeaponFactory weaponFactory;
    private readonly ICommandInterpreter commandInterpreter;
    private readonly IRepository repository;

    public Engine(IGemFactory gemFactory, IWeaponFactory weaponFactory, ICommandInterpreter commandInterpreter, IRepository repository)
    {
        this.gemFactory = gemFactory;
        this.weaponFactory = weaponFactory;
        this.commandInterpreter = commandInterpreter;
        this.repository = repository;
    }

    public void Run()
    {
        while (true)
        {
            string[] tokens = Console.ReadLine().Split(';');

            IExecutable executable = this.commandInterpreter.InterpretCommand(tokens[0], tokens.Skip(1).ToArray());
            var fields = executable.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            if (fields.Any(f => f.FieldType == typeof(IRepository)))
            {
                fields.Single(f => f.FieldType == typeof(IRepository))
                    .SetValue(executable, this.repository);
            }

            if (fields.Any(f => f.FieldType == typeof(IWeaponFactory)))
            {
                fields.Single(f => f.FieldType == typeof(IWeaponFactory))
                    .SetValue(executable, this.weaponFactory);
            }

            if (fields.Any(f => f.FieldType == typeof(IGemFactory)))
            {
                fields.Single(f => f.FieldType == typeof(IGemFactory))
                    .SetValue(executable, this.gemFactory);
            }

            executable.Execute();
        }
    }
}