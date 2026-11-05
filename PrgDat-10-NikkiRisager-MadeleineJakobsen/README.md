**Exercise 12.4**
We can se that with our changes. The same code compiles to more bytecode instructions. Here is beffore and after:
```F#
[LDARGS 1; CALL (1, "L1"); STOP; Label "L1"; INCSP 1; GETBP; CSTI 1; ADD;
   CSTI 1889; STI; INCSP -1; GOTO "L3"; Label "L2"; GETBP; CSTI 1; ADD; GETBP;
   CSTI 1; ADD; LDI; CSTI 1; ADD; STI; INCSP -1; GETBP; CSTI 1; ADD; LDI;
   CSTI 4; MOD; IFNZRO "L3"; GETBP; CSTI 1; ADD; LDI; CSTI 100; MOD;
   IFNZRO "L4"; GETBP; CSTI 1; ADD; LDI; CSTI 400; MOD; IFNZRO "L3";
   Label "L4"; GETBP; CSTI 1; ADD; LDI; PRINTI; INCSP -1; Label "L3"; GETBP;
   CSTI 1; ADD; LDI; GETBP; LDI; LT; IFNZRO "L2"; RET 1]
```

```F# 
[LDARGS 1; CALL (1, "L1"); STOP; Label "L1"; INCSP 1; GETBP; CSTI 1; ADD;
   CSTI 1889; STI; INCSP -1; GOTO "L3"; Label "L2"; GETBP; CSTI 1; ADD; GETBP;
   CSTI 1; ADD; LDI; CSTI 1; ADD; STI; INCSP -1; GETBP; CSTI 1; ADD; LDI;
   CSTI 4; MOD; IFNZRO "L5"; GETBP; CSTI 1; ADD; LDI; CSTI 100; MOD;
   IFZERO "L6"; CSTI 1; GOTO "L4"; Label "L6"; GETBP; CSTI 1; ADD; LDI;
   CSTI 400; MOD; NOT; GOTO "L4"; Label "L5"; CSTI 0; Label "L4"; IFZERO "L3";
   GETBP; CSTI 1; ADD; LDI; PRINTI; INCSP -1; Label "L3"; GETBP; CSTI 1; ADD;
   LDI; GETBP; LDI; LT; IFNZRO "L2"; RET 1]

```

This is becouse our implimentation of Cond is unoptimal. Such as this expression: `cExpr (Cond(CstI 1, CstI 1111, CstI 2222) ([], 0) [] [];`
Getting compilled to: 
```F# 
[CSTI 1111; GOTO "L0"; Label "L1"; CSTI 2222; Label "L0"]
```
When it could be compiled to

```f#  

[CSTI 1111]]
```