3/25 Update: Decided to revisit this to refactor as much of the main program into sub classes and then add as much unit testing as I could think of to those classes.

Below the line are the build specs for the programe. To complete the programe I decided to seperate the tens and hundereds position
from the one's position. I could have done this by converting the numerical grade into a string, and then splitting the individual numeric
positions off, and then convert that string back to a number. Instead, I decided to take advantage of the modulus and seperate off the
numbers by using the remainders. This allowed me to feed each tens position into a switch to get the letter grade and each unit position
into an if else statement to achive the bonus potion of the lab.

******************************************
# BonusOne
Grand Cirus Bonus One Work

Task: Convert Given number grades into letter grades

What will the application do?
  The user will enter a numerical grade from 0 to 100
  The application will display the corresponding letter grade
  The application will prompt the user to conintue
  
Build Specifications
  Assume that the user will enter valid integers for the grades
  The application should only continue if the user enters "y" or "Y"

Extended Challenge:
  Edit your grade ranges to include pluses and minuses
  
  
