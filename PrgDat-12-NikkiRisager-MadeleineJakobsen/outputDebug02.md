**02 (only -debug)**

Micro-Java compiler v 1.00 of 2026-05-14
Compiling JavaEx/ex02.java to JavaEx/ex02.out.


DEBUG Program AST after parsing: Program
  [Classdec
     ("A", "Object",
      [Fielddec (TypI, "i1", { line = 23
                               column = 6 });
       Fielddec (TypI, "i2", { line = 24
                               column = 6 });
       Methoddec
         (TypI, "f", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Prim2
                         ("+",
                          Access
                            (AccFld
                               (Access (AccVar ("this", None, { line = 26
                                                                column = 19 })),
                                "i1", None, { line = 26
                                              column = 19 })),
                          Access
                            (AccFld
                               (Access (AccVar ("this", None, { line = 26
                                                                column = 29 })),
                                "i2", None, { line = 26
                                              column = 29 })), None,
                          { line = 26
                            column = 27 })), { line = 26
                                               column = 19 }))], { line = 26
                                                                   column = 12 }),
          { line = 26
            column = 6 })], { line = 22
                              column = 6 });
   Classdec
     ("B", "A",
      [Fielddec (TypI, "i2", { line = 30
                               column = 6 });
       Methoddec
         (TypI, "f", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Access
                         (AccFld
                            (Access (AccVar ("this", None, { line = 32
                                                             column = 19 })),
                             "i2", None, { line = 32
                                           column = 19 }))), { line = 32
                                                               column = 19 }))],
             { line = 32
               column = 12 }), { line = 32
                                 column = 6 });
       Methoddec
         (TypI, "fSuper", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Call
                         (Access (AccVar ("super", None, { line = 33
                                                           column = 24 })), "f",
                          None, [], None, { line = 33
                                            column = 24 })), { line = 33
                                                               column = 24 }))],
             { line = 33
               column = 17 }), { line = 33
                                 column = 6 });
       Methoddec
         (TypI, "i2Super", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Access
                         (AccFld
                            (Access (AccVar ("super", None, { line = 34
                                                              column = 25 })),
                             "i2", None, { line = 34
                                           column = 25 }))), { line = 34
                                                               column = 25 }))],
             { line = 34
               column = 18 }), { line = 34
                                 column = 6 });
       Methoddec
         (TypI, "g", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Prim2
                         ("+",
                          Access
                            (AccFld
                               (Access (AccVar ("this", None, { line = 35
                                                                column = 19 })),
                                "i1", None, { line = 35
                                              column = 19 })),
                          Access
                            (AccFld
                               (Access (AccVar ("this", None, { line = 35
                                                                column = 29 })),
                                "i2", None, { line = 35
                                              column = 29 })), None,
                          { line = 35
                            column = 27 })), { line = 35
                                               column = 19 }))], { line = 35
                                                                   column = 12 }),
          { line = 35
            column = 6 })], { line = 29
                              column = 6 });
   Classdec
     ("Main", "Object",
      [Methoddec
         (TypV, "main", [],
          Block
            ([Dec (TypO "A", "a", { line = 40
                                    column = 6 });
              Stmt
                (Expr
                   (Assign
                      (AccVar ("a", None, { line = 40
                                            column = 6 }),
                       New ("A", None, { line = 40
                                         column = 10 }), { line = 40
                                                           column = 10 })));
              Stmt
                (Expr
                   (Assign
                      (AccFld
                         (Access (AccVar ("a", None, { line = 41
                                                       column = 4 })), "i1",
                          None, { line = 41
                                  column = 4 }),
                       Cst (CstI 1, None, { line = 41
                                            column = 11 }), { line = 41
                                                              column = 4 })));
              Stmt
                (Expr
                   (Assign
                      (AccFld
                         (Access (AccVar ("a", None, { line = 42
                                                       column = 4 })), "i2",
                          None, { line = 42
                                  column = 4 }),
                       Cst (CstI 2, None, { line = 42
                                            column = 11 }), { line = 42
                                                              column = 4 })));
              Dec (TypO "B", "b", { line = 43
                                    column = 6 });
              Stmt
                (Expr
                   (Assign
                      (AccVar ("b", None, { line = 43
                                            column = 6 }),
                       New ("B", None, { line = 43
                                         column = 10 }), { line = 43
                                                           column = 10 })));
              Stmt
                (Expr
                   (Assign
                      (AccFld
                         (Access (AccVar ("b", None, { line = 44
                                                       column = 4 })), "i1",
                          None, { line = 44
                                  column = 4 }),
                       Cst (CstI 4, None, { line = 44
                                            column = 11 }), { line = 44
                                                              column = 4 })));
              Stmt
                (Expr
                   (Assign
                      (AccFld
                         (Access (AccVar ("b", None, { line = 45
                                                       column = 4 })), "i2",
                          None, { line = 45
                                  column = 4 }),
                       Cst (CstI 42, None, { line = 45
                                             column = 11 }), { line = 45
                                                               column = 4 })));
              Dec (TypO "A", "ab", { line = 46
                                     column = 6 });
              Stmt
                (Expr
                   (Assign
                      (AccVar ("ab", None, { line = 46
                                             column = 6 }),
                       Access (AccVar ("b", None, { line = 46
                                                    column = 11 })),
                       { line = 46
                         column = 11 })));
              Stmt
                (Expr
                   (PrimC
                      ("println",
                       [Access
                          (AccFld
                             (Access (AccVar ("a", None, { line = 48
                                                           column = 12 })), "i1",
                              None, { line = 48
                                      column = 12 }));
                        Access
                          (AccFld
                             (Access (AccVar ("a", None, { line = 48
                                                           column = 18 })), "i2",
                              None, { line = 48
                                      column = 18 }));
                        Call
                          (Access (AccVar ("a", None, { line = 48
                                                        column = 24 })), "f",
                           None, [], None, { line = 48
                                             column = 24 })], None,
                       { line = 48
                         column = 4 })));
              Stmt
                (Expr
                   (PrimC
                      ("println",
                       [Access
                          (AccFld
                             (Access (AccVar ("b", None, { line = 49
                                                           column = 12 })), "i1",
                              None, { line = 49
                                      column = 12 }));
                        Access
                          (AccFld
                             (Access (AccVar ("b", None, { line = 49
                                                           column = 18 })), "i2",
                              None, { line = 49
                                      column = 18 }));
                        Call
                          (Access (AccVar ("b", None, { line = 49
                                                        column = 24 })), "f",
                           None, [], None, { line = 49
                                             column = 24 });
                        Call
                          (Access (AccVar ("b", None, { line = 49
                                                        column = 31 })),
                           "i2Super", None, [], None, { line = 49
                                                        column = 31 });
                        Call
                          (Access (AccVar ("b", None, { line = 49
                                                        column = 44 })),
                           "fSuper", None, [], None, { line = 49
                                                       column = 44 });
                        Call
                          (Access (AccVar ("b", None, { line = 49
                                                        column = 56 })), "g",
                           None, [], None, { line = 49
                                             column = 56 })], None,
                       { line = 49
                         column = 4 })));
              Stmt
                (Expr
                   (PrimC
                      ("println",
                       [Access
                          (AccFld
                             (Access (AccVar ("ab", None, { line = 50
                                                            column = 12 })),
                              "i1", None, { line = 50
                                            column = 12 }));
                        Access
                          (AccFld
                             (Access (AccVar ("ab", None, { line = 50
                                                            column = 19 })),
                              "i2", None, { line = 50
                                            column = 19 }));
                        Call
                          (Access (AccVar ("ab", None, { line = 50
                                                         column = 26 })), "f",
                           None, [], None, { line = 50
                                             column = 26 })], None,
                       { line = 50
                         column = 4 })))], { line = 40
                                             column = 4 }), { line = 39
                                                              column = 7 })],
      { line = 38
        column = 6 })]

