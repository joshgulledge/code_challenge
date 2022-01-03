/*
From: CodeWar
Red Knight is chasing two pawns. Which pawn will be caught, and where?

Input / Output
Input will be two integers:

N  vertical position of Red Knight (0 or 1).
P horizontal position of two pawns (between 2 and 1000000).
Output has to be a tuple (python, haskell, Rust, prolog, C#), an array (javascript, ruby), an object (java), or a structure (C) with:

"Black" or "White" - which pawn was caught
Where it was caught (horizontal position)

Notes
Red Knight will always start at horizontal position 0.
The black pawn will always be at the bottom (vertical position 1).
The white pawn will always be at the top (vertical position 0).
The pawns move first, and they move simultaneously.
Red Knight moves 2 squares forward and 1 up or down.
Pawns always move 1 square forward.
Both pawns will start at the same horizontal position.

*/

function redKnight(N, P) {
  //with each turn the pieces should move positions 
  let endLoop = 0;
  // continue until the knight catches a pawn
  let pawnCaught = false;
  let redKnight = [N, 0]; // vertical position, horizontal position

  console.log('before loop');
  while (pawnCaught !== true && endLoop !== 100) {
   console.log(endLoop);
   P++;
   redKnight[0] === 1 ? 0 : 1; // if @ position 1 change to 0 otherwise go to position 1
   redKnight[1] =+ 2; //add two to horizontal position
   if (redKnight[1] === P) pawnCaught = true;
   endLoop++;
  };

  let pawnColor = redKnight[0] === 1 ? "Black" : "White";
  
  console.log(`redKnight is ${redKnight}`);
  console.log(`p is ${P}`);
  return [pawnColor, P];
};

console.log(redKnight(0, 8)); // should return ['White', 16]