/*
Given an array of integers, find the one that appears an odd number of times.

There will always be only one integer that appears an odd number of times.
*/

function findOdd(A) {
  let count = 0;
  for (let i = 0; i < A.length; i++) {
     for (let x = 0; x < A.length; x++) {
      if (A[i] == A[x]) {
        count++;
      };
    };
    if (count % 2 != 0) {
      return A[i];
    };
    count = 0;
  };
};

console.log(findOdd([20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5])); // should return 5
console.log(findOdd([1,1,2,-2,5,2,4,4,-1,-2,5])); // should return -1
console.log(findOdd([1,1,1,1,1,1,10,1,1,1,1])); // should return 10
console.log(findOdd([5,4,3,2,1,5,4,3,2,10,10])); // should return 1