DEBUG Program AST after Return and Reachability Analysis: Program
  [Classdec
     ("A", "Object",
      [Fielddec (TypI, "i1", { line = 23
                               column = 6 });
       Fielddec (TypI, "i2", { line = 24
                               column = 6 });
       Methoddec
         (TypI, "f", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Prim2
                         ("+",
                          Access
                            (AccFld
                               (Access (AccVar ("this", None, { line = 26
                                                                column = 19 })),
                                "i1", None, { line = 26
                                              column = 19 })),
                          Access
                            (AccFld
                               (Access (AccVar ("this", None, { line = 26
                                                                column = 29 })),
                                "i2", None, { line = 26
                                              column = 29 })), None,
                          { line = 26
                            column = 27 })), { line = 26
                                               column = 19 }))], { line = 26
                                                                   column = 12 }),
          { line = 26
            column = 6 })], { line = 22
                              column = 6 });
   Classdec
     ("B", "A",
      [Fielddec (TypI, "i2", { line = 30
                               column = 6 });
       Methoddec
         (TypI, "f", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Access
                         (AccFld
                            (Access (AccVar ("this", None, { line = 32
                                                             column = 19 })),
                             "i2", None, { line = 32
                                           column = 19 }))), { line = 32
                                                               column = 19 }))],
             { line = 32
               column = 12 }), { line = 32
                                 column = 6 });
       Methoddec
         (TypI, "fSuper", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Call
                         (Access (AccVar ("super", None, { line = 33
                                                           column = 24 })), "f",
                          None, [], None, { line = 33
                                            column = 24 })), { line = 33
                                                               column = 24 }))],
             { line = 33
               column = 17 }), { line = 33
                                 column = 6 });
       Methoddec
         (TypI, "i2Super", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Access
                         (AccFld
                            (Access (AccVar ("super", None, { line = 34
                                                              column = 25 })),
                             "i2", None, { line = 34
                                           column = 25 }))), { line = 34
                                                               column = 25 }))],
             { line = 34
               column = 18 }), { line = 34
                                 column = 6 });
       Methoddec
         (TypI, "g", [],
          Block
            ([Stmt
                (Return
                   (Some
                      (Prim2
                         ("+",
                          Access
                            (AccFld
                               (Access (AccVar ("this", None, { line = 35
                                                                column = 19 })),
                                "i1", None, { line = 35
                                              column = 19 })),
                          Access
                            (AccFld
                               (Access (AccVar ("this", None, { line = 35
                                                                column = 29 })),
                                "i2", None, { line = 35
                                              column = 29 })), None,
                          { line = 35
                            column = 27 })), { line = 35
                                               column = 19 }))], { line = 35
                                                                   column = 12 }),
          { line = 35
            column = 6 })], { line = 29
                              column = 6 });
   Classdec
     ("Main", "Object",
      [Methoddec
         (TypV, "main", [],
          Block
            ([Dec (TypO "A", "a", { line = 40
                                    column = 6 });
              Stmt
                (Expr
                   (Assign
                      (AccVar ("a", None, { line = 40
                                            column = 6 }),
                       New ("A", None, { line = 40
                                         column = 10 }), { line = 40
                                                           column = 10 })));
              Stmt
                (Expr
                   (Assign
                      (AccFld
                         (Access (AccVar ("a", None, { line = 41
                                                       column = 4 })), "i1",
                          None, { line = 41
                                  column = 4 }),
                       Cst (CstI 1, None, { line = 41
                                            column = 11 }), { line = 41
                                                              column = 4 })));
              Stmt
                (Expr
                   (Assign
                      (AccFld
                         (Access (AccVar ("a", None, { line = 42
                                                       column = 4 })), "i2",
                          None, { line = 42
                                  column = 4 }),
                       Cst (CstI 2, None, { line = 42
                                            column = 11 }), { line = 42
                                                              column = 4 })));
              Dec (TypO "B", "b", { line = 43
                                    column = 6 });
              Stmt
                (Expr
                   (Assign
                      (AccVar ("b", None, { line = 43
                                            column = 6 }),
                       New ("B", None, { line = 43
                                         column = 10 }), { line = 43
                                                           column = 10 })));
              Stmt
                (Expr
                   (Assign
                      (AccFld
                         (Access (AccVar ("b", None, { line = 44
                                                       column = 4 })), "i1",
                          None, { line = 44
                                  column = 4 }),
                       Cst (CstI 4, None, { line = 44
                                            column = 11 }), { line = 44
                                                              column = 4 })));
              Stmt
                (Expr
                   (Assign
                      (AccFld
                         (Access (AccVar ("b", None, { line = 45
                                                       column = 4 })), "i2",
                          None, { line = 45
                                  column = 4 }),
                       Cst (CstI 42, None, { line = 45
                                             column = 11 }), { line = 45
                                                               column = 4 })));
              Dec (TypO "A", "ab", { line = 46
                                     column = 6 });
              Stmt
                (Expr
                   (Assign
                      (AccVar ("ab", None, { line = 46
                                             column = 6 }),
                       Access (AccVar ("b", None, { line = 46
                                                    column = 11 })),
                       { line = 46
                         column = 11 })));
              Stmt
                (Expr
                   (PrimC
                      ("println",
                       [Access
                          (AccFld
                             (Access (AccVar ("a", None, { line = 48
                                                           column = 12 })), "i1",
                              None, { line = 48
                                      column = 12 }));
                        Access
                          (AccFld
                             (Access (AccVar ("a", None, { line = 48
                                                           column = 18 })), "i2",
                              None, { line = 48
                                      column = 18 }));
                        Call
                          (Access (AccVar ("a", None, { line = 48
                                                        column = 24 })), "f",
                           None, [], None, { line = 48
                                             column = 24 })], None,
                       { line = 48
                         column = 4 })));
              Stmt
                (Expr
                   (PrimC
                      ("println",
                       [Access
                          (AccFld
                             (Access (AccVar ("b", None, { line = 49
                                                           column = 12 })), "i1",
                              None, { line = 49
                                      column = 12 }));
                        Access
                          (AccFld
                             (Access (AccVar ("b", None, { line = 49
                                                           column = 18 })), "i2",
                              None, { line = 49
                                      column = 18 }));
                        Call
                          (Access (AccVar ("b", None, { line = 49
                                                        column = 24 })), "f",
                           None, [], None, { line = 49
                                             column = 24 });
                        Call
                          (Access (AccVar ("b", None, { line = 49
                                                        column = 31 })),
                           "i2Super", None, [], None, { line = 49
                                                        column = 31 });
                        Call
                          (Access (AccVar ("b", None, { line = 49
                                                        column = 44 })),
                           "fSuper", None, [], None, { line = 49
                                                       column = 44 });
                        Call
                          (Access (AccVar ("b", None, { line = 49
                                                        column = 56 })), "g",
                           None, [], None, { line = 49
                                             column = 56 })], None,
                       { line = 49
                         column = 4 })));
              Stmt
                (Expr
                   (PrimC
                      ("println",
                       [Access
                          (AccFld
                             (Access (AccVar ("ab", None, { line = 50
                                                            column = 12 })),
                              "i1", None, { line = 50
                                            column = 12 }));
                        Access
                          (AccFld
                             (Access (AccVar ("ab", None, { line = 50
                                                            column = 19 })),
                              "i2", None, { line = 50
                                            column = 19 }));
                        Call
                          (Access (AccVar ("ab", None, { line = 50
                                                         column = 26 })), "f",
                           None, [], None, { line = 50
                                             column = 26 })], None,
                       { line = 50
                         column = 4 }))); Stmt (Return (None, { line = 0
                                                                column = 0 }))],
             { line = 40
               column = 4 }), { line = 39
                                column = 7 })], { line = 38
                                                  column = 6 })]

