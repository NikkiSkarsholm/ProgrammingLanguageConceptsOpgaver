**Exercise 6.1**

*Input 1*  
we expect the result to be the sum of 5 and 2

```
let add x = let f y = x+y in f end
in add 2 5 end
```
result was 7
 

*Input 2* 
We expect the result to be the sum of 5 and 2
```
let add x = let f y = x+y in f end
in let addtwo = add 2
in addtwo 5 end
end
```
result was 7

*Input 3*

we expect the value to be the sum of 5 and 2 and that the redefining of `x` does not affect the previously defined `x` because the closure created when calling `add 2` is holding the original value of `x`
```
let add x = let f y = x+y in f end
in let addtwo = add 2
in let x = 77 in addtwo 5 end
end
end
```
as expected the result was 7

*Input 4*

We expect to get an error because `y` is never defined 
```
let add x = let f y = x+y in f end
in add 2 end
```
It returned the closure of the function `f`. Since the result of `f` can't be evaluated to an int