﻿using System.ComponentModel;

/// <summary>
/// The start of our global settings. This viewmodel will grab changes in realtime to our settings page.
/// Makes the save button either Redundant OR reduces the complexiet of the event
/// </summary>
public class SettingsViewModel : INotifyPropertyChanged //Doesn't Use Communicty Toolkit.
{
    private float _brightness;
    public float Brightness
    {
        get => _brightness;
        set
        {
            _brightness = value;
            OnPropertyChanged(nameof(Brightness));
        }
    }

    private int _fontSize;
    public int FontSize
    {
        get => _fontSize;
        set
        {
            _fontSize = value;
            OnPropertyChanged(nameof(FontSize));
        }
    }

    private List<string> _fontFamilies;
    public List<string> FontFamilies
    {
        get => _fontFamilies;
        set
        {
            _fontFamilies = value;
            OnPropertyChanged(nameof(FontFamilies));
        }
    }

    private string _selectedFontFamily;
    public string SelectedFontFamily
    {
        get => _selectedFontFamily;
        set
        {
            _selectedFontFamily = value;
            OnPropertyChanged(nameof(SelectedFontFamily));
        }
    }

    //Defaults <- MVC <- Default settings control scripts
    //Prompts of defaults:
    //Reset Settings, Dark Theme, Light Theme, Colour Blind Mode.
    //Prompt to say these settings may change, be overwritten
    //OR X,y,z will change are you ok with that
    public SettingsViewModel()
    {
        // Initialize default values
        Brightness = 0.5f;
        FontSize = 16;
        FontFamilies = new List<string> { "Arial", "Times New Roman", "Verdana" };
        SelectedFontFamily = "Arial";
    }

    //TASK/COMMAND/INTERFACE 
    //The settings defaults for:
    //Reset Settings, Dark Theme, Light Theme, Colour Blind Mode.

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