DEBUG Class hierarchy value: 
Hierarchy
  (Classdec ("Object", "", [], { line = 0
                                 column = 0 }),
   [Hierarchy
      (Classdec
         ("A", "Object",
          [Fielddec (TypI, "i1", { line = 23
                                   column = 6 });
           Fielddec (TypI, "i2", { line = 24
                                   column = 6 });
           Methoddec
             (TypI, "f", [],
              Block
                ([Stmt
                    (Return
                       (Some
                          (Prim2
                             ("+",
                              Access
                                (AccFld
                                   (Access
                                      (AccVar ("this", None, { line = 26
                                                               column = 19 })),
                                    "i1", None, { line = 26
                                                  column = 19 })),
                              Access
                                (AccFld
                                   (Access
                                      (AccVar ("this", None, { line = 26
                                                               column = 29 })),
                                    "i2", None, { line = 26
                                                  column = 29 })), None,
                              { line = 26
                                column = 27 })), { line = 26
                                                   column = 19 }))],
                 { line = 26
                   column = 12 }), { line = 26
                                     column = 6 })], { line = 22
                                                       column = 6 }),
       [Hierarchy
          (Classdec
             ("B", "A",
              [Fielddec (TypI, "i2", { line = 30
                                       column = 6 });
               Methoddec
                 (TypI, "f", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Access
                                 (AccFld
                                    (Access
                                       (AccVar ("this", None, { line = 32
                                                                column = 19 })),
                                     "i2", None, { line = 32
                                                   column = 19 }))),
                            { line = 32
                              column = 19 }))], { line = 32
                                                  column = 12 }), { line = 32
                                                                    column = 6 });
               Methoddec
                 (TypI, "fSuper", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Call
                                 (Access
                                    (AccVar ("super", None, { line = 33
                                                              column = 24 })),
                                  "f", None, [], None, { line = 33
                                                         column = 24 })),
                            { line = 33
                              column = 24 }))], { line = 33
                                                  column = 17 }), { line = 33
                                                                    column = 6 });
               Methoddec
                 (TypI, "i2Super", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Access
                                 (AccFld
                                    (Access
                                       (AccVar ("super", None, { line = 34
                                                                 column = 25 })),
                                     "i2", None, { line = 34
                                                   column = 25 }))),
                            { line = 34
                              column = 25 }))], { line = 34
                                                  column = 18 }), { line = 34
                                                                    column = 6 });
               Methoddec
                 (TypI, "g", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Prim2
                                 ("+",
                                  Access
                                    (AccFld
                                       (Access
                                          (AccVar
                                             ("this", None, { line = 35
                                                              column = 19 })),
                                        "i1", None, { line = 35
                                                      column = 19 })),
                                  Access
                                    (AccFld
                                       (Access
                                          (AccVar
                                             ("this", None, { line = 35
                                                              column = 29 })),
                                        "i2", None, { line = 35
                                                      column = 29 })), None,
                                  { line = 35
                                    column = 27 })), { line = 35
                                                       column = 19 }))],
                     { line = 35
                       column = 12 }), { line = 35
                                         column = 6 })], { line = 29
                                                           column = 6 }), [])]);
    Hierarchy
      (Classdec
         ("Main", "Object",
          [Methoddec
             (TypV, "main", [],
              Block
                ([Dec (TypO "A", "a", { line = 40
                                        column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("a", None, { line = 40
                                                column = 6 }),
                           New ("A", None, { line = 40
                                             column = 10 }), { line = 40
                                                               column = 10 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access (AccVar ("a", None, { line = 41
                                                           column = 4 })), "i1",
                              None, { line = 41
                                      column = 4 }),
                           Cst (CstI 1, None, { line = 41
                                                column = 11 }), { line = 41
                                                                  column = 4 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access (AccVar ("a", None, { line = 42
                                                           column = 4 })), "i2",
                              None, { line = 42
                                      column = 4 }),
                           Cst (CstI 2, None, { line = 42
                                                column = 11 }), { line = 42
                                                                  column = 4 })));
                  Dec (TypO "B", "b", { line = 43
                                        column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("b", None, { line = 43
                                                column = 6 }),
                           New ("B", None, { line = 43
                                             column = 10 }), { line = 43
                                                               column = 10 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access (AccVar ("b", None, { line = 44
                                                           column = 4 })), "i1",
                              None, { line = 44
                                      column = 4 }),
                           Cst (CstI 4, None, { line = 44
                                                column = 11 }), { line = 44
                                                                  column = 4 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access (AccVar ("b", None, { line = 45
                                                           column = 4 })), "i2",
                              None, { line = 45
                                      column = 4 }),
                           Cst (CstI 42, None, { line = 45
                                                 column = 11 }), { line = 45
                                                                   column = 4 })));
                  Dec (TypO "A", "ab", { line = 46
                                         column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("ab", None, { line = 46
                                                 column = 6 }),
                           Access (AccVar ("b", None, { line = 46
                                                        column = 11 })),
                           { line = 46
                             column = 11 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access (AccVar ("a", None, { line = 48
                                                               column = 12 })),
                                  "i1", None, { line = 48
                                                column = 12 }));
                            Access
                              (AccFld
                                 (Access (AccVar ("a", None, { line = 48
                                                               column = 18 })),
                                  "i2", None, { line = 48
                                                column = 18 }));
                            Call
                              (Access (AccVar ("a", None, { line = 48
                                                            column = 24 })), "f",
                               None, [], None, { line = 48
                                                 column = 24 })], None,
                           { line = 48
                             column = 4 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access (AccVar ("b", None, { line = 49
                                                               column = 12 })),
                                  "i1", None, { line = 49
                                                column = 12 }));
                            Access
                              (AccFld
                                 (Access (AccVar ("b", None, { line = 49
                                                               column = 18 })),
                                  "i2", None, { line = 49
                                                column = 18 }));
                            Call
                              (Access (AccVar ("b", None, { line = 49
                                                            column = 24 })), "f",
                               None, [], None, { line = 49
                                                 column = 24 });
                            Call
                              (Access (AccVar ("b", None, { line = 49
                                                            column = 31 })),
                               "i2Super", None, [], None, { line = 49
                                                            column = 31 });
                            Call
                              (Access (AccVar ("b", None, { line = 49
                                                            column = 44 })),
                               "fSuper", None, [], None, { line = 49
                                                           column = 44 });
                            Call
                              (Access (AccVar ("b", None, { line = 49
                                                            column = 56 })), "g",
                               None, [], None, { line = 49
                                                 column = 56 })], None,
                           { line = 49
                             column = 4 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access (AccVar ("ab", None, { line = 50
                                                                column = 12 })),
                                  "i1", None, { line = 50
                                                column = 12 }));
                            Access
                              (AccFld
                                 (Access (AccVar ("ab", None, { line = 50
                                                                column = 19 })),
                                  "i2", None, { line = 50
                                                column = 19 }));
                            Call
                              (Access (AccVar ("ab", None, { line = 50
                                                             column = 26 })),
                               "f", None, [], None, { line = 50
                                                      column = 26 })], None,
                           { line = 50
                             column = 4 })));
                  Stmt (Return (None, { line = 0
                                        column = 0 }))], { line = 40
                                                           column = 4 }),
              { line = 39
                column = 7 })], { line = 38
                                  column = 6 }), [])])


