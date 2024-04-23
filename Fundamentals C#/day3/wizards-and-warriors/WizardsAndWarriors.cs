using System;

abstract class Character
{
    private string _characterType;
    
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
         if(target.Vulnerable() == true)
        {
            return 10;
        }
        else
        {
            return 6;
        } 
    }
}



class Wizard : Character
{
    
    private bool spellPrepared;
    public Wizard() : base("Wizard")
    {
       spellPrepared = false;
    }

    public override int DamagePoints(Character target)
    {
        if(spellPrepared == true)
        {
            return 12;
        }
        else
        {
            return 3;
        } 
    }

    public void PrepareSpell()
    {
        spellPrepared = true;
    }

    public override bool Vulnerable()
    {
        if(spellPrepared == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}


