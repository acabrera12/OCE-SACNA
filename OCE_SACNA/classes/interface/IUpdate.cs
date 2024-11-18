using System;

public interface IUpdatable
{
    void Update();
}

[AttributeUsage(AttributeTargets.Class)]
public class AutoUpdateAttribute : Attribute
{
}