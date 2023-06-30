# Сортировка выбором
// 1 2 3 4 5 1 2 3

MIN -> MAX
0 1 2 3 4 5 6 7
7 6 3 4 5 1 2 3
^

After first action
1 6 3 4 5 7 2 3
  ^

After second action
1 2 3 4 5 7 6 3
    ^

After third action 
1 2 3 4 5 6 7 3
      ^

After fourth action
1 2 3 3 5 7 6 4
        ^
etc.

finally
1 2 3 3 4 5 6 7