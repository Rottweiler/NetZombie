using System;
using System.Net;

[Serializable]
public class Config
{
    public static IPAddress Host = IPAddress.Parse("127.0.0.1");
    public static ushort Port = 3307;
    public static string Install_Name = "Windows Update";
    public static string Install_Key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
    public static bool Should_Install = true;
    public static int Connection_Timeout = (30 * 1000);
}