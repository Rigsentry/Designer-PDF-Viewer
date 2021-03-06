# Designer PDF Viewer

When a contiguous block of text is selected in a PDF viewer, the selection is highlighted with a blue rectangle. In this PDF viewer, each word is highlighted independently. For example:

![img1](img1.png)

There is a list of **26** character heights aligned by index to their letters. For example, 'a' is at index **0** and 'z' is at index **25**. There will also be a string. Using the letter heights given, determine the area of the rectangle highlight in **mm2** assuming all letters are **1mm** wide.

## Example

![img2](img2.png)

The heights are **t = 2, c = 1,r = 1 and n = 1**. The tallest letter is **2** high and there are **4** letters. The hightlighted area will be **2 * 4 = 8mm2** so the answer is **8**.

## Function Description

Complete the designerPdfViewer function.

designerPdfViewer has the following parameter(s):

* int h[26]: the heights of each letter
* string word: a string
## Returns

int: the size of the highlighted area

## Constraints

![img3](img3.png)

## Sample Input 0

```
1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5
abc
```
## Sample Output 0
```
9
```
## Explanation 0

We are highlighting the word abc:
Letter heights are **a = 1**,**b = 3** and **c = 1**. The tallest letter, b, is **3mm** high. The selection area for this word is **3 * 1mm * 3mm = 9mm2**.

**Note:** Recall that the width of each character is 1mm.

## Sample input 1
```
1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7
zaba
```

## Sample output 1
```
28
```
## Explanation 1

The tallest letter in **zaba** is **z** at **7mm**. The selection area for this word is **4 * 1mm * 7mm = 28mm2**.