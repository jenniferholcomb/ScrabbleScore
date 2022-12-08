# Scrabble Score

#### Application takes a word and returns the Scrabble score for the word.

#### By Jennifer Holcomb

## Technologies Used

* C#
* .NET 6
* Node
* MSTest
* Visual Studio

## Description

## Setup/Installation Requirements

* Clone this repository to your desktop.
* In the ScrabbleScore.Tests directory restore with $ dotnet restore
* To run tests, in ScrabbleScore.Tests directory, $ dotnet test
* Add .gitignore file to parent directory, ScrabbleScore.Solution
* Add all obj and bin folder in .gitignore file
* Push .gitignore file to repo first
* To compile and run program in command line, in ScrabbleScore directory $ dotnet run

## Specs
* Create a new instance of class Game, with empty constructor
* A method that returns the object Dictionary from Game class
* Take user input, and return as all lowercase
* Loop through Dictionary tallying score of user inputted word. Return score

## Known Bugs

* _Any known issues_
* If any issues are discovered, please email jenniferlholcomb@gmail.com.

## License
MIT License

Copyright (c) 2022 Jennifer Holcomb

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.






This application allows a user to input a specified amount of US dollars, then user picks another country's currency to convert dollar amount into. This country's currency value is outputed to browser.


Known Bugs
Formula for calculating exchange works only for converting USD to new currency.
