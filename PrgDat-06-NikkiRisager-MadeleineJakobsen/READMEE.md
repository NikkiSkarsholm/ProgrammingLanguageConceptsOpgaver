
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

Here is the trace:
```fsharp 
[ ]{0: LDARGS}                  // loade the argument "4" onto the stack
[ 4 ]{2: CALL 1 6}              // go to the start of main, 5 is the return address and -999 is the old bace pointer
[ 5 -999 4 ]{6: INCSP 1}        
[ 5 -999 4 0 ]{8: GETBP}        | i=0   // get base pointer (points to the value 4)
[ 5 -999 4 0 2 ]{9: CSTI 1}     |       // add the offset to the stack 
[ 5 -999 4 0 2 1 ]{11: ADD}     |       // calculate the new pointer to i
[ 5 -999 4 0 3 ]{12: CSTI 0}    |       // add the value that the pointer sould point to on the stack 
[ 5 -999 4 0 3 0 ]{14: STI}     |       // save that value, so the pointer points to that value
[ 5 -999 4 0 0 ]{15: INCSP -1}          // remove unused stack element
[ 5 -999 4 0 ]{17: GOTO 44}     |       // jumps to condition statment in while loop
[ 5 -999 4 0 ]{44: GETBP}       | i     // get base pointer 
[ 5 -999 4 0 2 ]{45: CSTI 1}    |       // add offset to the stack
[ 5 -999 4 0 2 1 ]{47: ADD}     |       // calulate new pointer
[ 5 -999 4 0 3 ]{48: LDI}       |       // get the value that the new pointer points to. in this case the value of i witch is 0
[ 5 -999 4 0 0 ]{49: GETBP}     | n     // same as we did for i above
[ 5 -999 4 0 0 2 ]{50: CSTI 0}  |
[ 5 -999 4 0 0 2 0 ]{52: ADD}   |
[ 5 -999 4 0 0 2 ]{53: LDI}     |
[ 5 -999 4 0 0 4 ]{54: LT}      | i < n // now that the values of both i and n is on the stack, we can compare them      
[ 5 -999 4 0 1 ]{55: IFNZRO 19}     // jumps to the body of our while statement
[ 5 -999 4 0 ]{19: GETBP}       | i     // retrives value of i
[ 5 -999 4 0 2 ]{20: CSTI 1}    |
[ 5 -999 4 0 2 1 ]{22: ADD}     |
[ 5 -999 4 0 3 ]{23: LDI}       |
[ 5 -999 4 0 0 ]{24: PRINTI}    | print(i)  // prints the top of the stack witch is i
0 [ 5 -999 4 0 0 ]{25: INCSP -1}| <- notice the 0 at the start of this line. that is the output for the print statement
[ 5 -999 4 0 ]{27: GETBP}       | i // get's pointer to i
[ 5 -999 4 0 2 ]{28: CSTI 1}    |
[ 5 -999 4 0 2 1 ]{30: ADD}     |
[ 5 -999 4 0 3 ]{31: GETBP}     | i // get's value of i and and it to the stack
[ 5 -999 4 0 3 2 ]{32: CSTI 1}  |
[ 5 -999 4 0 3 2 1 ]{34: ADD}   |
[ 5 -999 4 0 3 3 ]{35: LDI}     |
[ 5 -999 4 0 3 0 ]{36: CSTI 1}  | i + 1 // increment the value of i, and add the new value to the stack
[ 5 -999 4 0 3 0 1 ]{38: ADD}   | 
[ 5 -999 4 0 3 1 ]{39: STI}     | i = i + 1 // update the value at location 3 witch is i. thereby updating i to be equal to i+1
[ 5 -999 4 1 1 ]{40: INCSP -1}
[ 5 -999 4 1 ]{42: INCSP 0}
[ 5 -999 4 1 ]{44: GETBP}       // we are now back to the statment of the while loop, so we will keep looping until the stament is false
[ 5 -999 4 1 2 ]{45: CSTI 1}
[ 5 -999 4 1 2 1 ]{47: ADD}
[ 5 -999 4 1 3 ]{48: LDI}
[ 5 -999 4 1 1 ]{49: GETBP}
[ 5 -999 4 1 1 2 ]{50: CSTI 0}
[ 5 -999 4 1 1 2 0 ]{52: ADD}
[ 5 -999 4 1 1 2 ]{53: LDI}
[ 5 -999 4 1 1 4 ]{54: LT}
[ 5 -999 4 1 1 ]{55: IFNZRO 19}
[ 5 -999 4 1 ]{19: GETBP}
[ 5 -999 4 1 2 ]{20: CSTI 1}
[ 5 -999 4 1 2 1 ]{22: ADD}
[ 5 -999 4 1 3 ]{23: LDI}
[ 5 -999 4 1 1 ]{24: PRINTI}        // prints 1
1 [ 5 -999 4 1 1 ]{25: INCSP -1}    
[ 5 -999 4 1 ]{27: GETBP}
[ 5 -999 4 1 2 ]{28: CSTI 1}
[ 5 -999 4 1 2 1 ]{30: ADD}
[ 5 -999 4 1 3 ]{31: GETBP}
[ 5 -999 4 1 3 2 ]{32: CSTI 1}
[ 5 -999 4 1 3 2 1 ]{34: ADD}
[ 5 -999 4 1 3 3 ]{35: LDI}
[ 5 -999 4 1 3 1 ]{36: CSTI 1}
[ 5 -999 4 1 3 1 1 ]{38: ADD}
[ 5 -999 4 1 3 2 ]{39: STI}
[ 5 -999 4 2 2 ]{40: INCSP -1}
[ 5 -999 4 2 ]{42: INCSP 0}
[ 5 -999 4 2 ]{44: GETBP}
[ 5 -999 4 2 2 ]{45: CSTI 1}
[ 5 -999 4 2 2 1 ]{47: ADD}
[ 5 -999 4 2 3 ]{48: LDI}
[ 5 -999 4 2 2 ]{49: GETBP}
[ 5 -999 4 2 2 2 ]{50: CSTI 0}
[ 5 -999 4 2 2 2 0 ]{52: ADD}
[ 5 -999 4 2 2 2 ]{53: LDI}
[ 5 -999 4 2 2 4 ]{54: LT}
[ 5 -999 4 2 1 ]{55: IFNZRO 19}
[ 5 -999 4 2 ]{19: GETBP}
[ 5 -999 4 2 2 ]{20: CSTI 1}
[ 5 -999 4 2 2 1 ]{22: ADD}
[ 5 -999 4 2 3 ]{23: LDI}
[ 5 -999 4 2 2 ]{24: PRINTI}        // prints 2
2 [ 5 -999 4 2 2 ]{25: INCSP -1}        
[ 5 -999 4 2 ]{27: GETBP}
[ 5 -999 4 2 2 ]{28: CSTI 1}
[ 5 -999 4 2 2 1 ]{30: ADD}
[ 5 -999 4 2 3 ]{31: GETBP}
[ 5 -999 4 2 3 2 ]{32: CSTI 1}
[ 5 -999 4 2 3 2 1 ]{34: ADD}
[ 5 -999 4 2 3 3 ]{35: LDI}
[ 5 -999 4 2 3 2 ]{36: CSTI 1}
[ 5 -999 4 2 3 2 1 ]{38: ADD}
[ 5 -999 4 2 3 3 ]{39: STI}
[ 5 -999 4 3 3 ]{40: INCSP -1}
[ 5 -999 4 3 ]{42: INCSP 0}
[ 5 -999 4 3 ]{44: GETBP}
[ 5 -999 4 3 2 ]{45: CSTI 1}
[ 5 -999 4 3 2 1 ]{47: ADD}
[ 5 -999 4 3 3 ]{48: LDI}
[ 5 -999 4 3 3 ]{49: GETBP}
[ 5 -999 4 3 3 2 ]{50: CSTI 0}
[ 5 -999 4 3 3 2 0 ]{52: ADD}
[ 5 -999 4 3 3 2 ]{53: LDI}
[ 5 -999 4 3 3 4 ]{54: LT}
[ 5 -999 4 3 1 ]{55: IFNZRO 19}
[ 5 -999 4 3 ]{19: GETBP}
[ 5 -999 4 3 2 ]{20: CSTI 1}
[ 5 -999 4 3 2 1 ]{22: ADD}
[ 5 -999 4 3 3 ]{23: LDI}
[ 5 -999 4 3 3 ]{24: PRINTI}        // prints 3
3 [ 5 -999 4 3 3 ]{25: INCSP -1}
[ 5 -999 4 3 ]{27: GETBP}
[ 5 -999 4 3 2 ]{28: CSTI 1}
[ 5 -999 4 3 2 1 ]{30: ADD}
[ 5 -999 4 3 3 ]{31: GETBP}
[ 5 -999 4 3 3 2 ]{32: CSTI 1}
[ 5 -999 4 3 3 2 1 ]{34: ADD}
[ 5 -999 4 3 3 3 ]{35: LDI}
[ 5 -999 4 3 3 3 ]{36: CSTI 1}
[ 5 -999 4 3 3 3 1 ]{38: ADD}
[ 5 -999 4 3 3 4 ]{39: STI}
[ 5 -999 4 4 4 ]{40: INCSP -1}
[ 5 -999 4 4 ]{42: INCSP 0}
[ 5 -999 4 4 ]{44: GETBP}       |    // back to the statement of the while loop again, howevet this time the statement is false
[ 5 -999 4 4 2 ]{45: CSTI 1}    |
[ 5 -999 4 4 2 1 ]{47: ADD}     |
[ 5 -999 4 4 3 ]{48: LDI}       |
[ 5 -999 4 4 4 ]{49: GETBP}     |
[ 5 -999 4 4 4 2 ]{50: CSTI 0}  |
[ 5 -999 4 4 4 2 0 ]{52: ADD}   |
[ 5 -999 4 4 4 2 ]{53: LDI}     |
[ 5 -999 4 4 4 4 ]{54: LT}      | i < n !!! false!
[ 5 -999 4 4 0 ]{55: IFNZRO 19}     // cannot jump back to the body of the while loop as the statement was false
[ 5 -999 4 4 ]{57: INCSP -1}
[ 5 -999 4 ]{59: RET 0}         // return back to instruction 5
[ 4 ]{5: STOP}                  // end program

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