DEBUG Program AST with types as class hierarchy: 
Hierarchy
  (Classdec ("Object", "", [], { line = 0
                                 column = 0 }),
   [Hierarchy
      (Classdec
         ("A", "Object",
          [Fielddec (TypI, "i1", { line = 23
                                   column = 6 });
           Fielddec (TypI, "i2", { line = 24
                                   column = 6 });
           Methoddec
             (TypI, "f", [],
              Block
                ([Stmt
                    (Return
                       (Some
                          (Prim2
                             ("+",
                              Access
                                (AccFld
                                   (Access
                                      (AccVar
                                         ("this", Some (TypO "A"),
                                          { line = 26
                                            column = 19 })), "i1", Some TypI,
                                    { line = 26
                                      column = 19 })),
                              Access
                                (AccFld
                                   (Access
                                      (AccVar
                                         ("this", Some (TypO "A"),
                                          { line = 26
                                            column = 29 })), "i2", Some TypI,
                                    { line = 26
                                      column = 29 })), Some TypI,
                              { line = 26
                                column = 27 })), { line = 26
                                                   column = 19 }))],
                 { line = 26
                   column = 12 }), { line = 26
                                     column = 6 })], { line = 22
                                                       column = 6 }),
       [Hierarchy
          (Classdec
             ("B", "A",
              [Fielddec (TypI, "i2", { line = 30
                                       column = 6 });
               Methoddec
                 (TypI, "f", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Access
                                 (AccFld
                                    (Access
                                       (AccVar
                                          ("this", Some (TypO "B"),
                                           { line = 32
                                             column = 19 })), "i2", Some TypI,
                                     { line = 32
                                       column = 19 }))), { line = 32
                                                           column = 19 }))],
                     { line = 32
                       column = 12 }), { line = 32
                                         column = 6 });
               Methoddec
                 (TypI, "fSuper", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Call
                                 (Access
                                    (AccVar
                                       ("super", Some (TypO "A"),
                                        { line = 33
                                          column = 24 })), "f", Some ("f", []),
                                  [], Some TypI, { line = 33
                                                   column = 24 })),
                            { line = 33
                              column = 24 }))], { line = 33
                                                  column = 17 }), { line = 33
                                                                    column = 6 });
               Methoddec
                 (TypI, "i2Super", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Access
                                 (AccFld
                                    (Access
                                       (AccVar
                                          ("super", Some (TypO "A"),
                                           { line = 34
                                             column = 25 })), "i2", Some TypI,
                                     { line = 34
                                       column = 25 }))), { line = 34
                                                           column = 25 }))],
                     { line = 34
                       column = 18 }), { line = 34
                                         column = 6 });
               Methoddec
                 (TypI, "g", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Prim2
                                 ("+",
                                  Access
                                    (AccFld
                                       (Access
                                          (AccVar
                                             ("this", Some (TypO "B"),
                                              { line = 35
                                                column = 19 })), "i1", Some TypI,
                                        { line = 35
                                          column = 19 })),
                                  Access
                                    (AccFld
                                       (Access
                                          (AccVar
                                             ("this", Some (TypO "B"),
                                              { line = 35
                                                column = 29 })), "i2", Some TypI,
                                        { line = 35
                                          column = 29 })), Some TypI,
                                  { line = 35
                                    column = 27 })), { line = 35
                                                       column = 19 }))],
                     { line = 35
                       column = 12 }), { line = 35
                                         column = 6 })], { line = 29
                                                           column = 6 }), [])]);
    Hierarchy
      (Classdec
         ("Main", "Object",
          [Methoddec
             (TypV, "main", [],
              Block
                ([Dec (TypO "A", "a", { line = 40
                                        column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("a", Some (TypO "A"), { line = 40
                                                           column = 6 }),
                           New ("A", Some (TypO "A"), { line = 40
                                                        column = 10 }),
                           { line = 40
                             column = 10 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access
                                (AccVar ("a", Some (TypO "A"), { line = 41
                                                                 column = 4 })),
                              "i1", Some TypI, { line = 41
                                                 column = 4 }),
                           Cst (CstI 1, Some TypI, { line = 41
                                                     column = 11 }),
                           { line = 41
                             column = 4 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access
                                (AccVar ("a", Some (TypO "A"), { line = 42
                                                                 column = 4 })),
                              "i2", Some TypI, { line = 42
                                                 column = 4 }),
                           Cst (CstI 2, Some TypI, { line = 42
                                                     column = 11 }),
                           { line = 42
                             column = 4 })));
                  Dec (TypO "B", "b", { line = 43
                                        column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("b", Some (TypO "B"), { line = 43
                                                           column = 6 }),
                           New ("B", Some (TypO "B"), { line = 43
                                                        column = 10 }),
                           { line = 43
                             column = 10 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access
                                (AccVar ("b", Some (TypO "B"), { line = 44
                                                                 column = 4 })),
                              "i1", Some TypI, { line = 44
                                                 column = 4 }),
                           Cst (CstI 4, Some TypI, { line = 44
                                                     column = 11 }),
                           { line = 44
                             column = 4 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access
                                (AccVar ("b", Some (TypO "B"), { line = 45
                                                                 column = 4 })),
                              "i2", Some TypI, { line = 45
                                                 column = 4 }),
                           Cst (CstI 42, Some TypI, { line = 45
                                                      column = 11 }),
                           { line = 45
                             column = 4 })));
                  Dec (TypO "A", "ab", { line = 46
                                         column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("ab", Some (TypO "A"), { line = 46
                                                            column = 6 }),
                           Access
                             (AccVar ("b", Some (TypO "B"), { line = 46
                                                              column = 11 })),
                           { line = 46
                             column = 11 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("a", Some (TypO "A"), { line = 48
                                                                column = 12 })),
                                  "i1", Some TypI, { line = 48
                                                     column = 12 }));
                            Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("a", Some (TypO "A"), { line = 48
                                                                column = 18 })),
                                  "i2", Some TypI, { line = 48
                                                     column = 18 }));
                            Call
                              (Access
                                 (AccVar ("a", Some (TypO "A"), { line = 48
                                                                  column = 24 })),
                               "f", Some ("f", []), [], Some TypI,
                               { line = 48
                                 column = 24 })], Some TypI, { line = 48
                                                               column = 4 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("b", Some (TypO "B"), { line = 49
                                                                column = 12 })),
                                  "i1", Some TypI, { line = 49
                                                     column = 12 }));
                            Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("b", Some (TypO "B"), { line = 49
                                                                column = 18 })),
                                  "i2", Some TypI, { line = 49
                                                     column = 18 }));
                            Call
                              (Access
                                 (AccVar ("b", Some (TypO "B"), { line = 49
                                                                  column = 24 })),
                               "f", Some ("f", []), [], Some TypI,
                               { line = 49
                                 column = 24 });
                            Call
                              (Access
                                 (AccVar ("b", Some (TypO "B"), { line = 49
                                                                  column = 31 })),
                               "i2Super", Some ("i2Super", []), [], Some TypI,
                               { line = 49
                                 column = 31 });
                            Call
                              (Access
                                 (AccVar ("b", Some (TypO "B"), { line = 49
                                                                  column = 44 })),
                               "fSuper", Some ("fSuper", []), [], Some TypI,
                               { line = 49
                                 column = 44 });
                            Call
                              (Access
                                 (AccVar ("b", Some (TypO "B"), { line = 49
                                                                  column = 56 })),
                               "g", Some ("g", []), [], Some TypI,
                               { line = 49
                                 column = 56 })], Some TypI, { line = 49
                                                               column = 4 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("ab", Some (TypO "A"), { line = 50
                                                                 column = 12 })),
                                  "i1", Some TypI, { line = 50
                                                     column = 12 }));
                            Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("ab", Some (TypO "A"), { line = 50
                                                                 column = 19 })),
                                  "i2", Some TypI, { line = 50
                                                     column = 19 }));
                            Call
                              (Access
                                 (AccVar
                                    ("ab", Some (TypO "A"), { line = 50
                                                              column = 26 })),
                               "f", Some ("f", []), [], Some TypI,
                               { line = 50
                                 column = 26 })], Some TypI, { line = 50
                                                               column = 4 })));
                  Stmt (Return (None, { line = 0
                                        column = 0 }))], { line = 40
                                                           column = 4 }),
              { line = 39
                column = 7 })], { line = 38
                                  column = 6 }), [])])


