using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var dc = false;
        var pc = false;
        
        var dialingCode = phoneNumber.Substring(0, 3);
        var prefixCode =  phoneNumber.Substring(4,3);
        var lastFour =    phoneNumber.Substring(8,4);

        if(dialingCode == "212")
        {
            dc = true;
        }
        if(prefixCode == "555")
        {
            pc = true;
        }
        
        return (dc, pc, lastFour);
            
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.Item2;
    }
}
