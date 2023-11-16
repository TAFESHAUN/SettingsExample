using SQLite;

namespace SettingsExample;
/// <summary>
/// This is the user setting data model
/// </summary>
public class UserSet
{
    #region userdata
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    #endregion

    public bool lightOrDark { get; set; } //Toggle theme

    public string SomeEntry { get; set; } //RANDOM DATA ENTRY -> Email something later

    //These viewmodel settings
    public int SavedFontSize { get; set; }
    public float SavedBrightness { get; set; }
    public string SavedFontFamily { get; set; }

}