DEBUG Program AST after A-normalization for GC: Hierarchy
  (Classdec ("Object", "", [], { line = 0
                                 column = 0 }),
   [Hierarchy
      (Classdec
         ("A", "Object",
          [Fielddec (TypI, "i1", { line = 23
                                   column = 6 });
           Fielddec (TypI, "i2", { line = 24
                                   column = 6 });
           Methoddec
             (TypI, "f", [],
              Block
                ([Stmt
                    (Return
                       (Some
                          (Prim2
                             ("+",
                              Access
                                (AccFld
                                   (Access
                                      (AccVar
                                         ("this", Some (TypO "A"),
                                          { line = 26
                                            column = 19 })), "i1", Some TypI,
                                    { line = 26
                                      column = 19 })),
                              Access
                                (AccFld
                                   (Access
                                      (AccVar
                                         ("this", Some (TypO "A"),
                                          { line = 26
                                            column = 29 })), "i2", Some TypI,
                                    { line = 26
                                      column = 29 })), Some TypI,
                              { line = 26
                                column = 27 })), { line = 26
                                                   column = 19 }))],
                 { line = 26
                   column = 12 }), { line = 26
                                     column = 6 })], { line = 22
                                                       column = 6 }),
       [Hierarchy
          (Classdec
             ("B", "A",
              [Fielddec (TypI, "i2", { line = 30
                                       column = 6 });
               Methoddec
                 (TypI, "f", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Access
                                 (AccFld
                                    (Access
                                       (AccVar
                                          ("this", Some (TypO "B"),
                                           { line = 32
                                             column = 19 })), "i2", Some TypI,
                                     { line = 32
                                       column = 19 }))), { line = 32
                                                           column = 19 }))],
                     { line = 32
                       column = 12 }), { line = 32
                                         column = 6 });
               Methoddec
                 (TypI, "fSuper", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Call
                                 (Access
                                    (AccVar
                                       ("super", Some (TypO "A"),
                                        { line = 33
                                          column = 24 })), "f", Some ("f", []),
                                  [], Some TypI, { line = 33
                                                   column = 24 })),
                            { line = 33
                              column = 24 }))], { line = 33
                                                  column = 17 }), { line = 33
                                                                    column = 6 });
               Methoddec
                 (TypI, "i2Super", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Access
                                 (AccFld
                                    (Access
                                       (AccVar
                                          ("super", Some (TypO "A"),
                                           { line = 34
                                             column = 25 })), "i2", Some TypI,
                                     { line = 34
                                       column = 25 }))), { line = 34
                                                           column = 25 }))],
                     { line = 34
                       column = 18 }), { line = 34
                                         column = 6 });
               Methoddec
                 (TypI, "g", [],
                  Block
                    ([Stmt
                        (Return
                           (Some
                              (Prim2
                                 ("+",
                                  Access
                                    (AccFld
                                       (Access
                                          (AccVar
                                             ("this", Some (TypO "B"),
                                              { line = 35
                                                column = 19 })), "i1", Some TypI,
                                        { line = 35
                                          column = 19 })),
                                  Access
                                    (AccFld
                                       (Access
                                          (AccVar
                                             ("this", Some (TypO "B"),
                                              { line = 35
                                                column = 29 })), "i2", Some TypI,
                                        { line = 35
                                          column = 29 })), Some TypI,
                                  { line = 35
                                    column = 27 })), { line = 35
                                                       column = 19 }))],
                     { line = 35
                       column = 12 }), { line = 35
                                         column = 6 })], { line = 29
                                                           column = 6 }), [])]);
    Hierarchy
      (Classdec
         ("Main", "Object",
          [Methoddec
             (TypV, "main", [],
              Block
                ([Dec (TypO "A", "a", { line = 40
                                        column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("a", Some (TypO "A"), { line = 40
                                                           column = 6 }),
                           New ("A", Some (TypO "A"), { line = 40
                                                        column = 10 }),
                           { line = 40
                             column = 10 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access
                                (AccVar ("a", Some (TypO "A"), { line = 41
                                                                 column = 4 })),
                              "i1", Some TypI, { line = 41
                                                 column = 4 }),
                           Cst (CstI 1, Some TypI, { line = 41
                                                     column = 11 }),
                           { line = 41
                             column = 4 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access
                                (AccVar ("a", Some (TypO "A"), { line = 42
                                                                 column = 4 })),
                              "i2", Some TypI, { line = 42
                                                 column = 4 }),
                           Cst (CstI 2, Some TypI, { line = 42
                                                     column = 11 }),
                           { line = 42
                             column = 4 })));
                  Dec (TypO "B", "b", { line = 43
                                        column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("b", Some (TypO "B"), { line = 43
                                                           column = 6 }),
                           New ("B", Some (TypO "B"), { line = 43
                                                        column = 10 }),
                           { line = 43
                             column = 10 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access
                                (AccVar ("b", Some (TypO "B"), { line = 44
                                                                 column = 4 })),
                              "i1", Some TypI, { line = 44
                                                 column = 4 }),
                           Cst (CstI 4, Some TypI, { line = 44
                                                     column = 11 }),
                           { line = 44
                             column = 4 })));
                  Stmt
                    (Expr
                       (Assign
                          (AccFld
                             (Access
                                (AccVar ("b", Some (TypO "B"), { line = 45
                                                                 column = 4 })),
                              "i2", Some TypI, { line = 45
                                                 column = 4 }),
                           Cst (CstI 42, Some TypI, { line = 45
                                                      column = 11 }),
                           { line = 45
                             column = 4 })));
                  Dec (TypO "A", "ab", { line = 46
                                         column = 6 });
                  Stmt
                    (Expr
                       (Assign
                          (AccVar ("ab", Some (TypO "A"), { line = 46
                                                            column = 6 }),
                           Access
                             (AccVar ("b", Some (TypO "B"), { line = 46
                                                              column = 11 })),
                           { line = 46
                             column = 11 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("a", Some (TypO "A"), { line = 48
                                                                column = 12 })),
                                  "i1", Some TypI, { line = 48
                                                     column = 12 }));
                            Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("a", Some (TypO "A"), { line = 48
                                                                column = 18 })),
                                  "i2", Some TypI, { line = 48
                                                     column = 18 }));
                            Call
                              (Access
                                 (AccVar ("a", Some (TypO "A"), { line = 48
                                                                  column = 24 })),
                               "f", Some ("f", []), [], Some TypI,
                               { line = 48
                                 column = 24 })], Some TypI, { line = 48
                                                               column = 4 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("b", Some (TypO "B"), { line = 49
                                                                column = 12 })),
                                  "i1", Some TypI, { line = 49
                                                     column = 12 }));
                            Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("b", Some (TypO "B"), { line = 49
                                                                column = 18 })),
                                  "i2", Some TypI, { line = 49
                                                     column = 18 }));
                            Call
                              (Access
                                 (AccVar ("b", Some (TypO "B"), { line = 49
                                                                  column = 24 })),
                               "f", Some ("f", []), [], Some TypI,
                               { line = 49
                                 column = 24 });
                            Call
                              (Access
                                 (AccVar ("b", Some (TypO "B"), { line = 49
                                                                  column = 31 })),
                               "i2Super", Some ("i2Super", []), [], Some TypI,
                               { line = 49
                                 column = 31 });
                            Call
                              (Access
                                 (AccVar ("b", Some (TypO "B"), { line = 49
                                                                  column = 44 })),
                               "fSuper", Some ("fSuper", []), [], Some TypI,
                               { line = 49
                                 column = 44 });
                            Call
                              (Access
                                 (AccVar ("b", Some (TypO "B"), { line = 49
                                                                  column = 56 })),
                               "g", Some ("g", []), [], Some TypI,
                               { line = 49
                                 column = 56 })], Some TypI, { line = 49
                                                               column = 4 })));
                  Stmt
                    (Expr
                       (PrimC
                          ("println",
                           [Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("ab", Some (TypO "A"), { line = 50
                                                                 column = 12 })),
                                  "i1", Some TypI, { line = 50
                                                     column = 12 }));
                            Access
                              (AccFld
                                 (Access
                                    (AccVar
                                       ("ab", Some (TypO "A"), { line = 50
                                                                 column = 19 })),
                                  "i2", Some TypI, { line = 50
                                                     column = 19 }));
                            Call
                              (Access
                                 (AccVar
                                    ("ab", Some (TypO "A"), { line = 50
                                                              column = 26 })),
                               "f", Some ("f", []), [], Some TypI,
                               { line = 50
                                 column = 26 })], Some TypI, { line = 50
                                                               column = 4 })));
                  Stmt (Return (None, { line = 0
                                        column = 0 }))], { line = 40
                                                           column = 4 }),
              { line = 39
                column = 7 })], { line = 38
                                  column = 6 }), [])])

