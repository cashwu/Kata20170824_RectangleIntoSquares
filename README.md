# [Rectangle into Squares](https://www.codewars.com/kata/rectangle-into-squares/csharp)

---

The drawing below gives an idea of how to cut a given "true" rectangle into squares ("true" rectangle meaning that the two dimensions are different).

![](http://i.imgur.com/lk5vJ7sm.jpg)

Can you translate this drawing into an algorithm?

You will be given two dimensions

a positive integer length (parameter named `lng`)
a positive integer width (parameter named `wdth`)
You will return an array with the size of each of the squares.

```
  sqInRect(5, 3) should return a List<int> {3, 2, 1, 1}
  sqInRect(3, 5) should return a List<int> {3, 2, 1, 1}
```

#Note: lng == wdth as a starting case would be an entirely different problem and the drawing is planned to be interpreted with lng != wdth. See kata, Square into Squares. Protect trees!.

When the initial parameters are so that lng == wdth, the solution [lng] would be the most obvious but not in the spirit of this kata so, in that case, return None/nil/null/Nothing. Return {} with C++.

In that case the returned structure of C will have its sz component equal to 0. (See the "Solution" and "Examples" tabs)
```
  sqInRect(5, 5) should return null
```
---

### 中文大意

找到一個矩型裡面所有的正方型的邊長