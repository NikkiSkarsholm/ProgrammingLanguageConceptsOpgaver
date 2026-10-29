**Exercise 11.1**
(ii)

when calling the function 'lenc [2; 5; 7] (fun v -> 2*v)'
we get the double of the length (of the list argument given), in this case the result is 6.

(iii)
The core difference between lenc and leni is that lenc uses a continuation function and leni uses an accumulator.
This means that to get the expected output, you need to pass different arguments. For lenc you need to pass id, while for leni you need to pass 0.
In relation to performance, leni is more efficient because it uses an int as an accumulator (constant size), while lenc uses a function to accumulate, which gets bigger on the heap on every recursion.


**Exercise 11.2**

(ii)

When calling `revc [1; 2; 3] (fun v -> v @ v)` the returned value is the reversed list concatenated with itself.

**Exercise 11.8**

(I)

To print the values 3, 5 ,7 , 9: 
```f# 
run (Every(Write(Prim("+", CstI 1,Prim("*",FromTo(1, 4), CstI 2)))))
```

To print the values 21 22 31 32 41 42

```f#
run (Every(Write(Prim("+", Prim ("*", FromTo(2,4), CstI 10), FromTo(1,2)))))
```

(ii)

```f# 
run (Every(Seq(Write( Prim("<", CstI 50, Prim("*", CstI 7, FromTo(1,10))) ), Fail)))
```