DEBUG Main method with label L9_main found in class L10_class_Main with vTable index 0

DEBUG Bytecode: 
     0: PUSHLAB L10_class_Main
     2: HEAPALLOC 4 1
     5: HEAPCOPY 1
     7: LDARGS 0
     9: VCALL 1 0
    12: STOP
LABEL L10_class_Main
    13: LabelAddr L9_main
LABEL L9_main
    14: NIL
    15: GETBP
    16: CSTI 1
    18: ADD
    19: STACKADDR
    20: PUSHLAB L3_class_A
    22: CSTI 0
    24: CSTI 0
    26: HEAPALLOC 4 3
    29: HEAPCOPY 3
    31: STD
    32: INCSP -1
    34: GETBP
    35: CSTI 1
    37: ADD
    38: STACKADDR
    39: LDD
    40: CSTI 1
    42: HEAPADDR
    43: CSTI 1
    45: STD
    46: INCSP -1
    48: GETBP
    49: CSTI 1
    51: ADD
    52: STACKADDR
    53: LDD
    54: CSTI 2
    56: HEAPADDR
    57: CSTI 2
    59: STD
    60: INCSP -1
    62: NIL
    63: GETBP
    64: CSTI 2
    66: ADD
    67: STACKADDR
    68: PUSHLAB L8_class_B
    70: CSTI 0
    72: CSTI 0
    74: CSTI 0
    76: HEAPALLOC 4 4
    79: HEAPCOPY 4
    81: STD
    82: INCSP -1
    84: GETBP
    85: CSTI 2
    87: ADD
    88: STACKADDR
    89: LDD
    90: CSTI 1
    92: HEAPADDR
    93: CSTI 4
    95: STD
    96: INCSP -1
    98: GETBP
    99: CSTI 2
   101: ADD
   102: STACKADDR
   103: LDD
   104: CSTI 3
   106: HEAPADDR
   107: CSTI 42
   109: STD
   110: INCSP -1
   112: NIL
   113: GETBP
   114: CSTI 3
   116: ADD
   117: STACKADDR
   118: GETBP
   119: CSTI 2
   121: ADD
   122: STACKADDR
   123: LDD
   124: STD
   125: INCSP -1
   127: GETBP
   128: CSTI 1
   130: ADD
   131: STACKADDR
   132: LDD
   133: CSTI 1
   135: HEAPADDR
   136: LDD
   137: PRINTI
   138: INCSP -1
   140: GETBP
   141: CSTI 1
   143: ADD
   144: STACKADDR
   145: LDD
   146: CSTI 2
   148: HEAPADDR
   149: LDD
   150: PRINTI
   151: INCSP -1
   153: GETBP
   154: CSTI 1
   156: ADD
   157: STACKADDR
   158: LDD
   159: VCALL 1 0
   162: PRINTI
   163: PRINTNL
   164: INCSP -1
   166: GETBP
   167: CSTI 2
   169: ADD
   170: STACKADDR
   171: LDD
   172: CSTI 1
   174: HEAPADDR
   175: LDD
   176: PRINTI
   177: INCSP -1
   179: GETBP
   180: CSTI 2
   182: ADD
   183: STACKADDR
   184: LDD
   185: CSTI 3
   187: HEAPADDR
   188: LDD
   189: PRINTI
   190: INCSP -1
   192: GETBP
   193: CSTI 2
   195: ADD
   196: STACKADDR
   197: LDD
   198: VCALL 1 0
   201: PRINTI
   202: INCSP -1
   204: GETBP
   205: CSTI 2
   207: ADD
   208: STACKADDR
   209: LDD
   210: VCALL 1 2
   213: PRINTI
   214: INCSP -1
   216: GETBP
   217: CSTI 2
   219: ADD
   220: STACKADDR
   221: LDD
   222: VCALL 1 1
   225: PRINTI
   226: INCSP -1
   228: GETBP
   229: CSTI 2
   231: ADD
   232: STACKADDR
   233: LDD
   234: VCALL 1 3
   237: PRINTI
   238: PRINTNL
   239: INCSP -1
   241: GETBP
   242: CSTI 3
   244: ADD
   245: STACKADDR
   246: LDD
   247: CSTI 1
   249: HEAPADDR
   250: LDD
   251: PRINTI
   252: INCSP -1
   254: GETBP
   255: CSTI 3
   257: ADD
   258: STACKADDR
   259: LDD
   260: CSTI 2
   262: HEAPADDR
   263: LDD
   264: PRINTI
   265: INCSP -1
   267: GETBP
   268: CSTI 3
   270: ADD
   271: STACKADDR
   272: LDD
   273: VCALL 1 0
   276: PRINTI
   277: PRINTNL
   278: INCSP -1
   280: RET 3
   282: INCSP -3
