using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

// I
Aexpr e = new Add(new CstI(17), new Var("z"));
Console.WriteLine(e.toString());


// II
Aexpr e1 = new Sub( new Var("v"), new Add( new Var("w"), new Var("z")));
Console.WriteLine(e1.toString());
//Aexpr e2 = new Mul(CstI 2, Sub(Var "v", Add(Var "w", Var "z")));
//Aexpr e3 = new Add(Var "x", Add(Var "y", Add(Var "z", Var "v")));

abstract class Aexpr
{
    public abstract string toString();
}

class CstI : Aexpr
{
    
    private int val;

    public CstI(int val)
    {
        this.val = val;
    }
    public override string toString()
    {
        return this.val.ToString();
    }
}

class Var : Aexpr
{
    
    private string val;

    public Var(string val)
    {
        this.val = val;
    }
    public override string toString()
    {
        return this.val;
    }
}

abstract class Binop : Aexpr
{

    protected Aexpr a1;
    protected Aexpr a2;

    public Binop(Aexpr a1, Aexpr a2)
    {
        this.a1 = a1;
        this.a2 = a2;
    }

}

class Add : Binop
{
    public override string toString()
    {
        return "(" + this.a1.toString() + " + " + this.a2.toString() + ")";
    }
    public Add(Aexpr a1, Aexpr a2) : base(a1, a2)
    {
    }
}

class Sub : Binop
{
    public override string toString()
    {
        return "(" + this.a1.toString() + " - " + this.a2.toString() + ")";
    }
    public Sub(Aexpr a1, Aexpr a2) : base(a1, a2)
    {
    }
}

class Mul : Binop
{
    public override string toString()
    {
        return "(" + this.a1.toString() + " * " + this.a2.toString() + ")";
    }
    public Mul(Aexpr a1, Aexpr a2) : base(a1, a2)
    {
    }
}



