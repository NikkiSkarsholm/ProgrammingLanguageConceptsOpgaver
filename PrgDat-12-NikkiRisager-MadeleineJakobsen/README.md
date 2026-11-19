**Exercise 1.1**
The output for each commands can be found in the files 'outputVerbose....md' and 'outputDebug....md'

Here is a short description of our observations of the outputs:
The program after parsing: added extra syntax like 'extends object'
The program after return and reachability analysis: Void methods gained a return
The class hierarchy: We could se the class hierarchy
The program as a class hierarchy: Added all missing classes such as object
The class table: We see each class with a list of function descriptors and fields
The program as a class hierarchy with type annotations: Added type annotations

The abstract syntax tree after parsing: We se the abstract syntax but it is still refencing linesand columns
The abstract syntax tree after return and reachability analysis: Added return in the abstract syntax tree
The abstract syntax tree as a class hierarchy: Added Hierarchy markings and object class
The abstract syntax tree as a class hierarchy with type annotations: Added type markings to int


**Exercise 1.2**
1. H <: T is valid
2. U <: S is invalid
3. Main <: Object is valid
4. Object <: Main is not valid
5. null <: V is valid 
6. V <: null is not valid
7. S <: H is not valid
8. void <:λ void is valid
9. int <:λ void is not valid
10. H <:λ void is not valid
11. T <:λ H is not valid

**Exercise 1.4**
Object <- Main
       <- U <- V
       <- S <- T <- H

no.1 (f,Object×U×S) : Object×U×S → T
no.2 (f,U×Object×S) : U×Object×S → S
no.3 (f,V×Object×T) : V×Object×T → S
no.4 (f,U×U×S) : U×U×S → S

1. (f,U×Object×S) There exists a most specific signature (no.2)
2. (f,U×U×S) There exists a most specific signature (no.4)
3. (f,U×Object×T) There does not exist a most specific signature, as no2 and no3 are just as specific
4. (f,V×V×H) There exists a most specific signature (no.4)
5. (f,null×null×null) There does not exist a most specific signature, since null is more specific than all, and therefore all no. apply.
6. (f,Object×Object×Object) There does not exist a most specific signature, as none apply
7. (f,Object×S×U) There does not exist a most specific signature, as none apply


