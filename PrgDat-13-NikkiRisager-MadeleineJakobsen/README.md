**Exercise 2.1**


There are 92 solutions to the 8-queens problem.

When running the 4-queens program with stack tracing './microvm - trace ex55.out 4  ', the program took a very long time to run, and we had to stop the output as it did not seem to end. However when running './microvm ex55.out 4 ' we could see that the solutions to the 4-queens program is 2.

As described in the REAME of microJ, there are 3 categories. THe first is that of tests that can run both micro-Java and Java. 
The second is tests that fail on both microJava and Java. The third is tests that fail on microJava but succeed on Java. For example if the code uses interfaces, which are not supported in micro-java.
All tests following the naming scheme exFXX.java will fail, as they are designed to do so.
In short form the 3 types of results are:
- Programs with type errors in micro-Java.
- Programs with type errors in both micro-Java and Java.
- Programs that succeed.

Most of the of the tests with the name exXX.java return an error, as the java program did not give a result. 

We could not run the file ex55.java as a Java program, with Java version openJdk-27.0.1.1, as 'print' and 'println' was not recongnised, along with requiring main to be 'public static void main (string[] args)'. Changing these parts of the code allowed the file to be run. We were a little surprised, as the newer versions should have support.

**Exercise 2.2**
ex01.java :

-verbose
The purpose of class Bs label is to know where class Bs descriptor is in the program file.
The index of B.i in instance objects of B is 2.
74 bytecode instructions are generated.

-debug
the label used for the main method is called 'L4_main'. The index of the main method is 0.


ex02.java :

To create the main object and call the maian method, with the arguments, we beleive these lines are used:
2: HEAPALLOC 4 1 //allocate object
5: HEAPCOPY 1   //initialise object fields
7: LDARGS 0     //load arguments
9: VCALL 1 0    //call main
The class descriptor for class B can be found at lines: 284 to 287
The instructions containing the functionm f of class B can be found at lines: 288 to 300

288: GETBP  //get base pointer
289: CSTI 0 // 
291: ADD    // add 0 to stack
292: STACKADDR  // get address from stack
293: LDD        // load content (this) from address 
294: CSTI 3     // add 3 to the stack
296: HEAPADDR   // look at the index i + 1 in object 
297: LDD        // load (i2)
298: RET 1      // return
300: INCSP 0
The index in the instance object used to access field this.i2 is 3.

**Exercise 2.3**

super.f(2) and a.f(1) share the same label 'L2_f', as they are the same function.

the class A has the methods :
- f , boolean offset 1
- f, C offset 0
- g, C offset 2

the class B has the methods:
- f, boolean (shared with A, so not counted again) offset 1
- f, C (shared with A, so not counted again) offset 0
- f, D (this overloads the methods f, C from A) offset 3
- g, C (overwrited so this is counted) offset 2
- g, d offset 4
- superf, boolean offset 7
- superf, C offset 5
- superf, D offset 6

The class C has the methods:

The class D has the methods:

The class Main has the methods:
- main, () offset 0

There are 10 individual methods

We are a little unsure of what we are being asked to do for the last question, therefore we will simply list the variables declared in the main method of class Main.
- A a
- B b
- D d
- C c
- C c2
- D d2
- C c3
- A ba
- C c4
- C c5
- C c6
- C c7
- Object o
That makes 13 variables.

