using System;
using System.Collections.Generic;
using System.Linq;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
   
    public override bool Equals(object obj) => GetHashCode() == obj.GetHashCode();
    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    public override bool Equals(object obj) => GetHashCode() == obj.GetHashCode();
    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
    
}

public class Authenticator
{
    private readonly Identity admin = new(@"admin@exerc.ism", new FacialFeatures("green", 0.9m));
    private List<Identity> registeredIDs = new List<Identity>();
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);
    

    public bool IsAdmin(Identity identity) => identity.Equals(admin);

    public bool Register(Identity identity)
    {
        if (registeredIDs.Contains(identity)==false)
        {
            registeredIDs.Add(identity);
            return true;
        }
        else
            return false;
    }

    public bool IsRegistered(Identity identity)
    {
        if (registeredIDs.Contains(identity)==true)
            return true;
        else
            return false;
    }

    public static bool AreSameObject(Identity identityA, Identity identityB) => identityA==identityB;
    
}
