using System;

namespace XIVLauncher.Common;

[AttributeUsage(AttributeTargets.Field)]
public class SettingsDescriptionAttribute : Attribute
{
    public string Description { get; set; }

    public SettingsDescriptionAttribute(string friendlyName, string description)
    {
        this.Description = description;
    }
}