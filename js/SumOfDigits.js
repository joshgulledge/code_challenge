/*
Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.
*/

function digital_root(n) {
 let reduce = true;
 let amount = 0;
 let arr = n;

 while (reduce) {
  amount = Array.from(String(arr), Number).reduce((prev, next) => prev + next);
  arr = amount;
  if(amount <= 9) reduce = false;
 };

  return amount;
};

console.log(digital_root(16)); // should return 7
console.log(digital_root(942)); // should return 6
console.log(digital_root(132189)); // should return 6
console.log(digital_root(493193)); // should return 2
