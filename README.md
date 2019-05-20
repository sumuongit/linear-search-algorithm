## Table of Contents
* [General Info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Contributing](#contributing)
* [License](#license)

## General Info
This application searches that whether an input number is available or not in a given array of numbers

>**Linear search algorithm** starts from the beginning of the given array, compare the input number with evey item of the given array. If there is a match then no more compare is required.

Let us see the execution of the **Linear search algorithm** on the given array to search the input number (for example, 100). Hence, finally we have/have not found the number in the given array after completion all the required iterations.

#### `100 != 10`  &nbsp;&nbsp;&nbsp;   `10`  4   20   49   65   11   66   57   9   100   <br/>
#### `100 != 4`   &nbsp;&nbsp;&nbsp;    10  `4`  20   49   65   11   66   57   9   100   <br/>
#### `100 != 20`  &nbsp;&nbsp;&nbsp;    10   4  `20`  49   65   11   66   57   9   100   <br/>
#### `100 != 49`  &nbsp;&nbsp;&nbsp;    10   4   20  `49`  65   11   66   57   9   100   <br/>
#### `100 != 65`  &nbsp;&nbsp;&nbsp;    10   4   20   49  `65`  11   66   57   9   100   <br/>
#### `100 != 11`  &nbsp;&nbsp;&nbsp;    10   4   20   49   65  `11`  66   57   9   100   <br/>
#### `100 != 66`  &nbsp;&nbsp;&nbsp;    10   4   20   49   65   11  `66`  57   9   100   <br/>
#### `100 != 57`  &nbsp;&nbsp;&nbsp;    10   4   20   49   65   11   66  `57`  9   100   <br/>
#### `100 != 9`   &nbsp;&nbsp;&nbsp;    10   4   20   49   65   11   66   57  `9`  100   <br/>
#### `100 = 100`  &nbsp;&nbsp;&nbsp;    10   4   20   49   65   11   66   57   9  `100` &nbsp;&nbsp;&nbsp;`The input number, 100, is found`<br/>

## Technologies
This application is created with:
* Visual Studio 2013
* C# 
	
## Setup
To clone and run this repository you will need [Git](https://git-scm.com/) installed on your computer. From your command line:

```
# Clone this repository
$ git clone https://github.com/sumuongit/linear-search-algorithm.git
# Go into the repository
$ cd linear-search-algorithm
```

## Contributing
* Fork the repository
* Create a topic branch
* Implement your feature or bug fix
* Add, commit, and push your changes
* Submit a pull request

## License
[MIT License](https://github.com/sumuongit/linear-search-algorithm/blob/master/LICENSE)
