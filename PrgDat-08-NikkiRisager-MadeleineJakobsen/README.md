**Exercise 10.1:**

(i)

When executing a Add instruction, we assume that the stack has 2 integers at s[sp] and s[sp-1].
It then executes this code with reads and untags the two integers, adds them together and saves it tagged at s[sp-1].
The stack is then reduced by one.
stack before: [...,1,4] 
stack after: [...,5]
```c
case ADD: 
      s[sp-1] = Tag(Untag(s[sp-1]) + Untag(s[sp])); sp--; break;
```

When pushing an integer constant i onto the stack. 
We first read what the value of the constant from the program instructions at p[pc], 
tag it as a constant and saves it to the top of the stack. Increment the stack size and the program counter.  

```c
case CSTI:
       s[sp+1] = Tag(p[pc++]); sp++; break;
```

Adds a nil pointer to the top of the stack and increments the stack size.
the nil value is defined as 0, but is not confused by the constant 0 as constants are tagged on the stack.
So the binary representation of the constant 0 is 0b0000 0001 Assuming 8 bit ints.

```c
case NIL:    
    s[sp+1] = NILVALUE; sp++; break;
```


IFZERO looks at the value of the top of the stack.
If the value is either an integer 0 or a nil pointer, then change the program counter to be the value at the current instruction (effectively jumping to value at that instruction) .
Else skip to the next instruction.

```c 
case IFZERO: { 
      word v = s[sp--];
      pc = (IsInt(v) ? Untag(v) == 0 : v == 0) ? p[pc] : pc+1; 
```
CONS defines a new node in the list implementation.
It assumes that the stack has at minimum 2 values on it. s[sp-1] is the value we want to store in the node, and s[sp] is a pointer to the next node in the list.
The vertual machine allocates memory for the node. We call allocate with size 2, but in practice we create a node of size 3 for some bookkeeping.
We then save the value and the pointer in the node and returns a pointer to this node to s[sp-1] and decreases the stack size.

```c
case CONS: {
      word* p = allocate(CONSTAG, 2, s, sp); 
      p[1] = (word)s[sp-1];
      p[2] = (word)s[sp];
      s[sp-1] = (word)p;
      sp--;
    } break;
```
CAR assumes the top of the stack is an pointer to a node from a list. 
It gives an error if the point is a null pointer, else it returns to the top of the stack the value that was inside the node.

```c 
case CAR: {
      word* p = (word*)s[sp]; 
      if (p == 0) 
        { printf("Cannot take car of null\n"); return -1; }
      s[sp] = (word)(p[1]);
```
SETCAR assumes the top of the stack is a value that you want to insert into a node, and the previous element on the stack is a pointer to a node.
It then reads the value and updates the value in the node. The value inserted is removed from the stack.

```c
case SETCAR: {
      word v = (word)s[sp--];
      word* p = (word*)s[sp]; 
      p[1] = v;
    } break;
```

(ii)

Length: Isolates the length bits by removing the first 8 bit's and last 2

Color: Isolates the color bits

Paint: Replaces the color of the input with a new color

(III)

Allocate get's called when we make a now node for a list or a new object.
We also interact when we change values of a variable on the heap.

(IV)

The garbage collecter get's called when we try to allocate something but we do not successfully find free space for it.

**Exercise 10.2** 

We tried doing this exercise, however we had issues running the program ex30.out, both with our changes to microvm.c and without.
Here is the stack trace and error we get in a completely fresh copy of the repository:
```c 
[ ]{0:CSTI 0}
[ 0 ]{2:CSTI 481}
[ 0 481 ]{4:<unknown> 26735331856}
Illegal instruction 26735331856 at address 4 (109507919282880)
Heap: 1 blocks (19999 words); of which 1 free (19999 words, largest 19999 words); 0 orphans

Used 0 cpu milli-seconds
Number of GC: 0
```

We have tried doing the exercise the best we can, however we cannot test that it works, so it's probably incorrect.
For the same reason, we have not done exercise 10.3