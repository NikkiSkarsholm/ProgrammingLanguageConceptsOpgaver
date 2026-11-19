

*01 (only -verbose)*

```
Micro-Java compiler v 1.00 of 2026-05-14

VERBOSE: System Information
  Framework: .NET 10.0.9
  Environment.Version: 10.0.9
  OS: Microsoft Windows 10.0.26200
  OS Acrhitecture: X64
Compiling JavaEx/ex01.java to JavaEx/ex01.out.


VERBOSE: Parsing file JavaEx/ex01.java

VERBOSE: Program after parsing: 
class A extends Object {
  int i;
}

class B extends A {
  int i;
}

class Main extends Object {
  void main() { 
    B b;
    b = new B();
    b.i = 43;
    A ba;
    ba = b;
    ba.i = 42;
    println(ba.i,b.i);
  }
}

VERBOSE: Program after Return and Reachability Analysis: 
class A extends Object {
  int i;
}

class B extends A {
  int i;
}

class Main extends Object {
  void main() { 
    B b;
    b = new B();
    b.i = 43;
    A ba;
    ba = b;
    ba.i = 42;
    println(ba.i,b.i);
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
  int i;
}

class B extends A {
  int i;
}

class Main extends Object {
  void main() { 
    B b;
    b = new B();
    b.i = 43;
    A ba;
    ba = b;
    ba.i = 42;
    println(ba.i,b.i);
    return;
  }
}


VERBOSE: Class Table for Main: 
(main, ()): () -> void

Class Table for B: 

i: int
i: int
Class Table for A: 

i: int
Class Table for Object: 



VERBOSE: Program with types as class hierarchy: 


class Object extends  {
}

class A extends Object {
  int i;
}

class B extends A {
  int i;
}

class Main extends Object {
  void main() { 
    B b;
    b(B) = new B()(B);
    b(B).i(int) = 43(int);
    A ba;
    ba(A) = b(B);
    ba(A).i(int) = 42(int);
    println(ba(A).i(int),b(B).i(int))(int);
    return;
  }
}


VERBOSE: Program after A-normalization for GC: 

class Object extends  {
}

class A extends Object {
  int i;
}

class B extends A {
  int i;
}

class Main extends Object {
  void main() { 
    B b;
    b(B) = new B()(B);
    b(B).i(int) = 43(int);
    A ba;
    ba(A) = b(B);
    ba(A).i(int) = 42(int);
    println(ba(A).i(int),b(B).i(int))(int);
    return;
  }
}

VERBOSE: Compiling file JavaEx/ex01.java

VERBOSE: Class Environment: 
  A (L2_class_A): Object:
  Field Environment with next offset 2:
    A.i:int -> 1
  vTable Environment with next offset 0:

  B (L3_class_B): A:
  Field Environment with next offset 3:
    A.i:int -> 1
    B.i:int -> 2
  vTable Environment with next offset 0:

  Main (L5_class_Main): Object:
  Field Environment with next offset 1:

  vTable Environment with next offset 1:
    (main, ()) -> (0,L4_main)
  Object (L1_class_Object): :
  Field Environment with next offset 1:

  vTable Environment with next offset 0:


VERBOSE: Compiled program has 74 bytecode instructions.
```