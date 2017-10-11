//SuperDate3.cs 
//------------------------------------------- 
// SuperDate3.cs (c) 2006 by Charles Petzold 
//------------------------------------------- 
using System; 
using System.Runtime.InteropServices; 
 
partial class SuperDate 
{
    /*Defines a layout from the System.Runtime.Interop-
    Services namespace*/
    [StructLayout(LayoutKind.Sequential)] 
    class SystemTime 
    { 
        public ushort wYear; 
        public ushort wMonth; 
        public ushort wDayOfWeek; 
        public ushort wDay; 
        public ushort wHour; 
        public ushort wMinute; 
        public ushort wSecond; 
        public ushort wMilliseconds; 
    } 
    
    /*Calls a library's method from a external ressource*/
    [DllImport("kernel32.dll")] 
    static extern void GetSystemTime(SystemTime st); 
 
    public static SuperDate Today() 
    { 
        SystemTime systime = new SystemTime(); 
        GetSystemTime(systime); 
        return new SuperDate(systime.wYear, systime.wMonth, systime.wDay); 
    } 
}