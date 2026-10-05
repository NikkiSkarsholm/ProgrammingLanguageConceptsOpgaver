
**Exercise 8.1**

here is formatted bytecode for 0x03.out
```fsharp
[
LDARGS 1;               void main(int n)
CALL (1, "L1"); 
STOP; 

Label "L1"; INCSP 1;    
            GETBP;      | i = 0
            CSTI 1;     | 
            ADD;        |   
            CSTI 0;     |
            STI;        |
            INCSP -1;   
            GOTO "L3";  | // beginning while loop
            
Label "L2"; GETBP;  // inside while loop
            CSTI 1;     | print i
            ADD;        |
            LDI;        |
            PRINTI;     |
            INCSP -1;   |
            GETBP;      | i = i + 1
            CSTI 1;     |
            ADD;        |
            GETBP;      |
            CSTI 1;     |
            ADD;        |
            LDI;        |
            CSTI 1;     |
            ADD;        |
            STI;        |
            INCSP -1;   |
            INCSP 0; 
            
Label "L3"; GETBP;      | i < n
            CSTI 1;     |
            ADD;        |
            LDI;        |
            GETBP;      | 
            CSTI 0;     |
            ADD;        |
            LDI;        |
            LT;         |
            IFNZRO "L2"; // if true, continue while loop
            INCSP -1;
            RET 0]
```
Symbolic bytecode for ex05.out:
```fsharp
[
 LDARGS 1;
 CALL (1, "L1");
 STOP;
 
 Label "L1";
    INCSP 1;
    GETBP;     //r = n
    CSTI 1;   |  
    ADD;      |
    GETBP;    | // n
    CSTI 0;   |
    ADD;      |
    LDI;      | 
    STI;      |
    INCSP -1; |
    INCSP 1;  |
    GETBP;    | // n
    CSTI 0;   |
    ADD;      |
    LDI;      |
    GETBP;    | // r (in nested scope) the nested variable r get's treated as a seperate variable
    CSTI 2;   |
    ADD;      |
    CALL (2, "L2");   | //call function with two agruments n and nested r address
    INCSP -1; |
    GETBP;    | // r (nested scope)
    CSTI 2;   |
    ADD;      |
    LDI;      |
    PRINTI;   | // print the nested r
    INCSP -1; |
    INCSP -1; |
    GETBP;    | // r
    CSTI 1;   |
    ADD;      |
    LDI;      |
    PRINTI;   | // print r
    INCSP -1; |
    INCSP -1; |
    RET 0;

Label "L2"; // square function
    GETBP;  | // *rp
    CSTI 1; |
    ADD;    |
    LDI;    |
    GETBP;  | // n
    CSTI 0; |
    ADD;    |
    LDI;    |
    GETBP;  | // n
    CSTI 0; |
    ADD;    |
    LDI;    |
    MUL;    | // n * n
    STI;    |
    INCSP -1;   |
    INCSP 0;    |
    RET 1   |
]
```


**Exercise 8.4**

We compiled the code for ex08.c and ran it. It took 0.707 seconds to run.

The Prog1 file instead took about 0.109 seconds to run. 

The reason why ex08.c is slower than Prog1 is that it saves the iteration number in a variable `i` whitch then has to get loaded and updated multiple times per itteration.
This adds up. Prog1 does not save the itteration number in a varaiable. It is instead programed in souch a way that it is always in the top of the stack when needed. Therefore, removing the need to load and save the value.

Here is the symbolic bytecode as requested:
```fsharp
[LDARGS 1; CALL (1, "L1"); STOP; Label "L1"; INCSP 1; GETBP; CSTI 1; ADD;
   CSTI 1889; STI; INCSP -1; GOTO "L3"; Label "L2"; GETBP; CSTI 1; ADD; GETBP;
   CSTI 1; ADD; LDI; CSTI 1; ADD; STI; INCSP -1; GETBP; CSTI 1; ADD; LDI;
   CSTI 4; MOD; CSTI 0; EQ; IFZERO "L7"; GETBP; CSTI 1; ADD; LDI; CSTI 100;
   MOD; CSTI 0; EQ; NOT; IFNZRO "L9"; GETBP; CSTI 1; ADD; LDI; CSTI 400; MOD;
   CSTI 0; EQ; GOTO "L8"; Label "L9"; CSTI 1; Label "L8"; GOTO "L6";
   Label "L7"; CSTI 0; Label "L6"; IFZERO "L4"; GETBP; CSTI 1; ADD; LDI;
   PRINTI; INCSP -1; GOTO "L5"; Label "L4"; INCSP 0; Label "L5"; INCSP 0;
   Label "L3"; GETBP; CSTI 1; ADD; LDI; GETBP; CSTI 0; ADD; LDI; LT;
   IFNZRO "L2"; INCSP -1; RET 0]
```

We can se that the conditions adds a lot of labels and jumps, which makes the code hard to read.
