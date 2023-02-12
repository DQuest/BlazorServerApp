using System.ComponentModel;

namespace BlazorServerApp.Enums;

public enum TableType
{
    [Description("Животные")]
    Animal,
    
    [Description("Города")]
    City,
    
    [Description("Пользователи")]
    User
}