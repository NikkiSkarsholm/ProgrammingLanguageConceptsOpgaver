using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

// I
Aexpr e = new Add(new CstI(17), new Var("z"));
Console.WriteLine(e.toString());


// II
Aexpr e1 = new Sub( new Var("v"), new Add( new Var("w"), new Var("z")));
Console.WriteLine(e1.toString());

Aexpr e2 = new Mul(new CstI (2), new Sub( new Var ("v"), new Add( new Var ("w"), new Var ("z"))));
Console.WriteLine(e2.toString());

Aexpr e3 = new Add( new Var ("x"),new Add(new Var ("y"), new Add( new Var ("z"), new Var ("v"))));
Console.WriteLine(e3.toString());

//III
Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("z", 5);

Console.WriteLine(e.eval(dict));


// IV
Console.WriteLine(e2.betterEquals(e2));

//(x + 0)to x
Aexpr e4 = new Add(new Var("z"), new CstI(0));
Console.WriteLine(e4.simplify().toString());

Aexpr e5 = new Mul(new CstI(1), new CstI(0));
Console.WriteLine(e5.simplify().toString());

abstract class Aexpr
{
    public abstract string toString();

    public abstract int eval(Dictionary<string, int> env);

    public abstract Aexpr simplify();

    public abstract bool betterEquals(Aexpr aexpr);

}

class CstI : Aexpr
{
    
    private int val;

    public int getVal()
    {
        return val;
    }

    public CstI(int val)
    {
        this.val = val;
    }
    public override string toString()
    {
        return this.val.ToString();
    }

    public override int eval(Dictionary<string, int> env)
    {
        return val;
    }

    public override Aexpr simplify()
    {
        return new CstI (val);
    }

    public override bool betterEquals(Aexpr aexpr)
    {
        
        return aexpr is CstI && ((CstI) aexpr).getVal() == val;
        
    }
    
}

class Var : Aexpr
{
    
    private string val;

    public string getVal()
    {
        return val;
    }

    public Var(string val)
    {
        this.val = val;
    }
    public override string toString()
    {
        return this.val;
    }

    public override int eval(Dictionary<string, int> env)
    {
        if (env.ContainsKey(val))
        {
            return env[val];
        } else
        {
            throw new Exception("This variable was not available in the dictionary");
        }
    }

    public override Aexpr simplify()
    {
        return new Var (val);
    }

    public override bool betterEquals(Aexpr aexpr)
    {
        
        return aexpr is Var && ((Var) aexpr).getVal() == val;
        
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

    public Aexpr geta1()
    {
        return a1;
    }

    public Aexpr geta2()
    {
        return a2;
    }

    public Add(Aexpr a1, Aexpr a2) : base(a1, a2)
    {
    }

    public override int eval(Dictionary<string, int> env)
    {
        return a1.eval(env) + a2.eval(env);
    }

    public override Aexpr simplify()
    {
        if (a1 is CstI && ((CstI) a1).getVal() == 0)
        {
            return a2.simplify();
        } 

        if (a2 is CstI && ((CstI) a2).getVal() == 0)
        {
            return a1.simplify();
        }

        return new Add(a1.simplify(), a2.simplify());
    }

    public override bool betterEquals(Aexpr aexpr)
    {
        if (aexpr is Add && ((Add) aexpr).geta1().betterEquals(a1) && ((Add) aexpr).geta2().betterEquals(a2))
        {
            return true;

        } 
        return false;
    }
}

class Sub : Binop
{
    public override string toString()
    {
        return "(" + this.a1.toString() + " - " + this.a2.toString() + ")";
    }

    public Aexpr geta1()
    {
        return a1;
    }

    public Aexpr geta2()
    {
        return a2;
    }

    public Sub(Aexpr a1, Aexpr a2) : base(a1, a2)
    {
    }

    public override int eval(Dictionary<string, int> env)
    {
        return a1.eval(env) - a2.eval(env);
    }

    public override Aexpr simplify()
    {

        if (a2 is CstI && ((CstI) a2).getVal() == 0)
        {
            return a1.simplify();
        }

        if (a1.betterEquals(a2))
        {
            return new CstI(0);
        }

        return new Add(a1.simplify(),a2.simplify());
    }

    public override bool betterEquals(Aexpr aexpr)
    {
        if (aexpr is Sub && ((Sub) aexpr).geta1().betterEquals(a1) && ((Sub) aexpr).geta2().betterEquals(a2))
        {
            return true;

        } 
        return false;
    }
}

class Mul : Binop
{
    public override string toString()
    {
        return "(" + this.a1.toString() + " * " + this.a2.toString() + ")";
    }

    public Aexpr geta1()
    {
        return a1;
    }

    public Aexpr geta2()
    {
        return a2;
    }

    public Mul(Aexpr a1, Aexpr a2) : base(a1, a2)
    {
    }

    public override int eval(Dictionary<string, int> env)
    {
        return a1.eval(env) * a2.eval(env);
    }

    public override bool betterEquals(Aexpr aexpr)
    {
        if (aexpr is Mul && ((Mul) aexpr).geta1().betterEquals(a1) && ((Mul) aexpr).geta2().betterEquals(a2))
        {
            return true;

        } 
        return false;
    }

    public override Aexpr simplify()
    {
        if(a1 is CstI && ((CstI) a1).getVal() == 1)
        {
            return a2.simplify();
        }

        if(a2 is CstI && ((CstI) a2).getVal() == 1)
        {
            return a1.simplify();
        }

        if(a2 is CstI && ((CstI) a2).getVal() == 0)
        {
            return new CstI(0);
        }

        if(a1 is CstI && ((CstI) a1).getVal() == 0)
        {
            return new CstI(0);
        }

        return new Mul(a1.simplify(),a2.simplify() );
    }
}



