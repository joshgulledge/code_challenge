/*
The wave (known as the Mexican wave in the English-speaking world outside North America) is an example of metachronal rhythm achieved in a packed stadium when successive groups of spectators briefly stand, yell, and raise their arms. Immediately upon stretching to full height, the spectator returns to the usual seated position.

The result is a wave of standing spectators that travels through the crowd, even though individual spectators never move away from their seats. In many large arenas the crowd is seated in a contiguous circuit all the way around the sport field, and so the wave is able to travel continuously around the arena; in discontiguous seating arrangements, the wave can instead reflect back and forth through the crowd. When the gap in seating is narrow, the wave can sometimes pass through it. Usually only one wave crest will be present at any given time in an arena, although simultaneous, counter-rotating waves have been produced. 

In this simple Kata your task is to create a function that turns a string into a Mexican Wave. You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up. 

1.  The input string will always be lower case but maybe empty.

2.  If the character in the string is whitespace then pass over it as if it was an empty seat
*/

function wave(str){
  let arr = [];
  let letters = str.split('');

  for (i=0; i<letters.length; i++) {
    if (letters[i] == ' ') continue;
    letters.splice(i, 1, letters[i].toUpperCase());
    let word = letters.join('');
    arr.push(word);
    letters.splice(i, 1, letters[i].toLowerCase());
  };

  return arr;
};

console.log(wave("hello"));
console.log(wave("Codewars"));
console.log(wave("Two words"));