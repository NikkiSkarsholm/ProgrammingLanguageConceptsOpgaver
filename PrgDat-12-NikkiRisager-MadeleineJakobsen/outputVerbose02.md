*02 (only -verbose)*
Micro-Java compiler v 1.00 of 2026-05-14

VERBOSE: System Information
  Framework: .NET 10.0.9
  Environment.Version: 10.0.9
  OS: Microsoft Windows 10.0.26200
  OS Acrhitecture: X64
Compiling JavaEx/ex02.java to JavaEx/ex02.out.


VERBOSE: Parsing file JavaEx/ex02.java

VERBOSE: Program after parsing: 
class A extends Object {
  int i1;

  int i2;

  int f() { 
    return (this.i1 + this.i2);
  }
}

class B extends A {
  int i2;

  int f() { 
    return this.i2;
  }

  int fSuper() { 
    return super.f();
  }

  int i2Super() { 
    return super.i2;
  }

  int g() { 
    return (this.i1 + this.i2);
  }
}

class Main extends Object {
  void main() { 
    A a;
    a = new A();
    a.i1 = 1;
    a.i2 = 2;
    B b;
    b = new B();
    b.i1 = 4;
    b.i2 = 42;
    A ab;
    ab = b;
    println(a.i1,a.i2,a.f());
    println(b.i1,b.i2,b.f(),b.i2Super(),b.fSuper(),b.g());
    println(ab.i1,ab.i2,ab.f());
  }
}

VERBOSE: Program after Return and Reachability Analysis: 
class A extends Object {
  int i1;

  int i2;

  int f() { 
    return (this.i1 + this.i2);
  }
}

class B extends A {
  int i2;

  int f() { 
    return this.i2;
  }

  int fSuper() { 
    return super.f();
  }

  int i2Super() { 
    return super.i2;
  }

  int g() { 
    return (this.i1 + this.i2);
  }
}

class Main extends Object {
  void main() { 
    A a;
    a = new A();
    a.i1 = 1;
    a.i2 = 2;
    B b;
    b = new B();
    b.i1 = 4;
    b.i2 = 42;
    A ab;
    ab = b;
    println(a.i1,a.i2,a.f());
    println(b.i1,b.i2,b.f(),b.i2Super(),b.fSuper(),b.g());
    println(ab.i1,ab.i2,ab.f());
    return;
  }
}

VERBOSE: Class hierarchy: 
Object <- A <- B
       <- Main


VERBOSE: Program as class hierarchy: 


class Object extends  {
}

class A extends Object {
  int i1;

  int i2;

  int f() { 
    return (this.i1 + this.i2);
  }
}

class B extends A {
  int i2;

  int f() { 
    return this.i2;
  }

  int fSuper() { 
    return super.f();
  }

  int i2Super() { 
    return super.i2;
  }

  int g() { 
    return (this.i1 + this.i2);
  }
}

class Main extends Object {
  void main() { 
    A a;
    a = new A();
    a.i1 = 1;
    a.i2 = 2;
    B b;
    b = new B();
    b.i1 = 4;
    b.i2 = 42;
    A ab;
    ab = b;
    println(a.i1,a.i2,a.f());
    println(b.i1,b.i2,b.f(),b.i2Super(),b.fSuper(),b.g());
    println(ab.i1,ab.i2,ab.f());
    return;
  }
}


VERBOSE: Class Table for Main: 
(main, ()): () -> void

Class Table for B: 
(g, ()): () -> int
(i2Super, ()): () -> int
(fSuper, ()): () -> int
(f, ()): () -> int
(f, ()): () -> int
i2: int
i2: int
i1: int
Class Table for A: 
(f, ()): () -> int
i2: int
i1: int
Class Table for Object: 



VERBOSE: Program with types as class hierarchy: 


class Object extends  {
}

class A extends Object {
  int i1;

  int i2;

  int f() { 
    return (this(A).i1(int) + this(A).i2(int))(int);
  }
}

class B extends A {
  int i2;

  int f() { 
    return this(B).i2(int);
  }

  int fSuper() { 
    return super(A).f() vSig(f, ())(int);
  }

  int i2Super() { 
    return super(A).i2(int);
  }

  int g() { 
    return (this(B).i1(int) + this(B).i2(int))(int);
  }
}

class Main extends Object {
  void main() { 
    A a;
    a(A) = new A()(A);
    a(A).i1(int) = 1(int);
    a(A).i2(int) = 2(int);
    B b;
    b(B) = new B()(B);
    b(B).i1(int) = 4(int);
    b(B).i2(int) = 42(int);
    A ab;
    ab(A) = b(B);
    println(a(A).i1(int),a(A).i2(int),a(A).f() vSig(f, ())(int))(int);
    println(b(B).i1(int),b(B).i2(int),b(B).f() vSig(f, ())(int),b(B).i2Super() vSig(i2Super, ())(int),b(B).fSuper() vSig(fSuper, ())(int),b(B).g() vSig(g, ())(int))(int);
    println(ab(A).i1(int),ab(A).i2(int),ab(A).f() vSig(f, ())(int))(int);
    return;
  }
}


VERBOSE: Program after A-normalization for GC: 

class Object extends  {
}

class A extends Object {
  int i1;

  int i2;

  int f() { 
    return (this(A).i1(int) + this(A).i2(int))(int);
  }
}

class B extends A {
  int i2;

  int f() { 
    return this(B).i2(int);
  }

  int fSuper() { 
    return super(A).f() vSig(f, ())(int);
  }

  int i2Super() { 
    return super(A).i2(int);
  }

  int g() { 
    return (this(B).i1(int) + this(B).i2(int))(int);
  }
}

class Main extends Object {
  void main() { 
    A a;
    a(A) = new A()(A);
    a(A).i1(int) = 1(int);
    a(A).i2(int) = 2(int);
    B b;
    b(B) = new B()(B);
    b(B).i1(int) = 4(int);
    b(B).i2(int) = 42(int);
    A ab;
    ab(A) = b(B);
    println(a(A).i1(int),a(A).i2(int),a(A).f() vSig(f, ())(int))(int);
    println(b(B).i1(int),b(B).i2(int),b(B).f() vSig(f, ())(int),b(B).i2Super() vSig(i2Super, ())(int),b(B).fSuper() vSig(fSuper, ())(int),b(B).g() vSig(g, ())(int))(int);
    println(ab(A).i1(int),ab(A).i2(int),ab(A).f() vSig(f, ())(int))(int);
    return;
  }
}

VERBOSE: Compiling file JavaEx/ex02.java

VERBOSE: Class Environment: 
  A (L3_class_A): Object:
  Field Environment with next offset 3:
    A.i1:int -> 1
    A.i2:int -> 2
  vTable Environment with next offset 1:
    (f, ()) -> (0,L2_f)
  B (L8_class_B): A:
  Field Environment with next offset 4:
    A.i1:int -> 1
    A.i2:int -> 2
    B.i2:int -> 3
  vTable Environment with next offset 4:
    (f, ()) -> (0,L4_f)
    (fSuper, ()) -> (1,L5_fSuper)
    (g, ()) -> (3,L7_g)
    (i2Super, ()) -> (2,L6_i2Super)
  Main (L10_class_Main): Object:
  Field Environment with next offset 1:

  vTable Environment with next offset 1:
    (main, ()) -> (0,L9_main)
  Object (L1_class_Object): :
  Field Environment with next offset 1:

  vTable Environment with next offset 0:


VERBOSE: Compiled program has 268 bytecode instructions.