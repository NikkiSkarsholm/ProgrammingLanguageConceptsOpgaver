**Exercise 9.3**
The program could not garbage collect properly because it kept a reference to 'dummy', as it was a global variable. This made all nodes connected to dummy to be treated as not garbage, and therefore garbage collection could not clean the elements that were removed from the queue.

We fixed this by making 'dummy' local instead (putting it inside a constructor for the class SentinelLockQueue). yippee