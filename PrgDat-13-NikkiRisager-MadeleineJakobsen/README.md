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
Most of the of the test with the name exXX.java return an error, as the java program did not give a result. 

We could not run the file ex55.java as a Java program, with Java version openJdk-27.0.1.1, as 'print' and 'println' was not recongnised, along with requiring main to be 'public static void main (string[] args)'. Changing these parts of the code allowed the file to be run. We were a little surprised, as the newer versions should have support.
