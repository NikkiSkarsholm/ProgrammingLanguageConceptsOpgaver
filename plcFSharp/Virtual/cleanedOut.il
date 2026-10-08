.method public hidebysig static 
		void SelectionSort (
			int32[] arr
		) cil managed 
	{
		// Method begins at RVA 0x20cc
		// Header size: 12
		// Code size: 78 (0x4e)
		.maxstack 4
		.locals init (
			[0] int32,
			[1] int32,
			[2] int32,
			[3] int32,
			[4] bool,
			[5] bool,
			[6] bool
		)

		IL_0000: nop
		IL_0001: ldc.i4.0               //| load value 0 into regisster 0
		IL_0002: stloc.0                //| 
		IL_0003: br.s IL_0041           // jump to condtion of first for loop
		// loop start (head: IL_0041)
			IL_0005: nop
			IL_0006: ldloc.0     // load i onto the stack
			IL_0007: stloc.1     // set local variable 1 to be equal to i (least)
			IL_0008: ldloc.0    // load i onto stack
			IL_0009: ldc.i4.1    // add 1 to stack
			IL_000a: add        // i+1
			IL_000b: stloc.3    // save into variable 3 (j)
			IL_000c: br.s IL_0022 // hop to condtion of foor loop 2
			// loop start (head: IL_0022)
				IL_000e: ldarg.0 // load arr
				IL_000f: ldloc.3 // load j
				IL_0010: ldelem.i4 // load arr[j] onto the stack
				IL_0011: ldarg.0 // load arr
				IL_0012: ldloc.1 // load least
				IL_0013: ldelem.i4  //load arr[least]
				IL_0014: clt        // arr[j] < arr[least]
				IL_0016: stloc.s 4 // save result in variable 4
				IL_0018: ldloc.s 4 // load the result
				IL_001a: brfalse.s IL_001e // if fasle goto IL_001e

				IL_001c: ldloc.3    // load argument j
				IL_001d: stloc.1    // least = j

				IL_001e: ldloc.3    //load j
				IL_001f: ldc.i4.1   // load 1
				IL_0020: add        // add 
				IL_0021: stloc.3    // j = j+1

				IL_0022: ldloc.3 // load j
				IL_0023: ldarg.0 // load argument 0 (arr)
				IL_0024: ldlen   // get the length of arr
				IL_0025: conv.i4 // convert to int 32
				IL_0026: clt    // j < arr.Length
				IL_0028: stloc.s 5 // save the result to variable 5
				IL_002a: ldloc.s 5 // load varuable 5
				IL_002c: brtrue.s IL_000e // if true  jump to body of while loop
			// end loop

			IL_002e: ldarg.0     //load arr
			IL_002f: ldloc.0    // load i
			IL_0030: ldelem.i4    // load arr[i]
			IL_0031: stloc.2       // save it into variable 2 (tmp)
			IL_0032: ldarg.0    // load arr
			IL_0033: ldloc.0    // load i
			IL_0034: ldarg.0    // load arr
			IL_0035: ldloc.1    // load least
			IL_0036: ldelem.i4  // arr[least]
			IL_0037: stelem.i4  // arr[i] = arr[least]
			IL_0038: ldarg.0    // load arr
			IL_0039: ldloc.1    // load least
			IL_003a: ldloc.2    // load tmp
			IL_003b: stelem.i4  // arr[least] = tmp
			IL_003c: nop
			IL_003d: ldloc.0    // load i
			IL_003e: ldc.i4.1   // add 1 to astack
			IL_003f: add        // i+1
			IL_0040: stloc.0    // i = i+1

			IL_0041: ldloc.0        // load variable 0 onto stack
			IL_0042: ldarg.0        // load argument 0 onto stack
			IL_0043: ldlen          // get length of argument 0 whitch is a array (aka length of array)
			IL_0044: conv.i4        // convert to int32
			IL_0045: clt            // less than. (checking that variable 0 is less than the length of the array)
			IL_0047: stloc.s 6      // save result into variable 6
			IL_0049: ldloc.s 6      // pushes the variable 6 onto the stack
			IL_004b: brtrue.s IL_0005 //jump to body of foor loop if condtion is true
		// end loop

		IL_004d: ret        // return
	} // end of method Selsort::SelectionSort