LABEL L8_class_B
   284: LabelAddr L4_f
   285: LabelAddr L5_fSuper
   286: LabelAddr L6_i2Super
   287: LabelAddr L7_g
LABEL L4_f
   288: GETBP
   289: CSTI 0
   291: ADD
   292: STACKADDR
   293: LDD
   294: CSTI 3
   296: HEAPADDR
   297: LDD
   298: RET 1
   300: INCSP 0
LABEL L5_fSuper
   302: GETBP
   303: CSTI 0
   305: ADD
   306: STACKADDR
   307: LDD
   308: CALL 1 L2_f
   311: RET 1
   313: INCSP 0
LABEL L6_i2Super
   315: GETBP
   316: CSTI 0
   318: ADD
   319: STACKADDR
   320: LDD
   321: CSTI 2
   323: HEAPADDR
   324: LDD
   325: RET 1
   327: INCSP 0
LABEL L7_g
   329: GETBP
   330: CSTI 0
   332: ADD
   333: STACKADDR
   334: LDD
   335: CSTI 1
   337: HEAPADDR
   338: LDD
   339: GETBP
   340: CSTI 0
   342: ADD
   343: STACKADDR
   344: LDD
   345: CSTI 3
   347: HEAPADDR
   348: LDD
   349: ADD
   350: RET 1
   352: INCSP 0
LABEL L3_class_A
   354: LabelAddr L2_f
LABEL L2_f
   355: GETBP
   356: CSTI 0
   358: ADD
   359: STACKADDR
   360: LDD
   361: CSTI 1
   363: HEAPADDR
   364: LDD
   365: GETBP
   366: CSTI 0
   368: ADD
   369: STACKADDR
   370: LDD
   371: CSTI 2
   373: HEAPADDR
   374: LDD
   375: ADD
   376: RET 1
   378: INCSP 0
LABEL L1_class_Object

DEBUG Machine.code2insts.LabEnv: [("L1_class_Object", 380); ("L2_f", 355); ("L3_class_A", 354); ("L7_g", 329);
 ("L6_i2Super", 315); ("L5_fSuper", 302); ("L4_f", 288); ("L8_class_B", 284);
 ("L9_main", 14); ("L10_class_Main", 13)]
