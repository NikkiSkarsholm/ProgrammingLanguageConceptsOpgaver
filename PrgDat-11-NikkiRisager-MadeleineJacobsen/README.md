**Exercise 13.1**

1) The result value is 4.
2) The result type is int.
3) There are two tail calls. One in each branch of the if-statement in f. This matches the intuiton as they are both in tail positon as there are no further operations after the call. If `g 4` was replaces by `(g 4) + 1` then there would be a operation after the call, thereby not being a tail call.
4) Both `f` and `g` and when they are called have type `(int -> int)`.
5) Here is the result using the evaluator: `Elapsed 7ms, CPU 15ms` and here is the result of running the virtual machine `0 cpu milli-seconds` (possibly to fast to register). So we can se that running using the virtual machine is much faster.
6) With optimization the result is 53 and without optimization the result is 57. So it saves 4 instructions.


**Exercise 13.3**
We tried to solve this exercise. We belive we were close but did not succeed. The code can be found in absyn.fs .
