
# _Prime Sifting_

#### _This demonstrates beginner level C#._

#### By _**Matthew**_


## Description

_A page demonstrates basic C# with testing and a console._
_returns all primes up to a given number_

                              |                                         |           |           
## Setup/Installation Requirements

## Specs
| Specs | Input | Output |
|-|-|-|
| create a constructor which receives a number | new Sifter(5) | Sifter{} |
| create a private field list l that autofills with "O" values and is the length of the number in constructor | new Sifter(5) | _il{X,O,O,O,O} |
| create a sifter function | s.Sift() | {X,O,O,X,O} |
| create an index with a value of 2 |  |  |
| create another value that copies the index inside of a loop ic  |  |  |
| start at l[ic-1]  |  |  |
| increase ic by index value and replace O with x at ic value of l |  |  |
| repeat this process until ic is greater than number |  |  |
| increase the index by 1 and then repeat steps 5 through 8 |  |  |
| repeat step 10 until index equals number |  |  |
| operate on final list | private called from Sift() OperateOnFinalList() | {2,3,5} |
| create another list to hold primes pl |  |  |
| index through each value of the l list |  |  |
| if the index corresponds to an "O" then push that index value plus 1 to pl |  |  |

## Known Bugs

_I don't think there are any bugs but please tell me if you see any._

## Support and contact details

_Open a Github issue if you see a problem or have questions_

## Technologies Used

_This is a C#, MSTest and console thing._

### License

*Feel free to use this code as you please*

Copyright (c) 2020 **_Matthew_**
