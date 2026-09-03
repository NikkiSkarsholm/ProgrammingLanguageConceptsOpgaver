HOW TO FIND THE SOLVED EXERCISES:

1.1 -> Intro2.fs
1.2 -> 1.2.fs
1.4 -> 1.4.cs
2.1 , 2.2 , 2.3 -> Exercises2.fs


**Explanation for 1.1:**

(I)
Added 3 match statements in the out-commented eval function. 

(II)
On line 36, you can find a variable e4, all the variables up-to and including e7 are our example expressions
They test "==" , "max", "min".

(III)
Our new rewriten eval is called eval2

(IV)
Added If to expr

(V)
We added conditions to handle if else statements to the eval2 function.

**Explanation for 1.2:**

(I)
Added datatype aexpr.

(II)
We wrote the expression.

(III)
The function fmt is added.

(IV)
Added the simplify function, with all example cases in exercises, it also works for the "more ambitious" case.

(V)
Wrote the function, however it cannot handle powers of x (fx: x*3*x).
It was unclear if that was a passing requirement.

**Explanation for 1.4:**

(I)
Created an abstract class aexpr and child classes with toString methods. 

(II)
Created 3 expressions.

(III)
Added eval methods to aexpr class and its children.

(IV)
Added simplify methods to aexpr class and its children, however it does not work with the "more ambitious" case.

**Explanation for 2.1:**

Added sequential Let bindings, used fold function in eval.

**Explanation for 2.2:**

The function can be found on line 220.

**Explanation for 2.3:**

Revised tcomp to work with the new sequential Let bindings using a recursive approach.