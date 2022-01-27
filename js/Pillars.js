/*
There are pillars near the road. The distance between the pillars is the same and the width of the pillars is the same. Your function accepts three arguments:

number of pillars (≥ 1);
distance between pillars (10 - 30 meters);
width of the pillar (10 - 50 centimeters).
Calculate the distance between the first and the last pillar in centimeters (without the width of the first and last pillar).
*/

function pillars(num_pill, dist, width) {
  return num_pill == 1 ? 0 : (((dist * 100) * (num_pill-1)) + (width * (num_pill-1))) - width;
};

console.log(pillars(1, 10, 10)); // should return 0
console.log(pillars(2, 20, 25)); // should return 2000
console.log(pillars(11, 15, 30)) // should return 15270
