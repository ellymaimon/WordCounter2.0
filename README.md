# Word Counter

#### Epicodus C# Week 2 Code Review, 07/06/2018

#### By Elly Maimon

## Description

A .NET web app that allows the user to run two different Word Tools: a word counter, and a Scrabble points counter. Both of the tools have been written in C#.

## Specs for Word Counter

| Behavior | Input | Output | Explanation |
|----------|-------|--------|-------------|
| Program finds how many times a letter shows up in a given word. | "h", "hello" | "1" | A single letter is the simplest case to test here. |
| Program finds how many times a letter shows up in a given word where there is more than one instance of that letter. | "l", "hello" | "2" | Getting slightly more complex, I now add a second instance of the letter. |
| Program finds how many times a letter shows up in a given word despite capitalization. | "l", "heLLo" | "2" | Before moving on to multiple words, I handle case sensitivity. |
| Program finds how many times a single numbers shows up in a larger number. | "3", "333" | "3" | I include the case of numbers to keep to characters before moving on to a phrase. |
| Program finds how many times a letter shows up in a given word despite mixing in numbers. | "l" , "3hello3" | "2" | Now I can handle the mixture before expanding to multiple word phrases. |
| Program finds a match when given a word and then the same word. | "hello", "hello" | "1" | This is the simplest test case where we are now looking for more than just one letter or number. |
| Program finds how many times a word shows up in a given phrase. | "hello", "hello to you" | "1" | Now I add multiple words to further expand. |
| Program finds how many times a word shows up in a given phrase where there is more than one instance of the word. | "hello", "hello to you hello to you" | "2" | Now we add multiple occurrences in the next simplest version.
| Program finds how many times a word shows up in a given phrase, despite the capitalization. | "hello ", "hello there HeLLo" | "2" | Testing our earlier edge case in a more complex environment.
| Program finds how many times a number shows up in a given phrase. | "3" "3 Hello 3 people" | "2" | Complicating with numbers |
| Program finds how many times a number shows up in a given phrase despite the number being in a word. | "3" "3Hello 3 peopl3e" | "3" | Further complexity by forcing the program to take into account having to search inside a word for a number. |
| Program finds how many times a word shows up in a given phrase despite the word being adjacent to a punctuation mark. | "hello" "hello, to you, hello." | "2" | Further complexity by forcing the program to take into account having to ignore punctuation marks. |
| Program determines whether to look for single letters or a whole word based on inputs. | "hi" "high hi yo hi" OR "h" "high hi yo hi" | "2" OR "4"| Adding automated determination between single character inputs and multiple character inputs for further level of complexity. |
| Program accepts multiple word input. | "hi there" "hi hi there hi" | "1" | Further expanding on idea by accepting multiple word input to search phrase for. |

## Specs for Scrabble Counter

| Behavior | Input | Output |
|----------|-------|--------|
| Program receives word and returns points value. | hi | 4 |
| Program receives multiple words and returns points value. | hi hi | 8 |
| Program receives words with capital letters and returns points value. | Hi | 4 |


## Setup on OSX

* Download and install .Net Core 1.1.4
* Download and install Mono
* Clone the repo
* Run `dotnet restore` from project directory and test directory to install packages
* Run `dotnet build` from project directory and fix any build errors
* Run `dotnet test` from the test directory to run the testing suite
* Run `dotnet run` to start the server


## Technologies Used

* .Net Core 1.1.4

## Links

* Link to repository for this website: https://github.com/ellymaimon/WordCounter2.0

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Elly Maimon**

